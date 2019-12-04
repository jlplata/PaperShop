namespace PaperShop
{
    partial class MensajeOk
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
            this.lblx = new System.Windows.Forms.Label();
            this.BtnOk = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltxt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblx.ForeColor = System.Drawing.Color.Black;
            this.lblx.Location = new System.Drawing.Point(12, 46);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(0, 21);
            this.lblx.TabIndex = 15;
            this.lblx.Visible = false;
            // 
            // BtnOk
            // 
            this.BtnOk.AnimationHoverSpeed = 0.07F;
            this.BtnOk.AnimationSpeed = 0.03F;
            this.BtnOk.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.BtnOk.BorderColor = System.Drawing.Color.Black;
            this.BtnOk.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.BtnOk.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.BtnOk.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnOk.CheckedForeColor = System.Drawing.Color.White;
            this.BtnOk.CheckedImage = null;
            this.BtnOk.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.BtnOk.FocusedColor = System.Drawing.Color.Empty;
            this.BtnOk.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.Image = null;
            this.BtnOk.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnOk.LineBottom = 5;
            this.BtnOk.LineColor = System.Drawing.Color.Transparent;
            this.BtnOk.Location = new System.Drawing.Point(132, 139);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.BtnOk.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnOk.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.BtnOk.OnHoverImage = null;
            this.BtnOk.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.BtnOk.OnPressedColor = System.Drawing.Color.Black;
            this.BtnOk.Size = new System.Drawing.Size(126, 40);
            this.BtnOk.TabIndex = 20;
            this.BtnOk.Text = "Ok";
            this.BtnOk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "PaperShop - Mensaje";
            // 
            // lbltxt
            // 
            this.lbltxt.AutoSize = true;
            this.lbltxt.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxt.ForeColor = System.Drawing.Color.Black;
            this.lbltxt.Location = new System.Drawing.Point(108, 74);
            this.lbltxt.Name = "lbltxt";
            this.lbltxt.Size = new System.Drawing.Size(180, 21);
            this.lbltxt.TabIndex = 18;
            this.lbltxt.Text = "¿Seguro que deseas salir?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 5);
            this.panel1.TabIndex = 16;
            // 
            // MensajeOk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 205);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MensajeOk";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MensajeOk";
            this.Load += new System.EventHandler(this.MensajeOk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblx;
        private Guna.UI.WinForms.GunaAdvenceButton BtnOk;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbltxt;
        private System.Windows.Forms.Panel panel1;
    }
}