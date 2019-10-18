using PaperShop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperShop
{
    public partial class FrmPrin : Form
    {
        public FrmPrin()
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            //Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelContenedorForm, Color.Black, 20, 10, Guna.UI.WinForms.VerHorAlign.HoriziontalTop);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelContenedorForm, Color.Black, 90, 10, Guna.UI.WinForms.VerHorAlign.HoriziontalTop);



            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //SetStyle(ControlStyles.UserPaint, true);
            //SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //SetStyle(ControlStyles.DoubleBuffer, true);


        }
        //Metodo que ayuda a arrastrar el frm con el panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void InfoUsuario() 
        {
            string pach = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            if (ima == null)
            {
                ImgUsuario.Image = Resources.user;
            }
            else
            {
                 ImgUsuario.Load(pach + ima);
                 NombUsuario.Text = Usuario;
                 TipoUsuario.Text = tipo;
            }
        }

        private void GunaImageButton3_Click(object sender, EventArgs e)
        {
            Mensaje mm = new Mensaje();
            mm.Show();
        }
        public static string Usuario, id, tipo, ima;

        //Metodo para abrir un frm dentro de un panel
        public void AbrirFormEnPanel(object formHijo)
        {

            if (this.panelContenedorForm.Controls.Count > 0)
                this.panelContenedorForm.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorForm.Controls.Add(fh);
            this.panelContenedorForm.Tag = fh;
            fh.Show();
        }
        //Metodo para abrir el frm inicio
        private void MostrarForm()
        {
            AbrirFormEnPanel(new FrmBienvenida());
        }
        //Metodo para que al cerrar algun frm se abra el frminicio
        public void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            MostrarForm();
        }

        private void Btninicio_Click(object sender, EventArgs e)
        {
            MostrarForm();
        }

        private void GunaPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public void Alert(string msg, FrmNotificaciones.alertTypeEnum type)
        {
            FrmNotificaciones f = new FrmNotificaciones();
            f.setAlert(msg, type);
        }
        private void GunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            this.Alert("Bienvenido No jhjerjkkjrejk", FrmNotificaciones.alertTypeEnum.Info);

        }
        private bool Colapzar;

        private void Menu_Tick(object sender, EventArgs e)
        {
            if (Colapzar)
            {
                pnlmenu.Height += 10;
                if (pnlmenu.Size == pnlmenu.MaximumSize)
                {
                    Menu.Stop();
                    Colapzar = false;
                }
            }
            else
            {
                pnlmenu.Height -= 10;
                if (pnlmenu.Size == pnlmenu.MinimumSize)
                {
                    Menu.Stop();
                    Colapzar = true;
                }
            }
        }
        int v = 1;
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (v==0)
            {
                v = 1;
                Menu.Start();
                pnlmenu.Visible = true;
              
            }
            else
            {
                Menu.Start();
                pnlmenu.Visible = false;
                v = 0;
            }
        }
        public void cerrar()
        {
            if (v == 1)
            {
                BtnMenu.PerformClick();
            }
        }

        private void gunaPanel2_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void gunaPanel4_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void panelContenedorForm_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void gunaPanel1_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            FrmLogin log = new FrmLogin();
            log.Show();
            this.Hide();
            
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {
            cerrar();
        }

        private void FrmPrin_Load(object sender, EventArgs e)
        {
            MostrarForm();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
          | BindingFlags.Instance | BindingFlags.NonPublic, null,
          pnlmenu, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
           | BindingFlags.Instance | BindingFlags.NonPublic, null,
           pnldentro, new object[] { true });
            InfoUsuario();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(barra, Color.Black, 90, 10, Guna.UI.WinForms.VerHorAlign.HorizontalBottom);
        }

        private void GunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            FrmAdministracion adm = new FrmAdministracion();
            adm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(adm);
            cerrar();
            
        }

    }
}
