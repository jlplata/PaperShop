namespace PaperShop
{
    partial class FrmCarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarga));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelinicio1 = new PaperShop.Panelinicio();
            this.BPInicio = new Guna.UI.WinForms.GunaProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.panelinicio1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panelinicio1
            // 
            this.panelinicio1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.panelinicio1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.panelinicio1.Controls.Add(this.BPInicio);
            this.panelinicio1.Controls.Add(this.label1);
            this.panelinicio1.Controls.Add(this.label2);
            this.panelinicio1.Controls.Add(this.GunaPictureBox1);
            this.panelinicio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelinicio1.Location = new System.Drawing.Point(0, 0);
            this.panelinicio1.Name = "panelinicio1";
            this.panelinicio1.Size = new System.Drawing.Size(571, 325);
            this.panelinicio1.TabIndex = 0;
            // 
            // BPInicio
            // 
            this.BPInicio.BackColor = System.Drawing.Color.Transparent;
            this.BPInicio.BorderColor = System.Drawing.Color.Black;
            this.BPInicio.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.BPInicio.IdleColor = System.Drawing.Color.Transparent;
            this.BPInicio.Location = new System.Drawing.Point(0, 315);
            this.BPInicio.Name = "BPInicio";
            this.BPInicio.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(34)))), ((int)(((byte)(120)))));
            this.BPInicio.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(34)))), ((int)(((byte)(120)))));
            this.BPInicio.Size = new System.Drawing.Size(572, 10);
            this.BPInicio.TabIndex = 2;
            this.BPInicio.Click += new System.EventHandler(this.BPInicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(202, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "PaperShop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(222, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "All on one place";
            // 
            // GunaPictureBox1
            // 
            this.GunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.GunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("GunaPictureBox1.Image")));
            this.GunaPictureBox1.Location = new System.Drawing.Point(0, 219);
            this.GunaPictureBox1.Name = "GunaPictureBox1";
            this.GunaPictureBox1.Size = new System.Drawing.Size(571, 106);
            this.GunaPictureBox1.TabIndex = 3;
            this.GunaPictureBox1.TabStop = false;
            // 
            // FrmCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 325);
            this.Controls.Add(this.panelinicio1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCarga";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCarga";
            this.Load += new System.EventHandler(this.FrmCarga_Load);
            this.panelinicio1.ResumeLayout(false);
            this.panelinicio1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panelinicio panelinicio1;
        private Guna.UI.WinForms.GunaProgressBar BPInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.Timer timer1;
        internal Guna.UI.WinForms.GunaPictureBox GunaPictureBox1;
    }
}