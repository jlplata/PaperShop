using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace PaperShop
{
    public partial class frmSelecProducto : Form
    {
        string triggerForm;
        Type typeTriggerForm;
        Form realTriggerForm;
        public frmSelecProducto(string salidaentrada)
        {
            InitializeComponent();
            triggerForm = salidaentrada;
            typeTriggerForm = (triggerForm == "salida") ? typeof(frmSalidas) : typeof(frmSalidas);

            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeTriggerForm)
                {
                    realTriggerForm = frm;
                }

            }

        }

        void GridProductos()
        {
            string qry = "SELECT * FROM VistaProductos WHERE (cve_producto like '%" + txtBuscar.Text + "%' OR descripcion like '%" + txtBuscar.Text + "%' OR nombre like '%" + txtBuscar.Text + "%') AND activo=1";
            string msgError = "Error al llenar el dgvProductos";

            SqlDataAdapter adaptador = Connection.ExecuteQueryAdapter(qry, null, msgError);
            DataTable datos = new DataTable();
            adaptador.Fill(datos);

            //Asignamos los datos al dgvProductos
            dgvProductos.DataSource = datos;

        }
        private void frmSelecProducto_Load(object sender, EventArgs e)
        {
            GridProductos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            GridProductos();
        }

        private void frmSelecProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (realTriggerForm.GetType() == typeof(frmSalidas))
            {
                frmSalidas.frmSelecProductosSalidasAbierto = false;
            }
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

            string producto = dgvProductos.CurrentRow.Cells["cve_producto"].Value.ToString();
           
            foreach (Control ctrl1 in realTriggerForm.Controls)
            {
                if (ctrl1.Name == "grbbuscar_producto")
                {
                    foreach (Control ctrl2 in ctrl1.Controls)
                    {
                        if (ctrl2.Name == "txtcve_producto")
                        {
                            ctrl2.Text = producto;
                            ctrl2.Focus();
                        }
                    }
                }
            }

            this.Close();
        }
        private void focusBuscar_Enter(object sender, EventArgs e)
        {
            txtBuscar.Focus();
        }
        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            focusBuscar.LineColor = Color.White;
        }
        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            focusBuscar.LineColor = Color.FromArgb(67, 83, 192);
        }
    }
}
