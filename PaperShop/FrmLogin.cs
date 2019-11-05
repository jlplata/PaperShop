using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;
using PaperShop.Properties;

namespace PaperShop
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();

        }

        validacion p = new validacion();

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            txtUser.Focus();
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Mensaje mm = new Mensaje();
            mm.Show();
        }

        private void BtnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        public void Alert(string msg, FrmNotificaciones.alertTypeEnum type)
        {
            FrmNotificaciones f = new FrmNotificaciones();
            f.setAlert(msg, type);
        }
        private void BtnIniciarS_Click(object sender, EventArgs e)
        {
            string qry = "";

            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");

            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);

            SqlCommand sqlCMD = new SqlCommand();

            qry = "SELECT  personas, LoginUser, id_usuario, usuario, password,  imagen, tipo from VistaUsuarios where usuario = '" + this.txtUser.Text + "' and password = '" + this.txtPass.Text + "' and tipo = '" + this.cmbTipo.Text + "'";

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
                        FrmPrin.Usuario = sqlDR["personas"].ToString();
                        FrmPrin.id = sqlDR["id_usuario"].ToString();
                        FrmPrin.tipo = sqlDR["tipo"].ToString();
                        FrmPrin.ima = sqlDR["imagen"].ToString();
                    }
                    if (cmbTipo.Text == "Administrador")
                    {
                        FrmPrin formulario = new FrmPrin();
                        formulario.Show();
                    }
                    if (cmbTipo.Text == "Almacenista")
                    {
                        FrmPrin formulario = new FrmPrin();
                        formulario.Show();
                    }
                    if (cmbTipo.Text == "Cajero")
                    {
                        FrmPrin formulario = new FrmPrin();
                        formulario.Show();
                    }
                    this.Hide();

                    //MensajeOk mm = new MensajeOk();
                    //mm.lbltxt.Text = "Bienvenido, " + FrmPrin.Usuario;
                    //mm.ShowDialog();
                    this.Alert("Bienvenido " + FrmPrin.Usuario, FrmNotificaciones.alertTypeEnum.Success);




                    //MessageBox.Show("Bienvenido: " + frmPrincipal.bienvenida, "Control de Inventario");

                    sqlCNX.Close();
                }
                else
                {
                    this.Alert("Usuario o contraseña incorrecto ", FrmNotificaciones.alertTypeEnum.Warning);

                    //MessageBox.Show("Usuario o contraseña incorrecto", "Control de Inventario");
                    txtUser.Text = "";
                    txtPass.Text = "";
                    txtUser.Focus();
                }

            }
            catch(Exception ex)
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

        private void TxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPass.Text.Length == 0)
                {
                    MensajeOk ms = new MensajeOk();
                    ms.lbltxt.Text = "Campo vacio";
                    ms.ShowDialog();
                    txtPass.Focus();
                    return;
                }
                cmbTipo.Focus();
            }
        }

        private void TxtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPass.Text.Length == 0)
                {
                    MensajeOk ms = new MensajeOk();
                    ms.lbltxt.Text = "Campo vacio";
                    ms.ShowDialog();
                    txtUser.Focus();
                    return;

                }
                txtPass.Focus();
            }
        }

        private void TxtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Pp_Tick(object sender, EventArgs e)
        {
           
        }



        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
