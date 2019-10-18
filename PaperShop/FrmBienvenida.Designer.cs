namespace PaperShop
{
    partial class FrmBienvenida
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedorForm = new Guna.UI.WinForms.GunaPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(368, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "PaperShop";
            // 
            // panelContenedorForm
            // 
            this.panelContenedorForm.BackgroundImage = global::PaperShop.Properties.Resources.Fondo;
            this.panelContenedorForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContenedorForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorForm.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorForm.Name = "panelContenedorForm";
            this.panelContenedorForm.Size = new System.Drawing.Size(1127, 580);
            this.panelContenedorForm.TabIndex = 2;
            // 
            // FrmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1127, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelContenedorForm);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBienvenida";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmBienvenida";
            this.Load += new System.EventHandler(this.FrmBienvenida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPanel panelContenedorForm;
    }
}