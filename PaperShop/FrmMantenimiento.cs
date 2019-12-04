using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperShop
{
    public partial class FrmMantenimiento : Form
    {
        public FrmMantenimiento()
        {
     
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelContenedorForm, Color.Black, 90, 10, Guna.UI.WinForms.VerHorAlign.HoriziontalTop);
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

        private void BtnSalidaMant_Click(object sender, EventArgs e)
        {
            PanelAdios.Visible = false;
            frmManSalidas fp = new frmManSalidas();
            fp.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fp);
        }
    }
}
