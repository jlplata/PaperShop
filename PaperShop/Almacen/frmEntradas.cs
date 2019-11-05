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
    public partial class frmEntradas : Form
    {
        public frmEntradas()
        {
            InitializeComponent();
            txtidusuario.Text = FrmPrin.id;
        }
        validacion v = new validacion();
        void identrada()
        {
            //Variable para guardar la consulta
            string qry = "";
            //Variable para extrar la info del appconfig
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            //Variable para conectarnos al BD
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            //Variable para guardar el comando
            SqlCommand sqlCMD = new SqlCommand();
            //Guardamos la consulta en qry para extraer el id_salida
            qry = "SELECT id_entrada from entradas where fecha_registro='" + this.lblfecha_registro.Text + "' and hora_registro='" + this.lblhora_registro.Text + "'";
            //Asignamos la consulta al comando 
            sqlCMD.CommandText = qry;
            //Asignamos la conexion al comando
            sqlCMD.Connection = sqlCNX;
            //Variable para leer datos tipo sql
            SqlDataReader sqlDR = null;
            //Bloque de codigo apra cachar errores
            try
            {
                //Abrimos la conexion
                sqlCNX.Open();
                //Asignamos ejecutando el comando al sqlDR
                sqlDR = sqlCMD.ExecuteReader();
                if (sqlDR.HasRows == true)
                {
                    while (sqlDR.Read() == true)
                    {
                        this.txtidsalida.Text = sqlDR["id_entrada"].ToString();
                    }
                    //Cerramos la conexion
                    sqlCNX.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al extraer el id de la entrada", "Sistema de inventario");
                MessageBox.Show(ex.Message.ToString());

            }
        }
        void AgregarProducto()
        {
            //Validamos que la clave del producto y la cantidad sean mayor a cero
            if (this.txtcve_producto.Text.Length > 0 && this.txtcantidad.Text.Length > 0)
            {
                //Variable para guardar la consulta
                string qry = "";
                //Variable para extraer la info del appconfig
                string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
                //Variable para conectarnos a la BD
                SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
                //Variable para guardar el comando
                SqlCommand sqlCMD = new SqlCommand();
                //Guardamos la consulta en qry
                qry = "SELECT id_producto, nombre, cantidad, precio_compra from productos where cve_producto='" + this.txtcve_producto.Text + "'";
                //Asignamos la consulta al comando
                sqlCMD.CommandText = qry;
                //Asignamos la consulta al comando
                sqlCMD.Connection = sqlCNX;
                //Variable para leer datos tipo slq
                SqlDataReader sqlDR = null;
                //Bloque de codigo para cachar errores con el try and catch
                try
                {
                    //Abrimos la conexion
                    sqlCNX.Open();
                    //Asignamos ejecutado el comando al sqlDR
                    sqlDR = sqlCMD.ExecuteReader();
                    if (sqlDR.HasRows == true)
                    {
                        while (sqlDR.Read() == true)
                        {
                            this.txtid_producto.Text = sqlDR["id_producto"].ToString();
                            this.txtcantidadproducto.Text = sqlDR["cantidad"].ToString();
                            this.txtnombre.Text = sqlDR["nombre"].ToString();
                            this.txtprecio_venta.Text = sqlDR["precio_compra"].ToString();
                        }
                        //Cerramos la conexion
                        sqlCNX.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se ha agregado el producto");
                        this.txtcve_producto.Clear();
                        this.txtcantidad.Clear();
                        this.txtcve_producto.Focus();
                        return;
                        //Cerramos la conexion
                        //sqlCNX.Close();
                    }
                    //Variables para validar que la cantidad del producto introducido no exceda de lo que esta en stock
                    int cantidad_producto, cantidad_entrada;
                    cantidad_producto = Int16.Parse(this.txtcantidadproducto.Text);
                    cantidad_entrada = Int16.Parse(this.txtcantidad.Text);
                    //if (cantidad_entrada > cantidad_producto || cantidad_producto <= 0)
                    //{
                    //    MessageBox.Show("La cantidad de salida es mayor" + this.txtcantidad.Text + " que la actual" + this.txtcantidadproducto.Text);
                    //    this.txtcantidad.Clear();
                    //    this.txtcantidad.Focus();
                    //    return;
                    //}
                    //else
                    //{
                    //Variablepara guardar el total de productos en stock
                    int totalstock;
                    totalstock = cantidad_producto + cantidad_entrada;
                    //Guardamos la consulta en qry para actualizar la canitdad del producto
                    qry = "UPDATE productos set cantidad=" + totalstock + "where cve_producto='" + this.txtcve_producto.Text + "'";
                    //Asignamos la consulta al comando
                    sqlCMD.CommandText = qry;
                    //Asignamos la conexion al comando
                    sqlCMD.Connection = sqlCNX;
                    //Abrimos la conexion
                    sqlCNX.Open();
                    //Ejecutamos el comando
                    sqlCMD.ExecuteReader();
                    //Cerramos al coenxion
                    sqlCNX.Close();
                    //Limpiamos el txttotal
                    this.txttotal.Clear();
                    //Variables para manipular en el dgvproductos
                    double multiplicacion, cantidad, precio_venta;
                    cantidad = double.Parse(this.txtcantidad.Text);
                    precio_venta = double.Parse(this.txtprecio_venta.Text);
                    multiplicacion = cantidad * precio_venta;
                    //Variable para guardar el total sumado en el dgvProductos
                    double suma = multiplicacion;
                    //Ciclo foreach para sumar el gran total
                    foreach (DataGridViewRow row in dgvproductos.Rows)
                    {
                        suma += Convert.ToDouble(row.Cells["Total"].Value);
                    }
                    //Asignamos los valores a txttotal y a txtgrantotal
                    this.txttotal.Text = Convert.ToString(multiplicacion);
                    this.txtgran_total.Text = Convert.ToString(suma);
                    //Dibujamos la tabla con los valores
                    dgvproductos.Rows.Add(this.txtid_producto.Text, this.txtnombre.Text, this.txtprecio_venta.Text, this.txtcantidad.Text, this.txttotal.Text);
                    this.btncancelar_producto.Enabled = true;
                    this.btnliberar_salida.Enabled = true;
                }
                //}
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al agregar el producto", "Sistema de inventario");
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        void cargar()
        {
            DateTime hoy = DateTime.Now;
            this.lblfecha_registro.Text = hoy.ToString("yyyy-MM-dd");
            this.lblhora_registro.Text = hoy.ToShortTimeString();
            this.txtactivo.Text = "1";
            this.txtcantidad.Text = "1";
            this.cmbfactura.SelectedIndex = 0;
            this.grbSalida.Enabled = true;
            this.grbbuscar_producto.Enabled = false;
            this.btncancelar_salida.Enabled = false;
            this.btnliberar_salida.Enabled = false;
            this.btncancelar_producto.Enabled = false;
            this.btnregistrar_salida.Enabled = true;
            this.txtgran_total.ReadOnly = true;
            this.txtcve_producto.Clear();
            this.txtcantidad.Clear();
            this.txtprecio_venta.Clear();
            this.txtnombre.Clear();
            this.txtgran_total.Clear();
            this.dgvproductos.Rows.Clear();
            this.txtidsalida.Clear();
            this.btnregistrar_salida.Focus();

        }
        void habilitar()
        {
            this.grbSalida.Enabled = false;
            this.grbbuscar_producto.Enabled = true;
            this.btncancelar_salida.Enabled = true;
            this.btnliberar_salida.Enabled = false;
            this.btncancelar_producto.Enabled = false;
            this.btnregistrar_salida.Enabled = false;
            this.txtgran_total.ReadOnly = true;
            this.txtcve_producto.Focus();
        }
        void ComboCaja()
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
                qry = "Select id_caja, numero_caja as Caja from cajas where activo=1";
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
                cmbcaja.DataSource = datos;
                cmbcaja.ValueMember = "id_caja";
                cmbcaja.DisplayMember = "Caja";
                //Variable para usar en autocompletar
                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                foreach (DataRow row in datos.Rows)
                {
                    coleccion.Add(Convert.ToString(row["Caja"]));
                }
                cmbcaja.AutoCompleteCustomSource = coleccion;
                cmbcaja.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbcaja.AutoCompleteSource = AutoCompleteSource.CustomSource;


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al extraer las cajas" + ex.Message.ToString());

            }
        }
        void ComboTrabajador()
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
                qry = "select id_trabajador, CONCAT(p.nombre, ' ', p.apepaterno, ' ',p.apematerno) as persona from trabajadores as t inner join personas as p on t.id_persona = p.id_persona where t.activo = 1";
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
                cmbtrabajador.DataSource = datos;
                cmbtrabajador.ValueMember = "id_trabajador";
                cmbtrabajador.DisplayMember = "persona";
                //Variable para usar en autocompletar
                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                foreach (DataRow row in datos.Rows)
                {
                    coleccion.Add(Convert.ToString(row["persona"]));
                }
                cmbtrabajador.AutoCompleteCustomSource = coleccion;
                cmbtrabajador.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbtrabajador.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al extraer los trabajadores" + ex.Message.ToString());

            }
        }
        void ComboProveedor()
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
                qry = "Select id_proveedor, razon_social as proveedor from proveedores where activo=1";
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
                cmbproveedor.DisplayMember = "proveedor";
                //Variable para usar en autocompletar
                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                foreach (DataRow row in datos.Rows)
                {
                    coleccion.Add(Convert.ToString(row["proveedor"]));
                }
                cmbproveedor.AutoCompleteCustomSource = coleccion;
                cmbproveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbproveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al extraer los proveedores" + ex.Message.ToString());

            }
        }
        private void FrmEntradas_Load(object sender, EventArgs e)
        {
            //seleccionamos el elemento No del combo
            this.cmbfactura.SelectedIndex = 1;
            //variable para extraer la fecha y hora del sistema
            DateTime hoy = DateTime.Now;
            this.lblfecha_registro.Text = hoy.ToString("yyyyMMdd");
            this.lblhora_registro.Text = hoy.ToShortTimeString();
            this.txtactivo.Text = "1";
            this.txtcantidad.Text = "1";
            //Invocamos el metodo cargar
            this.cargar();
            ComboCaja();
            ComboTrabajador();
            ComboProveedor();
        }

        private void Btnregistrar_salida_Click(object sender, EventArgs e)
        {
            //Variable para guardar la consulta
            string qry = "";
            //Variable para extraer la info del appconfig
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            //Variable para conectarnos a la BD
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            //Variable para guardar el comando u objeto
            SqlCommand sqlCMD = new SqlCommand();
            try
            {
                sqlCNX.Close();
                //Guardamos la consulta en qry
                qry = "INSERT INTO entradas(id_caja, id_trabajador, id_proveedor ,factura, total, fecha_registro, hora_registro, activo, id_usuario) VALUES('"+lblid_caja.Text+"', '"+lblid_trabajador.Text+"', '"+lblid_proveedor.Text+"','" + this.cmbfactura.Text + "', '" + this.txttotal.Text + "', '" + this.lblfecha_registro.Text + "', '" + this.lblhora_registro.Text + "', " + this.txtactivo.Text + "," + this.txtidusuario.Text + ")";
                //Asignamos la consulta al comando
                sqlCMD.CommandText = qry;
                //Asignamos la conexion al comando
                sqlCMD.Connection = sqlCNX;
                //Abrimos la conexion
                sqlCNX.Open();
                //ejecutamos el comando
                sqlCMD.ExecuteReader();
                //Cerrar la conexion
                sqlCNX.Close();
                MessageBox.Show("Se a guardado la entrada", "Sistema de inventario");
                this.habilitar();
                this.identrada();



            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error al insertar el articulo", "Sistema de inventario");
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Txtcve_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                //Invocamos el metodo de agregar productos
                this.AgregarProducto();
            }
            validacion.solonumeros(e);
        }

        private void Txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                //Invocamos el metodo de agregar productos
                this.AgregarProducto();
            }
            validacion.solonumeros(e);
        }

        private void Btncancelar_producto_Click(object sender, EventArgs e)
        {
            //Checamos que haya registros en el dgvproductos
            if (dgvproductos.SelectedRows.Count > 0)
            {
                this.txtnombre.Clear();
                this.txtprecio_venta.Clear();
                //Variable para guardar la consulta
                string qry = "";
                //Variable apra extraer la info del appconfig
                string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
                //Variable para conectarnos a la BD
                SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
                //Variable para guardar el comando
                SqlCommand sqlCMD = new SqlCommand();
                //Bloque de codigo para cachar errores con el try and catch
                try
                {
                    //Recordar el dvgproductos para eliminar el producto deseado
                    foreach (DataGridViewRow row in dgvproductos.SelectedRows)

                    {
                        //Variables para guiardar el idproducto y la cantidad del producto
                        int idproducto = Int16.Parse(row.Cells["Id_Producto"].Value.ToString());
                        int cantidad_producto = Int16.Parse(row.Cells["Cantidad"].Value.ToString());


                        //Guardamos la consulta en qry para actualizar el stock en la tabla productos
                        qry = "UPDATE productos set cantidad-=" + (cantidad_producto) + " where id_producto=" + idproducto + "";
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
                        //Variable para actualizar el totalnuevo y el grandtotal
                        int grandtotal = Int16.Parse(this.txtgran_total.Text);
                        int totalproducto = Int16.Parse(row.Cells["Total"].Value.ToString());
                        int nuevototal = grandtotal - totalproducto;
                        this.txtgran_total.Text = nuevototal.ToString();
                        //Finalemente eliminamos el registro del dgvprodcutos
                        dgvproductos.Rows.RemoveAt(row.Index);
                        MessageBox.Show("Se a eliminado el producto del dgvproductos", "Sistema de inventario");

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al eliminar el producto del dvgproductos", "Sistema de inventario");
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Debes selecionar cuando menos un producto", "Sistema De Inventario");
            }
        }

        private void Btnliberar_salida_Click(object sender, EventArgs e)
        {
            //Validad que el dgvproductos tenga registros
            if (dgvproductos.Rows.Count > 0)
            {
                //Variable para guardar consulta
                string qry = "";
                //Variable para extraer la info del appconfig
                string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
                //Variable para conectarnos a la BD
                SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
                //Variable para guardar el comando
                SqlCommand sqlCMD = new SqlCommand();
                //Bloque de codigo para cachar errores
                try
                {
                    //Variable para apntar al idsalida
                    int id_entrada = Int16.Parse(this.txtidsalida.Text);
                    //Ciclo para leer todos los registros del dgvproductos e insertarlos en la tabla detalle_entrada
                    foreach (DataGridViewRow row in dgvproductos.Rows)
                    {
                        //Variables para guiardar el idproducto y la cantidad del producto
                        int idproducto = Int16.Parse(row.Cells["Id_producto"].Value.ToString());
                        int cantidad_producto = Int16.Parse(row.Cells["Cantidad"].Value.ToString());
                        //Guardamos la consulta en qry para insertar los datos en detalle entrada
                        qry = "INSERT INTO detalle_entrada(id_entrada, id_producto, precio_compra, cantidad, fecha_registro, hora_registro, activo, id_usuario) VALUES('" + id_entrada + "', '" + idproducto + "', '" + row.Cells["Precio_Venta"].Value.ToString() + "', '" + cantidad_producto + "', '" + this.lblfecha_registro.Text + "', '" + this.lblhora_registro.Text + "', '" + this.txtactivo.Text + "', '" + this.txtidusuario.Text + "')";
                        //Asignamos la consulta al comando
                        sqlCMD.CommandText = qry;
                        //Asginamos la conexion al comando
                        sqlCMD.Connection = sqlCNX;
                        //Abrimos la conexion
                        sqlCNX.Open();
                        //Ejecutamos el comando
                        sqlCMD.ExecuteReader();
                        //Cerramos la conexion
                        sqlCNX.Close();

                    }
                    //Consulta para actualizar el total de la tabla entradas
                    qry = "UPDATE entradas SET total=" + this.txtgran_total.Text + " where id_entrada=" + id_entrada + "";
                    //Asignamos la consulta al comando
                    sqlCMD.CommandText = qry;
                    //Asginamos la conexion al comando
                    sqlCMD.Connection = sqlCNX;
                    //Abrimos la conexion
                    sqlCNX.Open();
                    //Ejecutamos el comando
                    sqlCMD.ExecuteReader();
                    //Cerramos la conexion
                    sqlCNX.Close();
                    //Invocamos el metodo cargar
                    cargar();
                    MessageBox.Show("Se a liberado la entrada", "Sistema de inventario");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al liberar la entrada", "Sistema de inventario");
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("No hay productos en esta entrada", "Sistema de inventario");
            }
        }

        private void Btncancelar_salida_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Deseas cancelar la entrada ", "Sistema de inventario", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                //Variable para guardar consulta
                string qry = "";
                //Variable para extraer la info del appconfig
                string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
                //Variable para conectarnos a la BD
                SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
                //Variable para guardar el comando
                SqlCommand sqlCMD = new SqlCommand();
                //Bloque de codigo para cachar errores
                try
                {
                    //Variable para apntar al idsalida
                    int id_entrada = Int16.Parse(this.txtidsalida.Text);
                    //Ciclo para leer todos los registros del dgvproductos e insertarlos en la tabla detalle_salida
                    if (this.dgvproductos.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dgvproductos.Rows)
                        {
                            //Variables para guiardar el idproducto y la cantidad del producto
                            int idproducto = Int16.Parse(row.Cells["Id_producto"].Value.ToString());
                            int cantidad_producto = Int16.Parse(row.Cells["Cantidad"].Value.ToString());
                            //Actualizamos la cantidad del producto correspondiente a cada idproducto
                            qry = "UPDATE productos SET cantidad -=" + cantidad_producto + "where id_producto =" + idproducto + "";
                            //Asignamos la consulta al comando
                            sqlCMD.CommandText = qry;
                            //Asginamos la conexion al comando
                            sqlCMD.Connection = sqlCNX;
                            //Abrimos la conexion
                            sqlCNX.Open();
                            //Ejecutamos el comando
                            sqlCMD.ExecuteReader();
                            //Cerramos la conexion
                            sqlCNX.Close();

                        }
                    }
                    //Borramos la salida creada de la tabla dwe salidas
                    qry = "DELETE from entradas where id_entrada =" + this.txtidsalida.Text + "";
                    //Asignamos la consulta al comando
                    sqlCMD.CommandText = qry;
                    //Asginamos la conexion al comando
                    sqlCMD.Connection = sqlCNX;
                    //Abrimos la conexion
                    sqlCNX.Open();
                    //Ejecutamos el comando
                    sqlCMD.ExecuteReader();
                    //Cerramos la conexion
                    sqlCNX.Close();
                    //Invocamos el metodo cargar
                    cargar();
                    MessageBox.Show("Se a eliminado la entrada con sus detalles", "Sistema de inventario");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al liberar la entrada", "Sistema de inventario");
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else if (respuesta == DialogResult.No)
            {
                return;
            }
        }

        private void Txtcve_producto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtcve_producto.Text.Length == 0)
                {
                    MessageBox.Show("Porfavor llenar el campo clave producto:)", "ComponentesPC");
                    this.txtcve_producto.Focus();
                    return;
                }
                this.txtcantidad.Focus();
            }
        }

        private void Txtcantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtcantidad.Text.Length == 0)
                {
                    MessageBox.Show("Porfavor llenar el campo cantidad:)", "ComponentesPC");
                    this.txtcantidad.Focus();
                    return;
                }

            }
        }

        private void Cmbcaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblid_caja.Text = cmbcaja.SelectedValue.ToString();
        }

        private void Cmbtrabajador_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblid_trabajador.Text = cmbtrabajador.SelectedValue.ToString();
        }

        private void Cmbcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblid_proveedor.Text = cmbproveedor.SelectedValue.ToString();
        }

        private void txttotal_Enter(object sender, EventArgs e)
        {
            focustotal.LineColor = Color.FromArgb(67, 83, 192);
        }

        private void txttotal_Leave(object sender, EventArgs e)
        {
            focustotal.LineColor = Color.White;
        }

        private void focustotal_Enter(object sender, EventArgs e)
        {
            txttotal.Focus();
        }

        private void txtcve_producto_Enter(object sender, EventArgs e)
        {
            focusClave.LineColor = Color.FromArgb(67, 83, 192);
        }

        private void txtcve_producto_Leave(object sender, EventArgs e)
        {
            focusClave.LineColor = Color.White;

        }

        private void focusClave_Enter(object sender, EventArgs e)
        {
            txtcve_producto.Focus();
        }

        private void txtcantidad_Enter(object sender, EventArgs e)
        {
            focusCant.LineColor = Color.FromArgb(67, 83, 192);
        }

        private void txtcantidad_Leave(object sender, EventArgs e)
        {
            focusCant.LineColor = Color.White;
        }

        private void focusCant_Enter(object sender, EventArgs e)
        {
            txtcantidad.Focus();
        }

        private void txtnombre_Enter(object sender, EventArgs e)
        {
            focusNom.LineColor = Color.FromArgb(67, 83, 192);
        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            focusNom.LineColor = Color.White;
        }

        private void focusNom_Enter(object sender, EventArgs e)
        {
            txtnombre.Focus();
        }

        private void txtprecio_venta_Enter(object sender, EventArgs e)
        {
            foucuspre.LineColor = Color.FromArgb(67, 83, 192);

        }

        private void txtprecio_venta_Leave(object sender, EventArgs e)
        {
            foucuspre.LineColor = Color.White;
        }

        private void gunaLineTextBox1_Enter(object sender, EventArgs e)
        {
            txtprecio_venta.Focus();
        }
        private void txtgran_total_Enter(object sender, EventArgs e)
        {
            focusgran.LineColor = Color.FromArgb(67, 83, 192);

        }

        private void txtgran_total_Leave(object sender, EventArgs e)
        {
            focusgran.LineColor = Color.White;

        }

        private void focusgran_Enter(object sender, EventArgs e)
        {
            txtgran_total.Focus();
        }
        public static bool frmSelecProductosEntradasAbierto = false;
        private void txtBuscar_Click(object sender, EventArgs e)
        {
            if (!frmSelecProductosEntradasAbierto)
            {
                frmSelecProductosEntradasAbierto = true;
                frmSelecProducto frmSelecProducto = new frmSelecProducto("entrada");
                frmSelecProducto.Show();
            }
        }
    }
}
