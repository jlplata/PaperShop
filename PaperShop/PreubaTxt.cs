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
    public partial class PreubaTxt : Form
    {
        public PreubaTxt()
        {
            InitializeComponent();
        }

        private void valdacionLetras(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }
        private void PreubaTxt_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox1_Click(object sender, EventArgs e)
        {
         

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

            gunaLineTextBox1.LineColor = Color.Orange;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
             gunaLineTextBox1.LineColor = Color.FromArgb(100, 88, 255);
        }
    }
}
