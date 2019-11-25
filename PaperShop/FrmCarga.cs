using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

                string qry = "";
                string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
                SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
                SqlCommand sqlCMD = new SqlCommand();
                qry = "SELECT * from VistaUsuarios";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;
                SqlDataReader sqlDR = null;
                try
                {
                    sqlCNX.Open();
                    sqlDR = sqlCMD.ExecuteReader();
                    if (sqlDR.HasRows == true)
                    {
                        FrmLogin lo = new FrmLogin();
                        lo.Show();
                        this.Hide();
                        timer1.Stop();
                    }
                    else
                    {
                        FrmNuevoUsuAd frm = new FrmNuevoUsuAd();
                        frm.Show();
                        this.Hide();
                        timer1.Stop();
                    }
                }
                catch (SqlException ex)
                {
                    //    MessageBox.Show(ex.Message, "");
                    frmConexion frm = new frmConexion();
                    frm.Show();
                    this.Hide();
                    timer1.Stop();
                }

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
