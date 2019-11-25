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
            this.panelContenedorForm = new Guna.UI.WinForms.GunaPanel();
            this.lblBajoStock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProductosBajos = new System.Windows.Forms.DataGridView();
            this.panelContenedorForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosBajos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedorForm
            // 
            this.panelContenedorForm.BackgroundImage = global::PaperShop.Properties.Resources.Fondo;
            this.panelContenedorForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContenedorForm.Controls.Add(this.lblBajoStock);
            this.panelContenedorForm.Controls.Add(this.label1);
            this.panelContenedorForm.Controls.Add(this.dgvProductosBajos);
            this.panelContenedorForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorForm.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelContenedorForm.Name = "panelContenedorForm";
            this.panelContenedorForm.Size = new System.Drawing.Size(1503, 714);
            this.panelContenedorForm.TabIndex = 2;
            // 
            // lblBajoStock
            // 
            this.lblBajoStock.AutoSize = true;
            this.lblBajoStock.BackColor = System.Drawing.Color.Transparent;
            this.lblBajoStock.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBajoStock.ForeColor = System.Drawing.Color.White;
            this.lblBajoStock.Location = new System.Drawing.Point(447, 281);
            this.lblBajoStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBajoStock.Name = "lblBajoStock";
            this.lblBajoStock.Size = new System.Drawing.Size(374, 46);
            this.lblBajoStock.TabIndex = 1;
            this.lblBajoStock.Text = "Productos con bajo stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(489, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 81);
            this.label1.TabIndex = 1;
            this.label1.Text = "PaperShop";
            // 
            // dgvProductosBajos
            // 
            this.dgvProductosBajos.AllowUserToAddRows = false;
            this.dgvProductosBajos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosBajos.Location = new System.Drawing.Point(264, 330);
            this.dgvProductosBajos.Name = "dgvProductosBajos";
            this.dgvProductosBajos.RowHeadersWidth = 51;
            this.dgvProductosBajos.RowTemplate.Height = 24;
            this.dgvProductosBajos.Size = new System.Drawing.Size(752, 331);
            this.dgvProductosBajos.TabIndex = 0;
            this.dgvProductosBajos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProductosBajos_CellFormatting);
            // 
            // FrmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1503, 714);
            this.Controls.Add(this.panelContenedorForm);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBienvenida";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmBienvenida";
            this.Load += new System.EventHandler(this.FrmBienvenida_Load);
            this.panelContenedorForm.ResumeLayout(false);
            this.panelContenedorForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosBajos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPanel panelContenedorForm;
        private System.Windows.Forms.DataGridView dgvProductosBajos;
        private System.Windows.Forms.Label lblBajoStock;
    }
}