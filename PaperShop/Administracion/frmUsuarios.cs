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
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Net;
using PaperShop.Administracion;

namespace PaperShop
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
            txtIdUsuario.Text = FrmPrin.id;
        }
        validacion v = new validacion();

        string diro,dir;
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
                        qry = "Select imagen from usuarios where imagen = '\\ima\\" + inarchivo + "'";
                        sqlcmd.CommandText = qry;
                        sqlcmd.Connection = sqlcnx;
                        SqlDataReader DR = null;
                        sqlcnx.Open();
                        DR = sqlcmd.ExecuteReader();
                        if (DR.HasRows == true)
                        {
                            MensajeOk mm = new MensajeOk();
                            mm.lbltxt.Text = "Un usuario ya tiene esa imagen \n intentelo de nuevo";
                            mm.ShowDialog();
                            sqlcnx.Close();
                        }
                        else
                        {
                            string archivo = System.IO.Path.GetFileName(ofd.FileName);
                            diro = ofd.FileName;
                            dir = "\\ima\\" + archivo;
                            imgUser.Load(ofd.FileName);
                            imgUser.Refresh();
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Nose pudo" + ex, "Error");
            }

        }


        //Metodo para llenar el combo personas
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
                MessageBox.Show("Error al extraer las personas" + ex.Message.ToString());

            }
        }
        void GridUsuarios(int activo)
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
                 qry = "Select * From VistaUsuarios WHERE personas like '%" + txtBuscar.Text + "%' AND activo='" + activo + "'";

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
                dgvusuarios.DataSource = datos;
               

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al llenar el dgvUsuarios!" + ex.Message.ToString() + "SI");

            }
        }
        void Actualizar()
        {
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = true;
            btnGuardar.Enabled = false;
            grbusuarios.Enabled = true;
            txtIdUsuario.Text = FrmPrin.id;
            imgUser.Refresh();
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
            txtIdUsuario.Text = FrmPrin.id;
            
            string pach = ".\\.\\";
            imgUser.Image = Image.FromFile(pach + "\\ima\\user.png");

            //asignamos la fecha y hora a los lbls corresponientes
            DateTime hoy = DateTime.Now;
            lblfecharegistro.Text = hoy.ToString("yyyyMMdd");
            lblhoraregistro.Text = hoy.ToShortTimeString();
            //En caso de marcar error en la fecha
            //lblfecharegistro.text = hoy.ToString("yyyyMMdd");

        }
        void Nuevo()
        {
            grbusuarios.Enabled = true;
            btnCancelar.Enabled = true;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
            cmbpersonas.Focus();
            Activos.Checked = true;
            txtActivo.Text = "1";
            txtIdUsuario.Text = FrmPrin.id;
            
            string pach = ".\\.\\";
            imgUser.Image = Image.FromFile(pach + "\\ima\\user.png");
        }
        void Cancelar()
        {
            dir = null;
            diro = null;
            Cargar();
            cmbpersonas.SelectedIndex = 0;
            txtlogin.Clear();
            txtpassword.Clear();
            cmbtipo.SelectedIndex = 0;
            txtActivo.Text = "";
            txtIdUsuario.Text = "";
            
            string pach = ".\\.\\";
            imgUser.Image = Image.FromFile(pach + "\\ima\\user.png");
            pp.Clear();
        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            ComboPersonas();
            GridUsuarios(1);
            Cargar();

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

        private void Cmbpersonas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.cmbpersonas.Text.Length == 0)
                {
                    MensajeOk ok = new MensajeOk();
                    ok.lbltxt.Text = "Favor de llenar el campo.";
                    ok.ShowDialog();
                    this.cmbpersonas.Focus();
                    return;
                }
                this.txtlogin.Focus();
            }
        }

        private void Txtlogin_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtlogin.Text.Length == 0)
                {
                    MensajeOk ok = new MensajeOk();
                    ok.lbltxt.Text = "Favor de llenar el campo.";
                    ok.ShowDialog();
                    
                    this.txtlogin.Focus();
                    return;
                }
                this.txtpassword.Focus();
            }
        }

        private void Txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtpassword.Text.Length == 0)
                {
                    MensajeOk ok = new MensajeOk();
                    ok.lbltxt.Text = "Favor de llenar el campo.";
                    ok.ShowDialog();
                    this.txtpassword.Focus();
                    return;
                }
                this.cmbtipo.Focus();
            }
        }

        private void Cmbtipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.cmbtipo.Text.Length == 0)
                {
                    MensajeOk ok = new MensajeOk();
                    ok.lbltxt.Text = "Favor de llenar el campo.";
                    ok.ShowDialog();
                    this.cmbtipo.Focus();
                    return;
                }
                this.txtActivo.Focus();
            }
        }

        private void Txtactivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtActivo.Text.Length == 0)
                {
                    MensajeOk ok = new MensajeOk();
                    ok.lbltxt.Text = "Favor de llenar el campo.";
                    ok.ShowDialog();
                    this.txtActivo.Focus();
                    return;
                }
                this.txtIdUsuario.Focus();
            }
        }

        private void Txtidusuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtIdUsuario.Text.Length == 0)
                {
                    MensajeOk ok = new MensajeOk();
                    ok.lbltxt.Text = "Favor de llenar el campo.";
                    ok.ShowDialog();
                    this.txtIdUsuario.Focus();
                    return;
                }
                this.btnGuardar.Focus();
            }
        }

        private void Cmbpersonas_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Txtactivo_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void valdacionLetras(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }
        private void Txtidusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
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
               

                    qry = "SELECT login from usuarios where tipo = '" + cmbtipo.Text + "' and (id_persona= '" + lblid_persona.Text + "' or login= '" + txtlogin.Text + "')";
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

                        MensajeOk im = new MensajeOk();
                        im.lbltxt.Text = "Ya hay una persona con ese login y tipo";
                        im.ShowDialog();
                        this.btnagregar.Focus();
                        txtlogin.Clear();
                        txtlogin.Focus();
                        //Cerramos la conexion
                        sqlCNX.Close();
                    }
                    else
                    {
                        if (dir == null)
                            {
                                Random r = new Random();
                                int idc = r.Next(00000001, 99999999);
                                dir = "\\ima\\user"+idc+".png";
                                diro = "\\ima\\user.png";
                                
            string pach = ".\\.\\";
                                System.IO.File.Copy(pach + diro, pach + dir);
                            }
                            else
                            {
                                
            string pach = ".\\.\\";
                                System.IO.File.Copy( diro, pach + dir);
                            }

                 
                        

                    //Volvemos a cerrar la conexion
                    sqlCNX.Close();
                        //string imagen = openFileDialog1.FileName;
                        //pictureBox1.Image = Image.FromFile(imagen);
                        //Insertamos o guardamos la persona en la BD
                        qry = "INSERT INTO usuarios(id_persona, login, password, tipo, fecha_registro, hora_registro, activo, id_user, imagen)" +
                        "VALUES('" + lblid_persona.Text + "', '" + txtlogin.Text + "', '" + txtpassword.Text + "', '" + cmbtipo.Text + "', '" + lblfecharegistro.Text + "', '" + lblhoraregistro.Text + "', '" + txtActivo.Text + "', '" + txtIdUsuario.Text + "', '" + dir + "')";
                        //Codigo para guardar la imagen 
                        //MemoryStream stream = new MemoryStream();
                        //pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        //byte[] pic = stream.ToArray();
                        //sqlCMD.Parameters.AddWithValue("@imagen", pic);
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


                    this.Alert("Usuario Registrado!", FrmNotificaciones.alertTypeEnum.Success);

                    //Invocamos el metodo cancelar
                    imgUser.Image = null;
                        this.Cancelar();
                        GridUsuarios(1);


                    }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("" + ex, "SI");
            }
            //Fin del codigo guardar
        }
        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            if (dir == null)
            {
                dir = pp.Text;
            }
            else
            { imgUser.Refresh();
                string pach = ".\\.\\";
                System.IO.File.Delete(pach + pp.Text);
                System.IO.File.Copy(diro, pach + dir);


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
               
                   
                        //Volvemos a cerrar la conexion
                        sqlCNX.Close();
                    //Insertamos o guardamos la persona en la BD
                    qry = "UPDATE usuarios set id_persona='" + lblid_persona.Text + "', login='" + txtlogin.Text + "', password='" + txtpassword.Text + "', tipo='" + cmbtipo.Text + "', fecha_registro='" + lblfecharegistro.Text + "', hora_registro='" + lblhoraregistro.Text + "', activo='" + txtActivo.Text + "', id_user='" + txtIdUsuario.Text + "', imagen= '" + dir + "' where id_usuario = " + Convert.ToInt16(dgvusuarios.CurrentRow.Cells["id_usuario"].Value.ToString()) + "";
                    //System.IO.MemoryStream stream = new System.IO.MemoryStream();
                    //byte[] pic = stream.ToArray();
                    //pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //sqlCMD.Parameters.AddWithValue("@imagen", pic);
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
                this.Alert("Usuario Modificado!", FrmNotificaciones.alertTypeEnum.Success);

                //Invocamos el metodo cancelar
                this.Cargar();
                    this.GridUsuarios(1);
                    this.Cancelar();
                
                   
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al modificar el usuario!", "SI" + ex.Message.ToString());
            }

            

            //Fin codigo modificar
        }

        private void Mcusuarios_Opening(object sender, CancelEventArgs e)
        {

            if (dgvusuarios.Rows.Count > 0 && Activos.Checked == true && dgvusuarios.CurrentRow.Cells[0].Value.ToString() == txtIdUsuario.Text)
            {
                modificarToolStripMenuItem.Visible = true;
                activarToolStripMenuItem.Visible = false;
                desactivarToolStripMenuItem.Visible = false;
                cmbtipo.Enabled = false;
            }
            else if (dgvusuarios.Rows.Count > 0 && Activos.Checked == true && dgvusuarios.CurrentRow.Cells[0].Value.ToString() != txtIdUsuario.Text)
            {
                modificarToolStripMenuItem.Visible = true;
                activarToolStripMenuItem.Visible = false;
                desactivarToolStripMenuItem.Visible = true;
                cmbtipo.Enabled = true;
            }
            else if (dgvusuarios.Rows.Count > 0 && Activos.Checked == false)
            {
                modificarToolStripMenuItem.Visible = false;
                activarToolStripMenuItem.Visible = true;
                desactivarToolStripMenuItem.Visible = false;
            }
            else if (dgvusuarios.Rows.Count <= 0 && Activos.Checked == false)
            {
                modificarToolStripMenuItem.Visible = false;
                activarToolStripMenuItem.Visible = false;
                desactivarToolStripMenuItem.Visible = false;
            }

        }

        private void ModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text == dgvusuarios.CurrentRow.Cells["id_usuario"].Value.ToString())
            {
                MensajeOk no = new MensajeOk();
                no.lbltxt.Text = "No se puede modificar \n la imagen de este usuario";
                no.ShowDialog();
                btnagregar.Text = "Cambiar";
                cmbpersonas.Text = dgvusuarios.CurrentRow.Cells["personas"].Value.ToString();
                txtlogin.Text = dgvusuarios.CurrentRow.Cells["usuario"].Value.ToString();
                txtpassword.Text = dgvusuarios.CurrentRow.Cells["password"].Value.ToString();
                cmbtipo.Text = dgvusuarios.CurrentRow.Cells["tipo"].Value.ToString();
                txtActivo.Text = dgvusuarios.CurrentRow.Cells["activo"].Value.ToString();
                txtIdUsuario.Text = dgvusuarios.CurrentRow.Cells["id_user"].Value.ToString();
                pp.Text = dgvusuarios.CurrentRow.Cells["imagen"].Value.ToString();
                
            string pach = ".\\.\\";
                imgUser.Load(pach + pp.Text);
                btnagregar.Enabled = false;
                btnagregar.Text = "Cambiar";
                this.Actualizar();
            }
            else
            {
                btnagregar.Text = "Cambiar";
                cmbpersonas.Text = dgvusuarios.CurrentRow.Cells["personas"].Value.ToString();
                txtlogin.Text = dgvusuarios.CurrentRow.Cells["usuario"].Value.ToString();
                txtpassword.Text = dgvusuarios.CurrentRow.Cells["password"].Value.ToString();
                cmbtipo.Text = dgvusuarios.CurrentRow.Cells["tipo"].Value.ToString();
                txtActivo.Text = dgvusuarios.CurrentRow.Cells["activo"].Value.ToString();
                txtIdUsuario.Text = dgvusuarios.CurrentRow.Cells["id_user"].Value.ToString();
                pp.Text = dgvusuarios.CurrentRow.Cells["imagen"].Value.ToString();
                
            string pach = ".\\.\\";
                imgUser.Load(pach + pp.Text);
                this.Actualizar();
            }
            
        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.GridUsuarios(activo);
        }

        private void ActivarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Consulta
            string qry;
            //Extrae la configuracion del appconfig
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            //conectar a la BD
            SqlConnection sqlcnx = new SqlConnection(cadenaconexion);
            //guarda el objeto o comando
            SqlCommand sqlcmd = new SqlCommand();

            try
            {
                    //Insertamos o guardamos la persona 
                    qry = "UPDATE usuarios set activo = 1 where id_usuario = '" + dgvusuarios.CurrentRow.Cells[0].Value.ToString() + "'";
                    //asignamos a consulta al cmd
                    sqlcmd.CommandText = qry;
                    //asignamos la coneccion
                    sqlcmd.Connection = sqlcnx;
                    //abrimos la conexion
                    sqlcnx.Open();
                    //ejecutamso el comando
                    sqlcmd.ExecuteReader();
                    //cerramos conexion
                    sqlcnx.Close();

                    this.Alert("Usuario activado!", FrmNotificaciones.alertTypeEnum.Success);


                    //MessageBox.Show("Persona desactivada", "Si");
                    GridUsuarios(1);

                    //invocamos el metodo cargar
                    Cancelar();
                


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al modificar la persona" + ex, "Si");
            }
        }

        private void DesactivarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Consulta
            string qry;
            //Extrae la configuracion del appconfig
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            //conectar a la BD
            SqlConnection sqlcnx = new SqlConnection(cadenaconexion);
            //guarda el objeto o comando
            SqlCommand sqlcmd = new SqlCommand();

            try
            {
                    //Insertamos o guardamos la persona 
                    qry = "UPDATE usuarios set activo = 0 where id_usuario = '" + dgvusuarios.CurrentRow.Cells[0].Value.ToString() + "'";
                    //asignamos a consulta al cmd
                    sqlcmd.CommandText = qry;
                    //asignamos la coneccion
                    sqlcmd.Connection = sqlcnx;
                    //abrimos la conexion
                    sqlcnx.Open();
                    //ejecutamso el comando
                    sqlcmd.ExecuteReader();
                    //cerramos conexion
                    sqlcnx.Close();

                this.Alert("Usuario desactivada!", FrmNotificaciones.alertTypeEnum.Success);


                //MessageBox.Show("Persona desactivada", "Si");
                GridUsuarios(0);

                    //invocamos el metodo cargar
                    Cancelar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al modificar la persona" + ex, "Si");
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
                //Consulta para extraer los datos de las personas
                qry = "Select * From Usuarios";
                //Asignamos la consulta al comando
                sqlCMD.CommandText = qry;
                //Asignamos la conexion al comando
                sqlCMD.Connection = sqlCNX;
                //Abrimos la conexion
                sqlCNX.Open();
                //Variable para el adaptador
                SqlDataAdapter adaptador = new SqlDataAdapter(sqlCMD);
                //Variable para crear la tabla
                
                ReporUsua datos = new ReporUsua();
                //Llenamos la tabla
                adaptador.Fill(datos, "Usuarios");

                foreach (DataRow row in datos.Tables[0].Rows)
                {
                    
            string pach = ".\\.\\";

                    var webClient = new WebClient();
                    byte[] imageBytes = webClient.DownloadData(pach + row["imagen"].ToString());
                    
                    row["dire"] = imageBytes;

                }



                //Cerramos la conexion
                sqlCNX.Close();
                //Creamos el objeto del reporte para las personas
                ReporUsuario reporte = new ReporUsuario();
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

        private void txtlogin_Enter(object sender, EventArgs e)
        {
            focuslogin.LineColor = Color.FromArgb(100, 88, 255);
        }

        private void focuslogin_Enter(object sender, EventArgs e)
        {
            txtlogin.Focus();
        }

        private void txtlogin_Leave(object sender, EventArgs e)
        {
            focuslogin.LineColor = Color.White;

        }

        private void cmbpersonas_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            cmbpersonas.DroppedDown = true;
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            string str = cmbpersonas.Text.Substring(0, cmbpersonas.SelectionStart) + e.KeyChar;
            Int32 index = cmbpersonas.FindStringExact(str);
            if (index == -1)
            {
                index = cmbpersonas.FindString(str);
            }
            this.cmbpersonas.SelectedIndex = index;
            this.cmbpersonas.SelectionStart = str.Length;
            this.cmbpersonas.SelectionLength = this.cmbpersonas.Text.Length - this.cmbpersonas.SelectionStart;
            e.Handled = true;
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            focuspass.LineColor = Color.FromArgb(100, 88, 255);
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            focuspass.LineColor = Color.White;
        }
        private void focuspass_Enter(object sender, EventArgs e)
        {
            txtpassword.Focus();
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
        int activo;
        private void Activos_CheckedChanged(object sender, EventArgs e)
        {

            if (Activos.Checked == true)
            {

                activo = 1;
                GridUsuarios(activo);
                lblActi.Text = "Activos";
            }
            else if (Activos.Checked == false)
            {
                activo = 0;
                GridUsuarios(activo);
                lblActi.Text = "Inactivos";
            }
        }

        private void cmbtipo_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.cmbtipo.Text.Length == 0)
                {
                    MensajeOk ok = new MensajeOk();
                    ok.lbltxt.Text = "Favor de llenar el campo.";
                    ok.ShowDialog();
                    this.cmbtipo.Focus();
                    return;
                }
                this.btnGuardar.Focus();
            }
        }

        private void cmbpersonas_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.cmbpersonas.Text.Length == 0)
                {
                    MensajeOk ok = new MensajeOk();
                    ok.lbltxt.Text = "Favor de llenar el campo.";
                    ok.ShowDialog();
                    this.cmbpersonas.Focus();
                    return;
                }
                this.txtlogin.Focus();
            }
        }

        private void focuspass_FontChanged(object sender, EventArgs e)
        {

        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}