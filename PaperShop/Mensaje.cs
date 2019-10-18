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
    public partial class Mensaje : Form
    {
        public Mensaje()
        {
            InitializeComponent();
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
