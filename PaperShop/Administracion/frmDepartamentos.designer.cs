namespace PaperShop
{
    partial class frmDepartamentos
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
            this.mcDepartamentos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnModificarPuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDesactivarPuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnActivarPuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblHoraRegistro = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.FocusNombre = new Guna.UI.WinForms.GunaLineTextBox();
            this.focusext = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtIdUsuario = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtActivo = new Guna.UI.WinForms.GunaLineTextBox();
            this.grbDepartamentos = new System.Windows.Forms.Panel();
            this.lblActi = new System.Windows.Forms.Label();
            this.Activos = new Guna.UI.WinForms.GunaWinSwitch();
            this.focusbuscar = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.btnCancelar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnModificar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnGuardar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnNuevo = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnImprimir = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDepartamentos = new System.Windows.Forms.DataGridView();
            this.mcDepartamentos.SuspendLayout();
            this.grbDepartamentos.SuspendLayout();
            this.gunaPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // mcDepartamentos
            // 
            this.mcDepartamentos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mcDepartamentos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnModificarPuesto,
            this.btnDesactivarPuesto,
            this.btnActivarPuesto});
            this.mcDepartamentos.Name = "mcPuestos";
            this.mcDepartamentos.Size = new System.Drawing.Size(129, 70);
            this.mcDepartamentos.Opening += new System.ComponentModel.CancelEventHandler(this.McDepartamentos_Opening);
            // 
            // btnModificarPuesto
            // 
            this.btnModificarPuesto.Name = "btnModificarPuesto";
            this.btnModificarPuesto.Size = new System.Drawing.Size(128, 22);
            this.btnModificarPuesto.Text = "Modificar";
            this.btnModificarPuesto.Click += new System.EventHandler(this.BtnModificarPuesto_Click);
            // 
            // btnDesactivarPuesto
            // 
            this.btnDesactivarPuesto.Name = "btnDesactivarPuesto";
            this.btnDesactivarPuesto.Size = new System.Drawing.Size(128, 22);
            this.btnDesactivarPuesto.Text = "Desactivar";
            this.btnDesactivarPuesto.Click += new System.EventHandler(this.BtnDesactivarPuesto_Click);
            // 
            // btnActivarPuesto
            // 
            this.btnActivarPuesto.Name = "btnActivarPuesto";
            this.btnActivarPuesto.Size = new System.Drawing.Size(128, 22);
            this.btnActivarPuesto.Text = "Activar";
            this.btnActivarPuesto.Click += new System.EventHandler(this.BtnActivarPuesto_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(425, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 21);
            this.label10.TabIndex = 37;
            this.label10.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Extensión";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(32, 17);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(65, 21);
            this.lblnombre.TabIndex = 3;
            this.lblnombre.Text = "Nombre";
            // 
            // lblHoraRegistro
            // 
            this.lblHoraRegistro.AutoSize = true;
            this.lblHoraRegistro.Location = new System.Drawing.Point(241, 154);
            this.lblHoraRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraRegistro.Name = "lblHoraRegistro";
            this.lblHoraRegistro.Size = new System.Drawing.Size(104, 21);
            this.lblHoraRegistro.TabIndex = 3;
            this.lblHoraRegistro.Text = "Hora_Registro";
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Location = new System.Drawing.Point(235, 126);
            this.lblFechaRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(110, 21);
            this.lblFechaRegistro.TabIndex = 3;
            this.lblFechaRegistro.Text = "Fecha_Registro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Id_Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Activo:";
            // 
            // txtExtension
            // 
            this.txtExtension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtExtension.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExtension.ForeColor = System.Drawing.Color.White;
            this.txtExtension.Location = new System.Drawing.Point(100, 51);
            this.txtExtension.Margin = new System.Windows.Forms.Padding(2);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(158, 22);
            this.txtExtension.TabIndex = 2;
            this.txtExtension.Enter += new System.EventHandler(this.txtExtension_Enter);
            this.txtExtension.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtExtension_KeyDown);
            this.txtExtension.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valdacionNum);
            this.txtExtension.Leave += new System.EventHandler(this.txtExtension_Leave);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(482, 33);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(159, 22);
            this.txtBuscar.TabIndex = 31;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valdacionLetras);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(101, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 22);
            this.txtNombre.TabIndex = 15;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNombre_KeyDown);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valdacionLetras);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
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
            this.FocusNombre.Location = new System.Drawing.Point(100, 17);
            this.FocusNombre.Name = "FocusNombre";
            this.FocusNombre.PasswordChar = '\0';
            this.FocusNombre.ReadOnly = true;
            this.FocusNombre.Size = new System.Drawing.Size(160, 26);
            this.FocusNombre.TabIndex = 14;
            this.FocusNombre.Enter += new System.EventHandler(this.FocusNombre_Enter);
            // 
            // focusext
            // 
            this.focusext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focusext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focusext.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focusext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.focusext.ForeColor = System.Drawing.Color.White;
            this.focusext.LineColor = System.Drawing.Color.Gainsboro;
            this.focusext.LineSize = 2;
            this.focusext.Location = new System.Drawing.Point(99, 49);
            this.focusext.Name = "focusext";
            this.focusext.PasswordChar = '\0';
            this.focusext.ReadOnly = true;
            this.focusext.Size = new System.Drawing.Size(160, 26);
            this.focusext.TabIndex = 16;
            this.focusext.Enter += new System.EventHandler(this.gunaLineTextBox1_Enter);
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
            this.txtIdUsuario.Location = new System.Drawing.Point(97, 110);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.PasswordChar = '\0';
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(94, 26);
            this.txtIdUsuario.TabIndex = 80;
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
            this.txtActivo.Location = new System.Drawing.Point(97, 78);
            this.txtActivo.Name = "txtActivo";
            this.txtActivo.PasswordChar = '\0';
            this.txtActivo.ReadOnly = true;
            this.txtActivo.Size = new System.Drawing.Size(93, 26);
            this.txtActivo.TabIndex = 79;
            // 
            // grbDepartamentos
            // 
            this.grbDepartamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.grbDepartamentos.Controls.Add(this.txtIdUsuario);
            this.grbDepartamentos.Controls.Add(this.lblFechaRegistro);
            this.grbDepartamentos.Controls.Add(this.txtActivo);
            this.grbDepartamentos.Controls.Add(this.txtNombre);
            this.grbDepartamentos.Controls.Add(this.txtExtension);
            this.grbDepartamentos.Controls.Add(this.FocusNombre);
            this.grbDepartamentos.Controls.Add(this.label1);
            this.grbDepartamentos.Controls.Add(this.label2);
            this.grbDepartamentos.Controls.Add(this.label6);
            this.grbDepartamentos.Controls.Add(this.lblnombre);
            this.grbDepartamentos.Controls.Add(this.lblHoraRegistro);
            this.grbDepartamentos.Controls.Add(this.focusext);
            this.grbDepartamentos.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDepartamentos.ForeColor = System.Drawing.Color.White;
            this.grbDepartamentos.Location = new System.Drawing.Point(24, 69);
            this.grbDepartamentos.Name = "grbDepartamentos";
            this.grbDepartamentos.Size = new System.Drawing.Size(352, 184);
            this.grbDepartamentos.TabIndex = 41;
            // 
            // lblActi
            // 
            this.lblActi.AutoSize = true;
            this.lblActi.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActi.ForeColor = System.Drawing.Color.White;
            this.lblActi.Location = new System.Drawing.Point(835, 33);
            this.lblActi.Name = "lblActi";
            this.lblActi.Size = new System.Drawing.Size(57, 21);
            this.lblActi.TabIndex = 43;
            this.lblActi.Text = "Activos";
            // 
            // Activos
            // 
            this.Activos.BaseColor = System.Drawing.SystemColors.Control;
            this.Activos.Checked = true;
            this.Activos.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.Activos.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Activos.FillColor = System.Drawing.Color.White;
            this.Activos.Location = new System.Drawing.Point(789, 33);
            this.Activos.Name = "Activos";
            this.Activos.Size = new System.Drawing.Size(40, 22);
            this.Activos.TabIndex = 42;
            this.Activos.CheckedChanged += new System.EventHandler(this.Activos_CheckedChanged);
            // 
            // focusbuscar
            // 
            this.focusbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focusbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focusbuscar.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focusbuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.focusbuscar.ForeColor = System.Drawing.Color.White;
            this.focusbuscar.LineColor = System.Drawing.Color.Gainsboro;
            this.focusbuscar.LineSize = 2;
            this.focusbuscar.Location = new System.Drawing.Point(482, 31);
            this.focusbuscar.Name = "focusbuscar";
            this.focusbuscar.PasswordChar = '\0';
            this.focusbuscar.ReadOnly = true;
            this.focusbuscar.Size = new System.Drawing.Size(159, 26);
            this.focusbuscar.TabIndex = 81;
            this.focusbuscar.Enter += new System.EventHandler(this.gunaLineTextBox1_Enter_1);
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaPanel4.Controls.Add(this.btnCancelar);
            this.gunaPanel4.Controls.Add(this.btnModificar);
            this.gunaPanel4.Controls.Add(this.btnGuardar);
            this.gunaPanel4.Controls.Add(this.btnNuevo);
            this.gunaPanel4.Location = new System.Drawing.Point(11, 259);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(395, 40);
            this.gunaPanel4.TabIndex = 82;
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
            this.btnGuardar.Size = new System.Drawing.Size(101, 40);
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
            this.btnImprimir.Location = new System.Drawing.Point(663, 31);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnImprimir.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnImprimir.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnImprimir.OnHoverImage = null;
            this.btnImprimir.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnImprimir.OnPressedColor = System.Drawing.Color.Black;
            this.btnImprimir.Size = new System.Drawing.Size(100, 30);
            this.btnImprimir.TabIndex = 83;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 32);
            this.label3.TabIndex = 84;
            this.label3.Text = "Departamentos";
            // 
            // dgvDepartamentos
            // 
            this.dgvDepartamentos.AllowUserToAddRows = false;
            this.dgvDepartamentos.AllowUserToDeleteRows = false;
            this.dgvDepartamentos.AllowUserToResizeColumns = false;
            this.dgvDepartamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamentos.Location = new System.Drawing.Point(412, 69);
            this.dgvDepartamentos.Name = "dgvDepartamentos";
            this.dgvDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartamentos.Size = new System.Drawing.Size(516, 332);
            this.dgvDepartamentos.TabIndex = 85;
            // 
            // frmDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(940, 413);
            this.Controls.Add(this.dgvDepartamentos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.gunaPanel4);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.focusbuscar);
            this.Controls.Add(this.lblActi);
            this.Controls.Add(this.Activos);
            this.Controls.Add(this.grbDepartamentos);
            this.Controls.Add(this.label10);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDepartamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDepartamentos";
            this.Load += new System.EventHandler(this.FrmDepartamentos_Load);
            this.mcDepartamentos.ResumeLayout(false);
            this.grbDepartamentos.ResumeLayout(false);
            this.grbDepartamentos.PerformLayout();
            this.gunaPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblHoraRegistro;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ContextMenuStrip mcDepartamentos;
        private System.Windows.Forms.ToolStripMenuItem btnModificarPuesto;
        private System.Windows.Forms.ToolStripMenuItem btnDesactivarPuesto;
        private System.Windows.Forms.ToolStripMenuItem btnActivarPuesto;
        private System.Windows.Forms.TextBox txtNombre;
        private Guna.UI.WinForms.GunaLineTextBox FocusNombre;
        private Guna.UI.WinForms.GunaLineTextBox focusext;
        private Guna.UI.WinForms.GunaLineTextBox txtIdUsuario;
        private Guna.UI.WinForms.GunaLineTextBox txtActivo;
        private System.Windows.Forms.Panel grbDepartamentos;
        private System.Windows.Forms.Label lblActi;
        private Guna.UI.WinForms.GunaWinSwitch Activos;
        private Guna.UI.WinForms.GunaLineTextBox focusbuscar;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaAdvenceButton btnCancelar;
        private Guna.UI.WinForms.GunaAdvenceButton btnModificar;
        private Guna.UI.WinForms.GunaAdvenceButton btnGuardar;
        private Guna.UI.WinForms.GunaAdvenceButton btnNuevo;
        private Guna.UI.WinForms.GunaAdvenceButton btnImprimir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDepartamentos;
    }
}