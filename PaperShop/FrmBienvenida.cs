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
using System.Data.SqlClient;

namespace PaperShop
{
    public partial class FrmBienvenida : Form
    {
        public FrmBienvenida()
        {

            InitializeComponent();
        }

        public void GridProductosBajos()
        {
            string qry = "SELECT * FROM VistaProductos WHERE cantidad BETWEEN 0 AND 15";
            string msgError = "Error al llenar el dgvProductosBajos";

            bool HasRows = Connection.ExecuteQuery(qry, null, msgError);
            if (HasRows)
            {
                this.Show();
                SqlDataAdapter adaptador = Connection.ExecuteQueryAdapter(qry, null, msgError);
                DataTable datos = new DataTable();
                adaptador.Fill(datos);

                //Asignamos los datos al dgvProductos
                dgvProductosBajos.DataSource = datos;

                dgvProductosBajos.Visible = true;
                lblBajoStock.Visible = true;
            }
            else
            {
                dgvProductosBajos.DataSource = null;
                dgvProductosBajos.Visible = false;
                lblBajoStock.Visible = false;
                MessageBox.Show("Inventario en orden :D", "SI");
            }
        }
        private void FrmBienvenida_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelContenedorForm, Color.Black, 90, 10, Guna.UI.WinForms.VerHorAlign.HoriziontalTop);
            GridProductosBajos();
        }

        private void dgvProductosBajos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvProductosBajos.Rows)
            {
                if (Int16.Parse(row.Cells["cantidad"].Value.ToString()) <= 5)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else if (Int16.Parse(row.Cells["cantidad"].Value.ToString()) > 5 && Int16.Parse(row.Cells["cantidad"].Value.ToString()) <= 15)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }
    }
}
