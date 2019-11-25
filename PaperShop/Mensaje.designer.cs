namespace PaperShop
{
    partial class Mensaje
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltxt = new System.Windows.Forms.Label();
            this.BtnSi = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnNo = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 5);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "PaperShop - Mensaje";
            // 
            // lbltxt
            // 
            this.lbltxt.AutoSize = true;
            this.lbltxt.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxt.ForeColor = System.Drawing.Color.Black;
            this.lbltxt.Location = new System.Drawing.Point(114, 79);
            this.lbltxt.Name = "lbltxt";
            this.lbltxt.Size = new System.Drawing.Size(180, 21);
            this.lbltxt.TabIndex = 8;
            this.lbltxt.Text = "¿Seguro que deseas salir?";
            // 
            // BtnSi
            // 
            this.BtnSi.AnimationHoverSpeed = 0.07F;
            this.BtnSi.AnimationSpeed = 0.03F;
            this.BtnSi.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.BtnSi.BorderColor = System.Drawing.Color.Black;
            this.BtnSi.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.BtnSi.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.BtnSi.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnSi.CheckedForeColor = System.Drawing.Color.White;
            this.BtnSi.CheckedImage = null;
            this.BtnSi.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.BtnSi.FocusedColor = System.Drawing.Color.Empty;
            this.BtnSi.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSi.ForeColor = System.Drawing.Color.White;
            this.BtnSi.Image = null;
            this.BtnSi.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnSi.LineBottom = 5;
            this.BtnSi.LineColor = System.Drawing.Color.Transparent;
            this.BtnSi.Location = new System.Drawing.Point(32, 138);
            this.BtnSi.Name = "BtnSi";
            this.BtnSi.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.BtnSi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSi.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.BtnSi.OnHoverImage = null;
            this.BtnSi.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.BtnSi.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSi.Size = new System.Drawing.Size(126, 40);
            this.BtnSi.TabIndex = 11;
            this.BtnSi.Text = "Si";
            this.BtnSi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnSi.Click += new System.EventHandler(this.BunifuButton1_Click);
            // 
            // BtnNo
            // 
            this.BtnNo.AnimationHoverSpeed = 0.07F;
            this.BtnNo.AnimationSpeed = 0.03F;
            this.BtnNo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.BtnNo.BorderColor = System.Drawing.Color.Black;
            this.BtnNo.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.BtnNo.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.BtnNo.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnNo.CheckedForeColor = System.Drawing.Color.White;
            this.BtnNo.CheckedImage = null;
            this.BtnNo.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.BtnNo.FocusedColor = System.Drawing.Color.Empty;
            this.BtnNo.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNo.ForeColor = System.Drawing.Color.White;
            this.BtnNo.Image = null;
            this.BtnNo.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnNo.LineBottom = 5;
            this.BtnNo.LineColor = System.Drawing.Color.Transparent;
            this.BtnNo.Location = new System.Drawing.Point(240, 138);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.BtnNo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnNo.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.BtnNo.OnHoverImage = null;
            this.BtnNo.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.BtnNo.OnPressedColor = System.Drawing.Color.Black;
            this.BtnNo.Size = new System.Drawing.Size(126, 40);
            this.BtnNo.TabIndex = 12;
            this.BtnNo.Text = "No";
            this.BtnNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnNo.Click += new System.EventHandler(this.BunifuButton2_Click);
            // 
            // Mensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 205);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.BtnSi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltxt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbltxt;
        private Guna.UI.WinForms.GunaAdvenceButton BtnSi;
        private Guna.UI.WinForms.GunaAdvenceButton BtnNo;
    }
}