namespace PaperShop
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pp = new System.Windows.Forms.TextBox();
            this.pnLogin = new Guna.UI.WinForms.GunaPanel();
            this.cmbTipo = new Guna.UI.WinForms.GunaComboBox();
            this.GunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.BtnIniciarS = new Guna.UI.WinForms.GunaGradientButton();
            this.txtPass = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.GunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtUser = new Guna.UI.WinForms.GunaTextBox();
            this.GunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.GunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.GunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.GunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.pnLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GunaPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pp
            // 
            this.pp.Location = new System.Drawing.Point(62, 91);
            this.pp.Name = "pp";
            this.pp.Size = new System.Drawing.Size(100, 20);
            this.pp.TabIndex = 9;
            this.pp.Visible = false;
            // 
            // pnLogin
            // 
            this.pnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.pnLogin.Controls.Add(this.cmbTipo);
            this.pnLogin.Controls.Add(this.GunaLinkLabel1);
            this.pnLogin.Controls.Add(this.BtnIniciarS);
            this.pnLogin.Controls.Add(this.txtPass);
            this.pnLogin.Controls.Add(this.gunaLabel5);
            this.pnLogin.Controls.Add(this.GunaLabel4);
            this.pnLogin.Controls.Add(this.txtUser);
            this.pnLogin.Controls.Add(this.GunaLabel3);
            this.pnLogin.Controls.Add(this.GunaLabel2);
            this.pnLogin.Controls.Add(this.GunaLabel1);
            this.pnLogin.Controls.Add(this.GunaPictureBox1);
            this.pnLogin.Controls.Add(this.panel1);
            this.pnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLogin.Location = new System.Drawing.Point(0, 0);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(318, 462);
            this.pnLogin.TabIndex = 11;
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.cmbTipo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.cmbTipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(101)))));
            this.cmbTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTipo.ForeColor = System.Drawing.Color.White;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Administrador",
            "Trabajador",
            "Cajero",
            "Almacenista"});
            this.cmbTipo.Location = new System.Drawing.Point(28, 256);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbTipo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbTipo.Size = new System.Drawing.Size(161, 26);
            this.cmbTipo.TabIndex = 2;
            this.cmbTipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTipo_KeyDown);
            // 
            // GunaLinkLabel1
            // 
            this.GunaLinkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.GunaLinkLabel1.AutoSize = true;
            this.GunaLinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.GunaLinkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GunaLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.GunaLinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(101)))), ((int)(((byte)(134)))));
            this.GunaLinkLabel1.Location = new System.Drawing.Point(88, 354);
            this.GunaLinkLabel1.Name = "GunaLinkLabel1";
            this.GunaLinkLabel1.Size = new System.Drawing.Size(141, 15);
            this.GunaLinkLabel1.TabIndex = 8;
            this.GunaLinkLabel1.TabStop = true;
            this.GunaLinkLabel1.Text = "¿Olvidaste tu contraseña?";
            // 
            // BtnIniciarS
            // 
            this.BtnIniciarS.AnimationHoverSpeed = 0.07F;
            this.BtnIniciarS.AnimationSpeed = 0.03F;
            this.BtnIniciarS.BackColor = System.Drawing.Color.Transparent;
            this.BtnIniciarS.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.BtnIniciarS.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.BtnIniciarS.BorderColor = System.Drawing.Color.Black;
            this.BtnIniciarS.FocusedColor = System.Drawing.Color.Empty;
            this.BtnIniciarS.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnIniciarS.ForeColor = System.Drawing.Color.White;
            this.BtnIniciarS.Image = null;
            this.BtnIniciarS.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnIniciarS.Location = new System.Drawing.Point(28, 304);
            this.BtnIniciarS.Name = "BtnIniciarS";
            this.BtnIniciarS.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.BtnIniciarS.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.BtnIniciarS.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnIniciarS.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnIniciarS.OnHoverImage = null;
            this.BtnIniciarS.OnPressedColor = System.Drawing.Color.Black;
            this.BtnIniciarS.Radius = 2;
            this.BtnIniciarS.Size = new System.Drawing.Size(248, 37);
            this.BtnIniciarS.TabIndex = 3;
            this.BtnIniciarS.Text = "Iniciar Sesion";
            this.BtnIniciarS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnIniciarS.Click += new System.EventHandler(this.BtnIniciarS_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.txtPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(101)))));
            this.txtPass.BorderSize = 1;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.Location = new System.Drawing.Point(28, 182);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Radius = 2;
            this.txtPass.Size = new System.Drawing.Size(248, 37);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPass_KeyDown);
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUser_KeyPress);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.gunaLabel5.Location = new System.Drawing.Point(24, 234);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(35, 19);
            this.gunaLabel5.TabIndex = 5;
            this.gunaLabel5.Text = "Tipo";
            // 
            // GunaLabel4
            // 
            this.GunaLabel4.AutoSize = true;
            this.GunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.GunaLabel4.Location = new System.Drawing.Point(24, 160);
            this.GunaLabel4.Name = "GunaLabel4";
            this.GunaLabel4.Size = new System.Drawing.Size(79, 19);
            this.GunaLabel4.TabIndex = 5;
            this.GunaLabel4.Text = "Contraseña";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Transparent;
            this.txtUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.txtUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(101)))));
            this.txtUser.BorderSize = 1;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUser.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUser.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(28, 107);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.Radius = 2;
            this.txtUser.Size = new System.Drawing.Size(248, 37);
            this.txtUser.TabIndex = 0;
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUser_KeyDown);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUser_KeyPress);
            // 
            // GunaLabel3
            // 
            this.GunaLabel3.AutoSize = true;
            this.GunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.GunaLabel3.Location = new System.Drawing.Point(24, 85);
            this.GunaLabel3.Name = "GunaLabel3";
            this.GunaLabel3.Size = new System.Drawing.Size(56, 19);
            this.GunaLabel3.TabIndex = 3;
            this.GunaLabel3.Text = "Usuario";
            // 
            // GunaLabel2
            // 
            this.GunaLabel2.AutoSize = true;
            this.GunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.GunaLabel2.Location = new System.Drawing.Point(25, 56);
            this.GunaLabel2.Name = "GunaLabel2";
            this.GunaLabel2.Size = new System.Drawing.Size(66, 15);
            this.GunaLabel2.TabIndex = 2;
            this.GunaLabel2.Text = "Bienvenido";
            // 
            // GunaLabel1
            // 
            this.GunaLabel1.AutoSize = true;
            this.GunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.GunaLabel1.ForeColor = System.Drawing.Color.White;
            this.GunaLabel1.Location = new System.Drawing.Point(23, 26);
            this.GunaLabel1.Name = "GunaLabel1";
            this.GunaLabel1.Size = new System.Drawing.Size(70, 28);
            this.GunaLabel1.TabIndex = 1;
            this.GunaLabel1.Text = "¡Hola!";
            // 
            // GunaPictureBox1
            // 
            this.GunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.GunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("GunaPictureBox1.Image")));
            this.GunaPictureBox1.Location = new System.Drawing.Point(0, 356);
            this.GunaPictureBox1.Name = "GunaPictureBox1";
            this.GunaPictureBox1.Size = new System.Drawing.Size(318, 106);
            this.GunaPictureBox1.TabIndex = 0;
            this.GunaPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 25);
            this.panel1.TabIndex = 12;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.Image = global::PaperShop.Properties.Resources.Close;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(16, 16);
            this.gunaImageButton1.Location = new System.Drawing.Point(293, 0);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(25, 28);
            this.gunaImageButton1.TabIndex = 11;
            this.gunaImageButton1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 462);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.pp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión - PaperShop";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GunaPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pp;
        internal Guna.UI.WinForms.GunaPanel pnLogin;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private Guna.UI.WinForms.GunaComboBox cmbTipo;
        internal Guna.UI.WinForms.GunaLinkLabel GunaLinkLabel1;
        internal Guna.UI.WinForms.GunaGradientButton BtnIniciarS;
        internal Guna.UI.WinForms.GunaTextBox txtPass;
        internal Guna.UI.WinForms.GunaLabel gunaLabel5;
        internal Guna.UI.WinForms.GunaLabel GunaLabel4;
        internal Guna.UI.WinForms.GunaTextBox txtUser;
        internal Guna.UI.WinForms.GunaLabel GunaLabel3;
        internal Guna.UI.WinForms.GunaLabel GunaLabel2;
        internal Guna.UI.WinForms.GunaLabel GunaLabel1;
        internal Guna.UI.WinForms.GunaPictureBox GunaPictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}