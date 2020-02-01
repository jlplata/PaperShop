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
using System.IO;
using PaperShop.Properties;
using PaperShop.Almacen;
using System.Net;

namespace PaperShop
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
            txtIdUsuario.Text = FrmPrin.id;
            
        }
        int activo = 1;
        void ComboCategorias()
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
                qry = "Select id_categoria_producto, nombre_categoria as categoria from categoria_productos where activo=1";
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
                cmbcategoria.DataSource = datos;
                cmbcategoria.ValueMember = "id_categoria_producto";
                cmbcategoria.DisplayMember = "categoria";
                //Variable para usar en autocompletar
                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                foreach (DataRow row in datos.Rows)
                {
                    coleccion.Add(Convert.ToString(row["categoria"]));
                }
                cmbcategoria.AutoCompleteCustomSource = coleccion;
                cmbcategoria.AutoCompleteSource = AutoCompleteSource.CustomSource;


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al extraer las categorias" + ex.Message.ToString());

            }
        }
        void ComboProveedores()
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
                qry = "Select id_proveedor, razon_social as razon from proveedores where activo=1";
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
                cmbproveedor.DataSource = datos;
                cmbproveedor.ValueMember = "id_proveedor";
                cmbproveedor.DisplayMember = "razon";
                //Variable para usar en autocompletar
                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                foreach (DataRow row in datos.Rows)
                {
                    coleccion.Add(Convert.ToString(row["razon"]));
                }
                cmbproveedor.AutoCompleteCustomSource = coleccion;
                cmbproveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al extraer los proveedores" + ex.Message.ToString());

            }
        }
        void GridProductos(int activo)
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
                 qry = "Select * From VistaProductos where nombre like '%" + txtBuscar.Text + "%' and activo = '"+activo+"'";
                
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
                dgvproductos.DataSource = datos;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al llenar el dgvproductos!" + ex.Message.ToString() + "SI");

            }
        }
        void Actualizar()
        {
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = true;
            btnGuardar.Enabled = false;
            grbusuarios.Enabled = true;
        }
        void Cargar()
        {
            grbusuarios.Enabled = false;
            btnCancelar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            btnNuevo.Focus();
            Activos.Checked = true;
            txtActivo.Text = "1";
            //asignamos la fecha y hora a los lbls corresponientes
            DateTime hoy = DateTime.Now;
            //lblfecharegistro.Text = hoy.ToShortDateString();
            lblhoraregistro.Text = hoy.ToShortTimeString();
            //En caso de marcar error en la /*fecha*/
            lblfecharegistro.Text = hoy.ToString("yyyyMMdd");
            imgpro.Image = Resources.prod;
        }
        void Nuevo()
        {
            grbusuarios.Enabled = true;
            btnCancelar.Enabled = true;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
            txtcve_producto.Focus();
            Activos.Checked = true;
            txtActivo.Text = "1";
        }
        void Cancelar()
        {
            Cargar();
            txtcve_producto.Clear();
            txtcantidad.Clear();
            txtdescripcion.Clear();
            txtnombre.Clear();
            cmbcategoria.SelectedIndex = 0;
            txtprecio_compra.Clear();
            txtprecio_venta.Clear();
            cmbproveedor.SelectedIndex = 0;
            dgvproductos.Enabled = true;
        }
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            ComboCategorias();
            ComboProveedores();
            GridProductos(activo);
            Cargar();
            txtActivo.Text = "1";
        }

        private void Cmbcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblid_categoria.Text = cmbcategoria.SelectedValue.ToString();
        }

        private void Cmbproveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblid_proveedor.Text = cmbproveedor.SelectedValue.ToString();
        }

        private void Btnnuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void Cmproductos_Opening(object sender, CancelEventArgs e)
        {
            if (dgvproductos.Rows.Count > 0 && Activos.Checked == true)
            {
                modificarToolStripMenuItem.Visible = true;
                activarToolStripMenuItem.Visible = false;
                desactivarToolStripMenuItem.Visible = true;

            }
            else if (dgvproductos.Rows.Count > 0 && Activos.Checked == true)
            {
                modificarToolStripMenuItem.Visible = true;
                activarToolStripMenuItem.Visible = false;
                desactivarToolStripMenuItem.Visible = true;

            }
            else if (dgvproductos.Rows.Count > 0 && Activos.Checked == false)
            {
                modificarToolStripMenuItem.Visible = false;
                activarToolStripMenuItem.Visible = true;
                desactivarToolStripMenuItem.Visible = false;
            }
            else if (dgvproductos.Rows.Count <= 0 && Activos.Checked == false)
            {
                modificarToolStripMenuItem.Visible = false;
                activarToolStripMenuItem.Visible = false;
                desactivarToolStripMenuItem.Visible = false;
            }
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
                qry = "UPDATE productos set activo='" + 0 + "' where id_producto = '" + dgvproductos.CurrentRow.Cells["id_producto"].Value.ToString() + "'";
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

                MessageBox.Show("Producto desactivado!", "SI");
                //Invocamos el metodo cancelar

                this.GridProductos(activo);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al modificar el producto!", "SI" + ex.Message.ToString());
            }
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
                qry = "UPDATE productos set activo='" + 1 + "' where id_producto = '" + dgvproductos.CurrentRow.Cells["id_producto"].Value.ToString() + "'";
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

                MessageBox.Show("Producto activado!", "SI");
                //Invocamos el metodo cancelar

                this.GridProductos(activo);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al modificar el producto!", "SI" + ex.Message.ToString());
            }
        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            GridProductos(activo);
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
                //Consulta para extraer los datos de las personas
                qry = "Select * From VistaProductos";
                //Asignamos la consulta al comando
                sqlCMD.CommandText = qry;
                //Asignamos la conexion al comando
                sqlCMD.Connection = sqlCNX;
                //Abrimos la conexion
                sqlCNX.Open();
                //Variable para el adaptador
                SqlDataAdapter adaptador = new SqlDataAdapter(sqlCMD);
                //Variable para crear la tabla

                DataProductos datos = new DataProductos();
                //Llenamos la tabla
                adaptador.Fill(datos, "VistaProductos");

                foreach (DataRow row in datos.Tables[0].Rows)
                {

                    string pach = ".\\.\\";

                    var webClient = new WebClient();
                    byte[] imageBytes = webClient.DownloadData(pach + row["imagen"].ToString());

                    row["imapro"] = imageBytes;

                }



                //Cerramos la conexion
                sqlCNX.Close();
                //Creamos el objeto del reporte para las personas
                ReportePro reporte = new ReportePro();
                reporte.SetDataSource(datos.Tables["VistaUsuarios"]);
                //Pasamos la variable como parametro al vizualizador
                frmVisualizador formulario = new frmVisualizador(reporte);
                formulario.ShowDialog();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al imprimir!", "SI" + ex.Message.ToString());
            }
        }

        private void Txtcve_producto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtcve_producto.Text.Length == 0)
                {
                    MessageBox.Show("Favor de llenar el campo cve. producto.");
                    this.txtcve_producto.Focus();
                    return;
                }
                this.txtcantidad.Focus();
            }
        }

        private void Txtcve_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.solonumeros(e);
        }

        private void Txtcantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtcantidad.Text.Length == 0)
                {
                    MessageBox.Show("Favor de llenar el campo cantidad.");
                    this.txtcantidad.Focus();
                    return;
                }
                this.txtdescripcion.Focus();
            }
        }

        private void Txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.solonumeros(e);
        }

        private void Txtdescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtdescripcion.Text.Length == 0)
                {
                    MessageBox.Show("Favor de llenar el campo descripcion.");
                    this.txtdescripcion.Focus();
                    return;
                }
                this.txtnombre.Focus();
            }
        }

        private void Txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void Txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtnombre.Text.Length == 0)
                {
                    MessageBox.Show("Favor de llenar el campo nombre.");
                    this.txtnombre.Focus();
                    return;
                }
                this.cmbcategoria.Focus();
            }
        }

        private void Txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void Cmbcategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.cmbcategoria.Text.Length == 0)
                {
                    MessageBox.Show("Favor de seleccionar una categoria.");
                    this.cmbcategoria.Focus();
                    return;
                }
                this.txtprecio_compra.Focus();
            }
        }

        private void Cmbcategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void Txtprecio_compra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtprecio_compra.Text.Length == 0)
                {
                    MessageBox.Show("Favor de llenar el campo precio compra.");
                    this.txtprecio_compra.Focus();
                    return;
                }
                this.txtprecio_venta.Focus();
            }
        }

        private void Txtprecio_venta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtprecio_venta.Text.Length == 0)
                {
                    MessageBox.Show("Favor de llenar el campo precio venta.");
                    this.txtprecio_venta.Focus();
                    return;
                }
                this.cmbproveedor.Focus();
            }
        }

        private void Txtprecio_compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.solonumeros(e);
        }

        private void Txtprecio_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.solonumeros(e);
        }

        private void Cmbproveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.cmbproveedor.Text.Length == 0)
                {
                    MessageBox.Show("Favor de seleccionar un proveedor.");
                    this.cmbproveedor.Focus();
                    return;
                }
                this.btnagregar.Focus();
            }
        }

        private void Cmbproveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }
 string diro, dir;
        private void Btnagregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Todas las imágenes soportadas|*.jpg; *.png";
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string qry;
                    string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
                    SqlConnection sqlcnx = new SqlConnection(cadenaconexion);
                    SqlCommand sqlcmd = new SqlCommand();
                    if (ofd.CheckFileExists)
                    {
                        string inarchivo = System.IO.Path.GetFileName(ofd.FileName);
                        qry = "Select imagen from productos where imagen = '\\imapro\\" + inarchivo + "'";
                        sqlcmd.CommandText = qry;
                        sqlcmd.Connection = sqlcnx;
                        SqlDataReader DR = null;
                        sqlcnx.Open();
                        DR = sqlcmd.ExecuteReader();
                        if (DR.HasRows == true)
                        {
                            MensajeOk mm = new MensajeOk();
                            mm.lbltxt.Text = "Un producto ya tiene esa imagen \n intentelo de nuevo";
                            mm.ShowDialog();
                            sqlcnx.Close();
                        }
                        else
                        {
                            string archivo = System.IO.Path.GetFileName(ofd.FileName);
                            diro = ofd.FileName;
                            dir = "\\imapro\\" + archivo;
                            imgpro.Load(ofd.FileName);
                            imgpro.Refresh();
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Nose pudo" + ex, "Error");
            }

            
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
                qry = "SELECT cve_producto from productos where cve_producto = '" + txtcve_producto.Text + "'";
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
                    MessageBox.Show("Ya hay un producto con esa clave!", "SI");
                    txtcve_producto.Clear();
                    txtcve_producto.Focus();
                    //Cerramos la conexion
                    sqlCNX.Close();
                }
                else
                {
                    if (dir == null)
                    {
                        Random r = new Random();
                        int idc = r.Next(00000001, 99999999);
                        dir = "\\imapro\\prod" + idc + ".png";
                        diro = "\\imapro\\prod.png";
                        
            string pach = ".\\.\\";
                        System.IO.File.Copy(pach + diro, pach + dir);
                    }
                    else
                    {
                        
            string pach = ".\\.\\";
                        System.IO.File.Copy(diro, pach + dir);
                    }

                    //Volvemos a cerrar la conexion
                    sqlCNX.Close();
                    //Insertamos o guardamos la persona en la BD
                    qry = "INSERT INTO productos(cve_producto, cantidad, descripcion, nombre, id_categoria_producto, precio_compra, precio_venta, id_proveedor, fecha_registro, hora_registro, activo, id_usuario, imagen)" +
                        "VALUES('" + txtcve_producto.Text + "', '" + txtcantidad.Text + "', '" + txtdescripcion.Text + "', '" + txtnombre.Text + "', '"+lblid_categoria.Text+"', '"+txtprecio_compra.Text+"', '"+txtprecio_venta.Text+"', '"+lblid_proveedor.Text+"', '" + lblfecharegistro.Text + "', '" + lblhoraregistro.Text + "', '" + txtActivo.Text + "', '" + txtIdUsuario.Text + "', '" + dir + "')";
                    //Codigo para guardar la imagen 
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

                    MessageBox.Show("Producto Registrado", "SI");
                    //Limpiamos el picturebox y el txtpatchfile
                    imgpro.SizeMode = PictureBoxSizeMode.StretchImage;
                    imgpro.Image = null;
                    txtpathfile.Clear();
                    //Invocamos el metodo cancelar
                    this.Cancelar();
                    this.GridProductos(activo);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al insertar el producto!", "SI" + ex.Message.ToString());
                MessageBox.Show(ex.Message.ToString());
            }
            //Fin del codigo guardar
        }

        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            if (dir == null)
            {
                dir = txtpathfile.Text;
            }
            else
            {
                imgpro.Refresh();
                string patch = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                System.IO.File.Delete(patch + txtpathfile.Text);
                System.IO.File.Copy(diro, patch + dir);


            }
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
                    qry = "UPDATE productos set cve_producto='" + txtcve_producto.Text + "', cantidad='" + txtcantidad.Text + "', descripcion='" + txtdescripcion.Text + "', nombre='" + txtnombre.Text + "', id_categoria_producto= '" + lblid_categoria.Text + "', precio_compra='" + txtprecio_compra.Text + "', precio_venta='" + txtprecio_venta.Text + "', id_proveedor='" + lblid_proveedor.Text + "', fecha_registro='" + lblfecharegistro.Text + "', hora_registro='" + lblhoraregistro.Text + "', activo='" + txtActivo.Text + "', id_usuario='" + txtIdUsuario.Text + "', imagen= '" + dir + "' where id_producto = " + Convert.ToInt16(dgvproductos.CurrentRow.Cells["id_producto"].Value.ToString()) + "";
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

                    MessageBox.Show("Producto modificado", "SI");

                    this.Cargar();
                    this.GridProductos(1);
                    this.Cancelar();
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al modificar el producto!", "SI" + ex.Message.ToString());
            }
            //Fin codigo modificar
        }

        private void ModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtcve_producto.Text = dgvproductos.CurrentRow.Cells["cve_producto"].Value.ToString();
            txtcantidad.Text = dgvproductos.CurrentRow.Cells["cantidad"].Value.ToString();
            txtdescripcion.Text = dgvproductos.CurrentRow.Cells["descripcion"].Value.ToString();
            txtnombre.Text = dgvproductos.CurrentRow.Cells["nombre"].Value.ToString();
            cmbcategoria.Text = dgvproductos.CurrentRow.Cells["categoria"].Value.ToString();
            txtprecio_compra.Text = dgvproductos.CurrentRow.Cells["precio_compra"].Value.ToString();
            txtprecio_venta.Text = dgvproductos.CurrentRow.Cells["precio_venta"].Value.ToString();
            cmbproveedor.Text = dgvproductos.CurrentRow.Cells["proveedor"].Value.ToString();
            dgvproductos.Enabled = false;
            txtpathfile.Text = dgvproductos.CurrentRow.Cells["imagen"].Value.ToString();
            
            string pach = ".\\.\\";
            imgpro.Load(pach + txtpathfile.Text);
            btnagregar.Text = "Cambiar";
            this.Actualizar();
        }

        private void txtcve_producto_Leave(object sender, EventArgs e)
        {
            focusCveProd.LineColor = Color.White;
        }

        private void focusCveProd_Enter(object sender, EventArgs e)
        {
            txtcve_producto.Focus();
        }

        private void txtcantidad_Enter(object sender, EventArgs e)
        {
            focusCantidad.LineColor = Color.FromArgb(67, 83, 192);

        }

        private void txtcantidad_Leave(object sender, EventArgs e)
        {
            focusCantidad.LineColor = Color.White;

        }

        private void focusCantidad_Enter(object sender, EventArgs e)
        {
            txtcantidad.Focus();
        }

        private void txtdescripcion_Enter(object sender, EventArgs e)
        {
            focusDes.LineColor = Color.FromArgb(67, 83, 192);

        }

        private void txtnombre_Enter(object sender, EventArgs e)
        {
            focusNomb.LineColor = Color.FromArgb(67, 83, 192);
        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            focusNomb.LineColor = Color.White;

        }

        private void focusNomb_Enter(object sender, EventArgs e)
        {
            txtnombre.Focus();
        }

        private void txtprecio_compra_Enter(object sender, EventArgs e)
        {
            focusComp.LineColor = Color.FromArgb(67, 83, 192);

        }

        private void txtprecio_compra_Leave(object sender, EventArgs e)
        {
            focusComp.LineColor = Color.White;
        }

        private void focusComp_Enter(object sender, EventArgs e)
        {
            txtprecio_compra.Focus();
        }

        private void txtprecio_venta_Enter(object sender, EventArgs e)
        {
          gunaLineTextBox1.LineColor = Color.FromArgb(67, 83, 192);
        }

        private void txtprecio_venta_Leave(object sender, EventArgs e)
        {
            gunaLineTextBox1.LineColor = Color.White;
        }

        private void gunaLineTextBox1_Enter(object sender, EventArgs e)
        {
            txtprecio_venta.Focus();
        }

        private void txtcve_producto_Enter(object sender, EventArgs e)
        {
            focusCveProd.LineColor = Color.FromArgb(67, 83, 192);
        }
       

        

        private void Activos_CheckedChanged(object sender, EventArgs e)
        {
            if (Activos.Checked == true)
            {

                activo = 1;
                GridProductos(activo);
                lblActi.Text = "Activos";
            }
            else if (Activos.Checked == false)
            {
                activo = 0;
                GridProductos(activo);
                lblActi.Text = "Inactivos";
            }
        }

        private void focusDes_Enter(object sender, EventArgs e)
        {
            txtdescripcion.Focus();
        }
       
        private void txtdescripcion_Leave(object sender, EventArgs e)
        {
            focusDes.LineColor = Color.White;
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
