using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperShop
{
    public partial class agg : Form
    {
        public agg()
        {
            InitializeComponent();
        }

        private static bool ValidaIP(string sIP)
        {
            try
            {
                IPAddress ip = IPAddress.Parse(sIP);
            }
            catch
            {
                MessageBox.Show("llenar brother ya la kkk", " Error ");
                return false; 
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qry = "";
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            SqlCommand sqlCMD = new SqlCommand();
            try
            {

                if (textBox1.Text != "")
                {
                    if (textBox2.Text != "")
                    {
                        if (textBox2.Text.Length == 15)
                        {
                            
                            if (ValidaIP(textBox2.Text) == true)
                            {

                            
                            qry = "INSERT INTO equipos(nombre_equipo, ip_pc, activo) VALUES('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "',1)";
                            sqlCMD.CommandText = qry;
                            sqlCMD.Connection = sqlCNX;
                            sqlCNX.Open();
                            sqlCMD.ExecuteReader();
                            sqlCNX.Close();
                            this.Hide();
                            FrmPrin g = new FrmPrin();
                            g.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("llenar brother ya la", " Error ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("llenar brother ya la", " Error ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("llenar campos", " Error ");
                    }

                }
                else
                {
                    MessageBox.Show("llenar campos", " Error ");
                }  
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, " Error ");
            }
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
