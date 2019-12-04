namespace PaperShop
{
    partial class FrmPrin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrin));
            this.barra = new Guna.UI.WinForms.GunaPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaImageButton3 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton2 = new Guna.UI.WinForms.GunaImageButton();
            this.BtnMenu = new Guna.UI.WinForms.GunaImageButton();
            this.pnlmenutop = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.btnComputo = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnmtenimiento = new Guna.UI.WinForms.GunaAdvenceButton();
            this.Btninicio = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton3 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panelContenedorForm = new Guna.UI.WinForms.GunaPanel();
            this.pnldentro = new System.Windows.Forms.Panel();
            this.gunaAdvenceButton6 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TipoUsuario = new System.Windows.Forms.Label();
            this.NombUsuario = new System.Windows.Forms.Label();
            this.ImgUsuario = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Timer(this.components);
            this.pnlmenu = new System.Windows.Forms.Panel();
            this.barra.SuspendLayout();
            this.pnlmenutop.SuspendLayout();
            this.gunaPanel4.SuspendLayout();
            this.pnldentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgUsuario)).BeginInit();
            this.pnlmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.Controls.Add(this.label1);
            this.barra.Controls.Add(this.gunaImageButton3);
            this.barra.Controls.Add(this.gunaImageButton2);
            this.barra.Controls.Add(this.BtnMenu);
            this.barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(980, 50);
            this.barra.TabIndex = 0;
            this.barra.Click += new System.EventHandler(this.gunaPanel1_Click);
            this.barra.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            this.barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GunaPanel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(429, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "PaperShop";
            // 
            // gunaImageButton3
            // 
            this.gunaImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.gunaImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton3.Image")));
            this.gunaImageButton3.ImageSize = new System.Drawing.Size(16, 16);
            this.gunaImageButton3.Location = new System.Drawing.Point(947, 0);
            this.gunaImageButton3.Name = "gunaImageButton3";
            this.gunaImageButton3.OnHoverImage = null;
            this.gunaImageButton3.OnHoverImageOffset = new System.Drawing.Point(0, -1);
            this.gunaImageButton3.Size = new System.Drawing.Size(32, 32);
            this.gunaImageButton3.TabIndex = 2;
            this.gunaImageButton3.Click += new System.EventHandler(this.GunaImageButton3_Click);
            this.gunaImageButton3.MouseEnter += new System.EventHandler(this.gunaImageButton3_MouseEnter);
            this.gunaImageButton3.MouseLeave += new System.EventHandler(this.gunaImageButton3_MouseLeave);
            // 
            // gunaImageButton2
            // 
            this.gunaImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.gunaImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gunaImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton2.Image")));
            this.gunaImageButton2.ImageSize = new System.Drawing.Size(16, 16);
            this.gunaImageButton2.Location = new System.Drawing.Point(914, 0);
            this.gunaImageButton2.Name = "gunaImageButton2";
            this.gunaImageButton2.OnHoverImage = null;
            this.gunaImageButton2.OnHoverImageOffset = new System.Drawing.Point(0, -1);
            this.gunaImageButton2.Size = new System.Drawing.Size(32, 32);
            this.gunaImageButton2.TabIndex = 1;
            this.gunaImageButton2.Click += new System.EventHandler(this.gunaImageButton2_Click);
            this.gunaImageButton2.MouseEnter += new System.EventHandler(this.gunaImageButton2_MouseEnter);
            this.gunaImageButton2.MouseLeave += new System.EventHandler(this.gunaImageButton2_MouseLeave);
            // 
            // BtnMenu
            // 
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnMenu.Location = new System.Drawing.Point(7, 7);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.OnHoverImage = null;
            this.BtnMenu.OnHoverImageOffset = new System.Drawing.Point(0, -1);
            this.BtnMenu.Size = new System.Drawing.Size(32, 32);
            this.BtnMenu.TabIndex = 0;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // pnlmenutop
            // 
            this.pnlmenutop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.pnlmenutop.Controls.Add(this.gunaPanel4);
            this.pnlmenutop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlmenutop.Location = new System.Drawing.Point(0, 50);
            this.pnlmenutop.Name = "pnlmenutop";
            this.pnlmenutop.Size = new System.Drawing.Size(980, 50);
            this.pnlmenutop.TabIndex = 1;
            this.pnlmenutop.Click += new System.EventHandler(this.gunaPanel2_Click);
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaPanel4.Controls.Add(this.btnComputo);
            this.gunaPanel4.Controls.Add(this.btnmtenimiento);
            this.gunaPanel4.Controls.Add(this.Btninicio);
            this.gunaPanel4.Controls.Add(this.gunaAdvenceButton3);
            this.gunaPanel4.Controls.Add(this.gunaAdvenceButton1);
            this.gunaPanel4.Location = new System.Drawing.Point(230, 0);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(510, 50);
            this.gunaPanel4.TabIndex = 2;
            this.gunaPanel4.Click += new System.EventHandler(this.gunaPanel4_Click);
            // 
            // btnComputo
            // 
            this.btnComputo.AnimationHoverSpeed = 0.07F;
            this.btnComputo.AnimationSpeed = 0.03F;
            this.btnComputo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnComputo.BorderColor = System.Drawing.Color.Black;
            this.btnComputo.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnComputo.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnComputo.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnComputo.CheckedForeColor = System.Drawing.Color.White;
            this.btnComputo.CheckedImage = null;
            this.btnComputo.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btnComputo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnComputo.FocusedColor = System.Drawing.Color.Empty;
            this.btnComputo.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputo.ForeColor = System.Drawing.Color.White;
            this.btnComputo.Image = null;
            this.btnComputo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnComputo.LineBottom = 5;
            this.btnComputo.LineColor = System.Drawing.Color.Transparent;
            this.btnComputo.Location = new System.Drawing.Point(404, 0);
            this.btnComputo.Name = "btnComputo";
            this.btnComputo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnComputo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnComputo.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnComputo.OnHoverImage = null;
            this.btnComputo.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnComputo.OnPressedColor = System.Drawing.Color.Black;
            this.btnComputo.Size = new System.Drawing.Size(101, 50);
            this.btnComputo.TabIndex = 4;
            this.btnComputo.Text = "Computo";
            this.btnComputo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnComputo.Click += new System.EventHandler(this.btnComputo_Click);
            // 
            // btnmtenimiento
            // 
            this.btnmtenimiento.AnimationHoverSpeed = 0.07F;
            this.btnmtenimiento.AnimationSpeed = 0.03F;
            this.btnmtenimiento.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnmtenimiento.BorderColor = System.Drawing.Color.Black;
            this.btnmtenimiento.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnmtenimiento.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnmtenimiento.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnmtenimiento.CheckedForeColor = System.Drawing.Color.White;
            this.btnmtenimiento.CheckedImage = null;
            this.btnmtenimiento.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btnmtenimiento.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnmtenimiento.FocusedColor = System.Drawing.Color.Empty;
            this.btnmtenimiento.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmtenimiento.ForeColor = System.Drawing.Color.White;
            this.btnmtenimiento.Image = null;
            this.btnmtenimiento.ImageSize = new System.Drawing.Size(20, 20);
            this.btnmtenimiento.LineBottom = 5;
            this.btnmtenimiento.LineColor = System.Drawing.Color.Transparent;
            this.btnmtenimiento.Location = new System.Drawing.Point(303, 0);
            this.btnmtenimiento.Name = "btnmtenimiento";
            this.btnmtenimiento.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnmtenimiento.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnmtenimiento.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnmtenimiento.OnHoverImage = null;
            this.btnmtenimiento.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnmtenimiento.OnPressedColor = System.Drawing.Color.Black;
            this.btnmtenimiento.Size = new System.Drawing.Size(101, 50);
            this.btnmtenimiento.TabIndex = 3;
            this.btnmtenimiento.Text = "Mantenimiento";
            this.btnmtenimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnmtenimiento.Click += new System.EventHandler(this.GunaAdvenceButton4_Click);
            // 
            // Btninicio
            // 
            this.Btninicio.AnimationHoverSpeed = 0.07F;
            this.Btninicio.AnimationSpeed = 0.03F;
            this.Btninicio.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.Btninicio.BorderColor = System.Drawing.Color.Black;
            this.Btninicio.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.Btninicio.Checked = true;
            this.Btninicio.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.Btninicio.CheckedBorderColor = System.Drawing.Color.Black;
            this.Btninicio.CheckedForeColor = System.Drawing.Color.White;
            this.Btninicio.CheckedImage = null;
            this.Btninicio.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.Btninicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btninicio.FocusedColor = System.Drawing.Color.Empty;
            this.Btninicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btninicio.ForeColor = System.Drawing.Color.White;
            this.Btninicio.Image = null;
            this.Btninicio.ImageSize = new System.Drawing.Size(20, 20);
            this.Btninicio.LineBottom = 5;
            this.Btninicio.LineColor = System.Drawing.Color.Transparent;
            this.Btninicio.Location = new System.Drawing.Point(202, 0);
            this.Btninicio.Name = "Btninicio";
            this.Btninicio.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.Btninicio.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btninicio.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.Btninicio.OnHoverImage = null;
            this.Btninicio.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.Btninicio.OnPressedColor = System.Drawing.Color.Black;
            this.Btninicio.Size = new System.Drawing.Size(101, 50);
            this.Btninicio.TabIndex = 0;
            this.Btninicio.Text = "Inicio";
            this.Btninicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btninicio.Click += new System.EventHandler(this.Btninicio_Click);
            // 
            // gunaAdvenceButton3
            // 
            this.gunaAdvenceButton3.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton3.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.gunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.CheckedImage = null;
            this.gunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.gunaAdvenceButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton3.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.Image = null;
            this.gunaAdvenceButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton3.LineBottom = 5;
            this.gunaAdvenceButton3.LineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton3.Location = new System.Drawing.Point(101, 0);
            this.gunaAdvenceButton3.Name = "gunaAdvenceButton3";
            this.gunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaAdvenceButton3.OnHoverImage = null;
            this.gunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.gunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.Size = new System.Drawing.Size(101, 50);
            this.gunaAdvenceButton3.TabIndex = 2;
            this.gunaAdvenceButton3.Text = "Almacen";
            this.gunaAdvenceButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton3.Click += new System.EventHandler(this.gunaAdvenceButton3_Click);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = null;
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.gunaAdvenceButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = null;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineBottom = 5;
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(0, 0);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(101, 50);
            this.gunaAdvenceButton1.TabIndex = 1;
            this.gunaAdvenceButton1.Text = "Administración";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.GunaAdvenceButton1_Click);
            // 
            // panelContenedorForm
            // 
            this.panelContenedorForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorForm.Location = new System.Drawing.Point(0, 100);
            this.panelContenedorForm.Name = "panelContenedorForm";
            this.panelContenedorForm.Size = new System.Drawing.Size(980, 550);
            this.panelContenedorForm.TabIndex = 2;
            this.panelContenedorForm.Click += new System.EventHandler(this.panelContenedorForm_Click);
            // 
            // pnldentro
            // 
            this.pnldentro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnldentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.pnldentro.Controls.Add(this.gunaAdvenceButton6);
            this.pnldentro.Controls.Add(this.gunaAdvenceButton2);
            this.pnldentro.Controls.Add(this.TipoUsuario);
            this.pnldentro.Controls.Add(this.NombUsuario);
            this.pnldentro.Controls.Add(this.ImgUsuario);
            this.pnldentro.Controls.Add(this.label4);
            this.pnldentro.Location = new System.Drawing.Point(7, 7);
            this.pnldentro.MaximumSize = new System.Drawing.Size(180, 160);
            this.pnldentro.Name = "pnldentro";
            this.pnldentro.Size = new System.Drawing.Size(180, 2);
            this.pnldentro.TabIndex = 0;
            // 
            // gunaAdvenceButton6
            // 
            this.gunaAdvenceButton6.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton6.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton6.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.gunaAdvenceButton6.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton6.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton6.CheckedImage = null;
            this.gunaAdvenceButton6.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.gunaAdvenceButton6.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton6.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton6.Image = null;
            this.gunaAdvenceButton6.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton6.LineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton6.LineLeft = 2;
            this.gunaAdvenceButton6.Location = new System.Drawing.Point(14, 119);
            this.gunaAdvenceButton6.Name = "gunaAdvenceButton6";
            this.gunaAdvenceButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaAdvenceButton6.OnHoverImage = null;
            this.gunaAdvenceButton6.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.gunaAdvenceButton6.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.Size = new System.Drawing.Size(159, 32);
            this.gunaAdvenceButton6.TabIndex = 2;
            this.gunaAdvenceButton6.Text = "Cerrar Sesión";
            this.gunaAdvenceButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton6.Click += new System.EventHandler(this.gunaAdvenceButton6_Click);
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.CheckedImage = null;
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.Image = null;
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.LineLeft = 2;
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(14, 81);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(159, 32);
            this.gunaAdvenceButton2.TabIndex = 2;
            this.gunaAdvenceButton2.Text = "Modificar Perfil";
            this.gunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton2.Click += new System.EventHandler(this.gunaAdvenceButton2_Click);
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.AutoSize = true;
            this.TipoUsuario.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.TipoUsuario.Location = new System.Drawing.Point(83, 51);
            this.TipoUsuario.Name = "TipoUsuario";
            this.TipoUsuario.Size = new System.Drawing.Size(0, 17);
            this.TipoUsuario.TabIndex = 1;
            // 
            // NombUsuario
            // 
            this.NombUsuario.AutoSize = true;
            this.NombUsuario.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.NombUsuario.Location = new System.Drawing.Point(83, 29);
            this.NombUsuario.Name = "NombUsuario";
            this.NombUsuario.Size = new System.Drawing.Size(0, 17);
            this.NombUsuario.TabIndex = 1;
            // 
            // ImgUsuario
            // 
            this.ImgUsuario.BaseColor = System.Drawing.Color.White;
            this.ImgUsuario.Image = global::PaperShop.Properties.Resources.user;
            this.ImgUsuario.Location = new System.Drawing.Point(10, 8);
            this.ImgUsuario.Name = "ImgUsuario";
            this.ImgUsuario.Size = new System.Drawing.Size(64, 64);
            this.ImgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgUsuario.TabIndex = 0;
            this.ImgUsuario.TabStop = false;
            this.ImgUsuario.UseTransfarantBackground = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(77, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "__________________";
            // 
            // Menu
            // 
            this.Menu.Interval = 1;
            this.Menu.Tick += new System.EventHandler(this.Menu_Tick);
            // 
            // pnlmenu
            // 
            this.pnlmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.pnlmenu.Controls.Add(this.pnldentro);
            this.pnlmenu.Location = new System.Drawing.Point(10, 41);
            this.pnlmenu.MaximumSize = new System.Drawing.Size(195, 176);
            this.pnlmenu.MinimumSize = new System.Drawing.Size(195, 0);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(195, 18);
            this.pnlmenu.TabIndex = 3;
            this.pnlmenu.Visible = false;
            // 
            // FrmPrin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(980, 650);
            this.Controls.Add(this.pnlmenu);
            this.Controls.Add(this.panelContenedorForm);
            this.Controls.Add(this.pnlmenutop);
            this.Controls.Add(this.barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal - PaperShop";
            this.Load += new System.EventHandler(this.FrmPrin_Load);
            this.barra.ResumeLayout(false);
            this.barra.PerformLayout();
            this.pnlmenutop.ResumeLayout(false);
            this.gunaPanel4.ResumeLayout(false);
            this.pnldentro.ResumeLayout(false);
            this.pnldentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgUsuario)).EndInit();
            this.pnlmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel barra;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton3;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton2;
        private Guna.UI.WinForms.GunaImageButton BtnMenu;
        private Guna.UI.WinForms.GunaPanel pnlmenutop;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton3;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaAdvenceButton Btninicio;
        private Guna.UI.WinForms.GunaAdvenceButton btnComputo;
        private Guna.UI.WinForms.GunaAdvenceButton btnmtenimiento;
        public Guna.UI.WinForms.GunaPanel panelContenedorForm;
        private System.Windows.Forms.Panel pnldentro;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton6;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        private System.Windows.Forms.Label TipoUsuario;
        private System.Windows.Forms.Label NombUsuario;
        private Guna.UI.WinForms.GunaCirclePictureBox ImgUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer Menu;
        private System.Windows.Forms.Panel pnlmenu;
    }
}