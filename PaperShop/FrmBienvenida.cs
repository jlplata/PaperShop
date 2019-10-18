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
    public partial class FrmBienvenida : Form
    {
        public FrmBienvenida()
        {

            InitializeComponent();
        }

        private void FrmBienvenida_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelContenedorForm, Color.Black, 90, 10, Guna.UI.WinForms.VerHorAlign.HoriziontalTop);

        }
    }
}
