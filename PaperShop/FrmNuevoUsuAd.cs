using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperShop
{
    public partial class FrmNuevoUsuAd : Form
    {
        public FrmNuevoUsuAd()
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        string dir, diro;

        public void Alert(string msg, FrmNotificaciones.alertTypeEnum type)
        {
            FrmNotificaciones f = new FrmNotificaciones();
            f.setAlert(msg, type);
        }
        private void BtnIniciarS_Click(object sender, EventArgs e)
        {
            string[] stringArray = txtCorreo.Text.Split('@');
            if (!txtCorreo.Text.Contains('@') || !stringArray[1].Contains('.'))
            {
                MessageBox.Show("Introduce un correo electronico valido");
                return;
            }
            Random r = new Random();
            int idc = r.Next(00000001, 99999999);
            dir = "ima\\user" + idc + ".png";
            diro = "ima\\user.png";
            string pach = ".\\.\\";
            System.IO.File.Copy(pach + diro, pach + dir);

            //Variable para guardar la consulta
            string qry = "";
            //variable para extraer la configuracion del appconfig
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            //Variable para conectarnos a la BD
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            //variable para guardar objetos o comando
            SqlCommand sqlCMD = new SqlCommand();
            //Codigo para cachar errores
            try
            {
                string sexo = "";
                if (rdbMasculino.Checked == true)
                {
                    sexo = "M";
                }
                else
                {
                    sexo = "F";
                }
                int id = 1;
                string tipo = "administrador";
                string fechanacimiento = dtpFechaNacimiento.Value.ToString("yyyyMMdd");
                qry = "INSERT INTO usuarios(id_persona, login, password, tipo, fecha_registro, hora_registro, activo, id_user, imagen)" +
                            "VALUES('" + id + "', '" + txtlogin.Text + "','" + txtpassword.Text + "','" + tipo + "','" + lblFechaRegistro.Text + "','" + lblHoraRegistro.Text + "', '" + id + "', '" + id + "', '" + dir + "') INSERT INTO personas(nombre, apepaterno, apematerno, domicilio, telefono, correo, sexo, fecha_nac, estado_civil, estados, municipio, activo, fecha_registro, hora_registro, id_usuario)" +
                   "VALUES ('" + txtNombre.Text + "', '" + txtApeMaterno.Text + "', '" + txtApeMaterno.Text + "', '" + txtDomicilio.Text + "', '" + txtTelefono.Text + "', '" + txtCorreo.Text + "', '" + sexo + "', '" + fechanacimiento + "', '" + cmbEstadoCivil.Text + "', '" + txtEstado.Text + "', '" + txtMunicipio.Text + "','" + id + "', '" + lblFechaRegistro.Text + "', '" + lblHoraRegistro.Text + "', '" + id + "')";
                //asignamos la consulta al comando
                sqlCMD.CommandText = qry;
                //asignamos la conexion al comando
                sqlCMD.Connection = sqlCNX;
                //abrimos la coneccion
                sqlCNX.Open();
                //ejecutamos el comando
                sqlCMD.ExecuteReader();
                //cerramos conexion
                sqlCNX.Close();
                this.Alert("Usuario Agregado!", FrmNotificaciones.alertTypeEnum.Success);
                FrmLogin formulario = new FrmLogin();
                formulario.Show();
                Hide();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(""+ex,"Mnesaje");
                //this.Alert("Error al agregar usuario!", FrmNotificaciones.alertTypeEnum.Error);
            }
        }


        private void txtNombre_Enter(object sender, EventArgs e)
        {
            FocusNombre.LineColor = Color.FromArgb(100, 88, 255);
        }
        private void FocusNombre_Enter(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            FocusNombre.LineColor = Color.White;
        }
        private void txtApePaterno_Enter(object sender, EventArgs e)
        {
            focusPaterno.LineColor = Color.FromArgb(100, 88, 255);

        }
        private void focusPaterno_Enter(object sender, EventArgs e)
        {
            txtApePaterno.Focus();
        }
        private void txtApePaterno_Leave(object sender, EventArgs e)
        {
            focusPaterno.LineColor = Color.White;
        }

        private void txtApeMaterno_Enter(object sender, EventArgs e)
        {
            focusApeMaterno.LineColor = Color.FromArgb(100, 88, 255);
        }
        private void focusApeMaterno_Enter(object sender, EventArgs e)
        {
            txtApeMaterno.Focus();
        }
        private void txtApeMaterno_Leave(object sender, EventArgs e)
        {
            focusApeMaterno.LineColor = Color.White;
        }

        private void txtDomicilio_Enter(object sender, EventArgs e)
        {
            focusDomicilio.LineColor = Color.FromArgb(100, 88, 255);
        }
        private void focusDomicilio_Enter(object sender, EventArgs e)
        {
            txtDomicilio.Focus();
        }
        private void txtDomicilio_Leave(object sender, EventArgs e)
        {
            focusDomicilio.LineColor = Color.White;
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            focusCorreo.LineColor = Color.FromArgb(100, 88, 255);
        }
        private void focusCorreo_Enter(object sender, EventArgs e)
        {
            txtCorreo.Focus();
        }
        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            focusCorreo.LineColor = Color.White;

        }

        private void txtEstado_Enter(object sender, EventArgs e)
        {
            focusEstado.LineColor = Color.FromArgb(100, 88, 255);
        }

        private void focusEstado_Enter(object sender, EventArgs e)
        {
            txtEstado.Focus();
        }

        private void txtEstado_Leave(object sender, EventArgs e)
        {
            focusEstado.LineColor = Color.White;
        }

        private void txtMunicipio_Enter(object sender, EventArgs e)
        {
            focusMunicipio.LineColor = Color.FromArgb(100, 88, 255);
        }

        private void focusMunicipio_Enter(object sender, EventArgs e)
        {
            txtMunicipio.Focus();
        }

        private void txtMunicipio_Leave(object sender, EventArgs e)
        {
            focusMunicipio.LineColor = Color.White;
        }

        private void txtlogin_Enter(object sender, EventArgs e)
        {
            focuslogin.LineColor = Color.FromArgb(100, 88, 255);
        }

        private void focuslogin_Enter(object sender, EventArgs e)
        {
            txtlogin.Focus();
        }

        private void txtlogin_Leave(object sender, EventArgs e)
        {
            focuslogin.LineColor = Color.White;

        }
        private void txtpassword_Enter(object sender, EventArgs e)
        {
            focuspass.LineColor = Color.FromArgb(100, 88, 255);
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            focuspass.LineColor = Color.White;
        }

        private void FrmNuevoUsuAd_Load(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            //lblfecharegistro.Text = hoy.ToShortDateString();
            lblHoraRegistro.Text = hoy.ToShortTimeString();
            //En caso de marcar error en la /*fecha*/
            lblFechaRegistro.Text = hoy.ToString("yyyyMMdd");
        }

        private void focuspass_Enter(object sender, EventArgs e)
        {
            txtpassword.Focus();
        }
    }
}
