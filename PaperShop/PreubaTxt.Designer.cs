namespace PaperShop
{
    partial class PreubaTxt
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
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLineTextBox1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.CausesValidation = false;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(112, 173);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Size = new System.Drawing.Size(160, 30);
            this.gunaTextBox1.TabIndex = 0;
            this.gunaTextBox1.Text = "gunaTextBox1";
            this.gunaTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valdacionLetras);
            // 
            // gunaLineTextBox1
            // 
            this.gunaLineTextBox1.Animated = true;
            this.gunaLineTextBox1.BackColor = System.Drawing.Color.DimGray;
            this.gunaLineTextBox1.CausesValidation = false;
            this.gunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox1.Enabled = false;
            this.gunaLineTextBox1.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox1.LineColor = System.Drawing.Color.DarkOrange;
            this.gunaLineTextBox1.Location = new System.Drawing.Point(112, 228);
            this.gunaLineTextBox1.Name = "gunaLineTextBox1";
            this.gunaLineTextBox1.PasswordChar = '\0';
            this.gunaLineTextBox1.Size = new System.Drawing.Size(160, 26);
            this.gunaLineTextBox1.TabIndex = 1;
            this.gunaLineTextBox1.Text = "gunaLineTextBox1";
            this.gunaLineTextBox1.Click += new System.EventHandler(this.gunaLineTextBox1_Click);
            this.gunaLineTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valdacionLetras);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(112, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valdacionLetras);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // PreubaTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gunaLineTextBox1);
            this.Controls.Add(this.gunaTextBox1);
            this.Name = "PreubaTxt";
            this.Text = "PreubaTxt";
            this.Load += new System.EventHandler(this.PreubaTxt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}