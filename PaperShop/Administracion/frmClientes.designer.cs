namespace PaperShop
{
    partial class frmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label13 = new System.Windows.Forms.Label();
            this.cmClientes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desactivarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblid_persona = new System.Windows.Forms.Label();
            this.lblhoraregistro = new System.Windows.Forms.Label();
            this.lblfecharegistro = new System.Windows.Forms.Label();
            this.grbclientes = new System.Windows.Forms.Panel();
            this.cmbpersonas = new System.Windows.Forms.ComboBox();
            this.txtIdUsuario = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtActivo = new Guna.UI.WinForms.GunaLineTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnumerocliente = new System.Windows.Forms.TextBox();
            this.focusno = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImprimir = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.focusBuscar = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblActi = new System.Windows.Forms.Label();
            this.Activos = new Guna.UI.WinForms.GunaWinSwitch();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.btnCancelar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnModificar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnGuardar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnNuevo = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgvclientes = new System.Windows.Forms.DataGridView();
            this.cmClientes.SuspendLayout();
            this.grbclientes.SuspendLayout();
            this.gunaPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(427, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 21);
            this.label13.TabIndex = 50;
            this.label13.Text = "Buscar";
            // 
            // cmClientes
            // 
            this.cmClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.desactivarToolStripMenuItem,
            this.activarToolStripMenuItem});
            this.cmClientes.Name = "cmClientes";
            this.cmClientes.Size = new System.Drawing.Size(129, 70);
            this.cmClientes.Opening += new System.ComponentModel.CancelEventHandler(this.CmClientes_Opening);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.ModificarToolStripMenuItem_Click);
            // 
            // desactivarToolStripMenuItem
            // 
            this.desactivarToolStripMenuItem.Name = "desactivarToolStripMenuItem";
            this.desactivarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.desactivarToolStripMenuItem.Text = "Desactivar";
            this.desactivarToolStripMenuItem.Click += new System.EventHandler(this.DesactivarToolStripMenuItem_Click);
            // 
            // activarToolStripMenuItem
            // 
            this.activarToolStripMenuItem.Name = "activarToolStripMenuItem";
            this.activarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.activarToolStripMenuItem.Text = "Activar";
            this.activarToolStripMenuItem.Click += new System.EventHandler(this.ActivarToolStripMenuItem_Click);
            // 
            // lblid_persona
            // 
            this.lblid_persona.AutoSize = true;
            this.lblid_persona.Location = new System.Drawing.Point(6, 146);
            this.lblid_persona.Name = "lblid_persona";
            this.lblid_persona.Size = new System.Drawing.Size(84, 21);
            this.lblid_persona.TabIndex = 37;
            this.lblid_persona.Text = "Id_persona";
            this.lblid_persona.Visible = false;
            // 
            // lblhoraregistro
            // 
            this.lblhoraregistro.AutoSize = true;
            this.lblhoraregistro.Location = new System.Drawing.Point(271, 137);
            this.lblhoraregistro.Name = "lblhoraregistro";
            this.lblhoraregistro.Size = new System.Drawing.Size(104, 21);
            this.lblhoraregistro.TabIndex = 28;
            this.lblhoraregistro.Text = "Hora_Registro";
            // 
            // lblfecharegistro
            // 
            this.lblfecharegistro.AutoSize = true;
            this.lblfecharegistro.Location = new System.Drawing.Point(271, 114);
            this.lblfecharegistro.Name = "lblfecharegistro";
            this.lblfecharegistro.Size = new System.Drawing.Size(110, 21);
            this.lblfecharegistro.TabIndex = 27;
            this.lblfecharegistro.Text = "Fecha_Registro";
            // 
            // grbclientes
            // 
            this.grbclientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.grbclientes.Controls.Add(this.lblid_persona);
            this.grbclientes.Controls.Add(this.cmbpersonas);
            this.grbclientes.Controls.Add(this.txtIdUsuario);
            this.grbclientes.Controls.Add(this.txtActivo);
            this.grbclientes.Controls.Add(this.lblhoraregistro);
            this.grbclientes.Controls.Add(this.label5);
            this.grbclientes.Controls.Add(this.lblfecharegistro);
            this.grbclientes.Controls.Add(this.label6);
            this.grbclientes.Controls.Add(this.label7);
            this.grbclientes.Controls.Add(this.label8);
            this.grbclientes.Controls.Add(this.txtnumerocliente);
            this.grbclientes.Controls.Add(this.focusno);
            this.grbclientes.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbclientes.ForeColor = System.Drawing.Color.White;
            this.grbclientes.Location = new System.Drawing.Point(12, 67);
            this.grbclientes.Name = "grbclientes";
            this.grbclientes.Size = new System.Drawing.Size(386, 179);
            this.grbclientes.TabIndex = 55;
            // 
            // cmbpersonas
            // 
            this.cmbpersonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cmbpersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpersonas.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpersonas.ForeColor = System.Drawing.Color.White;
            this.cmbpersonas.FormattingEnabled = true;
            this.cmbpersonas.Location = new System.Drawing.Point(148, 19);
            this.cmbpersonas.Name = "cmbpersonas";
            this.cmbpersonas.Size = new System.Drawing.Size(175, 29);
            this.cmbpersonas.TabIndex = 79;
            this.cmbpersonas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmbpersonas_KeyDown);
            this.cmbpersonas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmbpersonas_KeyPress);
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
            this.txtIdUsuario.Location = new System.Drawing.Point(148, 117);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.PasswordChar = '\0';
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(94, 26);
            this.txtIdUsuario.TabIndex = 78;
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
            this.txtActivo.Location = new System.Drawing.Point(148, 85);
            this.txtActivo.Name = "txtActivo";
            this.txtActivo.PasswordChar = '\0';
            this.txtActivo.ReadOnly = true;
            this.txtActivo.Size = new System.Drawing.Size(93, 26);
            this.txtActivo.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 21);
            this.label5.TabIndex = 74;
            this.label5.Text = "Numero de cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 73;
            this.label6.Text = "Personas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 21);
            this.label7.TabIndex = 70;
            this.label7.Text = "Id Usuario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 21);
            this.label8.TabIndex = 69;
            this.label8.Text = "Activo:";
            // 
            // txtnumerocliente
            // 
            this.txtnumerocliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtnumerocliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnumerocliente.ForeColor = System.Drawing.Color.White;
            this.txtnumerocliente.Location = new System.Drawing.Point(148, 52);
            this.txtnumerocliente.Name = "txtnumerocliente";
            this.txtnumerocliente.Size = new System.Drawing.Size(175, 22);
            this.txtnumerocliente.TabIndex = 66;
            this.txtnumerocliente.Enter += new System.EventHandler(this.txtnumerocliente_Enter);
            this.txtnumerocliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtnumerocliente_KeyDown);
            this.txtnumerocliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valdacionNumsLetras);
            this.txtnumerocliente.Leave += new System.EventHandler(this.txtnumerocliente_Leave);
            // 
            // focusno
            // 
            this.focusno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focusno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focusno.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focusno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.focusno.ForeColor = System.Drawing.Color.White;
            this.focusno.LineColor = System.Drawing.Color.Gainsboro;
            this.focusno.LineSize = 2;
            this.focusno.Location = new System.Drawing.Point(148, 54);
            this.focusno.Name = "focusno";
            this.focusno.PasswordChar = '\0';
            this.focusno.ReadOnly = true;
            this.focusno.Size = new System.Drawing.Size(175, 26);
            this.focusno.TabIndex = 80;
            this.focusno.Enter += new System.EventHandler(this.focusno_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 40);
            this.label1.TabIndex = 74;
            this.label1.Text = "Cliente";
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
            this.btnImprimir.Location = new System.Drawing.Point(652, 15);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnImprimir.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnImprimir.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnImprimir.OnHoverImage = null;
            this.btnImprimir.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnImprimir.OnPressedColor = System.Drawing.Color.Black;
            this.btnImprimir.Size = new System.Drawing.Size(100, 30);
            this.btnImprimir.TabIndex = 75;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(487, 24);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(158, 22);
            this.txtBuscar.TabIndex = 77;
            this.txtBuscar.TextChanged += new System.EventHandler(this.Txtbuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valdacionLetras);
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
            this.focusBuscar.Location = new System.Drawing.Point(486, 22);
            this.focusBuscar.Name = "focusBuscar";
            this.focusBuscar.PasswordChar = '\0';
            this.focusBuscar.Size = new System.Drawing.Size(160, 26);
            this.focusBuscar.TabIndex = 76;
            // 
            // lblActi
            // 
            this.lblActi.AutoSize = true;
            this.lblActi.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActi.ForeColor = System.Drawing.Color.White;
            this.lblActi.Location = new System.Drawing.Point(809, 25);
            this.lblActi.Name = "lblActi";
            this.lblActi.Size = new System.Drawing.Size(57, 21);
            this.lblActi.TabIndex = 79;
            this.lblActi.Text = "Activos";
            // 
            // Activos
            // 
            this.Activos.BaseColor = System.Drawing.SystemColors.Control;
            this.Activos.Checked = true;
            this.Activos.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.Activos.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Activos.FillColor = System.Drawing.Color.White;
            this.Activos.Location = new System.Drawing.Point(763, 25);
            this.Activos.Name = "Activos";
            this.Activos.Size = new System.Drawing.Size(40, 22);
            this.Activos.TabIndex = 78;
            this.Activos.CheckedChanged += new System.EventHandler(this.Activos_CheckedChanged);
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaPanel4.Controls.Add(this.btnCancelar);
            this.gunaPanel4.Controls.Add(this.btnModificar);
            this.gunaPanel4.Controls.Add(this.btnGuardar);
            this.gunaPanel4.Controls.Add(this.btnNuevo);
            this.gunaPanel4.Location = new System.Drawing.Point(5, 257);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(395, 40);
            this.gunaPanel4.TabIndex = 80;
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
            this.btnCancelar.Location = new System.Drawing.Point(292, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnCancelar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancelar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnCancelar.OnHoverImage = null;
            this.btnCancelar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnCancelar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancelar.Size = new System.Drawing.Size(101, 40);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancelar.Click += new System.EventHandler(this.Btncancelar_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(191, 0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnModificar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModificar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnModificar.OnHoverImage = null;
            this.btnModificar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnModificar.OnPressedColor = System.Drawing.Color.Black;
            this.btnModificar.Size = new System.Drawing.Size(101, 40);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModificar.Click += new System.EventHandler(this.Btnmodificar_Click);
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
            this.btnGuardar.Size = new System.Drawing.Size(101, 40);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGuardar.Click += new System.EventHandler(this.Btnguardar_Click);
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
            this.btnNuevo.Click += new System.EventHandler(this.Btnnuevo_Click);
            // 
            // dgvclientes
            // 
            this.dgvclientes.AllowUserToAddRows = false;
            this.dgvclientes.AllowUserToDeleteRows = false;
            this.dgvclientes.AllowUserToResizeRows = false;
            this.dgvclientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvclientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclientes.ContextMenuStrip = this.cmClientes;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvclientes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvclientes.Location = new System.Drawing.Point(406, 54);
            this.dgvclientes.Name = "dgvclientes";
            this.dgvclientes.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvclientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvclientes.Size = new System.Drawing.Size(471, 309);
            this.dgvclientes.TabIndex = 81;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(889, 412);
            this.Controls.Add(this.dgvclientes);
            this.Controls.Add(this.gunaPanel4);
            this.Controls.Add(this.lblActi);
            this.Controls.Add(this.Activos);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.focusBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbclientes);
            this.Controls.Add(this.label13);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.cmClientes.ResumeLayout(false);
            this.grbclientes.ResumeLayout(false);
            this.grbclientes.PerformLayout();
            this.gunaPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblid_persona;
        private System.Windows.Forms.Label lblhoraregistro;
        private System.Windows.Forms.Label lblfecharegistro;
        private System.Windows.Forms.ContextMenuStrip cmClientes;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desactivarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activarToolStripMenuItem;
        private System.Windows.Forms.Panel grbclientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnumerocliente;
        private Guna.UI.WinForms.GunaLineTextBox txtIdUsuario;
        private Guna.UI.WinForms.GunaLineTextBox txtActivo;
        private System.Windows.Forms.ComboBox cmbpersonas;
        private Guna.UI.WinForms.GunaLineTextBox focusno;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton btnImprimir;
        private System.Windows.Forms.TextBox txtBuscar;
        private Guna.UI.WinForms.GunaLineTextBox focusBuscar;
        private System.Windows.Forms.Label lblActi;
        private Guna.UI.WinForms.GunaWinSwitch Activos;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaAdvenceButton btnCancelar;
        private Guna.UI.WinForms.GunaAdvenceButton btnModificar;
        private Guna.UI.WinForms.GunaAdvenceButton btnGuardar;
        private Guna.UI.WinForms.GunaAdvenceButton btnNuevo;
        private System.Windows.Forms.DataGridView dgvclientes;
    }
}