using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Specialized;

namespace PaperShop
{
    public partial class frmConexion : Form
    {
        public frmConexion()
        {
            InitializeComponent();

            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void FrmConexion_Load(object sender, EventArgs e)
        {
            cboServer.Items.Add(".");
            cboServer.Items.Add("(local)");
            cboServer.Items.Add(@".\SQLEXPRESS");
            cboServer.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cboServer.SelectedIndex = 3;
        }

        private void gunaImageButton3_MouseEnter(object sender, EventArgs e)
        {
            BtnCerrar.BackColor = Color.FromArgb(205, 97, 97);
        }
        private void gunaImageButton3_MouseLeave(object sender, EventArgs e)
        {
            BtnCerrar.BackColor = Color.FromArgb(20, 25, 53);
        }

        private void gunaImageButton2_MouseEnter(object sender, EventArgs e)
        {
            BtnMinimizar.BackColor = Color.FromArgb(96, 108, 173);
        }

        private void gunaImageButton2_MouseLeave(object sender, EventArgs e)
        {
           BtnMinimizar.BackColor = Color.FromArgb(20, 25, 53);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        string BD;
        private void btnbasedatos_Click(object sender, EventArgs e)
        {
            Boolean seguridad = true;
            if (BD == null)
            {
                BD = "master";
            }
            else
            {
                BD = cmbbasededatos.Text;
            }
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security={2};", cboServer.Text, BD, seguridad);
            try
            {

                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection) 
                {
                    btnbasedatos. Location = new Point(101, 209);
                    BtnGuardar.Visible = true;

                    if (cmbbasededatos.Visible == false)
                    {

                        string qry = "";
                        SqlConnection sqlCNX = new SqlConnection(connectionString);
                        SqlCommand sqlCMD = new SqlCommand();
                        try
                        {
                            qry = "SELECT NAME FROM sysdatabases;";
                            sqlCMD.CommandText = qry;
                            sqlCMD.Connection = sqlCNX;
                            sqlCNX.Open();
                            SqlDataAdapter adaptador = new SqlDataAdapter(sqlCMD);
                            DataTable datos = new DataTable();
                            adaptador.Fill(datos);
                            sqlCNX.Close();
                            cmbbasededatos.DataSource = datos;
                            cmbbasededatos.ValueMember = "NAME";
                            cmbbasededatos.DisplayMember = "NAME";
                            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                            foreach (DataRow row in datos.Rows)
                            {
                                coleccion.Add(Convert.ToString(row["NAME"]));
                            }
                            cmbbasededatos.AutoCompleteCustomSource = coleccion;
                            cmbbasededatos.AutoCompleteSource = AutoCompleteSource.CustomSource;
                            cmbbasededatos.Visible = true;

                            this.Alert("Prueba Exitosa!", FrmNotificaciones.alertTypeEnum.Success);

                        }
                        catch (SqlException ex)
                        {
                            this.Alert("Erro al llenar el combo!", FrmNotificaciones.alertTypeEnum.Error);
                        }
                    }
                    else
                    {
                        this.Alert("Prueba Exitosa!", FrmNotificaciones.alertTypeEnum.Success);
                    }

                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Alert(string msg, FrmNotificaciones.alertTypeEnum type)
        {
            FrmNotificaciones f = new FrmNotificaciones();
            f.setAlert(msg, type);
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Set connection string
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", cboServer.Text, cmbbasededatos.Text);
            try
            {
                string con = cboServer.Text.Trim();
                string bases = cmbbasededatos.Text.Trim();
                XmlDocument xmlCon = new XmlDocument();
                xmlCon.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
                foreach (XmlElement element in xmlCon.DocumentElement)
                {
                    if (element.Name.Equals("appSettings"))
                    {
                        foreach (XmlNode node in element.ChildNodes)
                        {
                            if (node.Attributes[0].Value == "cadenaconexion")
                            {
                                node.Attributes[1].Value = "Data Source=" + con + ";Initial Catalog=" + bases + ";Integrated Security=True";
                            }
                        }
                    }
                }
                xmlCon.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
                ConfigurationManager.RefreshSection("appSettings");

                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                {
                    AppSetting setting = new AppSetting();
                    setting.SaveConnectionString("PaperShop.Properties.Settings.papeleriaConnectionString", connectionString);

                }
                string qry = "";
                string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
                SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
                SqlCommand sqlCMD = new SqlCommand();
                qry = "SELECT * from VistaUsuarios";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;
                SqlDataReader sqlDR = null;
                try
                {
                    sqlCNX.Open();
                    sqlDR = sqlCMD.ExecuteReader();
                    if (sqlDR.HasRows == true)
                    {
                        FrmLogin lo = new FrmLogin();
                        lo.Show();
                        this.Hide();
                        this.Alert("Conexion Exitosa!", FrmNotificaciones.alertTypeEnum.Success);
                    }
                    else
                    {
                        FrmNuevoUsuAd frm = new FrmNuevoUsuAd();
                        frm.Show();
                        this.Hide();
                        this.Alert("Conexion Exitosa!", FrmNotificaciones.alertTypeEnum.Success);
                    }
                }
                catch (SqlException ex)
                {
                    this.Alert("Error para continuar!", FrmNotificaciones.alertTypeEnum.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void cboServer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbbasededatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            BD = cmbbasededatos.Text;
        }
    }   
}
