namespace PaperShop
{
    partial class FrmAdmin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.cmIp = new System.Windows.Forms.ComboBox();
            this.TextBoxMENSAJES1 = new System.Windows.Forms.TextBox();
            this.NumM1 = new System.Windows.Forms.NumericUpDown();
            this.NumH1 = new System.Windows.Forms.NumericUpDown();
            this.TextBoxPUERTO1 = new System.Windows.Forms.TextBox();
            this.panelContenedorForm = new System.Windows.Forms.Panel();
            this.PanelAdios = new Guna.UI.WinForms.GunaShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonAPAGAR = new Guna.UI.WinForms.GunaButton();
            this.ButtonREINICIAR = new Guna.UI.WinForms.GunaButton();
            this.ButtonCERRAR = new Guna.UI.WinForms.GunaButton();
            this.ButtonBLOQUEO = new Guna.UI.WinForms.GunaButton();
            this.ButtonAÑADIR = new Guna.UI.WinForms.GunaButton();
            this.BtnIniciar = new Guna.UI.WinForms.GunaButton();
            this.BntNuevaMaquina = new Guna.UI.WinForms.GunaButton();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumH1)).BeginInit();
            this.panelContenedorForm.SuspendLayout();
            this.PanelAdios.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmIp
            // 
            this.cmIp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmIp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmIp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmIp.FormattingEnabled = true;
            this.cmIp.Items.AddRange(new object[] {
            "Maquina 1",
            "Maquina 2"});
            this.cmIp.Location = new System.Drawing.Point(229, 69);
            this.cmIp.Name = "cmIp";
            this.cmIp.Size = new System.Drawing.Size(198, 24);
            this.cmIp.TabIndex = 67;
            this.cmIp.SelectedIndexChanged += new System.EventHandler(this.cmIp_SelectedIndexChanged);
            // 
            // TextBoxMENSAJES1
            // 
            this.TextBoxMENSAJES1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.TextBoxMENSAJES1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxMENSAJES1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMENSAJES1.ForeColor = System.Drawing.Color.Cornsilk;
            this.TextBoxMENSAJES1.HideSelection = false;
            this.TextBoxMENSAJES1.Location = new System.Drawing.Point(195, 235);
            this.TextBoxMENSAJES1.Multiline = true;
            this.TextBoxMENSAJES1.Name = "TextBoxMENSAJES1";
            this.TextBoxMENSAJES1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxMENSAJES1.Size = new System.Drawing.Size(267, 93);
            this.TextBoxMENSAJES1.TabIndex = 63;
            this.TextBoxMENSAJES1.Text = "Enviar Mensaje";
            this.TextBoxMENSAJES1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxMENSAJES1_KeyDown);
            // 
            // NumM1
            // 
            this.NumM1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.NumM1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumM1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.NumM1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumM1.Location = new System.Drawing.Point(341, 135);
            this.NumM1.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NumM1.Name = "NumM1";
            this.NumM1.Size = new System.Drawing.Size(60, 20);
            this.NumM1.TabIndex = 59;
            this.NumM1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumM1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // NumH1
            // 
            this.NumH1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.NumH1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumH1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.NumH1.Location = new System.Drawing.Point(261, 135);
            this.NumH1.Name = "NumH1";
            this.NumH1.Size = new System.Drawing.Size(60, 20);
            this.NumH1.TabIndex = 58;
            this.NumH1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxPUERTO1
            // 
            this.TextBoxPUERTO1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.TextBoxPUERTO1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxPUERTO1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxPUERTO1.Location = new System.Drawing.Point(229, 103);
            this.TextBoxPUERTO1.Name = "TextBoxPUERTO1";
            this.TextBoxPUERTO1.Size = new System.Drawing.Size(198, 20);
            this.TextBoxPUERTO1.TabIndex = 57;
            this.TextBoxPUERTO1.Text = "55555";
            this.TextBoxPUERTO1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelContenedorForm
            // 
            this.panelContenedorForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.panelContenedorForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContenedorForm.Controls.Add(this.PanelAdios);
            this.panelContenedorForm.Controls.Add(this.label14);
            this.panelContenedorForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorForm.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorForm.Name = "panelContenedorForm";
            this.panelContenedorForm.Size = new System.Drawing.Size(980, 550);
            this.panelContenedorForm.TabIndex = 70;
            // 
            // PanelAdios
            // 
            this.PanelAdios.BackColor = System.Drawing.Color.Transparent;
            this.PanelAdios.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.PanelAdios.Controls.Add(this.label1);
            this.PanelAdios.Controls.Add(this.label4);
            this.PanelAdios.Controls.Add(this.cmIp);
            this.PanelAdios.Controls.Add(this.ButtonAPAGAR);
            this.PanelAdios.Controls.Add(this.TextBoxPUERTO1);
            this.PanelAdios.Controls.Add(this.ButtonREINICIAR);
            this.PanelAdios.Controls.Add(this.TextBoxMENSAJES1);
            this.PanelAdios.Controls.Add(this.ButtonCERRAR);
            this.PanelAdios.Controls.Add(this.NumH1);
            this.PanelAdios.Controls.Add(this.ButtonBLOQUEO);
            this.PanelAdios.Controls.Add(this.NumM1);
            this.PanelAdios.Controls.Add(this.ButtonAÑADIR);
            this.PanelAdios.Controls.Add(this.BtnIniciar);
            this.PanelAdios.Controls.Add(this.BntNuevaMaquina);
            this.PanelAdios.Location = new System.Drawing.Point(185, 70);
            this.PanelAdios.Name = "PanelAdios";
            this.PanelAdios.ShadowColor = System.Drawing.Color.Black;
            this.PanelAdios.Size = new System.Drawing.Size(650, 450);
            this.PanelAdios.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 78;
            this.label1.Text = "Nombre.-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(72, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 77;
            this.label4.Text = "Domicilio.-";
            // 
            // ButtonAPAGAR
            // 
            this.ButtonAPAGAR.AnimationHoverSpeed = 0.07F;
            this.ButtonAPAGAR.AnimationSpeed = 0.03F;
            this.ButtonAPAGAR.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAPAGAR.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ButtonAPAGAR.BorderColor = System.Drawing.Color.Black;
            this.ButtonAPAGAR.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonAPAGAR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAPAGAR.ForeColor = System.Drawing.Color.White;
            this.ButtonAPAGAR.Image = null;
            this.ButtonAPAGAR.ImageSize = new System.Drawing.Size(20, 20);
            this.ButtonAPAGAR.Location = new System.Drawing.Point(446, 354);
            this.ButtonAPAGAR.Name = "ButtonAPAGAR";
            this.ButtonAPAGAR.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ButtonAPAGAR.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonAPAGAR.OnHoverForeColor = System.Drawing.Color.White;
            this.ButtonAPAGAR.OnHoverImage = null;
            this.ButtonAPAGAR.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonAPAGAR.Radius = 5;
            this.ButtonAPAGAR.Size = new System.Drawing.Size(140, 40);
            this.ButtonAPAGAR.TabIndex = 76;
            this.ButtonAPAGAR.Text = "Apagar Remoto";
            this.ButtonAPAGAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonAPAGAR.Click += new System.EventHandler(this.ButtonAPAGAR_Click);
            // 
            // ButtonREINICIAR
            // 
            this.ButtonREINICIAR.AnimationHoverSpeed = 0.07F;
            this.ButtonREINICIAR.AnimationSpeed = 0.03F;
            this.ButtonREINICIAR.BackColor = System.Drawing.Color.Transparent;
            this.ButtonREINICIAR.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ButtonREINICIAR.BorderColor = System.Drawing.Color.Black;
            this.ButtonREINICIAR.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonREINICIAR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonREINICIAR.ForeColor = System.Drawing.Color.White;
            this.ButtonREINICIAR.Image = null;
            this.ButtonREINICIAR.ImageSize = new System.Drawing.Size(20, 20);
            this.ButtonREINICIAR.Location = new System.Drawing.Point(261, 354);
            this.ButtonREINICIAR.Name = "ButtonREINICIAR";
            this.ButtonREINICIAR.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ButtonREINICIAR.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonREINICIAR.OnHoverForeColor = System.Drawing.Color.White;
            this.ButtonREINICIAR.OnHoverImage = null;
            this.ButtonREINICIAR.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonREINICIAR.Radius = 5;
            this.ButtonREINICIAR.Size = new System.Drawing.Size(140, 40);
            this.ButtonREINICIAR.TabIndex = 75;
            this.ButtonREINICIAR.Text = "Reiniciar Remoto";
            this.ButtonREINICIAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonREINICIAR.Click += new System.EventHandler(this.ButtonREINICIAR_Click);
            // 
            // ButtonCERRAR
            // 
            this.ButtonCERRAR.AnimationHoverSpeed = 0.07F;
            this.ButtonCERRAR.AnimationSpeed = 0.03F;
            this.ButtonCERRAR.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCERRAR.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ButtonCERRAR.BorderColor = System.Drawing.Color.Black;
            this.ButtonCERRAR.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonCERRAR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonCERRAR.ForeColor = System.Drawing.Color.White;
            this.ButtonCERRAR.Image = null;
            this.ButtonCERRAR.ImageSize = new System.Drawing.Size(20, 20);
            this.ButtonCERRAR.Location = new System.Drawing.Point(76, 354);
            this.ButtonCERRAR.Name = "ButtonCERRAR";
            this.ButtonCERRAR.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ButtonCERRAR.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonCERRAR.OnHoverForeColor = System.Drawing.Color.White;
            this.ButtonCERRAR.OnHoverImage = null;
            this.ButtonCERRAR.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonCERRAR.Radius = 5;
            this.ButtonCERRAR.Size = new System.Drawing.Size(140, 40);
            this.ButtonCERRAR.TabIndex = 74;
            this.ButtonCERRAR.Text = "Cerrar Aplicacion";
            this.ButtonCERRAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonCERRAR.Click += new System.EventHandler(this.ButtonCERRAR_Click);
            // 
            // ButtonBLOQUEO
            // 
            this.ButtonBLOQUEO.AnimationHoverSpeed = 0.07F;
            this.ButtonBLOQUEO.AnimationSpeed = 0.03F;
            this.ButtonBLOQUEO.BackColor = System.Drawing.Color.Transparent;
            this.ButtonBLOQUEO.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ButtonBLOQUEO.BorderColor = System.Drawing.Color.Black;
            this.ButtonBLOQUEO.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonBLOQUEO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonBLOQUEO.ForeColor = System.Drawing.Color.White;
            this.ButtonBLOQUEO.Image = null;
            this.ButtonBLOQUEO.ImageSize = new System.Drawing.Size(20, 20);
            this.ButtonBLOQUEO.Location = new System.Drawing.Point(446, 172);
            this.ButtonBLOQUEO.Name = "ButtonBLOQUEO";
            this.ButtonBLOQUEO.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ButtonBLOQUEO.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonBLOQUEO.OnHoverForeColor = System.Drawing.Color.White;
            this.ButtonBLOQUEO.OnHoverImage = null;
            this.ButtonBLOQUEO.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonBLOQUEO.Radius = 5;
            this.ButtonBLOQUEO.Size = new System.Drawing.Size(140, 40);
            this.ButtonBLOQUEO.TabIndex = 73;
            this.ButtonBLOQUEO.Text = "Bloquear Equipo";
            this.ButtonBLOQUEO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonBLOQUEO.Click += new System.EventHandler(this.ButtonBLOQUEO_Click);
            // 
            // ButtonAÑADIR
            // 
            this.ButtonAÑADIR.AnimationHoverSpeed = 0.07F;
            this.ButtonAÑADIR.AnimationSpeed = 0.03F;
            this.ButtonAÑADIR.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAÑADIR.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ButtonAÑADIR.BorderColor = System.Drawing.Color.Black;
            this.ButtonAÑADIR.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonAÑADIR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAÑADIR.ForeColor = System.Drawing.Color.White;
            this.ButtonAÑADIR.Image = null;
            this.ButtonAÑADIR.ImageSize = new System.Drawing.Size(20, 20);
            this.ButtonAÑADIR.Location = new System.Drawing.Point(261, 172);
            this.ButtonAÑADIR.Name = "ButtonAÑADIR";
            this.ButtonAÑADIR.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ButtonAÑADIR.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonAÑADIR.OnHoverForeColor = System.Drawing.Color.White;
            this.ButtonAÑADIR.OnHoverImage = null;
            this.ButtonAÑADIR.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonAÑADIR.Radius = 5;
            this.ButtonAÑADIR.Size = new System.Drawing.Size(140, 40);
            this.ButtonAÑADIR.TabIndex = 72;
            this.ButtonAÑADIR.Text = "Añadir T.";
            this.ButtonAÑADIR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonAÑADIR.Click += new System.EventHandler(this.ButtonAÑADIR_Click);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.AnimationHoverSpeed = 0.07F;
            this.BtnIniciar.AnimationSpeed = 0.03F;
            this.BtnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.BtnIniciar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BtnIniciar.BorderColor = System.Drawing.Color.Black;
            this.BtnIniciar.FocusedColor = System.Drawing.Color.Empty;
            this.BtnIniciar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnIniciar.ForeColor = System.Drawing.Color.White;
            this.BtnIniciar.Image = null;
            this.BtnIniciar.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnIniciar.Location = new System.Drawing.Point(76, 172);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnIniciar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnIniciar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnIniciar.OnHoverImage = null;
            this.BtnIniciar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnIniciar.Radius = 5;
            this.BtnIniciar.Size = new System.Drawing.Size(140, 40);
            this.BtnIniciar.TabIndex = 70;
            this.BtnIniciar.Text = "Inicio";
            this.BtnIniciar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // BntNuevaMaquina
            // 
            this.BntNuevaMaquina.AnimationHoverSpeed = 0.07F;
            this.BntNuevaMaquina.AnimationSpeed = 0.03F;
            this.BntNuevaMaquina.BackColor = System.Drawing.Color.Transparent;
            this.BntNuevaMaquina.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BntNuevaMaquina.BorderColor = System.Drawing.Color.Black;
            this.BntNuevaMaquina.FocusedColor = System.Drawing.Color.Empty;
            this.BntNuevaMaquina.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BntNuevaMaquina.ForeColor = System.Drawing.Color.White;
            this.BntNuevaMaquina.Image = ((System.Drawing.Image)(resources.GetObject("BntNuevaMaquina.Image")));
            this.BntNuevaMaquina.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BntNuevaMaquina.ImageSize = new System.Drawing.Size(20, 20);
            this.BntNuevaMaquina.Location = new System.Drawing.Point(446, 66);
            this.BntNuevaMaquina.Name = "BntNuevaMaquina";
            this.BntNuevaMaquina.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BntNuevaMaquina.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BntNuevaMaquina.OnHoverForeColor = System.Drawing.Color.White;
            this.BntNuevaMaquina.OnHoverImage = null;
            this.BntNuevaMaquina.OnPressedColor = System.Drawing.Color.Black;
            this.BntNuevaMaquina.Radius = 5;
            this.BntNuevaMaquina.Size = new System.Drawing.Size(27, 27);
            this.BntNuevaMaquina.TabIndex = 71;
            this.BntNuevaMaquina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BntNuevaMaquina.Click += new System.EventHandler(this.BntNuevaMaquina_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(23, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(211, 37);
            this.label14.TabIndex = 76;
            this.label14.Text = "Sala de Cómputo";
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 550);
            this.Controls.Add(this.panelContenedorForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdmin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumH1)).EndInit();
            this.panelContenedorForm.ResumeLayout(false);
            this.panelContenedorForm.PerformLayout();
            this.PanelAdios.ResumeLayout(false);
            this.PanelAdios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.ComboBox cmIp;
        internal System.Windows.Forms.TextBox TextBoxMENSAJES1;
        internal System.Windows.Forms.NumericUpDown NumM1;
        internal System.Windows.Forms.NumericUpDown NumH1;
        internal System.Windows.Forms.TextBox TextBoxPUERTO1;
        private System.Windows.Forms.Panel panelContenedorForm;
        private Guna.UI.WinForms.GunaButton ButtonAÑADIR;
        private Guna.UI.WinForms.GunaButton BntNuevaMaquina;
        private Guna.UI.WinForms.GunaButton BtnIniciar;
        private Guna.UI.WinForms.GunaButton ButtonAPAGAR;
        private Guna.UI.WinForms.GunaButton ButtonREINICIAR;
        private Guna.UI.WinForms.GunaButton ButtonCERRAR;
        private Guna.UI.WinForms.GunaButton ButtonBLOQUEO;
        private System.Windows.Forms.Label label14;
        private Guna.UI.WinForms.GunaShadowPanel PanelAdios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

