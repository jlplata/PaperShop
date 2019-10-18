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
    public partial class frmTrabajadores : Form
    {
        public frmTrabajadores()
        {
            InitializeComponent();
        }

        void Cargar()
        {
            grbTrabajadores.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            btnNuevo.Focus();
            Activos.Checked = true;


            //Asignamos la fecha y hora a los lbls correspondientes
            DateTime hoy = DateTime.Now;
            lblFechaRegistro.Text = hoy.ToString("yyyyMMdd");
            lblHoraRegistro.Text = hoy.ToShortTimeString();

        }
        //Método para llenar el cmbPersonas
        void ComboPersonas()
        {
            string qry;
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            SqlCommand sqlCMD = new SqlCommand();
            try
            {
                qry = "SELECT id_persona, CONCAT(nombre, ' ', apepaterno, ' ', apematerno) as persona FROM personas WHERE activo=1";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;
                sqlCNX.Open();

                SqlDataAdapter adaptador = new SqlDataAdapter(sqlCMD);
                DataTable datos = new DataTable();
                adaptador.Fill(datos);

                sqlCNX.Close();
                cmbPersonas.DataSource = datos;
                cmbPersonas.ValueMember = "id_persona";
                cmbPersonas.DisplayMember = "persona";

                //Variable para usar en autocompletar
                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

                foreach (DataRow row in datos.Rows)
                {
                    coleccion.Add(Convert.ToString(row["persona"]));
                }
                //Configuración final para el autocompletado del nombre de la categoría
                cmbPersonas.AutoCompleteCustomSource = coleccion;
                cmbPersonas.AutoCompleteSource = AutoCompleteSource.CustomSource;

            }
            catch (SqlException ex)
            {

                MessageBox.Show("Error al llenar el combo personas. " + ex.Message.ToString(), "SI");
            }
        }

        void ComboPuestos()
        {
            string qry;
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            SqlCommand sqlCMD = new SqlCommand();
            try
            {
                qry = "SELECT id_puesto, puesto FROM puestos WHERE activo=1";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;
                sqlCNX.Open();

                SqlDataAdapter adaptador = new SqlDataAdapter(sqlCMD);
                DataTable datos = new DataTable();
                adaptador.Fill(datos);

                sqlCNX.Close();
                cmbPuestos.DataSource = datos;
                cmbPuestos.ValueMember = "id_puesto";
                cmbPuestos.DisplayMember = "puesto";

                //Variable para usar en autocompletar
                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

                foreach (DataRow row in datos.Rows)
                {
                    coleccion.Add(Convert.ToString(row["puesto"]));
                }
                //Configuración final para el autocompletado del nombre de la categoría
                cmbPuestos.AutoCompleteCustomSource = coleccion;
                cmbPuestos.AutoCompleteSource = AutoCompleteSource.CustomSource;

            }
            catch (SqlException ex)
            {

                MessageBox.Show("Error al llenar el combo puestos. " + ex.Message.ToString(), "SI");
            }
        }

        void ComboDepartamentos()
        {
            string qry;
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            SqlCommand sqlCMD = new SqlCommand();
            try
            {
                qry = "SELECT id_departamento, nombre_departamento as departamento FROM departamentos WHERE activo=1";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;
                sqlCNX.Open();

                SqlDataAdapter adaptador = new SqlDataAdapter(sqlCMD);
                DataTable datos = new DataTable();
                adaptador.Fill(datos);

                sqlCNX.Close();
                cmbDepartamentos.DataSource = datos;
                cmbDepartamentos.ValueMember = "id_departamento";
                cmbDepartamentos.DisplayMember = "departamento";

                //Variable para usar en autocompletar
                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

                foreach (DataRow row in datos.Rows)
                {
                    coleccion.Add(Convert.ToString(row["departamento"]));
                }
                //Configuración final para el autocompletado del nombre de la categoría
                cmbDepartamentos.AutoCompleteCustomSource = coleccion;
                cmbDepartamentos.AutoCompleteSource = AutoCompleteSource.CustomSource;

            }
            catch (SqlException ex)
            {

                MessageBox.Show("Error al llenar el combo departamentos. " + ex.Message.ToString(), "SI");
            }
        }

        void GridTrabajadores(int activo)
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
                //Consulta parar extraer los datos de las personas
                qry = "SELECT * FROM VistaTrabajadores WHERE (Nombre like '%" + txtBuscar.Text + "%' OR puesto like '%" + txtBuscar.Text + "%' OR departamento like '%" + txtBuscar.Text + "%') AND activo='" + activo + "'";

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
                dgvTrabajadores.DataSource = datos;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al llenar el dgvTrabajadores! " + ex.Message.ToString(), "SI");
            }
        }

        void Nuevo()
        {
            grbTrabajadores.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            txtActivo.Text = "1";
            cmbPersonas.Focus();
            txtIdUsuario.Text=FrmPrin.id;

            //Asignamos la fecha y hora a los lbls correspondientes
            DateTime hoy = DateTime.Now;
            lblFechaRegistro.Text = hoy.ToString("yyyyMMdd");
            lblHoraRegistro.Text = hoy.ToShortTimeString();
        }

        void Cancelar()
        {
            Cargar();
            cmbPersonas.SelectedIndex = 0;
            txtNumEmpleado.Clear();
            cmbPuestos.SelectedIndex = 0;
            cmbDepartamentos.SelectedIndex = 0;
            cmbTurnos.SelectedIndex = 0;
            dgvTrabajadores.Enabled = true;
            txtIdUsuario.Text = "";
            lblFechaRegistro.Text = "Fecha_Registro";
            lblHoraRegistro.Text = "Hora_Registro";
        }

        void Actualizar()
        {
            grbTrabajadores.Enabled = true;
            cmbPersonas.Enabled = false;
            txtActivo.Enabled = false;
            txtIdUsuario.Enabled = false;
            cmbPersonas.Focus();
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void FrmTrabajadores_Load(object sender, EventArgs e)
        {
            Cargar();
            ComboPersonas();
            ComboPuestos();
            ComboDepartamentos();
            btnNuevo.Focus();
            GridTrabajadores(1);
        }

        private void CmbPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIdPersona.Text = cmbPersonas.SelectedValue.ToString();
        }

        private void CmbPuestos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIdPuesto.Text = cmbPuestos.SelectedValue.ToString();
        }

        private void CmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIdDepartamento.Text = cmbDepartamentos.SelectedValue.ToString();
        }
        private void valdacionSoloNums(object sender, KeyPressEventArgs e)
        {
            validacion.solonumeros(e);
        }

        private void CmbPersonas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!(cmbPersonas.Text == string.Empty))
                {
                    txtNumEmpleado.Focus();
                }
                else
                {
                    MessageBox.Show("No puedes dejar el campo vacío");
                }
            }
        }

        private void TxtNumEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!(txtNumEmpleado.Text == string.Empty))
                {
                    cmbPuestos.Focus();
                }
                else
                {
                    MessageBox.Show("No puedes dejar el campo vacío");
                }
            }
        }

        private void CmbPuestos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!(cmbPuestos.Text == string.Empty))
                {
                    cmbDepartamentos.Focus();
                }
                else
                {
                    MessageBox.Show("No puedes dejar el campo vacío");
                }
            }
        }

        private void CmbDepartamentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!(cmbDepartamentos.Text == string.Empty))
                {
                    cmbTurnos.Focus();
                }
                else
                {
                    MessageBox.Show("No puedes dejar el campo vacío");
                }
            }
        }

        private void CmbTurnos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!(cmbTurnos.Text == string.Empty))
                {
                    btnGuardar.Focus();
                }
                else
                {
                    MessageBox.Show("No puedes dejar el campo vacío");
                }
            }
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

                qry = "SELECT * FROM trabajadores WHERE numero_empleado = '" + txtNumEmpleado.Text + "'";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;

                SqlDataReader sqlDR = null;
                sqlCNX.Open();
                sqlDR = sqlCMD.ExecuteReader();
                if (sqlDR.HasRows)
                {
                    sqlCNX.Close();
                    MessageBox.Show("Ya hay una persona con ese número de empleado", "SI");

                }
                else
                {
                    sqlCNX.Close();
                    //Insertamos o guardamos la persona en la BD
                    qry = "INSERT INTO trabajadores(id_persona, numero_empleado, id_puesto, id_departamento, turno, fecha_registro, hora_registro, activo, id_usuario) " +
                    "VALUES ('" + lblIdPersona.Text + "', '" + txtNumEmpleado.Text + "', '" + lblIdPuesto.Text + "', '" + lblIdDepartamento.Text + "', '" + cmbTurnos.Text + "', '" + lblFechaRegistro.Text + "', '" + lblHoraRegistro.Text + "', '" + txtActivo.Text + "', '" + FrmPrin.id + "')";

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

                    MessageBox.Show("Trabajador registrado!", "SI");

                    //Invocamos al método cargar
                    Cargar();
                    //Invocamos el método cancelar
                    Cancelar();

                    GridTrabajadores(1);
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Error al agregar el trabajador. " + ex.Message.ToString(), "SI");
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
                qry = "SELECT * FROM trabajadores WHERE numero_empleado = '" + txtNumEmpleado.Text + "' AND id_trabajador !=" + Convert.ToInt16(dgvTrabajadores.CurrentRow.Cells["id_trabajador"].Value.ToString()) + "";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;

                sqlCNX.Open();
                sqlDR = sqlCMD.ExecuteReader();
                if (sqlDR.HasRows)
                {
                    sqlCNX.Close();
                    MessageBox.Show("Ya existe una persona con ese número de empleado. ", "SI");
                    txtNumEmpleado.Clear();
                    txtNumEmpleado.Focus();

                }
                else
                {
                    sqlCNX.Close();
                    //Insertamos o guardamos la persona en la BD
                    qry = "UPDATE trabajadores SET id_persona='" + lblIdPersona.Text + "', numero_empleado='" + txtNumEmpleado.Text + "', id_puesto='" + lblIdPuesto.Text + "', id_departamento='" + lblIdDepartamento.Text + "', turno='" + cmbTurnos.Text + "', activo='" + txtActivo.Text + "', id_usuario='" + FrmPrin.id + "' WHERE id_trabajador='" + dgvTrabajadores.CurrentRow.Cells["id_trabajador"].Value.ToString() + "'";

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

                    MessageBox.Show("Trabajador modificado!", "SI");

                    //Invocamos al método cargar
                    Cargar();
                    //Invocamos el método cancelar
                    Cancelar();

                    GridTrabajadores(1);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al modificar al trabajador! " + ex.Message.ToString(), "SI");
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        int activo = 1;
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            GridTrabajadores(activo);
        }

        private void RdbActivos_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RdbInactivos_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void McTrabajadores_Opening(object sender, CancelEventArgs e)
        {
            if (dgvTrabajadores.Rows.Count > 0 && Activos.Checked == true && dgvTrabajadores.CurrentRow.Cells[0].Value.ToString() == txtIdUsuario.Text)
            {
                btnModificarTrabajador.Visible = true;
                btnActivarTrabajador.Visible = false;
                btnDesactivarTrabajador.Visible = false;
            }
            else if (dgvTrabajadores.Rows.Count > 0 && Activos.Checked == true && dgvTrabajadores.CurrentRow.Cells[0].Value.ToString() != txtIdUsuario.Text)
            {
                btnModificarTrabajador.Visible = true;
                btnActivarTrabajador.Visible = false;
                btnDesactivarTrabajador.Visible = true;
            }
            else if (dgvTrabajadores.Rows.Count > 0 && Activos.Checked == false)
            {
                btnModificarTrabajador.Visible = false;
                btnActivarTrabajador.Visible = true;
                btnDesactivarTrabajador.Visible = false;
            }
            else if (dgvTrabajadores.Rows.Count <= 0 && Activos.Checked == false)
            {
                btnModificarTrabajador.Visible = false;
                btnActivarTrabajador.Visible = false;
                btnDesactivarTrabajador.Visible = false;
            }
        }

        private void BtnModificarTrabajador_Click(object sender, EventArgs e)
        {
            try
            {
                cmbPersonas.Text = dgvTrabajadores.CurrentRow.Cells["Nombre"].Value.ToString();
                txtNumEmpleado.Text = dgvTrabajadores.CurrentRow.Cells["numero_empleado"].Value.ToString();
                cmbPuestos.Text = dgvTrabajadores.CurrentRow.Cells["puesto"].Value.ToString();
                cmbDepartamentos.Text = dgvTrabajadores.CurrentRow.Cells["departamento"].Value.ToString();
                cmbTurnos.Text = dgvTrabajadores.CurrentRow.Cells["turno"].Value.ToString();
                txtActivo.Text = dgvTrabajadores.CurrentRow.Cells["activo"].Value.ToString();
                txtIdUsuario.Text = FrmPrin.id;
                dgvTrabajadores.Enabled = false;
                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnDesactivarTrabajador_Click(object sender, EventArgs e)
        {
            string idtrabajador = dgvTrabajadores.CurrentRow.Cells["id_trabajador"].Value.ToString();
            //Consulta
            string qry;
            //Extrae la configuración del appconfig
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");

            //Conecta a la BD
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            //Guarda el objeto o comando
            SqlCommand sqlCMD = new SqlCommand();
            //Insertamos o guardamos la persona en la BD
            qry = "UPDATE trabajadores SET activo=0 WHERE id_trabajador=" + idtrabajador;

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
                GridTrabajadores(activo);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void BtnActivarTrabajador_Click(object sender, EventArgs e)
        {
            string idtrabajador = dgvTrabajadores.CurrentRow.Cells["id_trabajador"].Value.ToString();
            //Consulta
            string qry;
            //Extrae la configuración del appconfig
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");

            //Conecta a la BD
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            //Guarda el objeto o comando
            SqlCommand sqlCMD = new SqlCommand();
            //Insertamos o guardamos la persona en la BD
            qry = "UPDATE trabajadores SET activo=1 WHERE id_trabajador=" + idtrabajador;

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

                GridTrabajadores(activo);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Activos_CheckedChanged(object sender, EventArgs e)
        {

            if (Activos.Checked == true)
            {

                activo = 1;
                GridTrabajadores(activo);
                lblActi.Text = "Activos";
            }
            else if (Activos.Checked == false)
            {
                activo = 0;
                GridTrabajadores(activo);
                lblActi.Text = "Inactivos";
            }
        }

        private void txtNumEmpleado_Enter(object sender, EventArgs e)
        {
            focusnum.LineColor = Color.FromArgb(100, 88, 255);

        }

        private void txtNumEmpleado_Leave(object sender, EventArgs e)
        {
            focusnum.LineColor = Color.White;
        }

        private void gunaLineTextBox1_Enter(object sender, EventArgs e)
        {
            txtNumEmpleado.Focus();
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
    }
}
