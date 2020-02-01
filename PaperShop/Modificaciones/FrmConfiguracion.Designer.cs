namespace PaperShop.Modificaciones
{
    partial class FrmConfiguracion
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
            this.SwchOriginal = new Guna.UI.WinForms.GunaSwitch();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SwchAqua = new Guna.UI.WinForms.GunaSwitch();
            this.label3 = new System.Windows.Forms.Label();
            this.SwchGreen = new Guna.UI.WinForms.GunaSwitch();
            this.btnModificar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original Blue";
            // 
            // SwchOriginal
            // 
            this.SwchOriginal.BaseColor = System.Drawing.SystemColors.Control;
            this.SwchOriginal.CheckedOffColor = System.Drawing.Color.Tomato;
            this.SwchOriginal.CheckedOnColor = System.Drawing.Color.SeaGreen;
            this.SwchOriginal.FillColor = System.Drawing.Color.White;
            this.SwchOriginal.Location = new System.Drawing.Point(116, 53);
            this.SwchOriginal.Name = "SwchOriginal";
            this.SwchOriginal.Size = new System.Drawing.Size(28, 20);
            this.SwchOriginal.TabIndex = 1;
            this.SwchOriginal.CheckedChanged += new System.EventHandler(this.gunaSwitch1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SwchGreen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SwchAqua);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SwchOriginal);
            this.groupBox1.Location = new System.Drawing.Point(42, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 167);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Configuracion del sistema";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Aquarium";
            // 
            // SwchAqua
            // 
            this.SwchAqua.BaseColor = System.Drawing.SystemColors.Control;
            this.SwchAqua.CheckedOffColor = System.Drawing.Color.Tomato;
            this.SwchAqua.CheckedOnColor = System.Drawing.Color.SeaGreen;
            this.SwchAqua.FillColor = System.Drawing.Color.White;
            this.SwchAqua.Location = new System.Drawing.Point(116, 79);
            this.SwchAqua.Name = "SwchAqua";
            this.SwchAqua.Size = new System.Drawing.Size(28, 20);
            this.SwchAqua.TabIndex = 5;
            this.SwchAqua.CheckedChanged += new System.EventHandler(this.SwchAqua_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Green";
            // 
            // SwchGreen
            // 
            this.SwchGreen.BaseColor = System.Drawing.SystemColors.Control;
            this.SwchGreen.CheckedOffColor = System.Drawing.Color.Tomato;
            this.SwchGreen.CheckedOnColor = System.Drawing.Color.SeaGreen;
            this.SwchGreen.FillColor = System.Drawing.Color.White;
            this.SwchGreen.Location = new System.Drawing.Point(116, 105);
            this.SwchGreen.Name = "SwchGreen";
            this.SwchGreen.Size = new System.Drawing.Size(28, 20);
            this.SwchGreen.TabIndex = 7;
            this.SwchGreen.CheckedChanged += new System.EventHandler(this.SwchGreen_CheckedChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.AnimationHoverSpeed = 0.07F;
            this.btnModificar.AnimationSpeed = 0.03F;
            this.btnModificar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnModificar.BorderColor = System.Drawing.Color.Black;
            this.btnModificar.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnModificar.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnModificar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnModificar.CheckedForeColor = System.Drawing.Color.White;
            this.btnModificar.CheckedImage = null;
            this.btnModificar.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btnModificar.FocusedColor = System.Drawing.Color.Empty;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = null;
            this.btnModificar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnModificar.LineBottom = 5;
            this.btnModificar.LineColor = System.Drawing.Color.Transparent;
            this.btnModificar.Location = new System.Drawing.Point(323, 389);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnModificar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModificar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnModificar.OnHoverImage = null;
            this.btnModificar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnModificar.OnPressedColor = System.Drawing.Color.Black;
            this.btnModificar.Size = new System.Drawing.Size(160, 40);
            this.btnModificar.TabIndex = 64;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmConfiguracion";
            this.Text = "FrmConfiguracion";
            this.Load += new System.EventHandler(this.FrmConfiguracion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaSwitch SwchOriginal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaSwitch SwchGreen;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaSwitch SwchAqua;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaAdvenceButton btnModificar;
    }
}