namespace PaperShop
{
    partial class frmTrabajadores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mcTrabajadores = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnModificarTrabajador = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDesactivarTrabajador = new System.Windows.Forms.ToolStripMenuItem();
            this.btnActivarTrabajador = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHoraRegistro = new System.Windows.Forms.Label();
            this.lblIdDepartamento = new System.Windows.Forms.Label();
            this.lblIdPuesto = new System.Windows.Forms.Label();
            this.lblIdPersona = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTurnos = new System.Windows.Forms.ComboBox();
            this.cmbDepartamentos = new System.Windows.Forms.ComboBox();
            this.cmbPuestos = new System.Windows.Forms.ComboBox();
            this.cmbPersonas = new System.Windows.Forms.ComboBox();
            this.txtNumEmpleado = new System.Windows.Forms.TextBox();
            this.grbTrabajadores = new Guna.UI.WinForms.GunaShadowPanel();
            this.txtIdUsuario = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtActivo = new Guna.UI.WinForms.GunaLineTextBox();
            this.focusnum = new Guna.UI.WinForms.GunaLineTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblActi = new System.Windows.Forms.Label();
            this.Activos = new Guna.UI.WinForms.GunaWinSwitch();
            this.btnImprimir = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.focusBuscar = new Guna.UI.WinForms.GunaLineTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.btnCancelar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnModificar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnGuardar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnNuevo = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgvTrabajadores = new System.Windows.Forms.DataGridView();
            this.mcTrabajadores.SuspendLayout();
            this.grbTrabajadores.SuspendLayout();
            this.gunaPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajadores)).BeginInit();
            this.SuspendLayout();
            // 
            // mcTrabajadores
            // 
            this.mcTrabajadores.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mcTrabajadores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnModificarTrabajador,
            this.btnDesactivarTrabajador,
            this.btnActivarTrabajador});
            this.mcTrabajadores.Name = "mcUsuarios";
            this.mcTrabajadores.Size = new System.Drawing.Size(129, 70);
            this.mcTrabajadores.Opening += new System.ComponentModel.CancelEventHandler(this.McTrabajadores_Opening);
            // 
            // btnModificarTrabajador
            // 
            this.btnModificarTrabajador.Name = "btnModificarTrabajador";
            this.btnModificarTrabajador.Size = new System.Drawing.Size(128, 22);
            this.btnModificarTrabajador.Text = "Modificar";
            this.btnModificarTrabajador.Click += new System.EventHandler(this.BtnModificarTrabajador_Click);
            // 
            // btnDesactivarTrabajador
            // 
            this.btnDesactivarTrabajador.Name = "btnDesactivarTrabajador";
            this.btnDesactivarTrabajador.Size = new System.Drawing.Size(128, 22);
            this.btnDesactivarTrabajador.Text = "Desactivar";
            this.btnDesactivarTrabajador.Click += new System.EventHandler(this.BtnDesactivarTrabajador_Click);
            // 
            // btnActivarTrabajador
            // 
            this.btnActivarTrabajador.Name = "btnActivarTrabajador";
            this.btnActivarTrabajador.Size = new System.Drawing.Size(128, 22);
            this.btnActivarTrabajador.Text = "Activar";
            this.btnActivarTrabajador.Click += new System.EventHandler(this.BtnActivarTrabajador_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Num. Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Persona:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 164);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Turno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Departamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Puesto:";
            // 
            // lblHoraRegistro
            // 
            this.lblHoraRegistro.AutoSize = true;
            this.lblHoraRegistro.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraRegistro.Location = new System.Drawing.Point(32, 280);
            this.lblHoraRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraRegistro.Name = "lblHoraRegistro";
            this.lblHoraRegistro.Size = new System.Drawing.Size(79, 15);
            this.lblHoraRegistro.TabIndex = 3;
            this.lblHoraRegistro.Text = "Hora_Registro";
            this.lblHoraRegistro.Visible = false;
            // 
            // lblIdDepartamento
            // 
            this.lblIdDepartamento.AutoSize = true;
            this.lblIdDepartamento.Location = new System.Drawing.Point(285, 126);
            this.lblIdDepartamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdDepartamento.Name = "lblIdDepartamento";
            this.lblIdDepartamento.Size = new System.Drawing.Size(121, 21);
            this.lblIdDepartamento.TabIndex = 3;
            this.lblIdDepartamento.Text = "idDepartamento";
            this.lblIdDepartamento.Visible = false;
            // 
            // lblIdPuesto
            // 
            this.lblIdPuesto.AutoSize = true;
            this.lblIdPuesto.Location = new System.Drawing.Point(285, 93);
            this.lblIdPuesto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdPuesto.Name = "lblIdPuesto";
            this.lblIdPuesto.Size = new System.Drawing.Size(68, 21);
            this.lblIdPuesto.TabIndex = 3;
            this.lblIdPuesto.Text = "idPuesto";
            this.lblIdPuesto.Visible = false;
            // 
            // lblIdPersona
            // 
            this.lblIdPersona.AutoSize = true;
            this.lblIdPersona.Location = new System.Drawing.Point(284, 28);
            this.lblIdPersona.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdPersona.Name = "lblIdPersona";
            this.lblIdPersona.Size = new System.Drawing.Size(75, 21);
            this.lblIdPersona.TabIndex = 3;
            this.lblIdPersona.Text = "idPersona";
            this.lblIdPersona.Visible = false;
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistro.Location = new System.Drawing.Point(26, 259);
            this.lblFechaRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(83, 15);
            this.lblFechaRegistro.TabIndex = 3;
            this.lblFechaRegistro.Text = "Fecha_Registro";
            this.lblFechaRegistro.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 228);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Id_Usuario:";
            this.label6.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Activo:";
            this.label1.Visible = false;
            // 
            // cmbTurnos
            // 
            this.cmbTurnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cmbTurnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurnos.ForeColor = System.Drawing.Color.White;
            this.cmbTurnos.FormattingEnabled = true;
            this.cmbTurnos.Items.AddRange(new object[] {
            "Matutino",
            "Nocturno"});
            this.cmbTurnos.Location = new System.Drawing.Point(145, 158);
            this.cmbTurnos.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTurnos.Name = "cmbTurnos";
            this.cmbTurnos.Size = new System.Drawing.Size(149, 29);
            this.cmbTurnos.TabIndex = 4;
            this.cmbTurnos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbTurnos_KeyDown);
            // 
            // cmbDepartamentos
            // 
            this.cmbDepartamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cmbDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamentos.ForeColor = System.Drawing.Color.White;
            this.cmbDepartamentos.FormattingEnabled = true;
            this.cmbDepartamentos.Items.AddRange(new object[] {
            "Administrador",
            "Almacenista"});
            this.cmbDepartamentos.Location = new System.Drawing.Point(145, 125);
            this.cmbDepartamentos.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDepartamentos.Name = "cmbDepartamentos";
            this.cmbDepartamentos.Size = new System.Drawing.Size(149, 29);
            this.cmbDepartamentos.TabIndex = 4;
            this.cmbDepartamentos.SelectedIndexChanged += new System.EventHandler(this.CmbDepartamentos_SelectedIndexChanged);
            this.cmbDepartamentos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbDepartamentos_KeyDown);
            // 
            // cmbPuestos
            // 
            this.cmbPuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cmbPuestos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuestos.ForeColor = System.Drawing.Color.White;
            this.cmbPuestos.FormattingEnabled = true;
            this.cmbPuestos.Location = new System.Drawing.Point(145, 93);
            this.cmbPuestos.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPuestos.Name = "cmbPuestos";
            this.cmbPuestos.Size = new System.Drawing.Size(149, 29);
            this.cmbPuestos.TabIndex = 1;
            this.cmbPuestos.SelectedIndexChanged += new System.EventHandler(this.CmbPuestos_SelectedIndexChanged);
            this.cmbPuestos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbPuestos_KeyDown);
            // 
            // cmbPersonas
            // 
            this.cmbPersonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cmbPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonas.ForeColor = System.Drawing.Color.White;
            this.cmbPersonas.FormattingEnabled = true;
            this.cmbPersonas.Location = new System.Drawing.Point(145, 28);
            this.cmbPersonas.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPersonas.Name = "cmbPersonas";
            this.cmbPersonas.Size = new System.Drawing.Size(149, 29);
            this.cmbPersonas.TabIndex = 1;
            this.cmbPersonas.SelectedIndexChanged += new System.EventHandler(this.CmbPersonas_SelectedIndexChanged);
            this.cmbPersonas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbPersonas_KeyDown);
            // 
            // txtNumEmpleado
            // 
            this.txtNumEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtNumEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumEmpleado.ForeColor = System.Drawing.Color.White;
            this.txtNumEmpleado.Location = new System.Drawing.Point(145, 62);
            this.txtNumEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumEmpleado.Name = "txtNumEmpleado";
            this.txtNumEmpleado.Size = new System.Drawing.Size(149, 22);
            this.txtNumEmpleado.TabIndex = 2;
            this.txtNumEmpleado.Enter += new System.EventHandler(this.txtNumEmpleado_Enter);
            this.txtNumEmpleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNumEmpleado_KeyDown);
            this.txtNumEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valdacionSoloNums);
            this.txtNumEmpleado.Leave += new System.EventHandler(this.txtNumEmpleado_Leave);
            // 
            // grbTrabajadores
            // 
            this.grbTrabajadores.BackColor = System.Drawing.Color.Transparent;
            this.grbTrabajadores.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.grbTrabajadores.Controls.Add(this.txtIdUsuario);
            this.grbTrabajadores.Controls.Add(this.txtActivo);
            this.grbTrabajadores.Controls.Add(this.label3);
            this.grbTrabajadores.Controls.Add(this.label2);
            this.grbTrabajadores.Controls.Add(this.txtNumEmpleado);
            this.grbTrabajadores.Controls.Add(this.label7);
            this.grbTrabajadores.Controls.Add(this.label5);
            this.grbTrabajadores.Controls.Add(this.cmbPersonas);
            this.grbTrabajadores.Controls.Add(this.label4);
            this.grbTrabajadores.Controls.Add(this.cmbPuestos);
            this.grbTrabajadores.Controls.Add(this.lblHoraRegistro);
            this.grbTrabajadores.Controls.Add(this.cmbDepartamentos);
            this.grbTrabajadores.Controls.Add(this.lblIdDepartamento);
            this.grbTrabajadores.Controls.Add(this.cmbTurnos);
            this.grbTrabajadores.Controls.Add(this.lblIdPuesto);
            this.grbTrabajadores.Controls.Add(this.lblIdPersona);
            this.grbTrabajadores.Controls.Add(this.label1);
            this.grbTrabajadores.Controls.Add(this.lblFechaRegistro);
            this.grbTrabajadores.Controls.Add(this.label6);
            this.grbTrabajadores.Controls.Add(this.focusnum);
            this.grbTrabajadores.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTrabajadores.ForeColor = System.Drawing.Color.White;
            this.grbTrabajadores.Location = new System.Drawing.Point(28, 71);
            this.grbTrabajadores.Name = "grbTrabajadores";
            this.grbTrabajadores.ShadowColor = System.Drawing.Color.Black;
            this.grbTrabajadores.ShadowShift = 15;
            this.grbTrabajadores.Size = new System.Drawing.Size(329, 313);
            this.grbTrabajadores.TabIndex = 19;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtIdUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdUsuario.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.txtIdUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdUsuario.ForeColor = System.Drawing.Color.White;
            this.txtIdUsuario.LineColor = System.Drawing.Color.Gainsboro;
            this.txtIdUsuario.LineSize = 2;
            this.txtIdUsuario.Location = new System.Drawing.Point(145, 225);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.PasswordChar = '\0';
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(149, 26);
            this.txtIdUsuario.TabIndex = 65;
            this.txtIdUsuario.Visible = false;
            // 
            // txtActivo
            // 
            this.txtActivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtActivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtActivo.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.txtActivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtActivo.ForeColor = System.Drawing.Color.White;
            this.txtActivo.LineColor = System.Drawing.Color.Gainsboro;
            this.txtActivo.LineSize = 2;
            this.txtActivo.Location = new System.Drawing.Point(145, 192);
            this.txtActivo.Name = "txtActivo";
            this.txtActivo.PasswordChar = '\0';
            this.txtActivo.ReadOnly = true;
            this.txtActivo.Size = new System.Drawing.Size(149, 26);
            this.txtActivo.TabIndex = 64;
            this.txtActivo.Visible = false;
            // 
            // focusnum
            // 
            this.focusnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focusnum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focusnum.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focusnum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.focusnum.ForeColor = System.Drawing.Color.White;
            this.focusnum.LineColor = System.Drawing.Color.Gainsboro;
            this.focusnum.LineSize = 2;
            this.focusnum.Location = new System.Drawing.Point(145, 62);
            this.focusnum.Name = "focusnum";
            this.focusnum.PasswordChar = '\0';
            this.focusnum.ReadOnly = true;
            this.focusnum.Size = new System.Drawing.Size(149, 26);
            this.focusnum.TabIndex = 66;
            this.focusnum.Enter += new System.EventHandler(this.gunaLineTextBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(22, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 32);
            this.label8.TabIndex = 58;
            this.label8.Text = "Trabajadores";
            // 
            // lblActi
            // 
            this.lblActi.AutoSize = true;
            this.lblActi.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActi.ForeColor = System.Drawing.Color.White;
            this.lblActi.Location = new System.Drawing.Point(785, 38);
            this.lblActi.Name = "lblActi";
            this.lblActi.Size = new System.Drawing.Size(57, 21);
            this.lblActi.TabIndex = 69;
            this.lblActi.Text = "Activos";
            // 
            // Activos
            // 
            this.Activos.BaseColor = System.Drawing.SystemColors.Control;
            this.Activos.Checked = true;
            this.Activos.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.Activos.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Activos.FillColor = System.Drawing.Color.White;
            this.Activos.Location = new System.Drawing.Point(739, 38);
            this.Activos.Name = "Activos";
            this.Activos.Size = new System.Drawing.Size(40, 22);
            this.Activos.TabIndex = 68;
            this.Activos.CheckedChanged += new System.EventHandler(this.Activos_CheckedChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AnimationHoverSpeed = 0.07F;
            this.btnImprimir.AnimationSpeed = 0.03F;
            this.btnImprimir.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnImprimir.BorderColor = System.Drawing.Color.Black;
            this.btnImprimir.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnImprimir.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnImprimir.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnImprimir.CheckedForeColor = System.Drawing.Color.White;
            this.btnImprimir.CheckedImage = null;
            this.btnImprimir.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btnImprimir.FocusedColor = System.Drawing.Color.Empty;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Image = null;
            this.btnImprimir.ImageSize = new System.Drawing.Size(20, 20);
            this.btnImprimir.LineBottom = 5;
            this.btnImprimir.LineColor = System.Drawing.Color.Transparent;
            this.btnImprimir.Location = new System.Drawing.Point(618, 29);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnImprimir.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnImprimir.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnImprimir.OnHoverImage = null;
            this.btnImprimir.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnImprimir.OnPressedColor = System.Drawing.Color.Black;
            this.btnImprimir.Size = new System.Drawing.Size(100, 30);
            this.btnImprimir.TabIndex = 64;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(453, 38);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(158, 22);
            this.txtBuscar.TabIndex = 67;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // focusBuscar
            // 
            this.focusBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focusBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focusBuscar.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focusBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.focusBuscar.ForeColor = System.Drawing.Color.White;
            this.focusBuscar.LineColor = System.Drawing.Color.Gainsboro;
            this.focusBuscar.LineSize = 2;
            this.focusBuscar.Location = new System.Drawing.Point(452, 36);
            this.focusBuscar.Name = "focusBuscar";
            this.focusBuscar.PasswordChar = '\0';
            this.focusBuscar.Size = new System.Drawing.Size(160, 26);
            this.focusBuscar.TabIndex = 66;
            this.focusBuscar.Enter += new System.EventHandler(this.focusBuscar_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(398, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 21);
            this.label13.TabIndex = 65;
            this.label13.Text = "Buscar:";
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaPanel4.Controls.Add(this.btnCancelar);
            this.gunaPanel4.Controls.Add(this.btnModificar);
            this.gunaPanel4.Controls.Add(this.btnGuardar);
            this.gunaPanel4.Controls.Add(this.btnNuevo);
            this.gunaPanel4.Location = new System.Drawing.Point(12, 390);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(366, 40);
            this.gunaPanel4.TabIndex = 71;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AnimationHoverSpeed = 0.07F;
            this.btnCancelar.AnimationSpeed = 0.03F;
            this.btnCancelar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnCancelar.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnCancelar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCancelar.CheckedForeColor = System.Drawing.Color.White;
            this.btnCancelar.CheckedImage = null;
            this.btnCancelar.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelar.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = null;
            this.btnCancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancelar.LineBottom = 5;
            this.btnCancelar.LineColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Location = new System.Drawing.Point(270, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnCancelar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancelar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnCancelar.OnHoverImage = null;
            this.btnCancelar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnCancelar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancelar.Size = new System.Drawing.Size(90, 40);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AnimationHoverSpeed = 0.07F;
            this.btnModificar.AnimationSpeed = 0.03F;
            this.btnModificar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnModificar.BorderColor = System.Drawing.Color.Black;
            this.btnModificar.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnModificar.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnModificar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnModificar.CheckedForeColor = System.Drawing.Color.White;
            this.btnModificar.CheckedImage = null;
            this.btnModificar.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModificar.FocusedColor = System.Drawing.Color.Empty;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = null;
            this.btnModificar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnModificar.LineBottom = 5;
            this.btnModificar.LineColor = System.Drawing.Color.Transparent;
            this.btnModificar.Location = new System.Drawing.Point(180, 0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnModificar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModificar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnModificar.OnHoverImage = null;
            this.btnModificar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnModificar.OnPressedColor = System.Drawing.Color.Black;
            this.btnModificar.Size = new System.Drawing.Size(90, 40);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AnimationHoverSpeed = 0.07F;
            this.btnGuardar.AnimationSpeed = 0.03F;
            this.btnGuardar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnGuardar.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnGuardar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnGuardar.CheckedForeColor = System.Drawing.Color.White;
            this.btnGuardar.CheckedImage = null;
            this.btnGuardar.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = null;
            this.btnGuardar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGuardar.LineBottom = 5;
            this.btnGuardar.LineColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Location = new System.Drawing.Point(90, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnGuardar.OnHoverImage = null;
            this.btnGuardar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardar.Size = new System.Drawing.Size(90, 40);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AnimationHoverSpeed = 0.07F;
            this.btnNuevo.AnimationSpeed = 0.03F;
            this.btnNuevo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnNuevo.BorderColor = System.Drawing.Color.Black;
            this.btnNuevo.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnNuevo.Checked = true;
            this.btnNuevo.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnNuevo.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnNuevo.CheckedForeColor = System.Drawing.Color.White;
            this.btnNuevo.CheckedImage = null;
            this.btnNuevo.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNuevo.FocusedColor = System.Drawing.Color.Empty;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = null;
            this.btnNuevo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNuevo.LineBottom = 5;
            this.btnNuevo.LineColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Location = new System.Drawing.Point(0, 0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnNuevo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNuevo.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnNuevo.OnHoverImage = null;
            this.btnNuevo.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnNuevo.OnPressedColor = System.Drawing.Color.Black;
            this.btnNuevo.Size = new System.Drawing.Size(90, 40);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // dgvTrabajadores
            // 
            this.dgvTrabajadores.AllowUserToAddRows = false;
            this.dgvTrabajadores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTrabajadores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrabajadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrabajadores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.dgvTrabajadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTrabajadores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrabajadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabajadores.ContextMenuStrip = this.mcTrabajadores;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrabajadores.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTrabajadores.EnableHeadersVisualStyles = false;
            this.dgvTrabajadores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.dgvTrabajadores.Location = new System.Drawing.Point(388, 72);
            this.dgvTrabajadores.Name = "dgvTrabajadores";
            this.dgvTrabajadores.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrabajadores.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTrabajadores.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTrabajadores.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTrabajadores.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.dgvTrabajadores.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTrabajadores.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTrabajadores.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.dgvTrabajadores.RowTemplate.ReadOnly = true;
            this.dgvTrabajadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrabajadores.Size = new System.Drawing.Size(472, 322);
            this.dgvTrabajadores.TabIndex = 72;
            // 
            // frmTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(893, 447);
            this.Controls.Add(this.gunaPanel4);
            this.Controls.Add(this.lblActi);
            this.Controls.Add(this.Activos);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.focusBuscar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grbTrabajadores);
            this.Controls.Add(this.dgvTrabajadores);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTrabajadores";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTrabajadores";
            this.Load += new System.EventHandler(this.FrmTrabajadores_Load);
            this.mcTrabajadores.ResumeLayout(false);
            this.grbTrabajadores.ResumeLayout(false);
            this.grbTrabajadores.PerformLayout();
            this.gunaPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHoraRegistro;
        private System.Windows.Forms.Label lblIdDepartamento;
        private System.Windows.Forms.Label lblIdPuesto;
        private System.Windows.Forms.Label lblIdPersona;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTurnos;
        private System.Windows.Forms.ComboBox cmbDepartamentos;
        private System.Windows.Forms.ComboBox cmbPuestos;
        private System.Windows.Forms.ComboBox cmbPersonas;
        private System.Windows.Forms.TextBox txtNumEmpleado;
        private System.Windows.Forms.ContextMenuStrip mcTrabajadores;
        private System.Windows.Forms.ToolStripMenuItem btnModificarTrabajador;
        private System.Windows.Forms.ToolStripMenuItem btnDesactivarTrabajador;
        private System.Windows.Forms.ToolStripMenuItem btnActivarTrabajador;
        private Guna.UI.WinForms.GunaShadowPanel grbTrabajadores;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaLineTextBox txtIdUsuario;
        private Guna.UI.WinForms.GunaLineTextBox txtActivo;
        private Guna.UI.WinForms.GunaLineTextBox focusnum;
        private System.Windows.Forms.Label lblActi;
        private Guna.UI.WinForms.GunaWinSwitch Activos;
        private Guna.UI.WinForms.GunaAdvenceButton btnImprimir;
        private System.Windows.Forms.TextBox txtBuscar;
        private Guna.UI.WinForms.GunaLineTextBox focusBuscar;
        private System.Windows.Forms.Label label13;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaAdvenceButton btnCancelar;
        private Guna.UI.WinForms.GunaAdvenceButton btnModificar;
        private Guna.UI.WinForms.GunaAdvenceButton btnGuardar;
        private Guna.UI.WinForms.GunaAdvenceButton btnNuevo;
        private System.Windows.Forms.DataGridView dgvTrabajadores;
    }
}