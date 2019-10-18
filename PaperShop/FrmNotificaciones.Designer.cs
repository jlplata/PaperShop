namespace PaperShop
{
    partial class FrmNotificaciones
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
            this.GunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.GunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.GunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GunaLabel1
            // 
            this.GunaLabel1.AutoSize = true;
            this.GunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.GunaLabel1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GunaLabel1.ForeColor = System.Drawing.Color.White;
            this.GunaLabel1.Location = new System.Drawing.Point(104, 29);
            this.GunaLabel1.Name = "GunaLabel1";
            this.GunaLabel1.Size = new System.Drawing.Size(77, 21);
            this.GunaLabel1.TabIndex = 16;
            this.GunaLabel1.Text = "Agregado";
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.panel1.BackgroundImage = global::PaperShop.Properties.Resources.preview_copy__1_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.GunaPictureBox2);
            this.panel1.Controls.Add(this.GunaPictureBox1);
            this.panel1.Controls.Add(this.GunaLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 89);
            this.panel1.TabIndex = 18;
            // 
            // GunaPictureBox2
            // 
            this.GunaPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.GunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.GunaPictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GunaPictureBox2.Image = global::PaperShop.Properties.Resources.Multiply_18px;
            this.GunaPictureBox2.Location = new System.Drawing.Point(364, 32);
            this.GunaPictureBox2.Name = "GunaPictureBox2";
            this.GunaPictureBox2.Size = new System.Drawing.Size(18, 18);
            this.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GunaPictureBox2.TabIndex = 17;
            this.GunaPictureBox2.TabStop = false;
            this.GunaPictureBox2.Click += new System.EventHandler(this.GunaPictureBox2_Click_1);
            // 
            // GunaPictureBox1
            // 
            this.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.GunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.GunaPictureBox1.Image = global::PaperShop.Properties.Resources.Checkmark_28px;
            this.GunaPictureBox1.Location = new System.Drawing.Point(44, 24);
            this.GunaPictureBox1.Name = "GunaPictureBox1";
            this.GunaPictureBox1.Size = new System.Drawing.Size(33, 31);
            this.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GunaPictureBox1.TabIndex = 2;
            this.GunaPictureBox1.TabStop = false;
            // 
            // FrmNotificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 89);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNotificaciones";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmNotificaciones";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmNotificaciones_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal Guna.UI.WinForms.GunaLabel GunaLabel1;
        internal System.Windows.Forms.Timer Timer1;
        internal Guna.UI.WinForms.GunaPictureBox GunaPictureBox2;
        private Guna.UI.WinForms.GunaPictureBox GunaPictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}