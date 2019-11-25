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
using System.Data.SqlClient;
using System.Collections.Specialized;
using System.Data.SqlTypes;

namespace PaperShop
{
    public partial class frmManSalidas : Form
    {
        public frmManSalidas()
        {
            InitializeComponent();
            txtIdU.Text = FrmPrin.id;
        }
        void CantidadProducto()
        {
            string qry = "";
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            SqlCommand sqlCMD = new SqlCommand();
            qry = "WITH C AS (SELECT id_salida, COUNT(*) AS Cantidad FROM detalle_salida GROUP BY id_salida, activo HAVING activo = 1) SELECT sa.id_salida, ISNULL(C.Cantidad, 0) AS CantidadReal FROM salidas sa LEFT OUTER JOIN C ON sa.id_salida = C.id_salida and sa.fecha_registro between '" + dtpFechaInicial.Value.ToString("yyyyMMdd") + "' and '" + dtpFechaFinal.Value.ToString("yyyyMMdd") + "'";
            sqlCMD.CommandText = qry;
            sqlCMD.Connection = sqlCNX;
            sqlCNX.Open();
            SqlDataAdapter a = new SqlDataAdapter(sqlCMD);
            DataTable datosContados = new DataTable();
            a.Fill(datosContados);
            sqlCNX.Close();
            dgvCantidadProducto.DataSource = datosContados;
        }
        void gridSalidas(int activos)
        {
            string qry = "";
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            SqlCommand sqlCMD = new SqlCommand();
            try
            {
                if (Activo.Checked == true)
                {
                    //Consulta para extraer los datos de las personas
                    qry = "select * from VistaSalidasGlobal where activo5 = 1 and activo05 = 1 and VistaSalidasGlobal.ID = '"+txtfolio.Text+"' and fecha_registro BETWEEN @FechaInicio and @FechaFinal";
                    
                }
                else
                {
                    //Consulta para extraer los datos de las personas
                    qry = "select * from VistaSalidasGlobal where activo5 = 0 or activo05 = 0";
                }
                sqlCMD.Parameters.Add("@FechaInicio", SqlDbType.Date).Value = dtpFechaInicial.Value;
                sqlCMD.Parameters.Add("@FechaFinal", SqlDbType.Date).Value = dtpFechaFinal.Value;
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;
                sqlCNX.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter(sqlCMD);
                DataTable datospersonas = new DataTable();
                adaptador.Fill(datospersonas);
                sqlCNX.Close();
                dgvSalidas.DataSource = datospersonas;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al extraer los datos persona!", "SI" + ex.Message.ToString());
            }
        }
        void cargar()
        {
            txtDescripcion.Visible = false;
            label5.Visible = false;
            btnEliminarSalida.Visible = false;
            btnCancelarSalida.Visible = false;
            txtDescripcion.Clear();
            DateTime hoy = DateTime.Now;
            lblFechaRegistro.Text = hoy.ToString("yyyyMMdd");
            lblHoraRegistro.Text = hoy.ToShortTimeString();
        }
        void cargarDetalleSalida()
        {
            txtDescripcionDS.Visible = false;
            label4.Visible = false;
            btnEliminarDS.Visible = false;
            btnCancelarDS.Visible = false;
            txtDescripcion.Clear();
            DateTime hoy = DateTime.Now;
            lblFechaRegistro.Text = hoy.ToString("yyyyMMdd");
            lblHoraRegistro.Text = hoy.ToShortTimeString();
        }
        void habilitar()
        {
            txtDescripcion.Visible = true;
            label5.Visible = true;
            btnEliminarSalida.Visible = true;
            btnCancelarSalida.Visible = true;
            txtDescripcion.Clear();
            btnImprimirSalida.Visible = true;
            btnImprimirDS.Visible = true;
            txtDescripcionDS.Visible = true;
            btnEliminarDS.Visible = true;
            btnCancelarDS.Visible = true;
        }
        void gridSalidasDetalle(int activosDs)
        {
            string qry = "";
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            SqlCommand sqlCMD = new SqlCommand();
            try
            {
                if (ActivoDs.Checked == true)
                {
                    //Consulta para extraer los datos de las personas
                    qry = "select * from vistaDS where activosS = 1 and activoDS = 1 and VistaDS.ID = '" + txtfoliods.Text + "' and fecha_registro BETWEEN @FechaInicio and @FechaFinal order by ID";
                    sqlCMD.Parameters.Add("@FechaInicio", SqlDbType.Date).Value = dtpFechaInicial.Value;
                    sqlCMD.Parameters.Add("@FechaFinal", SqlDbType.Date).Value = dtpFechaFinal.Value;
                }
                else
                {
                    //Consulta para extraer los datos de las personas
                    qry = "select * from vistaDS where activoDS = 0 or activosS = 0";
                }
                
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;
                sqlCNX.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter(sqlCMD);
                DataTable datospersonas = new DataTable();
                adaptador.Fill(datospersonas);
                sqlCNX.Close();
                dgvProductosDS.DataSource = datospersonas;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al extraer los datos persona!", "SI" + ex.Message.ToString());
            }
        }
        void gridSalidasDetalleProductos()
        {
            string qry = "";
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            SqlCommand sqlCMD = new SqlCommand();
            try
            {
                //Consulta para extraer los datos de las personas
                qry = "select id_producto, producto, cantidad from vistaDS where activoDS = 1";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;
                sqlCNX.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter(sqlCMD);
                DataTable datospersonas = new DataTable();
                adaptador.Fill(datospersonas);
                sqlCNX.Close();
                dgvCantidadProducto.DataSource = datospersonas;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al extraer los datos persona!", "SI" + ex.Message.ToString());
            }
        }
        int activos = 1, activosDs = 1;
        private void FrmManSalidas_Load(object sender, EventArgs e)
        {
            gridSalidas(activosDs);
            gridSalidasDetalle(activosDs);
            Activo.Checked = true;
            ActivoDs.Checked = true;
            CantidadProducto();
            gridSalidasDetalleProductos();
            DateTime hoy = DateTime.Now;
            lblFechaRegistro.Text = hoy.ToString("yyyyMMdd");
            lblHoraRegistro.Text = hoy.ToShortTimeString();
            cargar();
            cargarDetalleSalida();
            btnImprimirDS.Visible = true;
            btnImprimirSalida.Visible = true;
        }

        private void BtnEliminarSalida_Click(object sender, EventArgs e)
        {
            string qry = "";
            string cadenaconecion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            SqlConnection sqlCNX = new SqlConnection(cadenaconecion);
            SqlCommand sqlCMD = new SqlCommand();

            try
            {
                int idSalida = Int16.Parse(dgvSalidas.CurrentRow.Cells[0].Value.ToString());
                qry = "UPDATE salidas SET activo = 0, descripcion = '"+txtDescripcion.Text+"', fecha_registro = '"+lblFechaRegistro.Text+"', hora_registro = '"+lblHoraRegistro.Text+"', id_usuario = '"+txtIdU.Text+"' where id_salida = " + idSalida + "";

                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;
                sqlCNX.Open();
                sqlCMD.ExecuteReader();
                sqlCNX.Close();
                qry = "UPDATE detalle_salida SET activo = 0, fecha_registro = '" + lblFechaRegistro.Text + "', hora_registro = '" + lblHoraRegistro.Text + "', id_usuario = '" + txtIdU.Text + "' where id_salida = " + idSalida + "";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;
                sqlCNX.Open();
                sqlCMD.ExecuteReader();
                sqlCNX.Close();
                qry = "SELECT id_producto, cantidad FROM detalle_salida WHERE id_salida ='"+idSalida+"'";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;
                sqlCNX.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter(sqlCMD);
                DataTable datos = new DataTable();
                adaptador.Fill(datos);
                sqlCNX.Close();
                dgvSalidas.DataSource = datos;
                foreach (DataGridViewRow row in dgvSalidas.Rows)
                {
                    int id_producto = int.Parse(row.Cells["id_producto"].Value.ToString());
                    int cantidad_producto = int.Parse(row.Cells["cantidad"].Value.ToString());
                    qry = "UPDATE productos SET cantidad += "+cantidad_producto+" WHERE id_producto = "+id_producto+"";
                    sqlCMD.CommandText = qry;
                    sqlCMD.Connection = sqlCNX;
                    sqlCNX.Open();
                    sqlCMD.ExecuteReader();
                    sqlCNX.Close();
                }
                MessageBox.Show("Salida desactivada!", "SI");
                gridSalidas(activos);
                gridSalidasDetalle(activosDs);
                CantidadProducto();
                gridSalidasDetalleProductos();
                txtDescripcion.Clear();
                cargar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al desactivar persona!" + ex.Message.ToString(), "Sistema de Inventario");
            }
        }

        private void BtnEliminarDS_Click(object sender, EventArgs e)
        {
            string qry = "";
            string cadenaconecion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            SqlConnection sqlCNX = new SqlConnection(cadenaconecion);
            SqlCommand sqlCMD = new SqlCommand();

            try
            {
                int iddetallesalida = Int16.Parse(dgvProductosDS.CurrentRow.Cells["dsID"].Value.ToString());
                qry = "UPDATE detalle_salida SET activo = 0, descripcion = '"+txtDescripcionDS.Text+"', fecha_registro = '"+lblFechaRegistro.Text+"', hora_registro = '"+lblHoraRegistro.Text+"', id_usuario = '"+txtIdU.Text+"' where id_detalle_salida = " + iddetallesalida + "";

                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;
                sqlCNX.Open();
                sqlCMD.ExecuteReader();
                sqlCNX.Close();
                qry = "SELECT id_producto, cantidad, precio_venta FROM detalle_salida WHERE id_detalle_salida ='" + iddetallesalida + "'";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;
                sqlCNX.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter(sqlCMD);
                DataTable datos = new DataTable();
                adaptador.Fill(datos);
                sqlCNX.Close();
                dgvCantidadProducto.DataSource = datos;
                int id_producto = int.Parse(dgvCantidadProducto.CurrentRow.Cells["id_producto"].Value.ToString());
                int cantidad_producto = int.Parse(dgvCantidadProducto.CurrentRow.Cells["cantidad"].Value.ToString());
                qry = "UPDATE productos SET cantidad += " + cantidad_producto + " WHERE id_producto = " + id_producto + "";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;
                sqlCNX.Open();
                sqlCMD.ExecuteReader();
                sqlCNX.Close();
                double precioVenta = Double.Parse(dgvProductosDS.CurrentRow.Cells["precio_venta"].Value.ToString());
                int idSalida = int.Parse(dgvProductosDS.CurrentRow.Cells[1].Value.ToString());
                qry = "UPDATE salidas SET total -= "+precioVenta+" WHERE id_salida = "+idSalida+"";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;
                sqlCNX.Open();
                sqlCMD.ExecuteReader();
                sqlCNX.Close();
                qry = "WITH C AS (SELECT id_salida, COUNT(*) AS Cantidad FROM detalle_salida GROUP BY id_salida, activo HAVING activo = 1) SELECT sa.id_salida, ISNULL(C.Cantidad, 0) AS CantidadReal FROM salidas sa LEFT OUTER JOIN C ON sa.id_salida = C.id_salida and sa.fecha_registro between '"+dtpFechaInicial.Value.ToString("yyyyMMdd")+"' and '"+dtpFechaFinal.Value.ToString("yyyyMMdd")+"'";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;
                sqlCNX.Open();
                SqlDataAdapter a = new SqlDataAdapter(sqlCMD);
                DataTable datosContados = new DataTable();
                a.Fill(datosContados);
                sqlCNX.Close();
                dgvCantidadProducto.DataSource = datosContados;
                int idconteo = int.Parse(dgvCantidadProducto.CurrentRow.Cells["id_salida"].Value.ToString());
                int idDS = int.Parse(dgvProductosDS.CurrentRow.Cells["dsID"].Value.ToString());
                if (Convert.ToInt16(dgvCantidadProducto.CurrentRow.Cells["CantidadReal"].Value.ToString()) == 0 && idconteo == idDS)
                {
                    foreach (DataGridViewRow row in dgvCantidadProducto.Rows)
                    {
                        int idS = int.Parse(row.Cells["id_salida"].Value.ToString());
                        qry = "UPDATE salidas SET activo = 0 WHERE id_salida = "+idS+"";
                        sqlCMD.CommandText = qry;
                        sqlCMD.Connection = sqlCNX;
                        sqlCNX.Open();
                        sqlCMD.ExecuteReader();
                        sqlCNX.Close();
                    }
                }
                MessageBox.Show("Detalle salida desactivada!", "SI");
                gridSalidasDetalle(activosDs);
                CantidadProducto();
                gridSalidasDetalleProductos();
                txtDescripcionDS.Clear();
                txtCantidad.Clear();
                cargarDetalleSalida();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al desactivar persona!" + ex.Message.ToString(), "Sistema de Inventario");
            }
        }


        private void RdbActivoDS_CheckedChanged(object sender, EventArgs e)
        {
            gridSalidasDetalle(activosDs);
        }

        private void RdbInactivoDS_CheckedChanged(object sender, EventArgs e)
        {
            gridSalidasDetalle(activosDs);
        }

        private void DgvSalidas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDescripcion.Focus();
        }

        private void DgvProductosDS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDescripcionDS.Focus();
            txtCantidad.Text = dgvProductosDS.CurrentRow.Cells["cantidad"].Value.ToString();
        }

        private void BtnCancelarDS_Click(object sender, EventArgs e)
        {
            string qry = "";
            string cadenaconecion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            SqlConnection sqlCNX = new SqlConnection(cadenaconecion);
            SqlCommand sqlCMD = new SqlCommand();

            try
            {
                int idpersona = Int16.Parse(dgvProductosDS.CurrentRow.Cells["dsID"].Value.ToString());
                qry = "UPDATE detalle_salida SET activo = 1, descripcion = '" + txtDescripcionDS.Text + "' where id_detalle_salida = " + idpersona + "";

                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;
                sqlCNX.Open();
                sqlCMD.ExecuteReader();
                sqlCNX.Close();
                MessageBox.Show("Detalle salida cancelada!", "SI");
                gridSalidasDetalle(activosDs);
                gridSalidasDetalleProductos();
                gridSalidasDetalleProductos();
                txtDescripcionDS.Clear();
                txtCantidad.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al cancelar la salida!" + ex.Message.ToString(), "Sistema de Inventario");
            }
            cargarDetalleSalida();
        }

        private void BtnCancelarSalida_Click(object sender, EventArgs e)            
        {
                string qry = "";
                string cadenaconecion = ConfigurationManager.AppSettings.Get("cadenaconexion");
                SqlConnection sqlCNX = new SqlConnection(cadenaconecion);
                SqlCommand sqlCMD = new SqlCommand();

                try
                {
                    int idpersona = Int16.Parse(dgvSalidas.CurrentRow.Cells["ID"].Value.ToString());
                    qry = "UPDATE salidas SET activo = 1, descripcion = '" + txtDescripcion.Text + "' where id_salida = " + idpersona + "";

                    sqlCMD.CommandText = qry;
                    sqlCMD.Connection = sqlCNX;
                    sqlCNX.Open();
                    sqlCMD.ExecuteReader();
                    sqlCNX.Close();
                    MessageBox.Show("Salida Cancelada!", "SI");
                    gridSalidasDetalle(activosDs);
                    gridSalidasDetalleProductos();
                    txtDescripcion.Clear();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al cancelar la salida!" + ex.Message.ToString(), "Sistema de Inventario");
                }

                cargar();
        }

        private void DtpFechaInicial_ValueChanged(object sender, EventArgs e)
        {
            gridSalidas(activos);
            gridSalidasDetalle(activosDs);
        }

        private void DtpFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            gridSalidas(activos);
            gridSalidasDetalle(activosDs);
        }

        private void ModificarSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = dgvSalidas.CurrentRow.Cells["descripcion"].Value.ToString();
            habilitar();
            dgvCantidadProducto.ReadOnly = true;
        }

        private void TabControl1_Click(object sender, EventArgs e)
        {
            if (tabSalida.Focus())
            {
                gridSalidas(activos);
                cargar();
            }
            else if (tabSalidaDetalle.Focus())
            {
                gridSalidasDetalle(activosDs);
                CantidadProducto();
                gridSalidasDetalleProductos();
                cargarDetalleSalida();
            }
        }

        private void Txtfolio_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnTicket_Click(object sender, EventArgs e)
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
            //    //Consulta para extraer los datos de las personas
            //    qry = "Select * From VistaDS where ID = '"+txtfolio.Text+"' and activoDS = 1";
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
            //    ReporteTicket reporte = new ReporteTicket();
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

        private void TabSalida_Click(object sender, EventArgs e)
        {

        }

        private void Btnfoliods_Click(object sender, EventArgs e)
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
            //    //Consulta para extraer los datos de las personas
            //    qry = "Select * From VistaDS where ID = '" + txtfoliods.Text + "' and activoDS=1";
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
            //    ReporteTicket reporte = new ReporteTicket();
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

        private void Txtfoliods_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                gridSalidasDetalle(activosDs);
            }
        }

        private void Txtfolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                gridSalidas(activos);
            }
        }

        private void gunaWinSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (Activo.Checked == true)
            {

                activos = 1;
                gridSalidas(activos);
                lblActi.Text = "Activos";
            }
            else if (Activo.Checked == false)
            {
                activos = 0;
                gridSalidas(activos);
                lblActi.Text = "Inactivos";
            }
        }

        private void gunaWinSwitch1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ActivoDs.Checked == true)
            {
                activosDs = 1;
                gridSalidas(activosDs);
                lblActiDs.Text = "Activos";
            }
            else if (ActivoDs.Checked == false)
            {
                activosDs = 0;
                gridSalidas(activosDs);
                lblActiDs.Text = "Inactivos";
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
