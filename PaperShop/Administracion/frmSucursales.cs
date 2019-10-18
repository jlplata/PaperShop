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
    public partial class frmSucursales : Form
    {
        public frmSucursales()
        {
            InitializeComponent();
        }
        void Cargar()
        {
            grbSucursales.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            btnNuevo.Focus();
            Activos.Checked = true;
            txtActivo.Text = "1";
        }

        void ComboTrabajadores()
        {
            string qry;
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            SqlCommand sqlCMD = new SqlCommand();
            try
            {
                qry = "SELECT id_trabajador, Nombre FROM VistaTrabajadores WHERE activo=1";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;
                sqlCNX.Open();

                SqlDataAdapter adaptador = new SqlDataAdapter(sqlCMD);
                DataTable datos = new DataTable();
                adaptador.Fill(datos);

                sqlCNX.Close();
                cmbTrabajadores.DataSource = datos;
                cmbTrabajadores.ValueMember = "id_trabajador";
                cmbTrabajadores.DisplayMember = "Nombre";

                //Variable para usar en autocompletar
                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

                foreach (DataRow row in datos.Rows)
                {
                    coleccion.Add(Convert.ToString(row["Nombre"]));
                }
                //Configuración final para el autocompletado del nombre de la categoría
                cmbTrabajadores.AutoCompleteCustomSource = coleccion;
                cmbTrabajadores.AutoCompleteSource = AutoCompleteSource.CustomSource;

            }
            catch (SqlException ex)
            {

                MessageBox.Show("Error al llenar el combo trabajadores. " + ex.Message.ToString(), "SI");
            }
        }

        void GridSucursales(int activo)
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
                qry = "SELECT * FROM VistaSucursales where (nombre_sucursal like '%" + txtBuscar.Text + "%' OR Responsable like '%" + txtBuscar.Text + "%') AND activo='" + activo + "'";
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
                dgvSucursales.DataSource = datos;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al llenar el dgvSucursales! " + ex.Message.ToString(), "SI");
            }
        }

        void Nuevo()
        {
            grbSucursales.Enabled = true;
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
            cmbTrabajadores.SelectedIndex = 0;
            txtIdUsuario.Text = "";
            dgvSucursales.Enabled = true;
            lblFechaRegistro.Text = "Fecha_Registro";
            lblHoraRegistro.Text = "Hora_Registro";
        }

        void Actualizar()
        {
            grbSucursales.Enabled = true;
            txtActivo.Enabled = false;
            txtIdUsuario.Enabled = false;
            txtNombre.Focus();
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void FrmSucursales_Load(object sender, EventArgs e)
        {
            ComboTrabajadores();
            btnNuevo.Focus();
            txtIdUsuario.Text = FrmPrin.id;
            Cargar();
            //Invocamos el método GridPersonas()
            GridSucursales(1);
        }
        private void valdacionNumsLetras(object sender, KeyPressEventArgs e)
        {
            validacion.numsLetras(e);
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

                qry = "SELECT * FROM sucursales WHERE nombre_sucursal= '" + txtNombre.Text + "'";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;

                SqlDataReader sqlDR = null;
                sqlCNX.Open();
                sqlDR = sqlCMD.ExecuteReader();
                if (sqlDR.HasRows)
                {
                    sqlCNX.Close();
                    MessageBox.Show("Ya existe una sucursal con ese nombre", "SI");

                }
                else
                {
                    sqlCNX.Close();
                    //Insertamos o guardamos la persona en la BD
                    qry = "INSERT INTO sucursales(nombre_sucursal, responsable, fecha_registro, hora_registro, activo, id_usuario) " +
                    "VALUES ('" + txtNombre.Text + "', '" + lblIdTrabajador.Text + "', '" + lblFechaRegistro.Text + "', '" + lblHoraRegistro.Text + "', '" + txtActivo.Text + "', '" + FrmPrin.id + "')";

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

                    MessageBox.Show("Sucursal registrada!", "SI");

                    //Invocamos al método cargar
                    Cargar();
                    //Invocamos el método cancelar
                    Cancelar();

                    GridSucursales(1);
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Error al agregar la sucursal. " + ex.Message.ToString(), "SI");
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
                int idSucursal = Int16.Parse(dgvSucursales.CurrentRow.Cells["id_sucursal"].Value.ToString());
                qry = "SELECT * FROM sucursales WHERE nombre_sucursal = '" + txtNombre.Text + "' AND id_sucursal !=" + Convert.ToInt16(dgvSucursales.CurrentRow.Cells["id_sucursal"].Value.ToString());
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;

                sqlCNX.Open();
                sqlDR = sqlCMD.ExecuteReader();
                if (sqlDR.HasRows)
                {
                    sqlCNX.Close();
                    MessageBox.Show("Ya existe una sucursal con ese nombre", "SI");

                }
                else
                {
                    sqlCNX.Close();
                    //Insertamos o guardamos la persona en la BD
                    qry = "UPDATE sucursales SET nombre_sucursal='" + txtNombre.Text + "',  responsable='" + lblIdTrabajador.Text+ "', fecha_registro='" + DateTime.Parse(lblFechaRegistro.Text).ToString("yyyyMMdd") + "', hora_registro='" + lblHoraRegistro.Text + "', id_usuario='" + FrmPrin.id + "' WHERE id_sucursal=" + idSucursal;

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

                    MessageBox.Show("Sucursal modificada!", "SI");

                    //Invocamos al método cargar
                    Cargar();
                    //Invocamos el método cancelar
                    Cancelar();

                    GridSucursales(1);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al modificar la sucursal! " + ex.Message.ToString(), "SI");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        int activo = 1;
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            GridSucursales(activo);
        }

        private void TxtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!(txtNombre.Text == string.Empty))
                {
                    cmbTrabajadores.Focus();
                }
                else
                {
                    MessageBox.Show("No puedes dejar el campo vacío");
                }
            }
        }
        private void CmbTrabajadores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!(cmbTrabajadores.Text == string.Empty))
                {
                    btnGuardar.Focus();
                }
                else
                {
                    MessageBox.Show("No puedes dejar el campo vacío");
                }
            }
        }

        private void BtnModificarSucursal_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombre.Text = dgvSucursales.CurrentRow.Cells["nombre_sucursal"].Value.ToString();
                cmbTrabajadores.Text = dgvSucursales.CurrentRow.Cells["responsable"].Value.ToString();
                lblFechaRegistro.Text = dgvSucursales.CurrentRow.Cells["fecha_registro"].Value.ToString();
                lblHoraRegistro.Text = dgvSucursales.CurrentRow.Cells["hora_registro"].Value.ToString();
                txtActivo.Text = dgvSucursales.CurrentRow.Cells["activo"].Value.ToString();
                dgvSucursales.Enabled = false;

                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnDesactivarSucursal_Click(object sender, EventArgs e)
        {
            string idsucursal = dgvSucursales.CurrentRow.Cells["id_sucursal"].Value.ToString();
            //Consulta
            string qry;
            //Extrae la configuración del appconfig
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");

            //Conecta a la BD
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            //Guarda el objeto o comando
            SqlCommand sqlCMD = new SqlCommand();
            //Insertamos o guardamos la persona en la BD
            qry = "UPDATE sucursales SET activo=0 WHERE id_sucursal=" + idsucursal;

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
                GridSucursales(activo);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void BtnActivarSucursal_Click(object sender, EventArgs e)
        {
            string idsucursal = dgvSucursales.CurrentRow.Cells["id_sucursal"].Value.ToString();
            //Consulta
            string qry;
            //Extrae la configuración del appconfig
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");

            //Conecta a la BD
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            //Guarda el objeto o comando
            SqlCommand sqlCMD = new SqlCommand();
            //Insertamos o guardamos la persona en la BD
            qry = "UPDATE sucursales SET activo=1 WHERE id_sucursal=" + idsucursal;

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

                GridSucursales(activo);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void McSucursales_Opening(object sender, CancelEventArgs e)
        {




            if (dgvSucursales.Rows.Count > 0 && Activos.Checked == true)
            {

                btnModificarSucursal.Visible = true;
                btnDesactivarSucursal.Visible = true;
                btnActivarSucursal.Visible = false;

            }
            else if (dgvSucursales.Rows.Count <= 0 && Activos.Checked == true )
            {
                btnModificarSucursal.Visible = false;
                btnDesactivarSucursal.Visible = false;
                btnActivarSucursal.Visible = false;
            }
            else if (dgvSucursales.Rows.Count > 0 && Activos.Checked == false)
            {
                btnModificarSucursal.Visible = false;
                btnDesactivarSucursal.Visible = false;
                btnActivarSucursal.Visible = true;
            }
            else if (dgvSucursales.Rows.Count <= 0 && Activos.Checked == false)
            {
                btnModificarSucursal.Visible = false;
                btnDesactivarSucursal.Visible = false;
                btnActivarSucursal.Visible = false;
            }
        }

        private void CmbTrabajadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIdTrabajador.Text = cmbTrabajadores.SelectedValue.ToString();
        }

        private void Activos_CheckedChanged(object sender, EventArgs e)
        {
            if (Activos.Checked == true)
            {
                activo = 1;
                GridSucursales(activo);
                lblActi.Text = "Activos";
            }
            else if (Activos.Checked == false)
            {
                activo = 0;
                GridSucursales(activo);
                lblActi.Text = "Inactivos";
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

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            focusBuscar.LineColor = Color.FromArgb(100, 88, 255);

        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            focusBuscar.LineColor = Color.White;
        }

        private void focusBuscar_Enter(object sender, EventArgs e)
        {
            txtBuscar.Focus();
        }
    }
}
