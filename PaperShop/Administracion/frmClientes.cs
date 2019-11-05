using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Configuration;
using System.Data.SqlClient;

namespace PaperShop
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
            txtIdUsuario.Text = FrmPrin.id;
        }
        validacion v = new validacion();
        void ComboPersonas()
        {
            // Variable para guardar la consulta
            string qry = "";
            // Variable para extraer la configuracion del appconfig
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            //Variable para conectarnos a la BD
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            //Variable apra guardar el objeto o comando
            SqlCommand sqlCMD = new SqlCommand();
            try
            {
                qry = "Select id_persona, CONCAT(nombre, ' ', apepaterno, ' ', apematerno) as persona from personas where activo=1";
                //Asignamos la consulta al comando
                sqlCMD.CommandText = qry;
                //Asignamos la conexion al comando
                sqlCMD.Connection = sqlCNX;
                //Abrimos la conexion
                sqlCNX.Open();
                //Variable para el adaptador
                SqlDataAdapter adaptador = new SqlDataAdapter(sqlCMD);
                //Variable para crear la tabla
                DataTable datos = new DataTable();
                //Llenamos la tabla
                adaptador.Fill(datos);
                //Cerramos la conexion
                sqlCNX.Close();
                cmbpersonas.DataSource = datos;
                cmbpersonas.ValueMember = "id_persona";
                cmbpersonas.DisplayMember = "persona";
                //Variable para usar en autocompletar
                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                foreach (DataRow row in datos.Rows)
                {
                    coleccion.Add(Convert.ToString(row["persona"]));
                }
                cmbpersonas.AutoCompleteCustomSource = coleccion;
                cmbpersonas.AutoCompleteSource = AutoCompleteSource.CustomSource;


            }
            catch (SqlException ex)
            {
                this.Alert("Error al agergar Personas!", FrmNotificaciones.alertTypeEnum.Success);


            }
        }

        private void valdacionLetras(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void valdacionNumsLetras(object sender, KeyPressEventArgs e)
        {
            validacion.numsLetras(e);
        }
        void GridClientes(int activo)
        {
            // Variable para guardar la consulta
            string qry = "";
            // Variable para extraer la configuracion del appconfig
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            //Variable para conectarnos a la BD
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            //Variable apra guardar el objeto o comando
            SqlCommand sqlCMD = new SqlCommand();
            try
            {
                if (Activos.Checked == true)
                {
                    //Consulta para extraer los datos de las personas
                    qry = "Select * From VistaClientes where Nombre like '%" + txtBuscar.Text + "%' and VistaClientes.activo = '"+activo+"'";
                }
                else
                {
                    //Consulta para extraer los datos de las personas
                    qry = "Select * From VistaClientes where Nombre like '%" + txtBuscar.Text + "%' and VistaClientes.activo =  '" + activo + "'";
                }
                //Asignamos la consulta al comando
                sqlCMD.CommandText = qry;
                //Asignamos la conexion al comando
                sqlCMD.Connection = sqlCNX;
                //Abrimos la conexion
                sqlCNX.Open();
                //Variable para el adaptador
                SqlDataAdapter adaptador = new SqlDataAdapter(sqlCMD);
                //Variable para crear la tabla
                DataTable datos = new DataTable();
                //Llenamos la tabla
                adaptador.Fill(datos);
                //Cerramos la conexion
                sqlCNX.Close();

                //Asignamos los datos al dgvpersonas
                dgvclientes.DataSource = datos;

            }
            catch (SqlException ex)
            {
                this.Alert("Error al agregar Clientes!", FrmNotificaciones.alertTypeEnum.Success);

            }
        }
        void Actualizar()
        {
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = true;
            btnGuardar.Enabled = false;
            grbclientes.Enabled = true;
        }
        void Cargar()
        {
            grbclientes.Enabled = false;
            btnCancelar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            btnNuevo.Focus();
            Activos.Checked = true;
            txtActivo.Text = "1";
            //asignamos la fecha y hora a los lbls corresponientes
            DateTime hoy = DateTime.Now;
            lblfecharegistro.Text = hoy.ToString("yyyyMMdd");
            lblhoraregistro.Text = hoy.ToShortTimeString();
            //En caso de marcar error en la fecha
            //lblfecharegistro.text = hoy.ToString("yyyyMMdd");

        }
        void Nuevo()
        {
            grbclientes.Enabled = true;
            btnCancelar.Enabled = true;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
            cmbpersonas.Focus();
            Activos.Checked = true;
            txtActivo.Text = "1";
        }
        void Cancelar()
        {
            Cargar();
            cmbpersonas.SelectedIndex = 0;
            txtnumerocliente.Clear();
            cmbpersonas.SelectedIndex = 0;
            dgvclientes.Enabled = true;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ComboPersonas();
            GridClientes(1);
            Cargar();
            txtActivo.Text = "1";
        }

        private void Cmbpersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblid_persona.Text = cmbpersonas.SelectedValue.ToString();
        }

        private void Btnnuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }
        public void Alert(string msg, FrmNotificaciones.alertTypeEnum type)
        {
            FrmNotificaciones f = new FrmNotificaciones();
            f.setAlert(msg, type);
        }
        private void Btnguardar_Click(object sender, EventArgs e)
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
                //Validamos por el correo que no se repita la persona
                qry = "SELECT id_persona, numero_cliente from clientes where numero_cliente = '" + txtnumerocliente.Text + "' or id_persona ='"+lblid_persona.Text+"'";
                //Asignamos la consulta al comando
                sqlCMD.CommandText = qry;
                //Asignamos la conexion al comando
                sqlCMD.Connection = sqlCNX;
                //Variable para leer datos del ripo sql
                SqlDataReader sqlDR = null;
                //Abrimos la conexion
                sqlCNX.Open();
                //Asignamos ejecutado el comando al sqlDR
                sqlDR = sqlCMD.ExecuteReader();
                //Comparamos si el sqlDR tiene datos
                if (sqlDR.HasRows == true)
                {
                    MessageBox.Show("Ya hay un cliente con ese numero!", "SI");
                    txtnumerocliente.Clear();
                    txtnumerocliente.Focus();
                    //Cerramos la conexion
                    sqlCNX.Close();
                }
                else
                {
                    //Volvemos a cerrar la conexion
                    sqlCNX.Close();
                    //Insertamos o guardamos el cliente en la BD
                    qry = "INSERT INTO clientes(id_persona, numero_cliente, fecha_registro, hora_registro, activo, id_usuario) " +
                    "VALUES('" + lblid_persona.Text + "', '" + txtnumerocliente.Text + "', '" + lblfecharegistro.Text + "', '" + lblhoraregistro.Text + "', '" + txtActivo.Text + "', '" + txtIdUsuario.Text + "')";                   
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

                    this.Alert("Cliente Registrado", FrmNotificaciones.alertTypeEnum.Success);

                    //Invocamos el metodo cancelar
                    GridClientes(1);
                    this.Cancelar();
                }
            }
            catch (SqlException ex)
            {
                this.Alert("Error al registrar!", FrmNotificaciones.alertTypeEnum.Error);
            }
            //Fin del codigo guardar
        }

        private void Btnmodificar_Click(object sender, EventArgs e)
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
                //Validamos por el correo que no se repita la persona
                qry = "SELECT numero_cliente from clientes where numero_cliente = '" + txtnumerocliente.Text + "' and id_persona != " + Convert.ToInt16(lblid_persona.Text) + "";
                //Asignamos la consulta al comando
                sqlCMD.CommandText = qry;
                //Asignamos la conexion al comando
                sqlCMD.Connection = sqlCNX;
                //Variable para leer datos del ripo sql
                SqlDataReader sqlDR = null;
                //Abrimos la conexion
                sqlCNX.Open();
                //Asignamos ejecutado el comando al sqlDR
                sqlDR = sqlCMD.ExecuteReader();
                //Comparamos si el sqlDR tiene datos
                if (sqlDR.HasRows == true)
                {
                    MessageBox.Show("Ya hay un cliente con ese numero!", "SI");
                    txtnumerocliente.Clear();
                    txtnumerocliente.Focus();
                    //Cerramos la conexion
                    sqlCNX.Close();
                }
                else
                {
                    //Volvemos a cerrar la conexion
                    sqlCNX.Close();
                    //Insertamos o guardamos la persona en la BD
                    //Variable para el cliente
                    
                    qry = "UPDATE clientes set id_persona='" + lblid_persona.Text + "', numero_cliente='" + txtnumerocliente.Text + "', fecha_registro='" + lblfecharegistro.Text + "', hora_registro='" + lblhoraregistro.Text + "', activo='" + txtActivo.Text + "', id_usuario='" + txtIdUsuario.Text + "' where id_cliente = " + Convert.ToInt16(dgvclientes.CurrentRow.Cells["id_cliente"].Value.ToString()) + "";
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
                    this.Alert("Cliente Actualizado!", FrmNotificaciones.alertTypeEnum.Success);

                    //Invocamos el metodo cancelar
                    cmbpersonas.Enabled = true;
                    GridClientes(1);
                    this.Cancelar();
                }
            }
            catch (SqlException ex)
            {
                this.Alert("Error al actualizar cliente!", FrmNotificaciones.alertTypeEnum.Error);
            }
            //Fin del codigo guardar
        }

        private void CmClientes_Opening(object sender, CancelEventArgs e)
        {
            if (dgvclientes.Rows.Count > 0 && Activos.Checked == true && dgvclientes.CurrentRow.Cells[0].Value.ToString() == txtIdUsuario.Text)
            {
                modificarToolStripMenuItem.Visible = true;
                activarToolStripMenuItem.Visible = false;
                desactivarToolStripMenuItem.Visible = false;
            }
            else if (dgvclientes.Rows.Count > 0 && Activos.Checked == true && dgvclientes.CurrentRow.Cells[0].Value.ToString() != txtIdUsuario.Text)
            {
                modificarToolStripMenuItem.Visible = true;
                activarToolStripMenuItem.Visible = false;
                desactivarToolStripMenuItem.Visible = true;
            }
            else if (dgvclientes.Rows.Count > 0 && Activos.Checked == false)
            {
                modificarToolStripMenuItem.Visible = false;
                activarToolStripMenuItem.Visible = true;
                desactivarToolStripMenuItem.Visible = false;
            }
            else if (dgvclientes.Rows.Count <= 0 && Activos.Checked == false)
            {
                modificarToolStripMenuItem.Visible = false;
                activarToolStripMenuItem.Visible = false;
                desactivarToolStripMenuItem.Visible = false;
            }
        }

        private void ModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbpersonas.Text = dgvclientes.CurrentRow.Cells["Nombre"].Value.ToString();
            txtnumerocliente.Text = dgvclientes.CurrentRow.Cells["numero_cliente"].Value.ToString();
            txtActivo.Text = dgvclientes.CurrentRow.Cells["activo"].Value.ToString();
            cmbpersonas.Enabled = false;
            dgvclientes.Enabled = false;
            this.Actualizar();
        }

        private void DesactivarToolStripMenuItem_Click(object sender, EventArgs e)
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
                qry = "UPDATE clientes set activo='0' where id_cliente = '" + dgvclientes.CurrentRow.Cells["id_cliente"].Value.ToString() + "'";
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
                this.Alert("Cliente deesactivado!", FrmNotificaciones.alertTypeEnum.Success);
                //Invocamos el metodo cancelar

                this.GridClientes(0);
                Activos.Checked = false;
            }
            catch (SqlException ex)
            {
                this.Alert("Error al modificar!", FrmNotificaciones.alertTypeEnum.Error);
            }
        }
        int activo = 1;
        private void Rdbinactivo_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Rdbactivo_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.GridClientes(activo);
        }

        private void ActivarToolStripMenuItem_Click(object sender, EventArgs e)
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
                qry = "UPDATE clientes set activo='1' where id_cliente = '" + dgvclientes.CurrentRow.Cells["id_cliente"].Value.ToString() + "'";
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
                this.Alert("Persona activada!", FrmNotificaciones.alertTypeEnum.Success);
                //Invocamos el metodo cancelar

                this.GridClientes(1);
                Activos.Checked = true;
            }
            catch (SqlException ex)
            {
                this.Alert("Error al modificacion!", FrmNotificaciones.alertTypeEnum.Error);
            }
        }

        private void Btnimprimir_Click(object sender, EventArgs e)
        {
            //// Variable para guardar la consulta
            //string qry = "";
            //// Variable para extraer la configuracion del appconfig
            //string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            ////Variable para conectarnos a la BD
            //SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            ////Variable apra guardar el objeto o comando
            //SqlCommand sqlCMD = new SqlCommand();
            //try
            //{
            //    if (rdbactivo.Checked == true)
            //    {
            //        //Consulta para extraer los datos de las personas
            //        qry = "Select * From VistaClientes where persona like '%" + txtbuscar.Text + "%' and VistaClientes.activo = 1";
            //    }
            //    else
            //    {
            //        //Consulta para extraer los datos de las personas
            //        qry = "Select * From VistaClientes where persona like '%" + txtbuscar.Text + "%' and VistaClientes.activo = 0";
            //    }
            //    //Asignamos la consulta al comando
            //    sqlCMD.CommandText = qry;
            //    //Asignamos la conexion al comando
            //    sqlCMD.Connection = sqlCNX;
            //    //Abrimos la conexion
            //    sqlCNX.Open();
            //    //Variable para el adaptador
            //    SqlDataAdapter adaptador = new SqlDataAdapter(sqlCMD);
            //    //Variable para crear la tabla
            //    DataTable datos = new DataTable();
            //    //Llenamos la tabla
            //    adaptador.Fill(datos);
            //    //Cerramos la conexion
            //    sqlCNX.Close();
            //    //Creamos el objeto del reporte para las personas
            //    ReporteClientes reporte = new ReporteClientes();
            //    reporte.SetDataSource(datos);
            //    //Pasamos la variable como parametro al vizualizador
            //    frmVisualizador formulario = new frmVisualizador(reporte);
            //    formulario.ShowDialog();

            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show("Error al imprimir!", "SI" + ex.Message.ToString());
            //}
        }

        private void Cmbpersonas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.cmbpersonas.Text.Length == 0)
                {
                    MessageBox.Show("Favor de seleccionar una persona.");
                    this.cmbpersonas.Focus();
                    return;
                }
                this.txtnumerocliente.Focus();
            }
        }

        private void Cmbpersonas_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void Txtnumerocliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtnumerocliente.Text.Length == 0)
                {
                    MessageBox.Show("Favor de llenar el numero cliente.");
                    this.txtnumerocliente.Focus();
                    return;
                }
                this.btnGuardar.Focus();
            }
        }

        private void focusno_Enter(object sender, EventArgs e)
        {
            focusno.LineColor = Color.FromArgb(67, 83, 192);
        }

        private void txtnumerocliente_Enter(object sender, EventArgs e)
        {
            txtnumerocliente.Focus();
        }

        private void txtnumerocliente_Leave(object sender, EventArgs e)
        {
            focusno.LineColor = Color.White;
        }

        private void Activos_CheckedChanged(object sender, EventArgs e)
        {
            if (Activos.Checked == true)
            {

                activo = 1;
                GridClientes(activo);
                lblActi.Text = "Activos";
            }
            else if (Activos.Checked == false)
            {
                activo = 0;
                GridClientes(activo);
                lblActi.Text = "Inactivos";

            }
        }
    }
}
