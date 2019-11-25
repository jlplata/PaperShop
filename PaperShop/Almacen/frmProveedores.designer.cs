namespace PaperShop
{
    partial class frmProveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mcPro = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnModificarPro = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDesactivarPro = new System.Windows.Forms.ToolStripMenuItem();
            this.btnActivarPro = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.grppro = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtActivo = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.FocusNombre = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblHoraRegistro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.focusCorreo = new Guna.UI.WinForms.GunaLineTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.focusDomicilio = new Guna.UI.WinForms.GunaLineTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.btnCancelar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnModificar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnGuardar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btNuevo = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblActi = new System.Windows.Forms.Label();
            this.Activos = new Guna.UI.WinForms.GunaWinSwitch();
            this.btnImprimir = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.focusBuscar = new Guna.UI.WinForms.GunaLineTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvpro = new System.Windows.Forms.DataGridView();
            this.mcPro.SuspendLayout();
            this.grppro.SuspendLayout();
            this.gunaPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpro)).BeginInit();
            this.SuspendLayout();
            // 
            // mcPro
            // 
            this.mcPro.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mcPro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnModificarPro,
            this.btnDesactivarPro,
            this.btnActivarPro});
            this.mcPro.Name = "mcPuestos";
            this.mcPro.Size = new System.Drawing.Size(148, 76);
            this.mcPro.Opening += new System.ComponentModel.CancelEventHandler(this.McSucursales_Opening);
            // 
            // btnModificarPro
            // 
            this.btnModificarPro.Name = "btnModificarPro";
            this.btnModificarPro.Size = new System.Drawing.Size(147, 24);
            this.btnModificarPro.Text = "Modificar";
            this.btnModificarPro.Click += new System.EventHandler(this.BtnModificarPro_Click);
            // 
            // btnDesactivarPro
            // 
            this.btnDesactivarPro.Name = "btnDesactivarPro";
            this.btnDesactivarPro.Size = new System.Drawing.Size(147, 24);
            this.btnDesactivarPro.Text = "Desactivar";
            this.btnDesactivarPro.Click += new System.EventHandler(this.BtnDesactivarPro_Click);
            // 
            // btnActivarPro
            // 
            this.btnActivarPro.Name = "btnActivarPro";
            this.btnActivarPro.Size = new System.Drawing.Size(147, 24);
            this.btnActivarPro.Text = "Activar";
            this.btnActivarPro.Click += new System.EventHandler(this.BtnActivarPro_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 41);
            this.label9.TabIndex = 58;
            this.label9.Text = "Proveedores";
            // 
            // grppro
            // 
            this.grppro.Controls.Add(this.txtNombre);
            this.grppro.Controls.Add(this.txtIdUsuario);
            this.grppro.Controls.Add(this.txtActivo);
            this.grppro.Controls.Add(this.txtCorreo);
            this.grppro.Controls.Add(this.txtDomicilio);
            this.grppro.Controls.Add(this.FocusNombre);
            this.grppro.Controls.Add(this.lblHoraRegistro);
            this.grppro.Controls.Add(this.label1);
            this.grppro.Controls.Add(this.lblFechaRegistro);
            this.grppro.Controls.Add(this.txtTelefono);
            this.grppro.Controls.Add(this.label2);
            this.grppro.Controls.Add(this.focusCorreo);
            this.grppro.Controls.Add(this.label5);
            this.grppro.Controls.Add(this.label6);
            this.grppro.Controls.Add(this.label7);
            this.grppro.Controls.Add(this.focusDomicilio);
            this.grppro.Controls.Add(this.label16);
            this.grppro.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grppro.ForeColor = System.Drawing.Color.White;
            this.grppro.Location = new System.Drawing.Point(31, 75);
            this.grppro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grppro.Name = "grppro";
            this.grppro.Size = new System.Drawing.Size(406, 353);
            this.grppro.TabIndex = 64;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(150, 25);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(211, 27);
            this.txtNombre.TabIndex = 13;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
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
            this.txtIdUsuario.Location = new System.Drawing.Point(143, 220);
            this.txtIdUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.PasswordChar = '\0';
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(219, 39);
            this.txtIdUsuario.TabIndex = 12;
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
            this.txtActivo.Location = new System.Drawing.Point(143, 181);
            this.txtActivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtActivo.Name = "txtActivo";
            this.txtActivo.PasswordChar = '\0';
            this.txtActivo.ReadOnly = true;
            this.txtActivo.Size = new System.Drawing.Size(216, 39);
            this.txtActivo.TabIndex = 11;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCorreo.ForeColor = System.Drawing.Color.White;
            this.txtCorreo.Location = new System.Drawing.Point(147, 144);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(211, 27);
            this.txtCorreo.TabIndex = 39;
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCorreo_KeyDown_1);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDomicilio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDomicilio.ForeColor = System.Drawing.Color.White;
            this.txtDomicilio.Location = new System.Drawing.Point(150, 63);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(211, 27);
            this.txtDomicilio.TabIndex = 15;
            this.txtDomicilio.Enter += new System.EventHandler(this.txtDomicilio_Enter);
            this.txtDomicilio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDomicilio_KeyDown_1);
            this.txtDomicilio.Leave += new System.EventHandler(this.txtDomicilio_Leave);
            // 
            // FocusNombre
            // 
            this.FocusNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.FocusNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FocusNombre.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.FocusNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FocusNombre.ForeColor = System.Drawing.Color.White;
            this.FocusNombre.LineColor = System.Drawing.Color.Gainsboro;
            this.FocusNombre.LineSize = 2;
            this.FocusNombre.Location = new System.Drawing.Point(148, 16);
            this.FocusNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FocusNombre.Name = "FocusNombre";
            this.FocusNombre.PasswordChar = '\0';
            this.FocusNombre.ReadOnly = true;
            this.FocusNombre.Size = new System.Drawing.Size(213, 39);
            this.FocusNombre.TabIndex = 1;
            this.FocusNombre.Enter += new System.EventHandler(this.FocusNombre_Enter);
            // 
            // lblHoraRegistro
            // 
            this.lblHoraRegistro.AutoSize = true;
            this.lblHoraRegistro.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraRegistro.ForeColor = System.Drawing.Color.White;
            this.lblHoraRegistro.Location = new System.Drawing.Point(51, 315);
            this.lblHoraRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraRegistro.Name = "lblHoraRegistro";
            this.lblHoraRegistro.Size = new System.Drawing.Size(126, 28);
            this.lblHoraRegistro.TabIndex = 0;
            this.lblHoraRegistro.Text = "Hora_registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Usuario.-";
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistro.ForeColor = System.Drawing.Color.White;
            this.lblFechaRegistro.Location = new System.Drawing.Point(51, 279);
            this.lblFechaRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(133, 28);
            this.lblFechaRegistro.TabIndex = 0;
            this.lblFechaRegistro.Text = "Fecha_registro";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(150, 107);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Mask = "(999)000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(213, 27);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefono_KeyDown);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Razón Social.-";
            // 
            // focusCorreo
            // 
            this.focusCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focusCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focusCorreo.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focusCorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.focusCorreo.ForeColor = System.Drawing.Color.White;
            this.focusCorreo.LineColor = System.Drawing.Color.Gainsboro;
            this.focusCorreo.LineSize = 2;
            this.focusCorreo.Location = new System.Drawing.Point(146, 142);
            this.focusCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.focusCorreo.Name = "focusCorreo";
            this.focusCorreo.PasswordChar = '\0';
            this.focusCorreo.ReadOnly = true;
            this.focusCorreo.Size = new System.Drawing.Size(213, 39);
            this.focusCorreo.TabIndex = 6;
            this.focusCorreo.Enter += new System.EventHandler(this.focusCorreo_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Domicilio.-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(44, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Teléfono.-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(56, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Correo.-";
            // 
            // focusDomicilio
            // 
            this.focusDomicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focusDomicilio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focusDomicilio.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focusDomicilio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.focusDomicilio.ForeColor = System.Drawing.Color.White;
            this.focusDomicilio.LineColor = System.Drawing.Color.Gainsboro;
            this.focusDomicilio.LineSize = 2;
            this.focusDomicilio.Location = new System.Drawing.Point(148, 60);
            this.focusDomicilio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.focusDomicilio.Name = "focusDomicilio";
            this.focusDomicilio.PasswordChar = '\0';
            this.focusDomicilio.ReadOnly = true;
            this.focusDomicilio.Size = new System.Drawing.Size(213, 39);
            this.focusDomicilio.TabIndex = 4;
            this.focusDomicilio.Enter += new System.EventHandler(this.focusDomicilio_Enter);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(63, 186);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 28);
            this.label16.TabIndex = 0;
            this.label16.Text = "Activo.-";
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaPanel4.Controls.Add(this.btnCancelar);
            this.gunaPanel4.Controls.Add(this.btnModificar);
            this.gunaPanel4.Controls.Add(this.btnGuardar);
            this.gunaPanel4.Controls.Add(this.btNuevo);
            this.gunaPanel4.Location = new System.Drawing.Point(16, 446);
            this.gunaPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(527, 49);
            this.gunaPanel4.TabIndex = 85;
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
            this.btnCancelar.Location = new System.Drawing.Point(390, 0);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnCancelar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancelar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnCancelar.OnHoverImage = null;
            this.btnCancelar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnCancelar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancelar.Size = new System.Drawing.Size(135, 49);
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
            this.btnModificar.Location = new System.Drawing.Point(255, 0);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnModificar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModificar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnModificar.OnHoverImage = null;
            this.btnModificar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnModificar.OnPressedColor = System.Drawing.Color.Black;
            this.btnModificar.Size = new System.Drawing.Size(135, 49);
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
            this.btnGuardar.Location = new System.Drawing.Point(120, 0);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnGuardar.OnHoverImage = null;
            this.btnGuardar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardar.Size = new System.Drawing.Size(135, 49);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGuardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // btNuevo
            // 
            this.btNuevo.AnimationHoverSpeed = 0.07F;
            this.btNuevo.AnimationSpeed = 0.03F;
            this.btNuevo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btNuevo.BorderColor = System.Drawing.Color.Black;
            this.btNuevo.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btNuevo.Checked = true;
            this.btNuevo.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btNuevo.CheckedBorderColor = System.Drawing.Color.Black;
            this.btNuevo.CheckedForeColor = System.Drawing.Color.White;
            this.btNuevo.CheckedImage = null;
            this.btNuevo.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btNuevo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btNuevo.FocusedColor = System.Drawing.Color.Empty;
            this.btNuevo.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevo.ForeColor = System.Drawing.Color.White;
            this.btNuevo.Image = null;
            this.btNuevo.ImageSize = new System.Drawing.Size(20, 20);
            this.btNuevo.LineBottom = 5;
            this.btNuevo.LineColor = System.Drawing.Color.Transparent;
            this.btNuevo.Location = new System.Drawing.Point(0, 0);
            this.btNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btNuevo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btNuevo.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btNuevo.OnHoverImage = null;
            this.btNuevo.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btNuevo.OnPressedColor = System.Drawing.Color.Black;
            this.btNuevo.Size = new System.Drawing.Size(120, 49);
            this.btNuevo.TabIndex = 1;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btNuevo.Click += new System.EventHandler(this.Btnnuevo_Click);
            this.btNuevo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btNuevo_KeyDown);
            // 
            // lblActi
            // 
            this.lblActi.AutoSize = true;
            this.lblActi.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActi.ForeColor = System.Drawing.Color.White;
            this.lblActi.Location = new System.Drawing.Point(972, 49);
            this.lblActi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActi.Name = "lblActi";
            this.lblActi.Size = new System.Drawing.Size(72, 28);
            this.lblActi.TabIndex = 103;
            this.lblActi.Text = "Activos";
            // 
            // Activos
            // 
            this.Activos.BaseColor = System.Drawing.SystemColors.Control;
            this.Activos.Checked = true;
            this.Activos.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.Activos.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Activos.FillColor = System.Drawing.Color.White;
            this.Activos.Location = new System.Drawing.Point(911, 49);
            this.Activos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Activos.Name = "Activos";
            this.Activos.Size = new System.Drawing.Size(53, 27);
            this.Activos.TabIndex = 102;
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
            this.btnImprimir.Location = new System.Drawing.Point(749, 38);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnImprimir.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnImprimir.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnImprimir.OnHoverImage = null;
            this.btnImprimir.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnImprimir.OnPressedColor = System.Drawing.Color.Black;
            this.btnImprimir.Size = new System.Drawing.Size(133, 37);
            this.btnImprimir.TabIndex = 98;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(529, 49);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(211, 27);
            this.txtBuscar.TabIndex = 101;
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
            this.focusBuscar.Location = new System.Drawing.Point(528, 47);
            this.focusBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.focusBuscar.Name = "focusBuscar";
            this.focusBuscar.PasswordChar = '\0';
            this.focusBuscar.Size = new System.Drawing.Size(213, 37);
            this.focusBuscar.TabIndex = 100;
            this.focusBuscar.Enter += new System.EventHandler(this.focusBuscar_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(456, 49);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 28);
            this.label13.TabIndex = 99;
            this.label13.Text = "Buscar:";
            // 
            // dgvpro
            // 
            this.dgvpro.AllowUserToAddRows = false;
            this.dgvpro.AllowUserToDeleteRows = false;
            this.dgvpro.AllowUserToResizeRows = false;
            this.dgvpro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvpro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvpro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvpro.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvpro.Location = new System.Drawing.Point(461, 86);
            this.dgvpro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvpro.Name = "dgvpro";
            this.dgvpro.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvpro.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvpro.RowHeadersWidth = 51;
            this.dgvpro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpro.Size = new System.Drawing.Size(635, 342);
            this.dgvpro.TabIndex = 104;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1132, 521);
            this.Controls.Add(this.dgvpro);
            this.Controls.Add(this.lblActi);
            this.Controls.Add(this.Activos);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.focusBuscar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.gunaPanel4);
            this.Controls.Add(this.grppro);
            this.Controls.Add(this.label9);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProveedores";
            this.Load += new System.EventHandler(this.FrmProveedores_Load);
            this.mcPro.ResumeLayout(false);
            this.grppro.ResumeLayout(false);
            this.grppro.PerformLayout();
            this.gunaPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip mcPro;
        private System.Windows.Forms.ToolStripMenuItem btnModificarPro;
        private System.Windows.Forms.ToolStripMenuItem btnDesactivarPro;
        private System.Windows.Forms.ToolStripMenuItem btnActivarPro;
        private System.Windows.Forms.Panel grppro;
        private System.Windows.Forms.TextBox txtNombre;
        private Guna.UI.WinForms.GunaLineTextBox txtIdUsuario;
        private Guna.UI.WinForms.GunaLineTextBox txtActivo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDomicilio;
        private Guna.UI.WinForms.GunaLineTextBox FocusNombre;
        private System.Windows.Forms.Label lblHoraRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLineTextBox focusCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaLineTextBox focusDomicilio;
        private System.Windows.Forms.Label label16;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaAdvenceButton btnCancelar;
        private Guna.UI.WinForms.GunaAdvenceButton btnModificar;
        private Guna.UI.WinForms.GunaAdvenceButton btnGuardar;
        private Guna.UI.WinForms.GunaAdvenceButton btNuevo;
        private System.Windows.Forms.Label lblActi;
        private Guna.UI.WinForms.GunaWinSwitch Activos;
        private Guna.UI.WinForms.GunaAdvenceButton btnImprimir;
        private System.Windows.Forms.TextBox txtBuscar;
        private Guna.UI.WinForms.GunaLineTextBox focusBuscar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvpro;
    }
}