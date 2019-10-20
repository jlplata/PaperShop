using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperShop
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }
        int activo = 1;

        void Actualizar()
        {
            btnCancelar.Enabled = true;
            btNuevo.Enabled = false;
            btnModificar.Enabled = true;
            btnGuardar.Enabled = false;
            grppro.Enabled = true;
            txtIdUsuario.Text = FrmPrin.id;
        }

        void Cargar()
        {
            grppro.Enabled = false;
            btnCancelar.Enabled = true;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;
            btNuevo.Enabled = true;
            btNuevo.Focus();
            Activos.Checked = true;
            DateTime hoy = DateTime.Now;
            lblFechaRegistro.Text = hoy.ToString("yyyyMMdd");
            lblHoraRegistro.Text = hoy.ToShortTimeString();
        }

        void Nuevo()
        {
            grppro.Enabled = true;
            btnCancelar.Enabled = true;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            btNuevo.Enabled = false;
            Activos.Checked = true;
            txtActivo.Text = "1";
            txtIdUsuario.Text = FrmPrin.id;

        }

        void Cancelar()
        {
            Cargar();
            txtNombre.Text="";
            txtDomicilio.Text="";
            txtTelefono.Text="";
            txtCorreo.Text="";
            txtActivo.Text = "1";
            txtIdUsuario.Text = FrmPrin.id;
        }

        void GridPro(int activo)
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
                qry = "SELECT * FROM VistaPro where razon_social like '%" + txtBuscar.Text + "%' AND activo='" + activo + "'";
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
                dgvpro.DataSource = datos;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al llenar el dgvSucursales! " + ex.Message.ToString(), "SI");
            }
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {

            this.Cargar();
            GridPro(1);
        }

        private void Btnnuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            string qry = "";
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            SqlCommand sqlCMD = new SqlCommand();
            try
            {

                qry = "SELECT * FROM proveedores WHERE razon_social= '" + txtNombre.Text + "'";
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;

                SqlDataReader sqlDR = null;
                sqlCNX.Open();
                sqlDR = sqlCMD.ExecuteReader();
                if (sqlDR.HasRows)
                {
                    sqlCNX.Close();
                    MensajeOk mm = new MensajeOk();
                    mm.lbltxt.Text = "Ya existe un Proveedor con ese nombre";
                    mm.ShowDialog();

                }
                else
                {
                    sqlCNX.Close();
                    //Insertamos o guardamos la persona en la BD
                    qry = "INSERT INTO proveedores(razon_social, domicilio, telefono, correo, fecha_registro, hora_registro, activo, id_usuario) " +
                    "VALUES ('" + txtNombre.Text + "', '" + txtDomicilio.Text + "', '" + txtTelefono.Text + "', '"+txtCorreo.Text+"' ,'" + lblFechaRegistro.Text + "','"+lblHoraRegistro.Text+"', '" + txtActivo.Text + "', '" + FrmPrin.id + "')";

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

                    MensajeOk mm = new MensajeOk();
                    mm.lbltxt.Text = "Proveedor registrada";
                    mm.ShowDialog();
                    Cargar();
                    //Invocamos el método cancelar
                    Cancelar();
                    GridPro(1);
                }
            }
            catch (SqlException ex)
            {

                //MensajeOk mm = new MensajeOk();
                //mm.label2.Text = "Error al agregar el Proveedor, Base de Datos";
                //mm.lblx.Text = ""+ex;
                //mm.ShowDialog();
                MessageBox.Show(" "+ex,"Error");
            }
        }

        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            string qry = "";
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            SqlCommand sqlCMD = new SqlCommand();
            SqlDataReader sqlDR;

            try
            {
                int idpro = Int16.Parse(dgvpro.CurrentRow.Cells["id_proveedor"].Value.ToString());
                qry = "SELECT * FROM proveedores WHERE razon_social = '" + txtNombre.Text + "' AND id_proveedor !=" + Convert.ToInt16(dgvpro.CurrentRow.Cells["id_proveedor"].Value.ToString());
                sqlCMD.CommandText = qry;
                sqlCMD.Connection = sqlCNX;

                sqlCNX.Open();
                sqlDR = sqlCMD.ExecuteReader();
                if (sqlDR.HasRows)
                {
                    sqlCNX.Close();
                    MensajeOk mm = new MensajeOk();
                    mm.lbltxt.Text = "Ya existe un Proveedor con ese nombre";
                    mm.ShowDialog();
                }
                else
                {
                    sqlCNX.Close();
                    //Insertamos o guardamos la persona en la BD
                    qry = "UPDATE proveedores SET razon_social='" + txtNombre.Text + "',  domicilio='" + txtDomicilio.Text + "', telefono ='"+txtTelefono.Text+"',correo = '"+txtCorreo.Text+"' , fecha_registro='" + lblFechaRegistro.Text + "', hora_registro='" + lblHoraRegistro.Text + "', id_usuario='" + FrmPrin.id + "' WHERE id_proveedor=" + idpro;

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
                    MensajeOk mm = new MensajeOk();
                    mm.lbltxt.Text = "Proveedor modificado con exito";
                    mm.ShowDialog();

                    //Invocamos al método cargar
                    Cargar();
                    //Invocamos el método cancelar
                    Cancelar();

                    GridPro(1);
                }
            }
            catch (SqlException ex)
            {
                MensajeOk mm = new MensajeOk();
                mm.lbltxt.Text = "Error al modificar el Proveedor, Base de Datos";
                mm.lblx.Text = "" + ex;
                mm.ShowDialog();
            }
        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            GridPro(activo);
        }

        private void Rdbinactivo_CheckedChanged(object sender, EventArgs e)
        {
            activo = 0;
            GridPro(activo);
        }

        private void Rdbactivo_CheckedChanged(object sender, EventArgs e)
        {
            activo = 1;
            GridPro(activo);
        }

        private void McSucursales_Opening(object sender, CancelEventArgs e)
        {
            if (dgvpro.Rows.Count > 0 && Activos.Checked == true)
            {

                btnModificarPro.Visible = true;
                btnDesactivarPro.Visible = true;
                btnActivarPro.Visible = false;

            }
            else if (dgvpro.Rows.Count <= 0 && Activos.Checked == true)
            {
                btnModificarPro.Visible = false;
                btnDesactivarPro.Visible = false;
                btnActivarPro.Visible = false;
            }
            else if (dgvpro.Rows.Count > 0 && Activos.Checked == true)
            {
                btnModificarPro.Visible = false;
                btnDesactivarPro.Visible = false;
                btnActivarPro.Visible = true;
            }
            else if (dgvpro.Rows.Count <= 0 && Activos.Checked == true)
            {
                btnModificarPro.Visible = false;
                btnDesactivarPro.Visible = false;
                btnActivarPro.Visible = false;
            }
        }

        private void TxtRznSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void Txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        validacion v = new validacion();
        private void Txtcorreo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtCorreo.Text.Length == 0) || (v.validarcorr(txtCorreo.Text) == true))
                {
                    MessageBox.Show("El campo se encuentra vacio o el formato no es correcto", "");
                    txtCorreo.Focus();
                    return;
                }
                btnGuardar.Focus();
            }
        }

        private void TxtRznSocial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNombre.Text.Length == 0 )
                {
                    MensajeOk ok = new MensajeOk();
                    ok.lbltxt.Text = "El campo se encuentra vacio o el fromato no es correcto";
                    txtNombre.Focus();
                    return;
                }
                txtDomicilio.Focus();
            }
        }

        private void Txtdomicilio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtDomicilio.Text.Length == 0)
                {
                    MensajeOk ok = new MensajeOk();
                    ok.lbltxt.Text = "El campo se encuentra vacio o el fromato no es correcto";
                    txtDomicilio.Focus();
                    return;
                }
                txtTelefono.Focus();
            }
        }

        private void BtnDesactivarPro_Click(object sender, EventArgs e)
        {
            string idpersona = dgvpro.CurrentRow.Cells["id_persona"].Value.ToString();
            //Consulta
            string qry;
            //Extrae la configuración del appconfig
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");

            //Conecta a la BD
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            //Guarda el objeto o comando
            SqlCommand sqlCMD = new SqlCommand();
            //Insertamos o guardamos la persona en la BD
            qry = "UPDATE proveedores SET activo=0 WHERE id_persona=" + idpersona;

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


                GridPro(0);
                Activos.Checked = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnActivarPro_Click(object sender, EventArgs e)
        {
            string idpersona = dgvpro.CurrentRow.Cells["id_persona"].Value.ToString();
            //Consulta
            string qry;
            //Extrae la configuración del appconfig
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");

            //Conecta a la BD
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            //Guarda el objeto o comando
            SqlCommand sqlCMD = new SqlCommand();
            //Insertamos o guardamos la persona en la BD
            qry = "UPDATE personas SET activo=1 WHERE id_persona=" + idpersona;

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


                GridPro(1);
                Activos.Checked = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnModificarPro_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombre.Text = dgvpro.CurrentRow.Cells["razon_social"].Value.ToString();
                txtDomicilio.Text = dgvpro.CurrentRow.Cells["domicilio"].Value.ToString();
                txtTelefono.Text = dgvpro.CurrentRow.Cells["telefono"].Value.ToString();
                txtCorreo.Text = dgvpro.CurrentRow.Cells["correo"].Value.ToString();

                lblFechaRegistro.Text = dgvpro.CurrentRow.Cells["fecha_registro"].Value.ToString();
                lblHoraRegistro.Text = dgvpro.CurrentRow.Cells["hora_registro"].Value.ToString();
                txtActivo.Text = dgvpro.CurrentRow.Cells["activo"].Value.ToString();

                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            FocusNombre.LineColor = Color.FromArgb(100, 88, 255);
        }
        private void FocusNombre_Enter(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            FocusNombre.LineColor = Color.White;
        }
        private void txtDomicilio_Enter(object sender, EventArgs e)
        {
            focusDomicilio.LineColor = Color.FromArgb(100, 88, 255);
        }
        private void focusDomicilio_Enter(object sender, EventArgs e)
        {
            txtDomicilio.Focus();
        }
        private void txtDomicilio_Leave(object sender, EventArgs e)
        {
            focusDomicilio.LineColor = Color.White;
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            focusCorreo.LineColor = Color.FromArgb(100, 88, 255);
        }
        private void focusCorreo_Enter(object sender, EventArgs e)
        {
            txtCorreo.Focus();
        }
        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            focusCorreo.LineColor = Color.White;

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

        private void Activos_CheckedChanged(object sender, EventArgs e)
        {
            if (Activos.Checked == true)
            {

                activo = 1;
                GridPro(activo);
                lblActi.Text = "Activos";
            }
            else if (Activos.Checked == false)
            {
                activo = 0;
                GridPro(activo);
                lblActi.Text = "Inactivos";
            }
        }
    }
}
