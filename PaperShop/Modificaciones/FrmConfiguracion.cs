using PaperShop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperShop.Modificaciones
{
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
            
        }

        private void gunaSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.CheckColor = 0;
            Settings.Default.fondo = Color.FromArgb(20, 25, 53);
            if (SwchOriginal.Checked == true)
            {
                SwchAqua.Checked = false;
                SwchGreen.Checked = false;
            }
        }

        private void SwchAqua_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.CheckColor = 1;
            Settings.Default.fondo = Color.FromArgb(1, 135, 144);
            if (SwchAqua.Checked == true)
            {
                SwchOriginal.Checked = false;
                SwchGreen.Checked = false;
            }
        }

        private void SwchGreen_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.CheckColor = 2;
            Settings.Default.fondo = Color.FromArgb(0, 150, 136);
            if (SwchGreen.Checked == true)
            {
                SwchOriginal.Checked = false;
                SwchAqua.Checked = false;
            }
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            if (Settings.Default.CheckColor == 0)
            {
                SwchOriginal.Checked = true;
                SwchAqua.Checked = false;
                SwchGreen.Checked = false;
            }
            if (Settings.Default.CheckColor == 1)
            {
                SwchOriginal.Checked = false;
                SwchAqua.Checked = true;
                SwchGreen.Checked = false;
            }
            if (Settings.Default.CheckColor == 2)
            {
                SwchOriginal.Checked = false;
                SwchAqua.Checked = false;
                SwchGreen.Checked = true;
            }
        }
    }
}
