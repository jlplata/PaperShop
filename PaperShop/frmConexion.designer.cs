namespace PaperShop
{
    partial class frmConexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConexion));
            this.cmbbasededatos = new System.Windows.Forms.ComboBox();
            this.cboServer = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCerrar = new Guna.UI.WinForms.GunaImageButton();
            this.BtnMinimizar = new Guna.UI.WinForms.GunaImageButton();
            this.BtnGuardar = new Guna.UI.WinForms.GunaGradientButton();
            this.btnbasedatos = new Guna.UI.WinForms.GunaAdvenceButton();
            this.GunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbbasededatos
            // 
            this.cmbbasededatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbasededatos.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbasededatos.FormattingEnabled = true;
            this.cmbbasededatos.Location = new System.Drawing.Point(93, 176);
            this.cmbbasededatos.Name = "cmbbasededatos";
            this.cmbbasededatos.Size = new System.Drawing.Size(196, 29);
            this.cmbbasededatos.TabIndex = 2;
            this.cmbbasededatos.Visible = false;
            this.cmbbasededatos.SelectedIndexChanged += new System.EventHandler(this.cmbbasededatos_SelectedIndexChanged);
            // 
            // cboServer
            // 
            this.cboServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboServer.FormattingEnabled = true;
            this.cboServer.Location = new System.Drawing.Point(64, 141);
            this.cboServer.Name = "cboServer";
            this.cboServer.Size = new System.Drawing.Size(251, 29);
            this.cboServer.TabIndex = 4;
            this.cboServer.SelectedIndexChanged += new System.EventHandler(this.cboServer_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(68, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(244, 37);
            this.label14.TabIndex = 7;
            this.label14.Text = "Configuracion Inicial";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Controls.Add(this.BtnMinimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 40);
            this.panel1.TabIndex = 9;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnCerrar.Location = new System.Drawing.Point(332, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.OnHoverImage = null;
            this.BtnCerrar.OnHoverImageOffset = new System.Drawing.Point(0, -1);
            this.BtnCerrar.Size = new System.Drawing.Size(32, 32);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            this.BtnCerrar.MouseEnter += new System.EventHandler(this.gunaImageButton3_MouseEnter);
            this.BtnCerrar.MouseLeave += new System.EventHandler(this.gunaImageButton3_MouseLeave);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.BtnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnMinimizar.Location = new System.Drawing.Point(299, 0);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.OnHoverImage = null;
            this.BtnMinimizar.OnHoverImageOffset = new System.Drawing.Point(0, -1);
            this.BtnMinimizar.Size = new System.Drawing.Size(32, 32);
            this.BtnMinimizar.TabIndex = 3;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            this.BtnMinimizar.MouseEnter += new System.EventHandler(this.gunaImageButton2_MouseEnter);
            this.BtnMinimizar.MouseLeave += new System.EventHandler(this.gunaImageButton2_MouseLeave);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.AnimationHoverSpeed = 0.07F;
            this.BtnGuardar.AnimationSpeed = 0.03F;
            this.BtnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.BtnGuardar.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.BtnGuardar.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Image = null;
            this.BtnGuardar.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnGuardar.Location = new System.Drawing.Point(67, 259);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.BtnGuardar.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.BtnGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnGuardar.OnHoverImage = null;
            this.BtnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnGuardar.Radius = 2;
            this.BtnGuardar.Size = new System.Drawing.Size(248, 37);
            this.BtnGuardar.TabIndex = 10;
            this.BtnGuardar.Text = "Iniciar";
            this.BtnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnGuardar.Visible = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnbasedatos
            // 
            this.btnbasedatos.AnimationHoverSpeed = 0.07F;
            this.btnbasedatos.AnimationSpeed = 0.03F;
            this.btnbasedatos.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnbasedatos.BorderColor = System.Drawing.Color.Black;
            this.btnbasedatos.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnbasedatos.Checked = true;
            this.btnbasedatos.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnbasedatos.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnbasedatos.CheckedForeColor = System.Drawing.Color.White;
            this.btnbasedatos.CheckedImage = null;
            this.btnbasedatos.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btnbasedatos.FocusedColor = System.Drawing.Color.Empty;
            this.btnbasedatos.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbasedatos.ForeColor = System.Drawing.Color.White;
            this.btnbasedatos.Image = null;
            this.btnbasedatos.ImageSize = new System.Drawing.Size(20, 20);
            this.btnbasedatos.LineBottom = 5;
            this.btnbasedatos.LineColor = System.Drawing.Color.Transparent;
            this.btnbasedatos.Location = new System.Drawing.Point(101, 175);
            this.btnbasedatos.Name = "btnbasedatos";
            this.btnbasedatos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnbasedatos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnbasedatos.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnbasedatos.OnHoverImage = null;
            this.btnbasedatos.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnbasedatos.OnPressedColor = System.Drawing.Color.Black;
            this.btnbasedatos.Size = new System.Drawing.Size(179, 34);
            this.btnbasedatos.TabIndex = 11;
            this.btnbasedatos.Text = "Probar conexion";
            this.btnbasedatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnbasedatos.Click += new System.EventHandler(this.btnbasedatos_Click);
            // 
            // GunaPictureBox1
            // 
            this.GunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.GunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("GunaPictureBox1.Image")));
            this.GunaPictureBox1.Location = new System.Drawing.Point(0, 293);
            this.GunaPictureBox1.Name = "GunaPictureBox1";
            this.GunaPictureBox1.Size = new System.Drawing.Size(366, 97);
            this.GunaPictureBox1.TabIndex = 3;
            this.GunaPictureBox1.TabStop = false;
            // 
            // frmConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(366, 390);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnbasedatos);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboServer);
            this.Controls.Add(this.cmbbasededatos);
            this.Controls.Add(this.GunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConexion";
            this.Load += new System.EventHandler(this.FrmConexion_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbbasededatos;
        private System.Windows.Forms.ComboBox cboServer;
        private System.Windows.Forms.Label label14;
        internal Guna.UI.WinForms.GunaPictureBox GunaPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaImageButton BtnCerrar;
        private Guna.UI.WinForms.GunaImageButton BtnMinimizar;
        internal Guna.UI.WinForms.GunaGradientButton BtnGuardar;
        private Guna.UI.WinForms.GunaAdvenceButton btnbasedatos;
    }
}