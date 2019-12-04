namespace PaperShop
{
    partial class frmManSalidas
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
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtIdU = new System.Windows.Forms.TextBox();
            this.lblHoraRegistro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSalida = new System.Windows.Forms.TabPage();
            this.lblActi = new System.Windows.Forms.Label();
            this.Activo = new Guna.UI.WinForms.GunaWinSwitch();
            this.btnTicket = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnEliminarSalida = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnCancelarSalida = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnImprimirSalida = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfolio = new System.Windows.Forms.TextBox();
            this.dgvSalidas = new System.Windows.Forms.DataGridView();
            this.cmSalidas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarSalidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabSalidaDetalle = new System.Windows.Forms.TabPage();
            this.lblActiDs = new System.Windows.Forms.Label();
            this.ActivoDs = new Guna.UI.WinForms.GunaWinSwitch();
            this.btnfoliods = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnEliminarDS = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnCancelarDS = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnImprimirDS = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtfoliods = new System.Windows.Forms.TextBox();
            this.dgvProductosDS = new System.Windows.Forms.DataGridView();
            this.dgvCantidadProducto = new System.Windows.Forms.DataGridView();
            this.txtDescripcionDS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabSalida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).BeginInit();
            this.cmSalidas.SuspendLayout();
            this.tabSalidaDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCantidadProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(122, 217);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(54, 20);
            this.txtCantidad.TabIndex = 12;
            this.txtCantidad.Visible = false;
            // 
            // txtIdU
            // 
            this.txtIdU.Location = new System.Drawing.Point(146, 194);
            this.txtIdU.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdU.Name = "txtIdU";
            this.txtIdU.Size = new System.Drawing.Size(30, 20);
            this.txtIdU.TabIndex = 13;
            this.txtIdU.Visible = false;
            // 
            // lblHoraRegistro
            // 
            this.lblHoraRegistro.AutoSize = true;
            this.lblHoraRegistro.Location = new System.Drawing.Point(10, 218);
            this.lblHoraRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraRegistro.Name = "lblHoraRegistro";
            this.lblHoraRegistro.Size = new System.Drawing.Size(75, 13);
            this.lblHoraRegistro.TabIndex = 7;
            this.lblHoraRegistro.Text = "Hora_Registro";
            this.lblHoraRegistro.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "IdU";
            this.label3.Visible = false;
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Location = new System.Drawing.Point(10, 198);
            this.lblFechaRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(82, 13);
            this.lblFechaRegistro.TabIndex = 9;
            this.lblFechaRegistro.Text = "Fecha_Registro";
            this.lblFechaRegistro.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSalida);
            this.tabControl1.Controls.Add(this.tabSalidaDetalle);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(173, 133);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(666, 364);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.Click += new System.EventHandler(this.TabControl1_Click);
            // 
            // tabSalida
            // 
            this.tabSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.tabSalida.Controls.Add(this.lblActi);
            this.tabSalida.Controls.Add(this.Activo);
            this.tabSalida.Controls.Add(this.btnTicket);
            this.tabSalida.Controls.Add(this.btnEliminarSalida);
            this.tabSalida.Controls.Add(this.btnCancelarSalida);
            this.tabSalida.Controls.Add(this.btnImprimirSalida);
            this.tabSalida.Controls.Add(this.label6);
            this.tabSalida.Controls.Add(this.txtfolio);
            this.tabSalida.Controls.Add(this.dgvSalidas);
            this.tabSalida.Controls.Add(this.txtDescripcion);
            this.tabSalida.Controls.Add(this.label5);
            this.tabSalida.ForeColor = System.Drawing.Color.Black;
            this.tabSalida.Location = new System.Drawing.Point(4, 30);
            this.tabSalida.Margin = new System.Windows.Forms.Padding(2);
            this.tabSalida.Name = "tabSalida";
            this.tabSalida.Padding = new System.Windows.Forms.Padding(2);
            this.tabSalida.Size = new System.Drawing.Size(658, 330);
            this.tabSalida.TabIndex = 0;
            this.tabSalida.Text = "Mtto. Salidas Global";
            this.tabSalida.Click += new System.EventHandler(this.TabSalida_Click);
            // 
            // lblActi
            // 
            this.lblActi.AutoSize = true;
            this.lblActi.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActi.ForeColor = System.Drawing.Color.White;
            this.lblActi.Location = new System.Drawing.Point(306, 11);
            this.lblActi.Name = "lblActi";
            this.lblActi.Size = new System.Drawing.Size(57, 21);
            this.lblActi.TabIndex = 97;
            this.lblActi.Text = "Activos";
            // 
            // Activo
            // 
            this.Activo.BaseColor = System.Drawing.SystemColors.Control;
            this.Activo.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.Activo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Activo.FillColor = System.Drawing.Color.White;
            this.Activo.Location = new System.Drawing.Point(260, 10);
            this.Activo.Name = "Activo";
            this.Activo.Size = new System.Drawing.Size(40, 22);
            this.Activo.TabIndex = 96;
            this.Activo.CheckedChanged += new System.EventHandler(this.gunaWinSwitch1_CheckedChanged);
            // 
            // btnTicket
            // 
            this.btnTicket.AnimationHoverSpeed = 0.07F;
            this.btnTicket.AnimationSpeed = 0.03F;
            this.btnTicket.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnTicket.BorderColor = System.Drawing.Color.Black;
            this.btnTicket.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnTicket.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnTicket.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnTicket.CheckedForeColor = System.Drawing.Color.White;
            this.btnTicket.CheckedImage = null;
            this.btnTicket.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btnTicket.FocusedColor = System.Drawing.Color.Empty;
            this.btnTicket.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.ForeColor = System.Drawing.Color.White;
            this.btnTicket.Image = null;
            this.btnTicket.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTicket.LineBottom = 5;
            this.btnTicket.LineColor = System.Drawing.Color.Transparent;
            this.btnTicket.Location = new System.Drawing.Point(164, 7);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnTicket.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTicket.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnTicket.OnHoverImage = null;
            this.btnTicket.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnTicket.OnPressedColor = System.Drawing.Color.Black;
            this.btnTicket.Size = new System.Drawing.Size(80, 30);
            this.btnTicket.TabIndex = 40;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTicket.Click += new System.EventHandler(this.BtnTicket_Click);
            // 
            // btnEliminarSalida
            // 
            this.btnEliminarSalida.AnimationHoverSpeed = 0.07F;
            this.btnEliminarSalida.AnimationSpeed = 0.03F;
            this.btnEliminarSalida.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnEliminarSalida.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarSalida.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnEliminarSalida.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnEliminarSalida.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnEliminarSalida.CheckedForeColor = System.Drawing.Color.White;
            this.btnEliminarSalida.CheckedImage = null;
            this.btnEliminarSalida.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminarSalida.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminarSalida.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarSalida.ForeColor = System.Drawing.Color.White;
            this.btnEliminarSalida.Image = null;
            this.btnEliminarSalida.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminarSalida.LineBottom = 5;
            this.btnEliminarSalida.LineColor = System.Drawing.Color.Transparent;
            this.btnEliminarSalida.Location = new System.Drawing.Point(395, 74);
            this.btnEliminarSalida.Name = "btnEliminarSalida";
            this.btnEliminarSalida.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnEliminarSalida.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminarSalida.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnEliminarSalida.OnHoverImage = null;
            this.btnEliminarSalida.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnEliminarSalida.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminarSalida.Size = new System.Drawing.Size(80, 30);
            this.btnEliminarSalida.TabIndex = 39;
            this.btnEliminarSalida.Text = "Eliminar";
            this.btnEliminarSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminarSalida.Click += new System.EventHandler(this.BtnEliminarSalida_Click);
            // 
            // btnCancelarSalida
            // 
            this.btnCancelarSalida.AnimationHoverSpeed = 0.07F;
            this.btnCancelarSalida.AnimationSpeed = 0.03F;
            this.btnCancelarSalida.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnCancelarSalida.BorderColor = System.Drawing.Color.Black;
            this.btnCancelarSalida.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnCancelarSalida.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnCancelarSalida.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCancelarSalida.CheckedForeColor = System.Drawing.Color.White;
            this.btnCancelarSalida.CheckedImage = null;
            this.btnCancelarSalida.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelarSalida.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancelarSalida.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarSalida.ForeColor = System.Drawing.Color.White;
            this.btnCancelarSalida.Image = null;
            this.btnCancelarSalida.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancelarSalida.LineBottom = 5;
            this.btnCancelarSalida.LineColor = System.Drawing.Color.Transparent;
            this.btnCancelarSalida.Location = new System.Drawing.Point(481, 74);
            this.btnCancelarSalida.Name = "btnCancelarSalida";
            this.btnCancelarSalida.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnCancelarSalida.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancelarSalida.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnCancelarSalida.OnHoverImage = null;
            this.btnCancelarSalida.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnCancelarSalida.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancelarSalida.Size = new System.Drawing.Size(80, 30);
            this.btnCancelarSalida.TabIndex = 38;
            this.btnCancelarSalida.Text = "Cancelar";
            this.btnCancelarSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancelarSalida.Click += new System.EventHandler(this.BtnCancelarSalida_Click);
            // 
            // btnImprimirSalida
            // 
            this.btnImprimirSalida.AnimationHoverSpeed = 0.07F;
            this.btnImprimirSalida.AnimationSpeed = 0.03F;
            this.btnImprimirSalida.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnImprimirSalida.BorderColor = System.Drawing.Color.Black;
            this.btnImprimirSalida.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnImprimirSalida.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnImprimirSalida.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnImprimirSalida.CheckedForeColor = System.Drawing.Color.White;
            this.btnImprimirSalida.CheckedImage = null;
            this.btnImprimirSalida.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btnImprimirSalida.FocusedColor = System.Drawing.Color.Empty;
            this.btnImprimirSalida.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirSalida.ForeColor = System.Drawing.Color.White;
            this.btnImprimirSalida.Image = null;
            this.btnImprimirSalida.ImageSize = new System.Drawing.Size(20, 20);
            this.btnImprimirSalida.LineBottom = 5;
            this.btnImprimirSalida.LineColor = System.Drawing.Color.Transparent;
            this.btnImprimirSalida.Location = new System.Drawing.Point(567, 74);
            this.btnImprimirSalida.Name = "btnImprimirSalida";
            this.btnImprimirSalida.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnImprimirSalida.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnImprimirSalida.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnImprimirSalida.OnHoverImage = null;
            this.btnImprimirSalida.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnImprimirSalida.OnPressedColor = System.Drawing.Color.Black;
            this.btnImprimirSalida.Size = new System.Drawing.Size(80, 30);
            this.btnImprimirSalida.TabIndex = 35;
            this.btnImprimirSalida.Text = "Imprimir";
            this.btnImprimirSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Folio:";
            // 
            // txtfolio
            // 
            this.txtfolio.Location = new System.Drawing.Point(58, 7);
            this.txtfolio.Name = "txtfolio";
            this.txtfolio.Size = new System.Drawing.Size(100, 29);
            this.txtfolio.TabIndex = 14;
            this.txtfolio.TextChanged += new System.EventHandler(this.Txtfolio_TextChanged);
            this.txtfolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtfolio_KeyPress);
            // 
            // dgvSalidas
            // 
            this.dgvSalidas.AllowUserToAddRows = false;
            this.dgvSalidas.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalidas.ContextMenuStrip = this.cmSalidas;
            this.dgvSalidas.Location = new System.Drawing.Point(12, 115);
            this.dgvSalidas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSalidas.Name = "dgvSalidas";
            this.dgvSalidas.ReadOnly = true;
            this.dgvSalidas.RowHeadersWidth = 51;
            this.dgvSalidas.RowTemplate.Height = 24;
            this.dgvSalidas.Size = new System.Drawing.Size(635, 201);
            this.dgvSalidas.TabIndex = 5;
            this.dgvSalidas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSalidas_CellDoubleClick);
            // 
            // cmSalidas
            // 
            this.cmSalidas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarSalidaToolStripMenuItem});
            this.cmSalidas.Name = "cmSalidas";
            this.cmSalidas.Size = new System.Drawing.Size(160, 26);
            // 
            // modificarSalidaToolStripMenuItem
            // 
            this.modificarSalidaToolStripMenuItem.Name = "modificarSalidaToolStripMenuItem";
            this.modificarSalidaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.modificarSalidaToolStripMenuItem.Text = "Modificar Salida";
            this.modificarSalidaToolStripMenuItem.Click += new System.EventHandler(this.ModificarSalidaToolStripMenuItem_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(56, 74);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(307, 29);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Descripción o nota:";
            // 
            // tabSalidaDetalle
            // 
            this.tabSalidaDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.tabSalidaDetalle.Controls.Add(this.lblActiDs);
            this.tabSalidaDetalle.Controls.Add(this.ActivoDs);
            this.tabSalidaDetalle.Controls.Add(this.btnfoliods);
            this.tabSalidaDetalle.Controls.Add(this.btnEliminarDS);
            this.tabSalidaDetalle.Controls.Add(this.btnCancelarDS);
            this.tabSalidaDetalle.Controls.Add(this.btnImprimirDS);
            this.tabSalidaDetalle.Controls.Add(this.label7);
            this.tabSalidaDetalle.Controls.Add(this.txtfoliods);
            this.tabSalidaDetalle.Controls.Add(this.dgvProductosDS);
            this.tabSalidaDetalle.Controls.Add(this.dgvCantidadProducto);
            this.tabSalidaDetalle.Controls.Add(this.txtDescripcionDS);
            this.tabSalidaDetalle.Controls.Add(this.label4);
            this.tabSalidaDetalle.Location = new System.Drawing.Point(4, 30);
            this.tabSalidaDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.tabSalidaDetalle.Name = "tabSalidaDetalle";
            this.tabSalidaDetalle.Padding = new System.Windows.Forms.Padding(2);
            this.tabSalidaDetalle.Size = new System.Drawing.Size(658, 330);
            this.tabSalidaDetalle.TabIndex = 1;
            this.tabSalidaDetalle.Text = "Mtto. Salida por Detalle";
            // 
            // lblActiDs
            // 
            this.lblActiDs.AutoSize = true;
            this.lblActiDs.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiDs.ForeColor = System.Drawing.Color.White;
            this.lblActiDs.Location = new System.Drawing.Point(306, 13);
            this.lblActiDs.Name = "lblActiDs";
            this.lblActiDs.Size = new System.Drawing.Size(57, 21);
            this.lblActiDs.TabIndex = 98;
            this.lblActiDs.Text = "Activos";
            // 
            // ActivoDs
            // 
            this.ActivoDs.BaseColor = System.Drawing.SystemColors.Control;
            this.ActivoDs.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.ActivoDs.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ActivoDs.FillColor = System.Drawing.Color.White;
            this.ActivoDs.Location = new System.Drawing.Point(259, 13);
            this.ActivoDs.Name = "ActivoDs";
            this.ActivoDs.Size = new System.Drawing.Size(40, 22);
            this.ActivoDs.TabIndex = 97;
            this.ActivoDs.CheckedChanged += new System.EventHandler(this.gunaWinSwitch1_CheckedChanged_1);
            // 
            // btnfoliods
            // 
            this.btnfoliods.AnimationHoverSpeed = 0.07F;
            this.btnfoliods.AnimationSpeed = 0.03F;
            this.btnfoliods.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnfoliods.BorderColor = System.Drawing.Color.Black;
            this.btnfoliods.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnfoliods.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnfoliods.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnfoliods.CheckedForeColor = System.Drawing.Color.White;
            this.btnfoliods.CheckedImage = null;
            this.btnfoliods.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btnfoliods.FocusedColor = System.Drawing.Color.Empty;
            this.btnfoliods.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfoliods.ForeColor = System.Drawing.Color.White;
            this.btnfoliods.Image = null;
            this.btnfoliods.ImageSize = new System.Drawing.Size(20, 20);
            this.btnfoliods.LineBottom = 5;
            this.btnfoliods.LineColor = System.Drawing.Color.Transparent;
            this.btnfoliods.Location = new System.Drawing.Point(163, 5);
            this.btnfoliods.Name = "btnfoliods";
            this.btnfoliods.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnfoliods.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnfoliods.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnfoliods.OnHoverImage = null;
            this.btnfoliods.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnfoliods.OnPressedColor = System.Drawing.Color.Black;
            this.btnfoliods.Size = new System.Drawing.Size(80, 30);
            this.btnfoliods.TabIndex = 39;
            this.btnfoliods.Text = "Tickets";
            this.btnfoliods.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnfoliods.Click += new System.EventHandler(this.Btnfoliods_Click);
            // 
            // btnEliminarDS
            // 
            this.btnEliminarDS.AnimationHoverSpeed = 0.07F;
            this.btnEliminarDS.AnimationSpeed = 0.03F;
            this.btnEliminarDS.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnEliminarDS.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarDS.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnEliminarDS.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnEliminarDS.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnEliminarDS.CheckedForeColor = System.Drawing.Color.White;
            this.btnEliminarDS.CheckedImage = null;
            this.btnEliminarDS.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminarDS.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminarDS.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDS.ForeColor = System.Drawing.Color.White;
            this.btnEliminarDS.Image = null;
            this.btnEliminarDS.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminarDS.LineBottom = 5;
            this.btnEliminarDS.LineColor = System.Drawing.Color.Transparent;
            this.btnEliminarDS.Location = new System.Drawing.Point(387, 73);
            this.btnEliminarDS.Name = "btnEliminarDS";
            this.btnEliminarDS.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnEliminarDS.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminarDS.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnEliminarDS.OnHoverImage = null;
            this.btnEliminarDS.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnEliminarDS.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminarDS.Size = new System.Drawing.Size(80, 30);
            this.btnEliminarDS.TabIndex = 38;
            this.btnEliminarDS.Text = "Eliminar";
            this.btnEliminarDS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminarDS.Click += new System.EventHandler(this.BtnEliminarDS_Click);
            // 
            // btnCancelarDS
            // 
            this.btnCancelarDS.AnimationHoverSpeed = 0.07F;
            this.btnCancelarDS.AnimationSpeed = 0.03F;
            this.btnCancelarDS.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnCancelarDS.BorderColor = System.Drawing.Color.Black;
            this.btnCancelarDS.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnCancelarDS.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnCancelarDS.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCancelarDS.CheckedForeColor = System.Drawing.Color.White;
            this.btnCancelarDS.CheckedImage = null;
            this.btnCancelarDS.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelarDS.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancelarDS.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarDS.ForeColor = System.Drawing.Color.White;
            this.btnCancelarDS.Image = null;
            this.btnCancelarDS.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancelarDS.LineBottom = 5;
            this.btnCancelarDS.LineColor = System.Drawing.Color.Transparent;
            this.btnCancelarDS.Location = new System.Drawing.Point(473, 73);
            this.btnCancelarDS.Name = "btnCancelarDS";
            this.btnCancelarDS.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnCancelarDS.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancelarDS.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnCancelarDS.OnHoverImage = null;
            this.btnCancelarDS.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnCancelarDS.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancelarDS.Size = new System.Drawing.Size(80, 30);
            this.btnCancelarDS.TabIndex = 37;
            this.btnCancelarDS.Text = "Cancelar";
            this.btnCancelarDS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancelarDS.Click += new System.EventHandler(this.BtnCancelarDS_Click);
            // 
            // btnImprimirDS
            // 
            this.btnImprimirDS.AnimationHoverSpeed = 0.07F;
            this.btnImprimirDS.AnimationSpeed = 0.03F;
            this.btnImprimirDS.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnImprimirDS.BorderColor = System.Drawing.Color.Black;
            this.btnImprimirDS.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnImprimirDS.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnImprimirDS.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnImprimirDS.CheckedForeColor = System.Drawing.Color.White;
            this.btnImprimirDS.CheckedImage = null;
            this.btnImprimirDS.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btnImprimirDS.FocusedColor = System.Drawing.Color.Empty;
            this.btnImprimirDS.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirDS.ForeColor = System.Drawing.Color.White;
            this.btnImprimirDS.Image = null;
            this.btnImprimirDS.ImageSize = new System.Drawing.Size(20, 20);
            this.btnImprimirDS.LineBottom = 5;
            this.btnImprimirDS.LineColor = System.Drawing.Color.Transparent;
            this.btnImprimirDS.Location = new System.Drawing.Point(559, 73);
            this.btnImprimirDS.Name = "btnImprimirDS";
            this.btnImprimirDS.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnImprimirDS.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnImprimirDS.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnImprimirDS.OnHoverImage = null;
            this.btnImprimirDS.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnImprimirDS.OnPressedColor = System.Drawing.Color.Black;
            this.btnImprimirDS.Size = new System.Drawing.Size(80, 30);
            this.btnImprimirDS.TabIndex = 36;
            this.btnImprimirDS.Text = "Imprimir";
            this.btnImprimirDS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(2, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Folio:";
            // 
            // txtfoliods
            // 
            this.txtfoliods.Location = new System.Drawing.Point(57, 5);
            this.txtfoliods.Name = "txtfoliods";
            this.txtfoliods.Size = new System.Drawing.Size(100, 29);
            this.txtfoliods.TabIndex = 17;
            this.txtfoliods.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtfoliods_KeyPress);
            // 
            // dgvProductosDS
            // 
            this.dgvProductosDS.AllowUserToAddRows = false;
            this.dgvProductosDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosDS.ContextMenuStrip = this.cmSalidas;
            this.dgvProductosDS.Location = new System.Drawing.Point(20, 192);
            this.dgvProductosDS.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductosDS.Name = "dgvProductosDS";
            this.dgvProductosDS.ReadOnly = true;
            this.dgvProductosDS.RowHeadersWidth = 51;
            this.dgvProductosDS.RowTemplate.Height = 24;
            this.dgvProductosDS.Size = new System.Drawing.Size(619, 125);
            this.dgvProductosDS.TabIndex = 12;
            this.dgvProductosDS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductosDS_CellDoubleClick);
            // 
            // dgvCantidadProducto
            // 
            this.dgvCantidadProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCantidadProducto.Location = new System.Drawing.Point(20, 117);
            this.dgvCantidadProducto.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCantidadProducto.Name = "dgvCantidadProducto";
            this.dgvCantidadProducto.RowHeadersWidth = 51;
            this.dgvCantidadProducto.RowTemplate.Height = 24;
            this.dgvCantidadProducto.Size = new System.Drawing.Size(619, 71);
            this.dgvCantidadProducto.TabIndex = 12;
            // 
            // txtDescripcionDS
            // 
            this.txtDescripcionDS.Location = new System.Drawing.Point(48, 74);
            this.txtDescripcionDS.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionDS.Name = "txtDescripcionDS";
            this.txtDescripcionDS.Size = new System.Drawing.Size(307, 29);
            this.txtDescripcionDS.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descripción o nota:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 32);
            this.label8.TabIndex = 92;
            this.label8.Text = "Categoria Productos";
            // 
            // frmManSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(964, 511);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtIdU);
            this.Controls.Add(this.lblHoraRegistro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFechaRegistro);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManSalidas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManSalidas";
            this.Load += new System.EventHandler(this.FrmManSalidas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSalida.ResumeLayout(false);
            this.tabSalida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).EndInit();
            this.cmSalidas.ResumeLayout(false);
            this.tabSalidaDetalle.ResumeLayout(false);
            this.tabSalidaDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCantidadProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtIdU;
        private System.Windows.Forms.Label lblHoraRegistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.TabPage tabSalida;
        private System.Windows.Forms.DataGridView dgvSalidas;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabSalidaDetalle;
        private System.Windows.Forms.DataGridView dgvProductosDS;
        private System.Windows.Forms.DataGridView dgvCantidadProducto;
        private System.Windows.Forms.TextBox txtDescripcionDS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip cmSalidas;
        private System.Windows.Forms.ToolStripMenuItem modificarSalidaToolStripMenuItem;
        private System.Windows.Forms.TextBox txtfolio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtfoliods;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private Guna.UI.WinForms.GunaAdvenceButton btnImprimirSalida;
        private Guna.UI.WinForms.GunaAdvenceButton btnTicket;
        private Guna.UI.WinForms.GunaAdvenceButton btnEliminarSalida;
        private Guna.UI.WinForms.GunaAdvenceButton btnCancelarSalida;
        private Guna.UI.WinForms.GunaAdvenceButton btnCancelarDS;
        private Guna.UI.WinForms.GunaAdvenceButton btnImprimirDS;
        private Guna.UI.WinForms.GunaWinSwitch Activo;
        private System.Windows.Forms.Label lblActi;
        private System.Windows.Forms.Label lblActiDs;
        private Guna.UI.WinForms.GunaWinSwitch ActivoDs;
        private Guna.UI.WinForms.GunaAdvenceButton btnfoliods;
        private Guna.UI.WinForms.GunaAdvenceButton btnEliminarDS;
    }
}