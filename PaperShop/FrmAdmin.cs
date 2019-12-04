using System;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using System.Drawing;

namespace PaperShop
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelContenedorForm, Color.Black, 90, 10, Guna.UI.WinForms.VerHorAlign.HoriziontalTop);

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
           | BindingFlags.Instance | BindingFlags.NonPublic, null,
           PanelAdios, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
            | BindingFlags.Instance | BindingFlags.NonPublic, null,
            panelContenedorForm, new object[] { true });
        }

        //Variables 
        UdpClient ADMINISTRADOR = new UdpClient();
        IPAddress ORDENADOR;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            cmIp.Focus();
            ComboEquipos();
        }

        void desactivo() 
        {
            string qry = "";
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            SqlCommand sqlCMD = new SqlCommand();
            try
            {
                qry = "UPDATE equipos set id_equipos = 0 where nombre_equipo = '"+cmIp.Text+"'";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;
                sqlCNX.Open();
                sqlCMD.ExecuteReader();
                sqlCNX.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, " Error ");
            }
        }

        private void cmIp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nom = cmIp.Text;
            string qry = "";
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            SqlCommand sqlCMD = new SqlCommand();
            qry = "SELECT ip_pc from equipos where nombre_equipo = '" + nom + "' and activo = 1";

            sqlCMD.CommandText = qry;

            sqlCMD.Connection = sqlCNX;

            SqlDataReader sqlDR = null;

            try
            {
                sqlCNX.Open();
                sqlDR = sqlCMD.ExecuteReader();
                if (sqlDR.HasRows == true)
                {
                    while (sqlDR.Read() == true)
                    {
                        //this.txtlogin.Text = sqlDR["login"].ToString();
                       ORDENADOR = IPAddress.Parse(sqlDR["ip_pc"].ToString());
                    }
                    sqlCNX.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo " + ex, "Error");
            }
        }
       public void ComboEquipos()
        {
            string qry = "";
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            SqlCommand sqlCMD = new SqlCommand();
            try
            {
                qry = "Select id_equipos, nombre_equipo from equipos where activo=1";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;
                sqlCNX.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter(sqlCMD);
                DataTable datos = new DataTable();
                adaptador.Fill(datos);
                sqlCNX.Close();
                cmIp.DataSource = datos;
                cmIp.ValueMember = "id_equipos";
                cmIp.DisplayMember = "nombre_equipo";
                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                foreach (DataRow row in datos.Rows)
                {
                    coleccion.Add(Convert.ToString(row["nombre_equipo"]));
                }
                cmIp.AutoCompleteCustomSource = coleccion;
                cmIp.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al extraer las personas" + ex.Message.ToString());
            }
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                IPEndPoint IP = new IPEndPoint(ORDENADOR, Convert.ToInt32(TextBoxPUERTO1.Text));
                string FRASE = "INICIAR:" + NumH1.Value + ":" + NumM1.Value;
                byte[] MENSAJE = UTF7Encoding.UTF7.GetBytes(FRASE);
                ADMINISTRADOR.Connect(IP);
                ADMINISTRADOR.Send(MENSAJE, MENSAJE.Length);
                NumH1.Value = 0;
                NumM1.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void ButtonAÑADIR_Click(object sender, EventArgs e)
        {
            try
            {
                IPEndPoint IP = new IPEndPoint(ORDENADOR, Convert.ToInt32(TextBoxPUERTO1.Text));
                string FRASE = "AÑADIR:" + NumH1.Value + ":" + NumM1.Value;
                byte[] MENSAJE = UTF7Encoding.UTF7.GetBytes(FRASE);
                ADMINISTRADOR.Connect(IP);
                ADMINISTRADOR.Send(MENSAJE, MENSAJE.Length);
                NumH1.Value = 0;
                NumM1.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void TextBoxMENSAJES1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TextBoxMENSAJES1.Text != "")
                {
                    try
                    {
                        IPEndPoint IP = new IPEndPoint(ORDENADOR, Convert.ToInt32(TextBoxPUERTO1.Text));
                        string FRASE = "MENSAJE:" + TextBoxMENSAJES1.Text + ":0";
                        byte[] MENSAJE = UTF7Encoding.UTF7.GetBytes(FRASE);
                        ADMINISTRADOR.Connect(IP);
                        ADMINISTRADOR.Send(MENSAJE, MENSAJE.Length);
                        TextBoxMENSAJES1.Clear();
                        e.SuppressKeyPress = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
            }
        }

        private void ButtonBLOQUEO_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar bloqueo", " Bloquear la aplicacion remota", MessageBoxButtons.OKCancel) == DialogResult.OK) 
            {
                try
                {
                    IPEndPoint IP = new IPEndPoint(ORDENADOR, Convert.ToInt32(TextBoxPUERTO1.Text));
                    string FRASE = "BLOQUEO:0:0";
                    byte[] MENSAJE = UTF7Encoding.UTF7.GetBytes(FRASE);
                    ADMINISTRADOR.Connect(IP);
                    ADMINISTRADOR.Send(MENSAJE, MENSAJE.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void ButtonCERRAR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmacion de cierre de la aplicacion", " Cerrar la aplicacion remota", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    IPEndPoint IP = new IPEndPoint(ORDENADOR, Convert.ToInt32(TextBoxPUERTO1.Text));
                    string FRASE = "CERRAR:0:0";
                    byte[] MENSAJE = UTF7Encoding.UTF7.GetBytes(FRASE);
                    ADMINISTRADOR.Connect(IP);
                    ADMINISTRADOR.Send(MENSAJE, MENSAJE.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void ButtonREINICIAR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmacion de reinicio", " Reiniciar el equipo remota", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    IPEndPoint IP = new IPEndPoint(ORDENADOR, Convert.ToInt32(TextBoxPUERTO1.Text));
                    string FRASE = "REINICIAR:0:0";
                    byte[] MENSAJE = UTF7Encoding.UTF7.GetBytes(FRASE);
                    ADMINISTRADOR.Connect(IP);
                    ADMINISTRADOR.Send(MENSAJE, MENSAJE.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void ButtonAPAGAR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmacion para apagar el equipo remoto", " Apagar el queipo remoto ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    IPEndPoint IP = new IPEndPoint(ORDENADOR, Convert.ToInt32(TextBoxPUERTO1.Text));
                    string FRASE = "APAGAR:0:0";
                    byte[] MENSAJE = UTF7Encoding.UTF7.GetBytes(FRASE);
                    ADMINISTRADOR.Connect(IP);
                    ADMINISTRADOR.Send(MENSAJE, MENSAJE.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void BntNuevaMaquina_Click(object sender, EventArgs e)
        {
            agg agregar = new agg();
            agregar.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
