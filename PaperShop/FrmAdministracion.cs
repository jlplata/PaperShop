using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperShop
{
    public partial class FrmAdministracion : Form
    {
        public FrmAdministracion()
        {
            InitializeComponent();

            Guna.UI.Lib.GraphicsHelper.DrawLineShadow( panelContenedorForm, Color.Black, 90, 10, Guna.UI.WinForms.VerHorAlign.HoriziontalTop);

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
           | BindingFlags.Instance | BindingFlags.NonPublic, null,
           PanelAdios, new object[] { true }); 
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
            | BindingFlags.Instance | BindingFlags.NonPublic, null,
            panelContenedorForm, new object[] { true });
        }


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

        private void Btnpersonas_Click(object sender, EventArgs e)
        {
            PanelAdios.Visible = false;
            frmPersonas fp = new frmPersonas();
            fp.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fp);
            
        }

        private void GunaButton1_Click(object sender, EventArgs e)
        {

            frmUsuarios fp = new frmUsuarios();
            fp.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fp);
            PanelAdios.Visible = false;
        }

        private void GunaButton2_Click(object sender, EventArgs e)
        {
            frmClientes fp = new frmClientes();
            fp.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fp);
            PanelAdios.Visible = false;

        }

        private void GunaButton3_Click(object sender, EventArgs e)
        {
            frmDepartamentos fp = new frmDepartamentos();
            fp.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fp);
            PanelAdios.Visible = false;
        }

        private void Btnpuntos_Click(object sender, EventArgs e)
        {
            frmPuestos fp = new frmPuestos();
            fp.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fp);
            PanelAdios.Visible = false;
        }

        private void Btntraba_Click(object sender, EventArgs e)
        {
            frmTrabajadores fp = new frmTrabajadores();
            fp.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fp);
            PanelAdios.Visible = false;
        }

        private void Btncajas_Click(object sender, EventArgs e)
        {
            frmCajas fp = new frmCajas();
            fp.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fp);
            PanelAdios.Visible = false;
        }

        private void Btnsucur_Click(object sender, EventArgs e)
        {
            frmSucursales fp = new frmSucursales();
            fp.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fp);
            PanelAdios.Visible = false;
        }

        private void panelContenedorForm_Click(object sender, EventArgs e)
        {
           
        }

        private void panelContenedorForm_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
