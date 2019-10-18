namespace PaperShop
{
    partial class frmCajas
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
            this.mcCajas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnModificarCaja = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDesactivarCaja = new System.Windows.Forms.ToolStripMenuItem();
            this.btnActivarCaja = new System.Windows.Forms.ToolStripMenuItem();
            this.idusuario = new System.Windows.Forms.Label();
            this.lblIdSucursal = new System.Windows.Forms.Label();
            this.cmbSucursales = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblHoraRegistro = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.grbCajas = new Guna.UI.WinForms.GunaShadowPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvCajas = new System.Windows.Forms.DataGridView();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.btnCancelar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnModificar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnGuardar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnNuevo = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblActi = new System.Windows.Forms.Label();
            this.Activos = new Guna.UI.WinForms.GunaWinSwitch();
            this.btnImprimir = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.focusBuscar = new Guna.UI.WinForms.GunaLineTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIdUsuario = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtActivo = new Guna.UI.WinForms.GunaLineTextBox();
            this.focusnum = new Guna.UI.WinForms.GunaLineTextBox();
            this.mcCajas.SuspendLayout();
            this.grbCajas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajas)).BeginInit();
            this.gunaPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcCajas
            // 
            this.mcCajas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mcCajas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnModificarCaja,
            this.btnDesactivarCaja,
            this.btnActivarCaja});
            this.mcCajas.Name = "mcPuestos";
            this.mcCajas.Size = new System.Drawing.Size(129, 70);
            this.mcCajas.Opening += new System.ComponentModel.CancelEventHandler(this.McCajas_Opening);
            // 
            // btnModificarCaja
            // 
            this.btnModificarCaja.Name = "btnModificarCaja";
            this.btnModificarCaja.Size = new System.Drawing.Size(128, 22);
            this.btnModificarCaja.Text = "Modificar";
            this.btnModificarCaja.Click += new System.EventHandler(this.BtnModificarCaja_Click);
            // 
            // btnDesactivarCaja
            // 
            this.btnDesactivarCaja.Name = "btnDesactivarCaja";
            this.btnDesactivarCaja.Size = new System.Drawing.Size(128, 22);
            this.btnDesactivarCaja.Text = "Desactivar";
            this.btnDesactivarCaja.Click += new System.EventHandler(this.BtnDesactivarCaja_Click);
            // 
            // btnActivarCaja
            // 
            this.btnActivarCaja.Name = "btnActivarCaja";
            this.btnActivarCaja.Size = new System.Drawing.Size(128, 22);
            this.btnActivarCaja.Text = "Activar";
            this.btnActivarCaja.Click += new System.EventHandler(this.BtnActivarCaja_Click);
            // 
            // idusuario
            // 
            this.idusuario.AutoSize = true;
            this.idusuario.Location = new System.Drawing.Point(236, 42);
            this.idusuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idusuario.Name = "idusuario";
            this.idusuario.Size = new System.Drawing.Size(78, 21);
            this.idusuario.TabIndex = 9;
            this.idusuario.Text = "IdSucursal";
            this.idusuario.Visible = false;
            // 
            // lblIdSucursal
            // 
            this.lblIdSucursal.AutoSize = true;
            this.lblIdSucursal.Location = new System.Drawing.Point(236, 69);
            this.lblIdSucursal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdSucursal.Name = "lblIdSucursal";
            this.lblIdSucursal.Size = new System.Drawing.Size(78, 21);
            this.lblIdSucursal.TabIndex = 8;
            this.lblIdSucursal.Text = "IdSucursal";
            this.lblIdSucursal.Visible = false;
            // 
            // cmbSucursales
            // 
            this.cmbSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursales.ForeColor = System.Drawing.Color.White;
            this.cmbSucursales.FormattingEnabled = true;
            this.cmbSucursales.Location = new System.Drawing.Point(148, 65);
            this.cmbSucursales.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSucursales.Name = "cmbSucursales";
            this.cmbSucursales.Size = new System.Drawing.Size(105, 29);
            this.cmbSucursales.TabIndex = 7;
            this.cmbSucursales.SelectedIndexChanged += new System.EventHandler(this.CmbSucursales_SelectedIndexChanged);
            this.cmbSucursales.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbSucursales_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sucursal";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(28, 33);
            this.lblNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(116, 21);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "Número de caja";
            // 
            // lblHoraRegistro
            // 
            this.lblHoraRegistro.AutoSize = true;
            this.lblHoraRegistro.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraRegistro.Location = new System.Drawing.Point(29, 190);
            this.lblHoraRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraRegistro.Name = "lblHoraRegistro";
            this.lblHoraRegistro.Size = new System.Drawing.Size(83, 17);
            this.lblHoraRegistro.TabIndex = 3;
            this.lblHoraRegistro.Text = "Hora_Registro";
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistro.Location = new System.Drawing.Point(23, 166);
            this.lblFechaRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(89, 17);
            this.lblFechaRegistro.TabIndex = 3;
            this.lblFechaRegistro.Text = "Fecha_Registro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Id_Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Activo:";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.ForeColor = System.Drawing.Color.White;
            this.txtNumero.Location = new System.Drawing.Point(148, 33);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(105, 22);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.Enter += new System.EventHandler(this.txtNumero_Enter);
            this.txtNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNombre_KeyDown);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valdacionSoloNums);
            this.txtNumero.Leave += new System.EventHandler(this.txtNumero_Leave);
            // 
            // grbCajas
            // 
            this.grbCajas.BackColor = System.Drawing.Color.Transparent;
            this.grbCajas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.grbCajas.Controls.Add(this.txtNumero);
            this.grbCajas.Controls.Add(this.focusnum);
            this.grbCajas.Controls.Add(this.txtIdUsuario);
            this.grbCajas.Controls.Add(this.txtActivo);
            this.grbCajas.Controls.Add(this.cmbSucursales);
            this.grbCajas.Controls.Add(this.label2);
            this.grbCajas.Controls.Add(this.lblNum);
            this.grbCajas.Controls.Add(this.label1);
            this.grbCajas.Controls.Add(this.label6);
            this.grbCajas.Controls.Add(this.idusuario);
            this.grbCajas.Controls.Add(this.lblFechaRegistro);
            this.grbCajas.Controls.Add(this.lblIdSucursal);
            this.grbCajas.Controls.Add(this.lblHoraRegistro);
            this.grbCajas.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCajas.ForeColor = System.Drawing.Color.White;
            this.grbCajas.Location = new System.Drawing.Point(31, 67);
            this.grbCajas.Name = "grbCajas";
            this.grbCajas.ShadowColor = System.Drawing.Color.Black;
            this.grbCajas.ShadowShift = 15;
            this.grbCajas.Size = new System.Drawing.Size(329, 231);
            this.grbCajas.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 32);
            this.label8.TabIndex = 59;
            this.label8.Text = "Cajas";
            // 
            // dgvCajas
            // 
            this.dgvCajas.AllowUserToAddRows = false;
            this.dgvCajas.AllowUserToDeleteRows = false;
            this.dgvCajas.AllowUserToResizeRows = false;
            this.dgvCajas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCajas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCajas.ContextMenuStrip = this.mcCajas;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCajas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCajas.Location = new System.Drawing.Point(394, 67);
            this.dgvCajas.Name = "dgvCajas";
            this.dgvCajas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCajas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCajas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCajas.Size = new System.Drawing.Size(403, 293);
            this.dgvCajas.TabIndex = 71;
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaPanel4.Controls.Add(this.btnCancelar);
            this.gunaPanel4.Controls.Add(this.btnModificar);
            this.gunaPanel4.Controls.Add(this.btnGuardar);
            this.gunaPanel4.Controls.Add(this.btnNuevo);
            this.gunaPanel4.Location = new System.Drawing.Point(12, 304);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(366, 40);
            this.gunaPanel4.TabIndex = 72;
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
            // lblActi
            // 
            this.lblActi.AutoSize = true;
            this.lblActi.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActi.ForeColor = System.Drawing.Color.White;
            this.lblActi.Location = new System.Drawing.Point(743, 32);
            this.lblActi.Name = "lblActi";
            this.lblActi.Size = new System.Drawing.Size(57, 21);
            this.lblActi.TabIndex = 78;
            this.lblActi.Text = "Activos";
            // 
            // Activos
            // 
            this.Activos.BaseColor = System.Drawing.SystemColors.Control;
            this.Activos.Checked = true;
            this.Activos.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.Activos.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Activos.FillColor = System.Drawing.Color.White;
            this.Activos.Location = new System.Drawing.Point(697, 32);
            this.Activos.Name = "Activos";
            this.Activos.Size = new System.Drawing.Size(40, 22);
            this.Activos.TabIndex = 77;
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
            this.btnImprimir.Location = new System.Drawing.Point(576, 23);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnImprimir.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnImprimir.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnImprimir.OnHoverImage = null;
            this.btnImprimir.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnImprimir.OnPressedColor = System.Drawing.Color.Black;
            this.btnImprimir.Size = new System.Drawing.Size(100, 30);
            this.btnImprimir.TabIndex = 73;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(411, 32);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(158, 22);
            this.txtBuscar.TabIndex = 76;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valdacionSoloNums);
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
            this.focusBuscar.Location = new System.Drawing.Point(410, 30);
            this.focusBuscar.Name = "focusBuscar";
            this.focusBuscar.PasswordChar = '\0';
            this.focusBuscar.Size = new System.Drawing.Size(160, 26);
            this.focusBuscar.TabIndex = 75;
            this.focusBuscar.Enter += new System.EventHandler(this.focusBuscar_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(356, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 21);
            this.label13.TabIndex = 74;
            this.label13.Text = "Buscar:";
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
            this.txtIdUsuario.Location = new System.Drawing.Point(148, 134);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.PasswordChar = '\0';
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(105, 26);
            this.txtIdUsuario.TabIndex = 67;
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
            this.txtActivo.Location = new System.Drawing.Point(148, 101);
            this.txtActivo.Name = "txtActivo";
            this.txtActivo.PasswordChar = '\0';
            this.txtActivo.ReadOnly = true;
            this.txtActivo.Size = new System.Drawing.Size(105, 26);
            this.txtActivo.TabIndex = 66;
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
            this.focusnum.Location = new System.Drawing.Point(147, 33);
            this.focusnum.Name = "focusnum";
            this.focusnum.PasswordChar = '\0';
            this.focusnum.ReadOnly = true;
            this.focusnum.Size = new System.Drawing.Size(105, 26);
            this.focusnum.TabIndex = 68;
            this.focusnum.Enter += new System.EventHandler(this.focusnum_Enter);
            // 
            // frmCajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(830, 393);
            this.Controls.Add(this.lblActi);
            this.Controls.Add(this.Activos);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.focusBuscar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.gunaPanel4);
            this.Controls.Add(this.dgvCajas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grbCajas);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCajas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCajas";
            this.Load += new System.EventHandler(this.FrmCajas_Load);
            this.mcCajas.ResumeLayout(false);
            this.grbCajas.ResumeLayout(false);
            this.grbCajas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajas)).EndInit();
            this.gunaPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIdSucursal;
        private System.Windows.Forms.ComboBox cmbSucursales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblHoraRegistro;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ContextMenuStrip mcCajas;
        private System.Windows.Forms.ToolStripMenuItem btnModificarCaja;
        private System.Windows.Forms.ToolStripMenuItem btnDesactivarCaja;
        private System.Windows.Forms.ToolStripMenuItem btnActivarCaja;
        private System.Windows.Forms.Label idusuario;
        private Guna.UI.WinForms.GunaShadowPanel grbCajas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvCajas;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaAdvenceButton btnCancelar;
        private Guna.UI.WinForms.GunaAdvenceButton btnModificar;
        private Guna.UI.WinForms.GunaAdvenceButton btnGuardar;
        private Guna.UI.WinForms.GunaAdvenceButton btnNuevo;
        private System.Windows.Forms.Label lblActi;
        private Guna.UI.WinForms.GunaWinSwitch Activos;
        private Guna.UI.WinForms.GunaAdvenceButton btnImprimir;
        private System.Windows.Forms.TextBox txtBuscar;
        private Guna.UI.WinForms.GunaLineTextBox focusBuscar;
        private System.Windows.Forms.Label label13;
        private Guna.UI.WinForms.GunaLineTextBox txtIdUsuario;
        private Guna.UI.WinForms.GunaLineTextBox txtActivo;
        private Guna.UI.WinForms.GunaLineTextBox focusnum;
    }
}