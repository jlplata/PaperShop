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
    public partial class frmDepartamentos : Form
    {
        public frmDepartamentos()
        {
            InitializeComponent();
        }

        void Cargar()
        {
            grbDepartamentos.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            btnNuevo.Focus();
            Activos.Checked = true;
            Nuevo();

        }

        void GridDepartamentos(int activo)
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
                qry = "SELECT * FROM VistaDepartamentos where (nombre_departamento like '%" + txtBuscar.Text + "%' OR extension like '%" + txtBuscar.Text + "%') AND activo='" + activo + "'";
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

                //Asignamos los datos al dgvDepartamentos
                dgvDepartamentos.DataSource = datos;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al llenar el dgvDepartamentos! " + ex.Message.ToString(), "SI");
            }
        }

        void Nuevo()
        {
            grbDepartamentos.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            txtActivo.Text = "1";
            txtNombre.Focus();


            //asignamos la fecha y hora a los lbls corresponientes
            DateTime hoy = DateTime.Now;
            lblFechaRegistro.Text = hoy.ToString("yyyyMMdd");
            lblHoraRegistro.Text = hoy.ToShortTimeString();
            //En caso de marcar error en la fecha
            //lblfecharegistro.text = hoy.ToString("yyyyMMdd");
        }

        void Cancelar()
        {
            Cargar();
            txtNombre.Clear();
            txtExtension.Clear();
            txtIdUsuario.Text = "";
            dgvDepartamentos.Enabled = true;
        }

        void Actualizar()
        {
            grbDepartamentos.Enabled = true;
            txtActivo.Enabled = false;
            txtIdUsuario.Enabled = false;
            txtNombre.Focus();
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void FrmDepartamentos_Load(object sender, EventArgs e)
        {
            btnNuevo.Focus();
            txtIdUsuario.Text = FrmPrin.id;
            //Invocamos el método GridPersonas()        
            Cargar();

            GridDepartamentos(1);
        }

        validacion v = new validacion();

        private void valdacionLetras(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void valdacionNum(object sender, KeyPressEventArgs e)
        {
            validacion.solonumeros(e);
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

                qry = "SELECT * FROM departamentos WHERE nombre_departamento= '" + txtNombre.Text + "' OR extension= '" + txtNombre.Text + "'";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;

                SqlDataReader sqlDR = null;
                sqlCNX.Open();
                sqlDR = sqlCMD.ExecuteReader();
                if (sqlDR.HasRows)
                {
                    sqlCNX.Close();
                    MessageBox.Show("Ya existe ese departamento o extensión", "SI");

                }
                else
                {
                    sqlCNX.Close();
                    //Insertamos o guardamos la persona en la BD
                    qry = "INSERT INTO departamentos(nombre_departamento, extension, fecha_registro, hora_registro, activo, id_usuario) " +
                    "VALUES ('" + txtNombre.Text + "', '" + txtExtension.Text + "', '" + lblFechaRegistro.Text + "', '" + lblHoraRegistro.Text + "', '" + txtActivo.Text + "', '" + FrmPrin.id + "')";

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
                    this.Alert("Registrado", FrmNotificaciones.alertTypeEnum.Success);

                    //Invocamos al método cargar
                    Cargar();
                    //Invocamos el método cancelar
                    Cancelar();

                    GridDepartamentos(1);
                }
            }
            catch (SqlException ex)
            {

                this.Alert("Error al registrar!", FrmNotificaciones.alertTypeEnum.Error);
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
                int idDepartamento = Convert.ToInt16(dgvDepartamentos.CurrentRow.Cells["id_departamento"].Value.ToString());
                qry = "SELECT * FROM departamentos WHERE nombre_departamento= '" + txtNombre.Text + "' OR extension= '" + txtNombre.Text + "'";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;

                sqlCNX.Open();
                sqlDR = sqlCMD.ExecuteReader();
                if (sqlDR.HasRows)
                {
                    sqlCNX.Close();
                    MessageBox.Show("Ya existe ese departamento o extensión", "SI");

                }
                else
                {
                    sqlCNX.Close();
                    //Insertamos o guardamos la persona en la BD
                    qry = "UPDATE departamentos SET nombre_departamento='" + txtNombre.Text + "', extension='" + txtExtension.Text + "', fecha_registro='" + lblFechaRegistro.Text + "', hora_registro='" + lblHoraRegistro.Text + "', id_usuario='" + FrmPrin.id + "' WHERE id_departamento=" + idDepartamento;

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
                    this.Alert("Modificado", FrmNotificaciones.alertTypeEnum.Success);


                    //Invocamos al método cargar
                    Cargar();
                    //Invocamos el método cancelar
                    Cancelar();

                    GridDepartamentos(1);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SI");

                this.Alert("Error al Modificar", FrmNotificaciones.alertTypeEnum.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
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
            GridDepartamentos(activo);
        }

        private void TxtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!(txtNombre.Text == string.Empty))
                {
                    txtExtension.Focus();
                }
                else
                {
                    MessageBox.Show("No puedes dejar el campo vacío");
                }
            }
        }

        private void TxtExtension_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!(txtExtension.Text == string.Empty))
                {
                    btnGuardar.Focus();
                }
                else
                {
                    MessageBox.Show("No puedes dejar el campo vacío");
                }
            }
        }

        private void BtnModificarPuesto_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombre.Text = dgvDepartamentos.CurrentRow.Cells["nombre_departamento"].Value.ToString();
                txtExtension.Text = dgvDepartamentos.CurrentRow.Cells["extension"].Value.ToString();
                lblFechaRegistro.Text = dgvDepartamentos.CurrentRow.Cells["fecha_registro"].Value.ToString();
                lblHoraRegistro.Text = dgvDepartamentos.CurrentRow.Cells["hora_registro"].Value.ToString();
                txtActivo.Text = dgvDepartamentos.CurrentRow.Cells["activo"].Value.ToString();
                dgvDepartamentos.Enabled = false;

                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnDesactivarPuesto_Click(object sender, EventArgs e)
        {
            string idepartamento = dgvDepartamentos.CurrentRow.Cells["id_departamento"].Value.ToString();
            //Consulta
            string qry;
            //Extrae la configuración del appconfig
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");

            //Conecta a la BD
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            //Guarda el objeto o comando
            SqlCommand sqlCMD = new SqlCommand();
            //Insertamos o guardamos la persona en la BD
            qry = "UPDATE departamentos SET activo=0 WHERE id_departamento=" + idepartamento;

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
                GridDepartamentos(activo);
                this.Alert("Activado", FrmNotificaciones.alertTypeEnum.Success);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void BtnActivarPuesto_Click(object sender, EventArgs e)
        {
            string idepartamento = dgvDepartamentos.CurrentRow.Cells["id_departamento"].Value.ToString();
            //Consulta
            string qry;
            //Extrae la configuración del appconfig
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");

            //Conecta a la BD
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            //Guarda el objeto o comando
            SqlCommand sqlCMD = new SqlCommand();
            //Insertamos o guardamos la persona en la BD
            qry = "UPDATE departamentos SET activo=1 WHERE id_departamento=" + idepartamento;

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

                GridDepartamentos(activo);
                this.Alert("Desactivado", FrmNotificaciones.alertTypeEnum.Warning);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void McDepartamentos_Opening(object sender, CancelEventArgs e)
        {
            if (dgvDepartamentos.Rows.Count > 0 && Activos.Checked)
            {

                btnModificarPuesto.Visible = true;
                btnDesactivarPuesto.Visible = true;
                btnActivarPuesto.Visible = false;

            }
            else if (dgvDepartamentos.Rows.Count <= 0 && Activos.Checked)
            {
                btnModificarPuesto.Visible = false;
                btnDesactivarPuesto.Visible = false;
                btnActivarPuesto.Visible = false;
            }
            else if (dgvDepartamentos.Rows.Count > 0 && Activos.Checked)
            {
                btnModificarPuesto.Visible = false;
                btnDesactivarPuesto.Visible = false;
                btnActivarPuesto.Visible = true;
            }
            else if (dgvDepartamentos.Rows.Count <= 0 && Activos.Checked)
            {
                btnModificarPuesto.Visible = false;
                btnDesactivarPuesto.Visible = false;
                btnActivarPuesto.Visible = false;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            FocusNombre.LineColor = Color.FromArgb(67, 83, 192);
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            FocusNombre.LineColor = Color.White;
        }

        private void FocusNombre_Enter(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void txtExtension_Enter(object sender, EventArgs e)
        {
            focusext.LineColor = Color.FromArgb(67, 83, 192);
        }

        private void txtExtension_Leave(object sender, EventArgs e)
        {
            focusext.LineColor = Color.White;
        }

        private void gunaLineTextBox1_Enter(object sender, EventArgs e)
        {
            txtExtension.Focus();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            focusbuscar.LineColor = Color.FromArgb(67, 83, 192);

        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            focusbuscar.LineColor = Color.White;

        }

        private void gunaLineTextBox1_Enter_1(object sender, EventArgs e)
        {
            txtBuscar.Focus();
        }

        private void Activos_CheckedChanged(object sender, EventArgs e)
        {
            if (Activos.Checked == true)
            {

                activo = 1;
                GridDepartamentos(activo);
                lblActi.Text = "Activos";
            }
            else if (Activos.Checked == false)
            {
                activo = 0;
                GridDepartamentos(activo);
                lblActi.Text = "Inactivos";
            }
        }
    }
}
