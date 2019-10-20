using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Librerías para extraer info del app.config
using System.Configuration;
using System.Collections.Specialized;
//Librería para conexión a BD
using System.Data.SqlClient;

namespace PaperShop
{
    public partial class frmCategoriasProductos : Form
    {
        public frmCategoriasProductos()
        {
            InitializeComponent();
        }

        void Cargar()
        {
            grbCatProductos.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            btnNuevo.Focus();
            Activos.Checked = true;

        }

        void GridCatProd(int activo)
        {
            //Consulta
            string qry;
            //Extrae la configuración del appconfig
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");

            //Conecta a la BD
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            //Guarda el objeto o comando
            SqlCommand sqlCMD = new SqlCommand();

            try
            {
                qry = "SELECT * FROM VistaCategoriaProductos WHERE nombre_categoria like '%" + txtBuscar.Text + "%' AND activo='" + activo + "'";
                //Consulta parar extraer los datos de las personas

                //Asignamos la consulta al comando
                sqlCMD.CommandText = qry;

                //Asignamos la conexión al comando
                sqlCMD.Connection = sqlCNX;

                //Abrimos la conexión
                sqlCNX.Open();

                //Variable para el adaptador
                SqlDataAdapter adaptador = new SqlDataAdapter(sqlCMD);

                //Variable para crear la tabla
                DataTable datos = new DataTable();

                //Llenamos la tabla
                adaptador.Fill(datos);

                //Cerramos la conexión
                sqlCNX.Close();

                //Asignamos los datos al dgvPersonas
                dgvCatProductos.DataSource = datos;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al llenar el dgvCatProductos! " + ex.Message.ToString(), "SI");
            }
        }
        void Nuevo()
        {
            grbCatProductos.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            txtActivo.Text = "1";
            txtNombre.Focus();

            //Asignamos la fecha y hora a los lbls correspondientes
            DateTime hoy = DateTime.Now;
            lblFechaRegistro.Text = hoy.ToString("yyyyMMdd");
            lblHoraRegistro.Text = hoy.ToShortTimeString();
        }

        void Cancelar()
        {
            Cargar();
            txtNombre.Clear();
            dgvCatProductos.Enabled = true; 
            DateTime hoy = DateTime.Now;
            lblFechaRegistro.Text = hoy.ToString("yyyyMMdd");
            lblHoraRegistro.Text = hoy.ToShortTimeString();
        }

        void Actualizar()
        {
            grbCatProductos.Enabled = true;
            txtNombre.Focus();
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            DateTime hoy = DateTime.Now;
            lblFechaRegistro.Text = hoy.ToString("yyyyMMdd");
            lblHoraRegistro.Text = hoy.ToShortTimeString();
            btnGuardar.Enabled = false;
        }

        private void FrmCategoriasProductos_Load(object sender, EventArgs e)
        {
            Cargar();
            txtIdUsuario.Text = FrmPrin.id;
            //Invocamos el método GridPersonas()
            GridCatProd(1);
            
        }
        private void valdacionNumsLetras(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string qry = "";

            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");

            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);

            SqlCommand sqlCMD = new SqlCommand();

            try
            {

                qry = "SELECT * FROM categoria_productos WHERE nombre_categoria= '" + txtNombre.Text + "'";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;

                SqlDataReader sqlDR = null;
                sqlCNX.Open();
                sqlDR = sqlCMD.ExecuteReader();
                if (sqlDR.HasRows)
                {
                    sqlCNX.Close();
                    MessageBox.Show("Ya existe una categoría con ese nombre", "SI");

                }
                else
                {
                    sqlCNX.Close();
                    //Insertamos o guardamos la persona en la BD
                    qry = "INSERT INTO categoria_productos(nombre_categoria, fecha_registro, hora_registro, activo, id_usuario) " +
                    "VALUES ('" + txtNombre.Text + "', '" + lblFechaRegistro.Text + "', '" + lblHoraRegistro.Text + "', '" + txtActivo.Text + "', '" + FrmPrin.id + "')";

                    //Asignamos la consulta al comando
                    sqlCMD.CommandText = qry;

                    //Asignamos la conexión al comando
                    sqlCMD.Connection = sqlCNX;

                    //Abrimos la conexión
                    sqlCNX.Open();

                    //Ejecutamos el comando
                    sqlCMD.ExecuteReader();

                    //Cerramos la conexión
                    sqlCNX.Close();

                    MessageBox.Show("Categoría registrada!", "SI");

                    //Invocamos al método cargar
                    Cargar();
                    //Invocamos el método cancelar
                    Cancelar();

                    GridCatProd(1);
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Error al agregar la categoría. " + ex.Message.ToString(), "SI");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            string qry = "";

            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");

            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);

            SqlCommand sqlCMD = new SqlCommand();

            SqlDataReader sqlDR;

            try
            {
                int idCategoria = Convert.ToInt16(dgvCatProductos.CurrentRow.Cells["id_categoria_producto"].Value.ToString());
                qry = "SELECT * FROM categoria_productos WHERE nombre_categoria= '" + txtNombre.Text + "' AND id_categoria_producto !=" + idCategoria + "";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;

                sqlCNX.Open();
                sqlDR = sqlCMD.ExecuteReader();
                if (sqlDR.HasRows)
                {
                    sqlCNX.Close();
                    MessageBox.Show("Ya existe una categoría con ese nombre", "SI");

                }
                else
                {
                    sqlCNX.Close();
                    //Insertamos o guardamos la persona en la BD
                    qry = "UPDATE categoria_productos SET nombre_categoria='" + txtNombre.Text + "', fecha_registro='" + lblFechaRegistro.Text + "', hora_registro='" + lblHoraRegistro.Text + "', id_usuario='" + FrmPrin.id + "' WHERE id_categoria_producto=" + idCategoria;

                    //Asignamos la consulta al comando
                    sqlCMD.CommandText = qry;

                    //Asignamos la conexión al comando
                    sqlCMD.Connection = sqlCNX;

                    //Abrimos la conexión
                    sqlCNX.Open();

                    //Ejecutamos el comando
                    sqlCMD.ExecuteReader();

                    //Cerramos la conexión
                    sqlCNX.Close();

                    MessageBox.Show("Categoría modificada!", "SI");

                    //Invocamos al método cargar
                    Cargar();
                    //Invocamos el método cancelar
                    Cancelar();

                    GridCatProd(1);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al modificar la categoría! " + ex.Message.ToString(), "SI");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void RdbActivos_CheckedChanged(object sender, EventArgs e)
        {
            activo = 1;
            GridCatProd(activo);
        }

        private void RdbInactivos_CheckedChanged(object sender, EventArgs e)
        {
            activo = 0;
            GridCatProd(activo);
        }

        int activo = 1;
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            GridCatProd(activo);
        }

        private void TxtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!(txtNombre.Text == string.Empty))
                {
                    btnGuardar.Focus();
                }
                else
                {
                    MessageBox.Show("No puedes dejar el campo vacío");
                }
            }
        }
        private void BtnModificarCatProducto_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombre.Text = dgvCatProductos.CurrentRow.Cells["nombre_categoria"].Value.ToString();
                lblFechaRegistro.Text = dgvCatProductos.CurrentRow.Cells["fecha_registro"].Value.ToString();
                lblHoraRegistro.Text = dgvCatProductos.CurrentRow.Cells["hora_registro"].Value.ToString();
                txtActivo.Text = dgvCatProductos.CurrentRow.Cells["activo"].Value.ToString();
                dgvCatProductos.Enabled = false;

                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnDesactivarCatProducto_Click(object sender, EventArgs e)
        {
            string idCatProducto = dgvCatProductos.CurrentRow.Cells["id_categoria_producto"].Value.ToString();
            //Consulta
            string qry;
            //Extrae la configuración del appconfig
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");

            //Conecta a la BD
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            //Guarda el objeto o comando
            SqlCommand sqlCMD = new SqlCommand();
            //Insertamos o guardamos la persona en la BD
            qry = "UPDATE categoria_productos SET activo=0 WHERE id_categoria_producto=" + idCatProducto;

            //Asignamos la consulta al comando
            sqlCMD.CommandText = qry;

            //Asignamos la conexión al comando
            sqlCMD.Connection = sqlCNX;

            try
            {
                //Abrimos la conexión
                sqlCNX.Open();

                //Ejecutamos el comando
                sqlCMD.ExecuteReader();

                //Cerramos la conexión
                sqlCNX.Close();

                Activos.Checked = true;
                GridCatProd(activo);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void BtnActivarCatProducto_Click(object sender, EventArgs e)
        {
            string idCatProducto = dgvCatProductos.CurrentRow.Cells["id_categoria_producto"].Value.ToString();
            //Consulta
            string qry;
            //Extrae la configuración del appconfig
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");

            //Conecta a la BD
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            //Guarda el objeto o comando
            SqlCommand sqlCMD = new SqlCommand();
            //Insertamos o guardamos la persona en la BD
            qry = "UPDATE categoria_productos SET activo=1 WHERE id_categoria_producto=" + idCatProducto;

            //Asignamos la consulta al comando
            sqlCMD.CommandText = qry;

            //Asignamos la conexión al comando
            sqlCMD.Connection = sqlCNX;

            try
            {
                //Abrimos la conexión
                sqlCNX.Open();

                //Ejecutamos el comando
                sqlCMD.ExecuteReader();

                //Cerramos la conexión
                sqlCNX.Close();

                GridCatProd(activo);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void McCatProductos_Opening(object sender, CancelEventArgs e)
        {
            if (dgvCatProductos.Rows.Count > 0 && Activos.Checked == true)
            {

                btnModificarCatProducto.Visible = true;
                btnDesactivarCatProducto.Visible = true;
                btnActivarCatProducto.Visible = false;

            }
            else if (dgvCatProductos.Rows.Count <= 0 && Activos.Checked == true)
            {
                btnModificarCatProducto.Visible = false;
                btnDesactivarCatProducto.Visible = false;
                btnActivarCatProducto.Visible = false;
            }
            else if (dgvCatProductos.Rows.Count > 0 && Activos.Checked == false)
            {
                btnModificarCatProducto.Visible = false;
                btnDesactivarCatProducto.Visible = false;
                btnActivarCatProducto.Visible = true;
            }
            else if (dgvCatProductos.Rows.Count <= 0 && Activos.Checked == false)
            {
                btnModificarCatProducto.Visible = false;
                btnDesactivarCatProducto.Visible = false;
                btnActivarCatProducto.Visible = false;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            focusnom.LineColor = Color.FromArgb(100, 88, 255);
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            focusnom.LineColor = Color.White;
        }

        private void focusnom_Enter(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }
        private void focusBuscar_Enter(object sender, EventArgs e)
        {
            txtBuscar.Focus();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            focusBuscar.LineColor = Color.FromArgb(100, 88, 255);
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            focusBuscar.LineColor = Color.White;
        }

        private void Activos_CheckedChanged(object sender, EventArgs e)
        {
            if (Activos.Checked == true)
            {

                activo = 1;
                GridCatProd(activo);
                lblActi.Text = "Activos";
            }
            else if (Activos.Checked == false)
            {
                activo = 0;
                GridCatProd(activo);
                lblActi.Text = "Inactivos";
            }
        }

        private void focusBuscar_FontChanged(object sender, EventArgs e)
        {

        }
    }
}
