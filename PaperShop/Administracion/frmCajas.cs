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
    public partial class frmCajas : Form
    {
        public frmCajas()
        {
            InitializeComponent();
            txtIdUsuario.Text = FrmPrin.id;

        }

        void Cargar()
        {
            grbCajas.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            btnNuevo.Focus();
            Activos.Checked = true;

        }

        void ComboSucursales()
        {
            string qry;
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            SqlCommand sqlCMD = new SqlCommand();
            try
            {
                qry = "SELECT id_sucursal, nombre_sucursal FROM VistaSucursales WHERE activo=1";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;
                sqlCNX.Open();

                SqlDataAdapter adaptador = new SqlDataAdapter(sqlCMD);
                DataTable datos = new DataTable();
                adaptador.Fill(datos);

                sqlCNX.Close();
                cmbSucursales.DataSource = datos;
                cmbSucursales.ValueMember = "id_sucursal";
                cmbSucursales.DisplayMember = "nombre_sucursal";

                //Variable para usar en autocompletar
                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

                foreach (DataRow row in datos.Rows)
                {
                    coleccion.Add(Convert.ToString(row["nombre_sucursal"]));
                }
                //Configuración final para el autocompletado del nombre de la categoría
                cmbSucursales.AutoCompleteCustomSource = coleccion;
                cmbSucursales.AutoCompleteSource = AutoCompleteSource.CustomSource;

            }
            catch (SqlException ex)
            {

                MessageBox.Show("Error al llenar el combo sucursales. " + ex.Message.ToString(), "SI");
            }
        }

        void GridCajas(int activo)
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
                qry = "SELECT * FROM VistaCajas WHERE (numero_caja like '%" + txtBuscar.Text + "%' OR sucursal like '%" + txtBuscar.Text + "%') AND activo='" + activo + "'";
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
                dgvCajas.DataSource = datos;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al llenar el dgvCajas! " + ex.Message.ToString(), "SI");
            }
        }

        void Nuevo()
        {
            grbCajas.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            txtActivo.Text = "1";
            txtNumero.Focus();

            //Asignamos la fecha y hora a los lbls correspondientes
            DateTime hoy = DateTime.Now;
            lblFechaRegistro.Text = hoy.ToString("yyyyMMdd");
            lblHoraRegistro.Text = hoy.ToShortTimeString();
        }

        void Cancelar()
        {
            Cargar();
            txtNumero.Clear();
            cmbSucursales.SelectedIndex = 0;
            txtIdUsuario.Text = "";
            dgvCajas.Enabled = true;
            lblFechaRegistro.Text = "Fecha_Registro";
            lblHoraRegistro.Text = "Hora_Registro";
        }

        void Actualizar()
        {
            grbCajas.Enabled = true;
            txtActivo.Enabled = false;
            txtIdUsuario.Enabled = false;
            txtNumero.Focus();
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void FrmCajas_Load(object sender, EventArgs e)
        {
            ComboSucursales();
            btnNuevo.Focus();
            //Invocamos el método GridPersonas()
            GridCajas(1);
            Cargar();
        }

        private void valdacionSoloNums(object sender, KeyPressEventArgs e)
        {
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        public void Alert(string msg, FrmNotificaciones.alertTypeEnum type)
        {
            FrmNotificaciones f = new FrmNotificaciones();
            f.setAlert(msg, type);
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string qry = "";

            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");

            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);

            SqlCommand sqlCMD = new SqlCommand();

            try
            {

                qry = "SELECT * FROM cajas WHERE numero_caja= '" + txtNumero.Text + "' AND id_sucursal= '" + lblIdSucursal.Text + "'";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;

                SqlDataReader sqlDR = null;
                sqlCNX.Open();
                sqlDR = sqlCMD.ExecuteReader();
                if (sqlDR.HasRows)
                {
                    sqlCNX.Close();
                    MessageBox.Show("Ya existe una caja con ese número en esa sucursal", "SI");

                }
                else
                {
                    sqlCNX.Close();
                    //Insertamos o guardamos la persona en la BD
                    qry = "INSERT INTO cajas(numero_caja, id_sucursal, fecha_registro, hora_registro, activo, id_usuario) " +
                    "VALUES ('" + txtNumero.Text + "', '" + lblIdSucursal.Text + "', '" + lblFechaRegistro.Text + "', '" + lblHoraRegistro.Text + "', '" + txtActivo.Text + "', '" + FrmPrin.id + "')";

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

                    this.Alert("Caja Registrada", FrmNotificaciones.alertTypeEnum.Success);

                    //Invocamos al método cargar
                    Cargar();
                    //Invocamos el método cancelar
                    Cancelar();

                    GridCajas(1);
                }
            }
            catch (SqlException ex)
            {
                this.Alert("Error al agregar la caja", FrmNotificaciones.alertTypeEnum.Error);
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
                int idCaja = Int16.Parse(dgvCajas.CurrentRow.Cells["id_caja"].Value.ToString());
                qry = "SELECT * FROM cajas WHERE numero_caja = '" + txtNumero.Text + "' AND id_sucursal= '" + lblIdSucursal.Text + "' AND id_caja !=" + Convert.ToInt16(dgvCajas.CurrentRow.Cells["id_caja"].Value.ToString());
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;

                sqlCNX.Open();
                sqlDR = sqlCMD.ExecuteReader();
                if (sqlDR.HasRows)
                {
                    sqlCNX.Close();
                    MessageBox.Show("Ya existe una caja con ese número en esa sucursal", "SI");

                }
                else
                {
                    sqlCNX.Close();
                    //Insertamos o guardamos la persona en la BD
                    qry = "UPDATE cajas SET numero_caja='" + txtNumero.Text + "',  id_sucursal='" + lblIdSucursal.Text + "', fecha_registro='" + lblFechaRegistro.Text + "', hora_registro='" + lblHoraRegistro.Text + "', id_usuario='" + FrmPrin.id + "' WHERE id_caja=" + idCaja;

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

                    this.Alert("Caja Modificada", FrmNotificaciones.alertTypeEnum.Success);

                    //Invocamos al método cargar
                    Cargar();
                    //Invocamos el método cancelar
                    Cancelar();

                    GridCajas(1);
                }
            }
            catch (SqlException ex)
            {

                this.Alert("Error al Modificar la caja", FrmNotificaciones.alertTypeEnum.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Alert("Cancelado", FrmNotificaciones.alertTypeEnum.Warning);

            Cancelar();
        }

        private void RdbActivos_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void RdbInactivos_CheckedChanged(object sender, EventArgs e)
        {
        }

        int activo = 1;
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            GridCajas(activo);
        }

        private void TxtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!(txtNumero.Text == string.Empty))
                {
                    cmbSucursales.Focus();
                }
                else
                {
                    MessageBox.Show("No puedes dejar el campo vacío");
                }
            }
        }

        private void CmbSucursales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!(cmbSucursales.Text == string.Empty))
                {
                    btnGuardar.Focus();
                }
                else
                {
                    MessageBox.Show("No puedes dejar el campo vacío");
                }
            }
        }

        private void BtnModificarCaja_Click(object sender, EventArgs e)
        {
            try
            {
                txtNumero.Text = dgvCajas.CurrentRow.Cells["numero_caja"].Value.ToString();
                lblIdSucursal.Text = dgvCajas.CurrentRow.Cells["id_sucursal"].Value.ToString();
                cmbSucursales.Text = dgvCajas.CurrentRow.Cells["sucursal"].Value.ToString();
                lblFechaRegistro.Text = dgvCajas.CurrentRow.Cells["fecha_registro"].Value.ToString();
                lblHoraRegistro.Text = dgvCajas.CurrentRow.Cells["hora_registro"].Value.ToString();
                txtActivo.Text = dgvCajas.CurrentRow.Cells["activo"].Value.ToString();
                dgvCajas.Enabled = false;

                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnDesactivarCaja_Click(object sender, EventArgs e)
        {
            // Variable para guardar la consulta
            string qry = "";
            // Variable para extraer la configuracion del appconfig
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            //Variable para conectarnos a la BD
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            //Variable apra guardar el objeto o comando
            SqlCommand sqlCMD = new SqlCommand();
            //Codigo para cachar errores con el try and catch
            try
            {
                //Insertamos o guardamos la persona en la BD
                qry = "UPDATE cajas set activo='" + 0 + "' where id_caja = '" + dgvCajas.CurrentRow.Cells["id_caja"].Value.ToString() + "'";
                //Asignamos la consulta al comando
                sqlCMD.CommandText = qry;
                //Asignamos la conexion al comando
                sqlCMD.Connection = sqlCNX;
                //Abrimos la conexion
                sqlCNX.Open();
                //Ejecutamos el comando
                sqlCMD.ExecuteReader();
                //Cerramos la conexion
                sqlCNX.Close();


                Activos.Checked = false;
                GridCajas(activo);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void BtnActivarCaja_Click(object sender, EventArgs e)
        {
            // Variable para guardar la consulta
            string qry = "";
            // Variable para extraer la configuracion del appconfig
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            //Variable para conectarnos a la BD
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            //Variable apra guardar el objeto o comando
            SqlCommand sqlCMD = new SqlCommand();
            //Codigo para cachar errores con el try and catch
            try
            {
                //Insertamos o guardamos la persona en la BD
                qry = "UPDATE cajas set activo='" + 1 + "' where id_caja = '" + dgvCajas.CurrentRow.Cells["id_caja"].Value.ToString() + "'";
                //Asignamos la consulta al comando
                sqlCMD.CommandText = qry;
                //Asignamos la conexion al comando
                sqlCMD.Connection = sqlCNX;
                //Abrimos la conexion
                sqlCNX.Open();
                //Ejecutamos el comando
                sqlCMD.ExecuteReader();
                //Cerramos la conexion
                sqlCNX.Close();


                GridCajas(activo);
                Activos.Checked = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void McCajas_Opening(object sender, CancelEventArgs e)
        {


            if (dgvCajas.Rows.Count > 0 && Activos.Checked == true && dgvCajas.CurrentRow.Cells[0].Value.ToString() == txtIdUsuario.Text)
            {
                btnModificarCaja.Visible = true;
                btnActivarCaja.Visible = false;
                btnDesactivarCaja.Visible = false;
            }
            else if (dgvCajas.Rows.Count > 0 && Activos.Checked == true && dgvCajas.CurrentRow.Cells[0].Value.ToString() != txtIdUsuario.Text)
            {
                btnModificarCaja.Visible = true;
                btnActivarCaja.Visible = false;
                btnDesactivarCaja.Visible = true;
            }
            else if (dgvCajas.Rows.Count > 0 && Activos.Checked == false)
            {
                btnModificarCaja.Visible = false;
                btnActivarCaja.Visible = true;
                btnDesactivarCaja.Visible = false;
            }
            else if (dgvCajas.Rows.Count <= 0 && Activos.Checked == false)
            {
                btnModificarCaja.Visible = false;
                btnActivarCaja.Visible = false;
                btnDesactivarCaja.Visible = false;
            }
        }

        private void CmbSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIdSucursal.Text = cmbSucursales.SelectedValue.ToString();
        }

        private void txtNumero_Enter(object sender, EventArgs e)
        {
            focusnum.LineColor = Color.FromArgb(100, 88, 255);
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            focusnum.LineColor = Color.White;

        }
        private void focusnum_Enter(object sender, EventArgs e)
        {
            txtNumero.Focus();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            focusBuscar.LineColor = Color.FromArgb(100, 88, 255);
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            focusnum.LineColor = Color.White;

        }

        private void focusBuscar_Enter(object sender, EventArgs e)
        {
            txtBuscar.Focus();
        }

        private void Activos_CheckedChanged(object sender, EventArgs e)
        {
            if (Activos.Checked == true)
            {

                activo = 1;
                GridCajas(activo);
                lblActi.Text = "Activos";
            }
            else if (Activos.Checked == false)
            {
                activo = 0;
                GridCajas(activo);
                lblActi.Text = "Inactivos";
            }
        }
    }
}
