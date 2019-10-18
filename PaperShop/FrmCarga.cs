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
    public partial class FrmCarga : Form
    {
        public FrmCarga()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, panelinicio1, new object[] { true });

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
                BPInicio.Increment(2);
            if (BPInicio.Value==100)
            {
                FrmLogin frm = new FrmLogin();
                frm.Show();
                this.Hide();
                timer1.Stop();

            }
            
        }

        private void FrmCarga_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);

        }

        private void BPInicio_Click(object sender, EventArgs e)
        {

        }
    }
}
