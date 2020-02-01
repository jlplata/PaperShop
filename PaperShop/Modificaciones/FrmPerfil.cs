using PaperShop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperShop.Modificaciones
{
    public partial class FrmPerfil : Form
    {
        public FrmPerfil()
        {
            InitializeComponent();
            txtIdUsuario.Text = FrmPrin.id;
            DateTime hoy = DateTime.Now;
            lblFechaRegistro.Text = hoy.ToString("yyyyMMdd");
            lblHoraRegistro.Text = hoy.ToShortTimeString();
        }
        void rellenar() 
        {
            string qry = "";

            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");

            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);

            SqlCommand sqlCMD = new SqlCommand();

            qry = "SELECT  * from VistaUsuarios where usuario = '" + this.txtIdUsuario.Text + "'";

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
                        FrmPrin.Usuario = sqlDR["personas"].ToString();
                        FrmPrin.id = sqlDR["id_usuario"].ToString();
                        FrmPrin.tipo = sqlDR["tipo"].ToString();
                        FrmPrin.ima = sqlDR["imagen"].ToString();
                    }
                }
                else
                {
                    this.Alert("Error al extrar datos", FrmNotificaciones.alertTypeEnum.Warning);
                    
                }

            }
            catch (Exception ex)
            {
                //Mensaje ms = new Mensaje();
                //ms.BtnNo.Visible = false;
                //ms.BtnSi.Visible = false;
                //ms.BtnOk.Visible = true;
                //ms.lbltxt.Text = "Error al iniciar sesion"+ex;
                //ms.ShowDialog();

                MessageBox.Show("No se pudo " + ex, "Error");
            }
        }
        private void gunaImageButton2_MouseEnter(object sender, EventArgs e)
        {
            gunaImageButton2.BackColor = Color.FromArgb(96, 108, 173);
        }
        int pas = 0;
        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            if (pas == 0)
            {
                txtpassword.UseSystemPasswordChar = false;
                pas = 1;
                gunaImageButton2.Image = Resources.ocultar;
            }
            else 
            {
                txtpassword.UseSystemPasswordChar = true;
                pas = 0;
                gunaImageButton2.Image = Resources.ver;
            }
        }
        string diro, dir;

        public void Alert(string msg, FrmNotificaciones.alertTypeEnum type)
        {
            FrmNotificaciones f = new FrmNotificaciones();
            f.setAlert(msg, type);
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Todas las imágenes soportadas|*.jpg; *.png";
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string qry;
                    string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
                    SqlConnection sqlcnx = new SqlConnection(cadenaconexion);
                    SqlCommand sqlcmd = new SqlCommand();
                    if (ofd.CheckFileExists)
                    {
                        string inarchivo = System.IO.Path.GetFileName(ofd.FileName);
                        qry = "Select imagen from usuarios where imagen = '\\ima\\" + inarchivo + "'";
                        sqlcmd.CommandText = qry;
                        sqlcmd.Connection = sqlcnx;
                        SqlDataReader DR = null;
                        sqlcnx.Open();
                        DR = sqlcmd.ExecuteReader();
                        if (DR.HasRows == true)
                        {
                            MensajeOk mm = new MensajeOk();
                            mm.lbltxt.Text = "Un usuario ya tiene esa imagen \n intentelo de nuevo";
                            mm.ShowDialog();
                            sqlcnx.Close();
                        }
                        else
                        {
                            string archivo = System.IO.Path.GetFileName(ofd.FileName);
                            diro = ofd.FileName;
                            dir = "\\ima\\" + archivo;
                            imgUser.Load(ofd.FileName);
                            imgUser.Refresh();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nose pudo" + ex, "Error");
            }
        }
    }
}
