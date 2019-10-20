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
    public partial class FrmAlmacen : Form
    {
        public FrmAlmacen()
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
        private void MostrarForm()
        {
            AbrirFormEnPanel(new FrmBienvenida());
        }
        //Metodo para que al cerrar algun frm se abra el frminicio
        public void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            MostrarForm();
        }

        private void BtnCatProd_Click(object sender, EventArgs e)
        {
            PanelAdios.Visible = false;
            frmCategoriasProductos fp = new frmCategoriasProductos();
            fp.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fp);
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            PanelAdios.Visible = false;
            frmProductos fp = new frmProductos();
            fp.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fp);
        }

        private void btncajas_Click(object sender, EventArgs e)
        {
            PanelAdios.Visible = false;
            frmSalidas fp = new frmSalidas();
            fp.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fp);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            PanelAdios.Visible = false;
            frmProveedores fp = new frmProveedores();
            fp.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fp);
        }
    }
}
