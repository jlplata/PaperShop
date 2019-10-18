using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using System.Data.SqlClient;

namespace PaperShop
{
    public partial class frmPuestos : Form
    {
        public frmPuestos()
        {
            InitializeComponent();
            txtIdUsuario.Text = FrmPrin.id;
        }

        private void Grbclientes_Enter(object sender, EventArgs e)
        {

        }
        void GridPuestos(int activo)
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
                    //Consulta para extraer los datos de las personas
                    qry = "Select * From VistaPuestos where puesto like '%" + txtbuscar.Text + "%' and VistaPuestos.activo = '" + activo + "'";
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
                dgvpuestos.DataSource = datos;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al llenar el dgvpuestos!" + ex.Message.ToString() + "SI");

            }
        }
        void Actualizar()
        {
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = true;
            btnGuardar.Enabled = false;
            grbpuestos.Enabled = true;
        }
        void Cargar()
        {
            grbpuestos.Enabled = false;
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
            grbpuestos.Enabled = true;
            btnCancelar.Enabled = true;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
            txtpuesto.Focus();
            Activos.Checked = true;
            txtActivo.Text = "1";
        }
        void Cancelar()
        {
            Cargar();
            txtpuesto.Clear();
            dgvpuestos.Enabled = true;
        }
        private void FrmPuestos_Load(object sender, EventArgs e)
        {
            GridPuestos(1);
            Cargar();
            txtActivo.Text = "1";
        }

        private void Txtidusuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Btnnuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
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
                qry = "SELECT puesto from puestos where puesto = '" + txtpuesto.Text + "'";
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
                    MessageBox.Show("Ya hay un puesto con ese nombre!", "SI");
                    txtpuesto.Clear();
                    txtpuesto.Focus();
                    //Cerramos la conexion
                    sqlCNX.Close();
                }
                else
                {
                    //Volvemos a cerrar la conexion
                    sqlCNX.Close();
                    //Insertamos o guardamos el cliente en la BD
                    qry = "INSERT INTO puestos(puesto, fecha_registro, hora_registro, activo, id_usuario)" +
                    "VALUES('" + txtpuesto.Text + "', '" + lblfecharegistro.Text + "', '" + lblhoraregistro.Text + "', '" + txtActivo.Text + "', '" + txtIdUsuario.Text + "')";
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

                    MessageBox.Show("Puesto Registrado", "SI");
                    //Invocamos el metodo cancelar
                    GridPuestos(1);
                    this.Cancelar();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al insertar el puesto!", "SI" + ex.Message.ToString());
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
                qry = "SELECT puesto from puestos where puesto = '" + txtpuesto.Text + "' and id_puesto != " + Convert.ToInt16(dgvpuestos.CurrentRow.Cells["id_puesto"].Value.ToString()) + "";
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
                    MessageBox.Show("Ya hay un puesto con ese nombre!", "SI");
                    txtpuesto.Clear();
                    txtpuesto.Focus();
                    //Cerramos la conexion
                    sqlCNX.Close();
                }
                else
                {
                    //Volvemos a cerrar la conexion
                    sqlCNX.Close();
                    //Insertamos o guardamos la persona en la BD
                    //Variable para el cliente

                    qry = "UPDATE puestos set  puesto='" + txtpuesto.Text + "', fecha_registro='" + lblfecharegistro.Text + "', hora_registro='" + lblhoraregistro.Text + "', activo='" + txtActivo.Text + "', id_usuario='" + txtIdUsuario.Text + "' where id_puesto = " + Convert.ToInt16(dgvpuestos.CurrentRow.Cells["id_puesto"].Value.ToString()) + "";
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

                    MessageBox.Show("Puesto Actualizado", "SI");
                    //Invocamos el metodo cancelar
                    
                    GridPuestos(1);
                    this.Cancelar();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al actualizar el puesto!", "SI" + ex.Message.ToString());
            }
            //Fin del codigo guardar
        }

        private void Cmpuestos_Opening(object sender, CancelEventArgs e)
        {
            if (dgvpuestos.Rows.Count > 0 && Activos.Checked == true)
            {
                modificarToolStripMenuItem.Visible = true;
                activarToolStripMenuItem.Visible = false;
                desactivarToolStripMenuItem.Visible = true;

            }
            else if (dgvpuestos.Rows.Count > 0 && Activos.Checked == true)
            {
                modificarToolStripMenuItem.Visible = false;
                activarToolStripMenuItem.Visible = false;
                desactivarToolStripMenuItem.Visible = false;

            }
            else if (dgvpuestos.Rows.Count > 0 && Activos.Checked == false)
            {
                modificarToolStripMenuItem.Visible = false;
                activarToolStripMenuItem.Visible = true;
                desactivarToolStripMenuItem.Visible = false;
            }
            else if (dgvpuestos.Rows.Count <= 0 && Activos.Checked == false)
            {
                modificarToolStripMenuItem.Visible = false;
                activarToolStripMenuItem.Visible = false;
                desactivarToolStripMenuItem.Visible = false;
            }
        }

        private void ModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtpuesto.Text = dgvpuestos.CurrentRow.Cells["puesto"].Value.ToString();
            txtActivo.Text = dgvpuestos.CurrentRow.Cells["activo"].Value.ToString();
            dgvpuestos.Enabled = false;
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
                qry = "UPDATE puestos set activo='" + 0 + "' where id_puesto = '" + dgvpuestos.CurrentRow.Cells["id_puesto"].Value.ToString() + "'";
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

                MessageBox.Show("Puesto desactivado!", "SI");
                //Invocamos el metodo cancelar

                this.GridPuestos(0);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al modificar el puesto!", "SI" + ex.Message.ToString());
            }
        }
        int activo;
        private void Activos_CheckedChanged(object sender, EventArgs e)
        {

            if (Activos.Checked == true)
            {
                activo = 1;
                GridPuestos(activo);
                lblActi.Text = "Activos";
            }
            else if (Activos.Checked == false)
            {
                activo = 0;
                GridPuestos(activo);
                lblActi.Text = "Inactivos";
            }
        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            GridPuestos(activo);
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
                qry = "UPDATE puestos set activo='" + 1 + "' where id_puesto = '" + dgvpuestos.CurrentRow.Cells["id_puesto"].Value.ToString() + "'";
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

                MessageBox.Show("Puesto activado!", "SI");
                //Invocamos el metodo cancelar

                this.GridPuestos(1);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al modificar el Puesto!", "SI" + ex.Message.ToString());
            }
        }

        private void Btnimprimir_Click(object sender, EventArgs e)
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
                    qry = "Select * From VistaPuestos where puesto like '%" + txtbuscar.Text + "%' and VistaPuesto.activo = 1";
                }
                else
                {
                    //Consulta para extraer los datos de las personas
                    qry = "Select * From VistaPuestos where pueso like '%" + txtbuscar.Text + "%' and VistaPuesto.activo = 0";
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
                //sqlCNX.Close();
                ////Creamos el objeto del reporte para las personas
                //ReportePuestos reporte = new ReportePuestos();
                //reporte.SetDataSource(datos);
                ////Pasamos la variable como parametro al vizualizador
                //frmVisualizador formulario = new frmVisualizador(reporte);
                //formulario.ShowDialog();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al imprimir!", "SI" + ex.Message.ToString());
            }
        }

        private void Txtpuesto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtpuesto.Text.Length == 0)
                {
                    MessageBox.Show("Favor de llenar el campo puesto.");
                    this.txtpuesto.Focus();
                    return;
                }
                this.btnGuardar.Focus();
            }
        }

        private void Txtpuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtpuesto_Enter(object sender, EventArgs e)
        {
            focusPu.LineColor = Color.FromArgb(100, 88, 255);
        }

        private void txtpuesto_Leave(object sender, EventArgs e)
        {
            focusPu.LineColor = Color.White;
        }

        private void focusPu_Enter(object sender, EventArgs e)
        {
            txtpuesto.Focus();
        }

        private void txtbuscar_Enter(object sender, EventArgs e)
        {
            FocusBuscar.LineColor = Color.FromArgb(100, 88, 255);
        }

        private void txtbuscar_Leave(object sender, EventArgs e)
        {
            FocusBuscar.LineColor = Color.White;
        }

        private void FocusBuscar_Enter(object sender, EventArgs e)
        {
            txtbuscar.Focus();
        }
    }
}
