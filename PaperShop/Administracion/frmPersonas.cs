using System;
using System.ComponentModel;
//Librerías para acceder al appconfig
using System.Configuration;
using System.Data;
//Librerías para acceder el cliente de la BD
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace PaperShop
{
    public partial class frmPersonas : Form
    {
        public frmPersonas()
        {
            InitializeComponent();
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //SetStyle(ControlStyles.UserPaint, true);
            //SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //SetStyle(ControlStyles.DoubleBuffer, true);
            //InitializeComponent();
            //typeof(Panel).InvokeMember("DoubleBuffered",
            //BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            //null, grbPersonas, new object[] { true });
        }


        //IDEA COLORES 




        //Método cargar
        void Cargar()
        {
            grbPersonas.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            btnNuevo.Focus();
            rdbMasculino.Checked = true;
            txtActivo.Text = "1";

            //Asignamos la fecha y hora a los lbls correspondientes
            DateTime hoy = DateTime.Now;
            lblFechaRegistro.Text = hoy.ToString("yyyyMMdd");
            lblHoraRegistro.Text = hoy.ToShortTimeString();

        }

        //Método nuevo
        void Nuevo()
        {
            grbPersonas.Enabled = true;
            txtIdUsuario.Enabled = false;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            txtNombre.Focus();
        }

        void Cancelar()
        {
            Cargar();
            //grbPersonas.Controls.Clear();
            txtNombre.Clear();
            txtApePaterno.Clear();
            txtApeMaterno.Text = "";
            txtDomicilio.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            cmbEstadoCivil.SelectedIndex = 0;
            txtEstado.Text = "";
            txtMunicipio.Text = "";
        }

        void Actualizar()
        {
            grbPersonas.Enabled = true;
            txtNombre.Focus();
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = false;
        }

        void GridPersonas(int activo)
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
                qry = "SELECT * FROM VistaPersonas WHERE nombre like '%" + txtBuscar.Text + "%' AND activo='" + activo + "'";

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
                dgvPersonas.DataSource = datos;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al llenar el dgvPersonas! " + ex.Message.ToString(), "SI");
            }
        }

        private void FrmPersonas_Load(object sender, EventArgs e)
        {
            //Invocamos el método GridPersonas()
            GridPersonas(1);
            txtIdUsuario.Text = FrmPrin.id;
            //Invocamos el método Cargar()
            Cargar();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            //Invocamos el método Nuevo()
            Nuevo();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void valdacionLetras(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void valdacionNumsLetras(object sender, KeyPressEventArgs e)
        {
            validacion.numsLetras(e);
        }


        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (this.txtNombre.Text.Length == 0)
                {
                    MensajeOk ok = new MensajeOk();
                    ok.lbltxt.Text = "Favor de llenar el campo.";
                    ok.ShowDialog();
                    this.txtNombre.Focus();
                    return;
                }
                this.txtApePaterno.Focus();
            }
        }
        private void TxtApePaterno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (this.txtApePaterno.Text.Length == 0)
                {
                    MensajeOk ok = new MensajeOk();
                    ok.lbltxt.Text = "Favor de llenar el campo.";
                    ok.ShowDialog();
                    this.txtApePaterno.Focus();
                    return;
                }
                this.focusApeMaterno.Focus();
            }
        }

        private void TxtApeMaterno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (this.txtApeMaterno.Text.Length == 0)
                {
                    MensajeOk ok = new MensajeOk();
                    ok.lbltxt.Text = "Favor de llenar el campo.";
                    ok.ShowDialog();
                    this.txtApeMaterno.Focus();
                    return;
                }
                this.txtDomicilio.Focus();
            }
        }

        private void TxtDomicilio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (this.txtDomicilio.Text.Length == 0)
                {
                    MensajeOk ok = new MensajeOk();
                    ok.lbltxt.Text = "Favor de llenar el campo.";
                    ok.ShowDialog();
                    this.txtDomicilio.Focus();
                    return;
                }
                this.txtTelefono.Focus();
            }
        }

        private void TxtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (this.txtTelefono.Text.Length == 0 || this.txtTelefono.Text == "(   )   -")
                {
                    MensajeOk ok = new MensajeOk();
                    ok.lbltxt.Text = "Favor de llenar el campo.";
                    ok.ShowDialog();
                    this.txtTelefono.Focus();
                    return;
                }
                this.txtCorreo.Focus();
            }
        }
        validacion v = new validacion();
        private void TxtCorreo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtCorreo.Text.Length == 0) || (v.validarcorr(txtCorreo.Text) == false))
                {
                    MensajeOk ok = new MensajeOk();
                    ok.lbltxt.Text = "El campo se encuentra vacio o \n el formato no es correcto.";
                    ok.ShowDialog();
                    txtCorreo.Focus();
                    return;
                }
                dtpFechaNacimiento.Focus();
            }
        }

        private void DtpFechaNacimiento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (this.dtpFechaNacimiento.Text.Length == 0)
                {
                    MensajeOk ok = new MensajeOk();
                    ok.lbltxt.Text = "Favor de llenar el campo.";
                    ok.ShowDialog();
                    this.dtpFechaNacimiento.Focus();
                    return;
                }
                this.cmbEstadoCivil.Focus();
            }
        }

        private void CmbEstadoCivil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (this.cmbEstadoCivil.Text.Length == 0)
                {
                    MensajeOk ok = new MensajeOk();
                    ok.lbltxt.Text = "Favor de llenar el campo.";
                    ok.ShowDialog();
                    this.cmbEstadoCivil.Focus();
                    return;
                }
                this.txtEstado.Focus();
            }
        }

        private void txtEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (this.txtEstado.Text.Length == 0)
                {
                    MensajeOk ok = new MensajeOk();
                    ok.lbltxt.Text = "Favor de llenar el campo.";
                    ok.ShowDialog();
                    this.txtEstado.Focus();
                    return;
                }
                this.txtMunicipio.Focus();
            }
        }
        private void TxtMunicipio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (this.txtMunicipio.Text.Length == 0)
                {
                    MensajeOk ok = new MensajeOk();
                    ok.lbltxt.Text = "Favor de llenar el campo.";
                    ok.ShowDialog();
                    this.txtMunicipio.Focus();
                    return;
                }
                this.btnGuardar.Focus();
            }
        }
        public void Alert(string msg, FrmNotificaciones.alertTypeEnum type)
        {
            FrmNotificaciones f = new FrmNotificaciones();
            f.setAlert(msg, type);
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
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
                //Validación de correo no repetido
                qry = "SELECT correo FROM personas WHERE correo = '" + focusCorreo.Text + "'";
                //Asignamos la consulta al comando
                sqlCMD.CommandText = qry;
                //Asignamos la conexión al comando
                sqlCMD.Connection = sqlCNX;
                //Variable para leer datos tipo sql
                SqlDataReader sqlDR = null;
                //Abrimos la conexión
                sqlCNX.Open();
                //Asignamos ejecuantao el comando al sqlDR
                sqlDR = sqlCMD.ExecuteReader();
                //Comparamos si el sqlDR tiene datos
                if (sqlDR.HasRows)
                {
                    MensajeOk ok = new MensajeOk();
                    ok.lbltxt.Text = "Ya hay una persona con ese correo!";
                    ok.ShowDialog();
                    focusCorreo.Text = "";
                    focusCorreo.Focus();
                    //Cerramos la conexión
                    sqlCNX.Close();
                }
                else
                {
                    sqlCNX.Close();
                    string sexo = "";
                    if (rdbMasculino.Checked)
                    {
                        sexo = "M";
                    }
                    else
                    {
                        sexo = "F";
                    }

                    //Variable para guardar la fecha de nacimiento
                    string fechanacimiento = dtpFechaNacimiento.Value.ToString("yyyyMMdd");

                    //Insertamos o guardamos la persona en la BD
                    qry = "INSERT INTO personas(nombre, apepaterno, apematerno, domicilio, telefono, correo, sexo, fecha_nac, estado_civil, estados, municipio, activo, fecha_registro, hora_registro, id_usuario) " +
                    "VALUES ('" + txtNombre.Text + "', '" + txtApePaterno.Text + "', '" + txtApeMaterno.Text + "', '" + txtDomicilio.Text + "', '" + txtTelefono.Text + "', '" + txtCorreo.Text + "', '" + sexo + "', '" + fechanacimiento + "', '" + cmbEstadoCivil.Text + "', '" + txtEstado.Text + "', '" + txtMunicipio.Text + "', '" + txtActivo.Text + "', '" + lblFechaRegistro.Text + "', '" + lblHoraRegistro.Text + "', '" + txtIdUsuario.Text + "')";

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
                    this.Alert("Persona Registrada!", FrmNotificaciones.alertTypeEnum.Success);


                    //Invocamos al método cargar
                    Cargar();
                    //Invocamos el método cancelar
                    Cancelar();

                    GridPersonas(1);
                }
            }
            catch (SqlException ex)
            {
                MensajeOk ok = new MensajeOk();
                ok.lbltxt.Text = "Error al agregar la persona!";
                ok.lblx.Text = "" + ex;
                ok.ShowDialog();
            }            
            // FIN GUARDAR
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //INICIO MODIFICAR

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
                
                    sqlCNX.Close();
                    string sexo = "";
                    if (rdbMasculino.Checked)
                    {
                        sexo = "M";
                    }
                    else
                    {
                        sexo = "F";
                    }

                    //Variable para guardar la fecha de nacimiento
                    string fechanacimiento = dtpFechaNacimiento.Value.ToString("yyyyMMdd");
                    
                    string fecharegistro = DateTime.Parse(lblFechaRegistro.Text).ToString("yyyyMMdd");

                    //Insertamos o guardamos la persona en la BD
                    qry = "UPDATE personas SET nombre='" + txtNombre.Text + "', apepaterno='" + txtApePaterno.Text + "', apematerno='" + txtApeMaterno.Text + "', domicilio='" + txtDomicilio.Text + "', telefono='" + txtTelefono.Text + "', correo='" + txtCorreo.Text + "', sexo='" + sexo + "', fecha_nac='" + fechanacimiento + "', estado_civil='" + cmbEstadoCivil.Text + "', estados='" + txtEstado.Text + "', municipio='" + txtMunicipio.Text + "', activo='" + txtActivo.Text + "',  hora_registro='" + lblHoraRegistro.Text + "', id_usuario='" + txtIdUsuario.Text + "' WHERE id_persona= '" + dgvPersonas.CurrentRow.Cells["id_persona"].Value.ToString() + "'";

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
                    this.Alert("Persona Modificada!", FrmNotificaciones.alertTypeEnum.Success);

                    //Invocamos al método cargar
                    Cargar();
                    //Invocamos el método cancelar
                    Cancelar();

                    GridPersonas(1);
                
            }
            catch (SqlException ex)
            {
                MensajeOk ok = new MensajeOk();
                ok.lbltxt.Text = "Error al modificar la persona!";
                ok.lblx.Text = "" + ex;
                ok.ShowDialog();
            }

            //FIN MODIFICAR
        }


        private void ModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNombre.Text = dgvPersonas.CurrentRow.Cells["nombre"].Value.ToString();
            txtApePaterno.Text = dgvPersonas.CurrentRow.Cells["apepaterno"].Value.ToString();
            txtApeMaterno.Text = dgvPersonas.CurrentRow.Cells["apematerno"].Value.ToString();
            txtDomicilio.Text = dgvPersonas.CurrentRow.Cells["domicilio"].Value.ToString();
            txtTelefono.Text = dgvPersonas.CurrentRow.Cells["telefono"].Value.ToString();
            txtCorreo.Text = dgvPersonas.CurrentRow.Cells["correo"].Value.ToString();
            if (dgvPersonas.CurrentRow.Cells["sexo"].Value.ToString() == "M")
            {
                rdbMasculino.Checked = true;
            }
            else
            {
                rdbFemenino.Checked = true;
            }
            dtpFechaNacimiento.Text = dgvPersonas.CurrentRow.Cells["fecha_nac"].Value.ToString();
            cmbEstadoCivil.Text = dgvPersonas.CurrentRow.Cells["estado_civil"].Value.ToString();
            txtEstado.Text = dgvPersonas.CurrentRow.Cells["estados"].Value.ToString();
            txtMunicipio.Text = dgvPersonas.CurrentRow.Cells["municipio"].Value.ToString();
            txtActivo.Text = dgvPersonas.CurrentRow.Cells["activo"].Value.ToString();
            lblFechaRegistro.Text = dgvPersonas.CurrentRow.Cells["fecha_registro"].Value.ToString();
            lblHoraRegistro.Text = dgvPersonas.CurrentRow.Cells["hora_registro"].Value.ToString();

            Actualizar();
        }

        private void DgvPersonas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCell cell = (sender as DataGridView)[e.ColumnIndex, e.RowIndex];
            MessageBox.Show(cell.ToString());
            dgvPersonas.CurrentCell = cell;
            /*DataGridViewCell c = (sender as DataGridView)[e.ColumnIndex, e.RowIndex];
           
                c.DataGridView.ClearSelection();
                c.DataGridView.CurrentCell = c;
                c.Selected = true;*/
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            GridPersonas(activo);
        }

        private void McPersonas_Opening(object sender, CancelEventArgs e)
        {
            if (dgvPersonas.Rows.Count > 0 && Activos.Checked == true && dgvPersonas.CurrentRow.Cells[0].Value.ToString() == txtIdUsuario.Text)
            {
                btnModificarPersona.Visible = true;
                btnActivarPersona.Visible = false;
                btnDesactivarPersona.Visible = false;
            }
            else if (dgvPersonas.Rows.Count > 0 && Activos.Checked == true && dgvPersonas.CurrentRow.Cells[0].Value.ToString() != txtIdUsuario.Text)
            {
                btnModificarPersona.Visible = true;
                btnActivarPersona.Visible = false;
                btnDesactivarPersona.Visible = true;
            }
            else if (dgvPersonas.Rows.Count > 0 && Activos.Checked == false)
            {
                btnModificarPersona.Visible = false;
                btnActivarPersona.Visible = true;
                btnDesactivarPersona.Visible = false;
            }
            else if (dgvPersonas.Rows.Count <= 0 && Activos.Checked == false)
            {
                btnModificarPersona.Visible = false;
                btnActivarPersona.Visible = false;
                btnDesactivarPersona.Visible = false;
            }


          
        }

        private void BtnDesactivarPersona_Click(object sender, EventArgs e)
        {
            string idpersona = dgvPersonas.CurrentRow.Cells["id_persona"].Value.ToString();
            //Consulta
            string qry;
            //Extrae la configuración del appconfig
            string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");

            //Conecta a la BD
            SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
            //Guarda el objeto o comando
            SqlCommand sqlCMD = new SqlCommand();
            //Insertamos o guardamos la persona en la BD
            qry = "UPDATE personas SET activo=0 WHERE id_persona=" + idpersona;

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


                GridPersonas(0);
                this.Alert("Persona desactivada!", FrmNotificaciones.alertTypeEnum.Success);

                Activos.Checked = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void BtnActivarPersona_Click(object sender, EventArgs e)
        {
            string idpersona = dgvPersonas.CurrentRow.Cells["id_persona"].Value.ToString();
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

                GridPersonas(1);
                this.Alert("Persona activada!", FrmNotificaciones.alertTypeEnum.Success);

                Activos.Checked = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        int activo = 1;

        private void Activos_CheckedChanged(object sender, EventArgs e)
        {
          
            if (Activos.Checked == true)
            {
                
                activo = 1;
                GridPersonas(activo);
                lblActi.Text = "Activos";
            }else if (Activos.Checked == false)
            {
                activo = 0;
                GridPersonas(activo);
                lblActi.Text = "Inactivos";
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
        private void txtApePaterno_Enter(object sender, EventArgs e)
        {
            focusPaterno.LineColor = Color.FromArgb(100, 88, 255);

        }
        private void focusPaterno_Enter(object sender, EventArgs e)
        {
            txtApePaterno.Focus();
        }
        private void txtApePaterno_Leave(object sender, EventArgs e)
        {
            focusPaterno.LineColor = Color.White;
        }

        private void txtApeMaterno_Enter(object sender, EventArgs e)
        {
            focusApeMaterno.LineColor = Color.FromArgb(100, 88, 255);
        }
        private void focusApeMaterno_Enter(object sender, EventArgs e)
        {
            txtApeMaterno.Focus();
        }
        private void txtApeMaterno_Leave(object sender, EventArgs e)
        {
            focusApeMaterno.LineColor = Color.White;
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

        private void txtEstado_Enter(object sender, EventArgs e)
        {
            focusEstado.LineColor = Color.FromArgb(100, 88, 255);
        }

        private void focusEstado_Enter(object sender, EventArgs e)
        {
            txtEstado.Focus();
        }

        private void txtEstado_Leave(object sender, EventArgs e)
        {
            focusEstado.LineColor = Color.White;
        }

        private void txtMunicipio_Enter(object sender, EventArgs e)
        {
            focusMunicipio.LineColor = Color.FromArgb(100, 88, 255);
        }

        private void focusMunicipio_Enter(object sender, EventArgs e)
        {
            txtMunicipio.Focus();
        }

        private void txtMunicipio_Leave(object sender, EventArgs e)
        {
            focusMunicipio.LineColor = Color.White;
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            focusBuscar.LineColor = Color.FromArgb(100, 88, 255);
        }

        private void focusBuscar_Enter(object sender, EventArgs e)
        {
            txtBuscar.Focus();
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            focusBuscar.LineColor = Color.White;
        }

        private void lblActi_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.solonumeros(e);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
