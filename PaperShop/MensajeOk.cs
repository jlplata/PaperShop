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
    public partial class MensajeOk : Form
    {
        public MensajeOk()
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void MensajeOk_Load(object sender, EventArgs e)
        {
            

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
