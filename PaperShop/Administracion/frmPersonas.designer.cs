namespace PaperShop
{
    partial class frmPersonas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHoraRegistro = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbPersonas = new System.Windows.Forms.Panel();
            this.rdbMasculino = new Guna.UI.WinForms.GunaAdvenceButton();
            this.rdbFemenino = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.txtApePaterno = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbEstadoCivil = new Guna.UI.WinForms.GunaComboBox();
            this.txtIdUsuario = new Guna.UI.WinForms.GunaLineTextBox();
            this.dtpFechaNacimiento = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txtActivo = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.focusPaterno = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.focusMunicipio = new Guna.UI.WinForms.GunaLineTextBox();
            this.FocusNombre = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtApeMaterno = new System.Windows.Forms.TextBox();
            this.focusEstado = new Guna.UI.WinForms.GunaLineTextBox();
            this.focusCorreo = new Guna.UI.WinForms.GunaLineTextBox();
            this.focusDomicilio = new Guna.UI.WinForms.GunaLineTextBox();
            this.focusApeMaterno = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.btnCancelar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnModificar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnGuardar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnNuevo = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.focusBuscar = new Guna.UI.WinForms.GunaLineTextBox();
            this.mcPersonas = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.btnModificarPersona = new System.Windows.Forms.ToolStripMenuItem();
            this.btnActivarPersona = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDesactivarPersona = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImprimir = new Guna.UI.WinForms.GunaAdvenceButton();
            this.Activos = new Guna.UI.WinForms.GunaWinSwitch();
            this.lblActi = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.grbPersonas.SuspendLayout();
            this.gunaPanel4.SuspendLayout();
            this.mcPersonas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(139, 128);
            this.txtTelefono.Mask = "(999)000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(160, 22);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTelefono_KeyDown);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(52, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "ID Usuario.-";
            this.label12.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(80, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Activo.-";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(56, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Municipio.-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(76, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Estado.-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(49, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Estado civil.-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(5, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fecha nacimiento.-";
            // 
            // lblHoraRegistro
            // 
            this.lblHoraRegistro.AutoSize = true;
            this.lblHoraRegistro.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraRegistro.ForeColor = System.Drawing.Color.White;
            this.lblHoraRegistro.Location = new System.Drawing.Point(324, 411);
            this.lblHoraRegistro.Name = "lblHoraRegistro";
            this.lblHoraRegistro.Size = new System.Drawing.Size(100, 21);
            this.lblHoraRegistro.TabIndex = 0;
            this.lblHoraRegistro.Text = "Hora_registro";
            this.lblHoraRegistro.Visible = false;
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistro.ForeColor = System.Drawing.Color.White;
            this.lblFechaRegistro.Location = new System.Drawing.Point(331, 390);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(106, 21);
            this.lblFechaRegistro.TabIndex = 0;
            this.lblFechaRegistro.Text = "Fecha_registro";
            this.lblFechaRegistro.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(75, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Correo.-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(66, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Teléfono.-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(60, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Domicilio.-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ape. Materno.-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ape. Paterno.-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre.-";
            // 
            // grbPersonas
            // 
            this.grbPersonas.Controls.Add(this.rdbMasculino);
            this.grbPersonas.Controls.Add(this.rdbFemenino);
            this.grbPersonas.Controls.Add(this.txtMunicipio);
            this.grbPersonas.Controls.Add(this.txtApePaterno);
            this.grbPersonas.Controls.Add(this.txtEstado);
            this.grbPersonas.Controls.Add(this.txtNombre);
            this.grbPersonas.Controls.Add(this.cmbEstadoCivil);
            this.grbPersonas.Controls.Add(this.txtIdUsuario);
            this.grbPersonas.Controls.Add(this.dtpFechaNacimiento);
            this.grbPersonas.Controls.Add(this.txtActivo);
            this.grbPersonas.Controls.Add(this.txtCorreo);
            this.grbPersonas.Controls.Add(this.focusPaterno);
            this.grbPersonas.Controls.Add(this.txtDomicilio);
            this.grbPersonas.Controls.Add(this.focusMunicipio);
            this.grbPersonas.Controls.Add(this.FocusNombre);
            this.grbPersonas.Controls.Add(this.txtApeMaterno);
            this.grbPersonas.Controls.Add(this.focusEstado);
            this.grbPersonas.Controls.Add(this.lblHoraRegistro);
            this.grbPersonas.Controls.Add(this.label12);
            this.grbPersonas.Controls.Add(this.lblFechaRegistro);
            this.grbPersonas.Controls.Add(this.txtTelefono);
            this.grbPersonas.Controls.Add(this.label1);
            this.grbPersonas.Controls.Add(this.label2);
            this.grbPersonas.Controls.Add(this.focusCorreo);
            this.grbPersonas.Controls.Add(this.label3);
            this.grbPersonas.Controls.Add(this.label4);
            this.grbPersonas.Controls.Add(this.label5);
            this.grbPersonas.Controls.Add(this.label6);
            this.grbPersonas.Controls.Add(this.focusDomicilio);
            this.grbPersonas.Controls.Add(this.label7);
            this.grbPersonas.Controls.Add(this.label8);
            this.grbPersonas.Controls.Add(this.label9);
            this.grbPersonas.Controls.Add(this.label10);
            this.grbPersonas.Controls.Add(this.focusApeMaterno);
            this.grbPersonas.Controls.Add(this.label11);
            this.grbPersonas.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPersonas.ForeColor = System.Drawing.Color.White;
            this.grbPersonas.Location = new System.Drawing.Point(6, 41);
            this.grbPersonas.Name = "grbPersonas";
            this.grbPersonas.Size = new System.Drawing.Size(437, 448);
            this.grbPersonas.TabIndex = 6;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AnimationHoverSpeed = 0.07F;
            this.rdbMasculino.AnimationSpeed = 0.03F;
            this.rdbMasculino.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.rdbMasculino.BorderColor = System.Drawing.Color.Black;
            this.rdbMasculino.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.rdbMasculino.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.rdbMasculino.CheckedBorderColor = System.Drawing.Color.Black;
            this.rdbMasculino.CheckedForeColor = System.Drawing.Color.White;
            this.rdbMasculino.CheckedImage = null;
            this.rdbMasculino.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.rdbMasculino.FocusedColor = System.Drawing.Color.Empty;
            this.rdbMasculino.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMasculino.ForeColor = System.Drawing.Color.White;
            this.rdbMasculino.Image = null;
            this.rdbMasculino.ImageSize = new System.Drawing.Size(20, 20);
            this.rdbMasculino.LineBottom = 5;
            this.rdbMasculino.LineColor = System.Drawing.Color.Transparent;
            this.rdbMasculino.Location = new System.Drawing.Point(72, 337);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.rdbMasculino.OnHoverBorderColor = System.Drawing.Color.Black;
            this.rdbMasculino.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.rdbMasculino.OnHoverImage = null;
            this.rdbMasculino.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.rdbMasculino.OnPressedColor = System.Drawing.Color.Black;
            this.rdbMasculino.Size = new System.Drawing.Size(100, 30);
            this.rdbMasculino.TabIndex = 8;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AnimationHoverSpeed = 0.07F;
            this.rdbFemenino.AnimationSpeed = 0.03F;
            this.rdbFemenino.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.rdbFemenino.BorderColor = System.Drawing.Color.Black;
            this.rdbFemenino.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.rdbFemenino.Checked = true;
            this.rdbFemenino.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.rdbFemenino.CheckedBorderColor = System.Drawing.Color.Black;
            this.rdbFemenino.CheckedForeColor = System.Drawing.Color.White;
            this.rdbFemenino.CheckedImage = null;
            this.rdbFemenino.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.rdbFemenino.FocusedColor = System.Drawing.Color.Empty;
            this.rdbFemenino.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemenino.ForeColor = System.Drawing.Color.White;
            this.rdbFemenino.Image = null;
            this.rdbFemenino.ImageSize = new System.Drawing.Size(20, 20);
            this.rdbFemenino.LineBottom = 5;
            this.rdbFemenino.LineColor = System.Drawing.Color.Transparent;
            this.rdbFemenino.Location = new System.Drawing.Point(188, 337);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.rdbFemenino.OnHoverBorderColor = System.Drawing.Color.Black;
            this.rdbFemenino.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.rdbFemenino.OnHoverImage = null;
            this.rdbFemenino.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.rdbFemenino.OnPressedColor = System.Drawing.Color.Black;
            this.rdbFemenino.Size = new System.Drawing.Size(100, 30);
            this.rdbFemenino.TabIndex = 7;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtMunicipio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMunicipio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMunicipio.ForeColor = System.Drawing.Color.White;
            this.txtMunicipio.Location = new System.Drawing.Point(141, 292);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(158, 22);
            this.txtMunicipio.TabIndex = 41;
            this.txtMunicipio.Enter += new System.EventHandler(this.txtMunicipio_Enter);
            this.txtMunicipio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtMunicipio_KeyDown);
            this.txtMunicipio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valdacionLetras);
            this.txtMunicipio.Leave += new System.EventHandler(this.txtMunicipio_Leave);
            // 
            // txtApePaterno
            // 
            this.txtApePaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtApePaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApePaterno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtApePaterno.ForeColor = System.Drawing.Color.White;
            this.txtApePaterno.Location = new System.Drawing.Point(141, 37);
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.Size = new System.Drawing.Size(158, 22);
            this.txtApePaterno.TabIndex = 14;
            this.txtApePaterno.Enter += new System.EventHandler(this.txtApePaterno_Enter);
            this.txtApePaterno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtApePaterno_KeyDown);
            this.txtApePaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valdacionLetras);
            this.txtApePaterno.Leave += new System.EventHandler(this.txtApePaterno_Leave);
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEstado.ForeColor = System.Drawing.Color.White;
            this.txtEstado.Location = new System.Drawing.Point(141, 260);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(158, 22);
            this.txtEstado.TabIndex = 40;
            this.txtEstado.Enter += new System.EventHandler(this.txtEstado_Enter);
            this.txtEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEstado_KeyDown);
            this.txtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valdacionLetras);
            this.txtEstado.Leave += new System.EventHandler(this.txtEstado_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(141, 8);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 22);
            this.txtNombre.TabIndex = 13;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valdacionLetras);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.BackColor = System.Drawing.Color.Transparent;
            this.cmbEstadoCivil.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cmbEstadoCivil.BorderColor = System.Drawing.Color.Silver;
            this.cmbEstadoCivil.BorderSize = 1;
            this.cmbEstadoCivil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoCivil.FocusedColor = System.Drawing.Color.Empty;
            this.cmbEstadoCivil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEstadoCivil.ForeColor = System.Drawing.Color.White;
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Items.AddRange(new object[] {
            "Soltero(a)",
            "Casado(a)",
            "Divorciado(a)",
            "Viudo(a)",
            "Union Libre"});
            this.cmbEstadoCivil.Location = new System.Drawing.Point(140, 228);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.cmbEstadoCivil.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbEstadoCivil.Radius = 2;
            this.cmbEstadoCivil.Size = new System.Drawing.Size(160, 26);
            this.cmbEstadoCivil.TabIndex = 8;
            this.cmbEstadoCivil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbEstadoCivil_KeyDown);
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtIdUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdUsuario.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.txtIdUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdUsuario.ForeColor = System.Drawing.Color.White;
            this.txtIdUsuario.LineColor = System.Drawing.Color.Gainsboro;
            this.txtIdUsuario.LineSize = 2;
            this.txtIdUsuario.Location = new System.Drawing.Point(140, 353);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.PasswordChar = '\0';
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(160, 30);
            this.txtIdUsuario.TabIndex = 12;
            this.txtIdUsuario.Visible = false;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.dtpFechaNacimiento.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.dtpFechaNacimiento.BorderColor = System.Drawing.Color.Silver;
            this.dtpFechaNacimiento.BorderSize = 1;
            this.dtpFechaNacimiento.CustomFormat = null;
            this.dtpFechaNacimiento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaNacimiento.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(140, 191);
            this.dtpFechaNacimiento.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpFechaNacimiento.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFechaNacimiento.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaNacimiento.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaNacimiento.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFechaNacimiento.Radius = 2;
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(160, 30);
            this.dtpFechaNacimiento.TabIndex = 7;
            this.dtpFechaNacimiento.Text = "31/12/2001";
            this.dtpFechaNacimiento.Value = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            this.dtpFechaNacimiento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DtpFechaNacimiento_KeyDown);
            // 
            // txtActivo
            // 
            this.txtActivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtActivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtActivo.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.txtActivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtActivo.ForeColor = System.Drawing.Color.White;
            this.txtActivo.LineColor = System.Drawing.Color.Gainsboro;
            this.txtActivo.LineSize = 2;
            this.txtActivo.Location = new System.Drawing.Point(140, 321);
            this.txtActivo.Name = "txtActivo";
            this.txtActivo.PasswordChar = '\0';
            this.txtActivo.ReadOnly = true;
            this.txtActivo.Size = new System.Drawing.Size(160, 30);
            this.txtActivo.TabIndex = 11;
            this.txtActivo.Visible = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCorreo.ForeColor = System.Drawing.Color.White;
            this.txtCorreo.Location = new System.Drawing.Point(142, 161);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(158, 22);
            this.txtCorreo.TabIndex = 39;
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCorreo_KeyDown);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // focusPaterno
            // 
            this.focusPaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focusPaterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focusPaterno.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focusPaterno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.focusPaterno.ForeColor = System.Drawing.Color.White;
            this.focusPaterno.LineColor = System.Drawing.Color.Gainsboro;
            this.focusPaterno.LineSize = 2;
            this.focusPaterno.Location = new System.Drawing.Point(140, 35);
            this.focusPaterno.Name = "focusPaterno";
            this.focusPaterno.PasswordChar = '\0';
            this.focusPaterno.ReadOnly = true;
            this.focusPaterno.Size = new System.Drawing.Size(160, 30);
            this.focusPaterno.TabIndex = 2;
            this.focusPaterno.Enter += new System.EventHandler(this.focusPaterno_Enter);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDomicilio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDomicilio.ForeColor = System.Drawing.Color.White;
            this.txtDomicilio.Location = new System.Drawing.Point(142, 97);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(158, 22);
            this.txtDomicilio.TabIndex = 15;
            this.txtDomicilio.Enter += new System.EventHandler(this.txtDomicilio_Enter);
            this.txtDomicilio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDomicilio_KeyDown);
            this.txtDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valdacionNumsLetras);
            this.txtDomicilio.Leave += new System.EventHandler(this.txtDomicilio_Leave);
            // 
            // focusMunicipio
            // 
            this.focusMunicipio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focusMunicipio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focusMunicipio.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focusMunicipio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.focusMunicipio.ForeColor = System.Drawing.Color.White;
            this.focusMunicipio.LineColor = System.Drawing.Color.Gainsboro;
            this.focusMunicipio.LineSize = 2;
            this.focusMunicipio.Location = new System.Drawing.Point(140, 290);
            this.focusMunicipio.Name = "focusMunicipio";
            this.focusMunicipio.PasswordChar = '\0';
            this.focusMunicipio.ReadOnly = true;
            this.focusMunicipio.Size = new System.Drawing.Size(160, 30);
            this.focusMunicipio.TabIndex = 10;
            this.focusMunicipio.Enter += new System.EventHandler(this.focusMunicipio_Enter);
            this.focusMunicipio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtMunicipio_KeyDown);
            this.focusMunicipio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valdacionLetras);
            // 
            // FocusNombre
            // 
            this.FocusNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.FocusNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FocusNombre.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.FocusNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FocusNombre.ForeColor = System.Drawing.Color.White;
            this.FocusNombre.LineColor = System.Drawing.Color.Gainsboro;
            this.FocusNombre.LineSize = 2;
            this.FocusNombre.Location = new System.Drawing.Point(140, 6);
            this.FocusNombre.Name = "FocusNombre";
            this.FocusNombre.PasswordChar = '\0';
            this.FocusNombre.ReadOnly = true;
            this.FocusNombre.Size = new System.Drawing.Size(160, 30);
            this.FocusNombre.TabIndex = 1;
            this.FocusNombre.Enter += new System.EventHandler(this.FocusNombre_Enter);
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtApeMaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApeMaterno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtApeMaterno.ForeColor = System.Drawing.Color.White;
            this.txtApeMaterno.Location = new System.Drawing.Point(141, 67);
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.Size = new System.Drawing.Size(158, 22);
            this.txtApeMaterno.TabIndex = 15;
            this.txtApeMaterno.Enter += new System.EventHandler(this.txtApeMaterno_Enter);
            this.txtApeMaterno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtApeMaterno_KeyDown);
            this.txtApeMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valdacionLetras);
            this.txtApeMaterno.Leave += new System.EventHandler(this.txtApeMaterno_Leave);
            // 
            // focusEstado
            // 
            this.focusEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focusEstado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focusEstado.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focusEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.focusEstado.ForeColor = System.Drawing.Color.White;
            this.focusEstado.LineColor = System.Drawing.Color.Gainsboro;
            this.focusEstado.LineSize = 2;
            this.focusEstado.Location = new System.Drawing.Point(140, 258);
            this.focusEstado.Name = "focusEstado";
            this.focusEstado.PasswordChar = '\0';
            this.focusEstado.ReadOnly = true;
            this.focusEstado.Size = new System.Drawing.Size(160, 30);
            this.focusEstado.TabIndex = 9;
            this.focusEstado.Enter += new System.EventHandler(this.focusEstado_Enter);
            // 
            // focusCorreo
            // 
            this.focusCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focusCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focusCorreo.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focusCorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.focusCorreo.ForeColor = System.Drawing.Color.White;
            this.focusCorreo.LineColor = System.Drawing.Color.Gainsboro;
            this.focusCorreo.LineSize = 2;
            this.focusCorreo.Location = new System.Drawing.Point(141, 159);
            this.focusCorreo.Name = "focusCorreo";
            this.focusCorreo.PasswordChar = '\0';
            this.focusCorreo.ReadOnly = true;
            this.focusCorreo.Size = new System.Drawing.Size(160, 30);
            this.focusCorreo.TabIndex = 6;
            this.focusCorreo.Enter += new System.EventHandler(this.focusCorreo_Enter);
            // 
            // focusDomicilio
            // 
            this.focusDomicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focusDomicilio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focusDomicilio.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focusDomicilio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.focusDomicilio.ForeColor = System.Drawing.Color.White;
            this.focusDomicilio.LineColor = System.Drawing.Color.Gainsboro;
            this.focusDomicilio.LineSize = 2;
            this.focusDomicilio.Location = new System.Drawing.Point(141, 95);
            this.focusDomicilio.Name = "focusDomicilio";
            this.focusDomicilio.PasswordChar = '\0';
            this.focusDomicilio.ReadOnly = true;
            this.focusDomicilio.Size = new System.Drawing.Size(160, 30);
            this.focusDomicilio.TabIndex = 4;
            this.focusDomicilio.Enter += new System.EventHandler(this.focusDomicilio_Enter);
            // 
            // focusApeMaterno
            // 
            this.focusApeMaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focusApeMaterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focusApeMaterno.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focusApeMaterno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.focusApeMaterno.ForeColor = System.Drawing.Color.White;
            this.focusApeMaterno.LineColor = System.Drawing.Color.Gainsboro;
            this.focusApeMaterno.LineSize = 2;
            this.focusApeMaterno.Location = new System.Drawing.Point(140, 65);
            this.focusApeMaterno.Name = "focusApeMaterno";
            this.focusApeMaterno.PasswordChar = '\0';
            this.focusApeMaterno.ReadOnly = true;
            this.focusApeMaterno.Size = new System.Drawing.Size(160, 30);
            this.focusApeMaterno.TabIndex = 3;
            this.focusApeMaterno.Enter += new System.EventHandler(this.focusApeMaterno_Enter);
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaPanel4.Controls.Add(this.btnCancelar);
            this.gunaPanel4.Controls.Add(this.btnModificar);
            this.gunaPanel4.Controls.Add(this.btnGuardar);
            this.gunaPanel4.Controls.Add(this.btnNuevo);
            this.gunaPanel4.Location = new System.Drawing.Point(32, 508);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(406, 50);
            this.gunaPanel4.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AnimationHoverSpeed = 0.07F;
            this.btnCancelar.AnimationSpeed = 0.03F;
            this.btnCancelar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnCancelar.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnCancelar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCancelar.CheckedForeColor = System.Drawing.Color.White;
            this.btnCancelar.CheckedImage = null;
            this.btnCancelar.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelar.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = null;
            this.btnCancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancelar.LineBottom = 5;
            this.btnCancelar.LineColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Location = new System.Drawing.Point(303, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnCancelar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancelar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnCancelar.OnHoverImage = null;
            this.btnCancelar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnCancelar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancelar.Size = new System.Drawing.Size(101, 50);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
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
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModificar.FocusedColor = System.Drawing.Color.Empty;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = null;
            this.btnModificar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnModificar.LineBottom = 5;
            this.btnModificar.LineColor = System.Drawing.Color.Transparent;
            this.btnModificar.Location = new System.Drawing.Point(202, 0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnModificar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModificar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnModificar.OnHoverImage = null;
            this.btnModificar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnModificar.OnPressedColor = System.Drawing.Color.Black;
            this.btnModificar.Size = new System.Drawing.Size(101, 50);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AnimationHoverSpeed = 0.07F;
            this.btnGuardar.AnimationSpeed = 0.03F;
            this.btnGuardar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnGuardar.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnGuardar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnGuardar.CheckedForeColor = System.Drawing.Color.White;
            this.btnGuardar.CheckedImage = null;
            this.btnGuardar.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = null;
            this.btnGuardar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGuardar.LineBottom = 5;
            this.btnGuardar.LineColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Location = new System.Drawing.Point(101, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnGuardar.OnHoverImage = null;
            this.btnGuardar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardar.Size = new System.Drawing.Size(101, 50);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AnimationHoverSpeed = 0.07F;
            this.btnNuevo.AnimationSpeed = 0.03F;
            this.btnNuevo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnNuevo.BorderColor = System.Drawing.Color.Black;
            this.btnNuevo.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnNuevo.Checked = true;
            this.btnNuevo.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnNuevo.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnNuevo.CheckedForeColor = System.Drawing.Color.White;
            this.btnNuevo.CheckedImage = null;
            this.btnNuevo.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNuevo.FocusedColor = System.Drawing.Color.Empty;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = null;
            this.btnNuevo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNuevo.LineBottom = 5;
            this.btnNuevo.LineColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Location = new System.Drawing.Point(0, 0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnNuevo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNuevo.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnNuevo.OnHoverImage = null;
            this.btnNuevo.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnNuevo.OnPressedColor = System.Drawing.Color.Black;
            this.btnNuevo.Size = new System.Drawing.Size(101, 50);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(25, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 37);
            this.label14.TabIndex = 0;
            this.label14.Text = "Personas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(449, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "Buscar";
            // 
            // focusBuscar
            // 
            this.focusBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focusBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focusBuscar.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focusBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.focusBuscar.ForeColor = System.Drawing.Color.White;
            this.focusBuscar.LineColor = System.Drawing.Color.Gainsboro;
            this.focusBuscar.LineSize = 2;
            this.focusBuscar.Location = new System.Drawing.Point(509, 25);
            this.focusBuscar.Name = "focusBuscar";
            this.focusBuscar.PasswordChar = '\0';
            this.focusBuscar.Size = new System.Drawing.Size(160, 30);
            this.focusBuscar.TabIndex = 1;
            this.focusBuscar.Enter += new System.EventHandler(this.focusBuscar_Enter);
            // 
            // mcPersonas
            // 
            this.mcPersonas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mcPersonas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnModificarPersona,
            this.btnActivarPersona,
            this.btnDesactivarPersona});
            this.mcPersonas.Name = "mcPersonas";
            this.mcPersonas.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.mcPersonas.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.mcPersonas.RenderStyle.ColorTable = null;
            this.mcPersonas.RenderStyle.RoundedEdges = true;
            this.mcPersonas.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.mcPersonas.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.mcPersonas.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.mcPersonas.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.mcPersonas.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.mcPersonas.Size = new System.Drawing.Size(129, 70);
            this.mcPersonas.Opening += new System.ComponentModel.CancelEventHandler(this.McPersonas_Opening);
            // 
            // btnModificarPersona
            // 
            this.btnModificarPersona.Name = "btnModificarPersona";
            this.btnModificarPersona.Size = new System.Drawing.Size(128, 22);
            this.btnModificarPersona.Text = "Modificar";
            this.btnModificarPersona.Click += new System.EventHandler(this.ModificarToolStripMenuItem_Click);
            // 
            // btnActivarPersona
            // 
            this.btnActivarPersona.Name = "btnActivarPersona";
            this.btnActivarPersona.Size = new System.Drawing.Size(128, 22);
            this.btnActivarPersona.Text = "Activar";
            this.btnActivarPersona.Click += new System.EventHandler(this.BtnActivarPersona_Click);
            // 
            // btnDesactivarPersona
            // 
            this.btnDesactivarPersona.Name = "btnDesactivarPersona";
            this.btnDesactivarPersona.Size = new System.Drawing.Size(128, 22);
            this.btnDesactivarPersona.Text = "Desactivar";
            this.btnDesactivarPersona.Click += new System.EventHandler(this.BtnDesactivarPersona_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AnimationHoverSpeed = 0.07F;
            this.btnImprimir.AnimationSpeed = 0.03F;
            this.btnImprimir.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnImprimir.BorderColor = System.Drawing.Color.Black;
            this.btnImprimir.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnImprimir.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnImprimir.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnImprimir.CheckedForeColor = System.Drawing.Color.White;
            this.btnImprimir.CheckedImage = null;
            this.btnImprimir.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btnImprimir.FocusedColor = System.Drawing.Color.Empty;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Image = null;
            this.btnImprimir.ImageSize = new System.Drawing.Size(20, 20);
            this.btnImprimir.LineBottom = 5;
            this.btnImprimir.LineColor = System.Drawing.Color.Transparent;
            this.btnImprimir.Location = new System.Drawing.Point(675, 25);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnImprimir.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnImprimir.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnImprimir.OnHoverImage = null;
            this.btnImprimir.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnImprimir.OnPressedColor = System.Drawing.Color.Black;
            this.btnImprimir.Size = new System.Drawing.Size(100, 30);
            this.btnImprimir.TabIndex = 34;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Activos
            // 
            this.Activos.BaseColor = System.Drawing.SystemColors.Control;
            this.Activos.Checked = true;
            this.Activos.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.Activos.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Activos.FillColor = System.Drawing.Color.White;
            this.Activos.Location = new System.Drawing.Point(795, 29);
            this.Activos.Name = "Activos";
            this.Activos.Size = new System.Drawing.Size(40, 22);
            this.Activos.TabIndex = 37;
            this.Activos.CheckedChanged += new System.EventHandler(this.Activos_CheckedChanged);
            // 
            // lblActi
            // 
            this.lblActi.AutoSize = true;
            this.lblActi.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActi.ForeColor = System.Drawing.Color.White;
            this.lblActi.Location = new System.Drawing.Point(841, 29);
            this.lblActi.Name = "lblActi";
            this.lblActi.Size = new System.Drawing.Size(57, 21);
            this.lblActi.TabIndex = 38;
            this.lblActi.Text = "Activos";
            this.lblActi.Click += new System.EventHandler(this.lblActi_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(510, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(158, 22);
            this.txtBuscar.TabIndex = 42;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valdacionLetras);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AllowUserToAddRows = false;
            this.dgvPersonas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPersonas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersonas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.dgvPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPersonas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.ContextMenuStrip = this.mcPersonas;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPersonas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPersonas.EnableHeadersVisualStyles = false;
            this.dgvPersonas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.dgvPersonas.Location = new System.Drawing.Point(335, 61);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPersonas.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPersonas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPersonas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.dgvPersonas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPersonas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPersonas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.dgvPersonas.RowTemplate.ReadOnly = true;
            this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonas.Size = new System.Drawing.Size(633, 367);
            this.dgvPersonas.TabIndex = 66;
            // 
            // frmPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(980, 600);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblActi);
            this.Controls.Add(this.Activos);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.gunaPanel4);
            this.Controls.Add(this.grbPersonas);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.focusBuscar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPersonas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personas | SCI";
            this.Load += new System.EventHandler(this.FrmPersonas_Load);
            this.grbPersonas.ResumeLayout(false);
            this.grbPersonas.PerformLayout();
            this.gunaPanel4.ResumeLayout(false);
            this.mcPersonas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHoraRegistro;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.Panel grbPersonas;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaAdvenceButton btnCancelar;
        private Guna.UI.WinForms.GunaAdvenceButton btnModificar;
        private Guna.UI.WinForms.GunaAdvenceButton btnGuardar;
        private Guna.UI.WinForms.GunaAdvenceButton btnNuevo;
        private System.Windows.Forms.Label label14;
        private Guna.UI.WinForms.GunaAdvenceButton rdbMasculino;
        private Guna.UI.WinForms.GunaAdvenceButton rdbFemenino;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFechaNacimiento;
        private Guna.UI.WinForms.GunaLineTextBox focusCorreo;
        private Guna.UI.WinForms.GunaLineTextBox focusDomicilio;
        private Guna.UI.WinForms.GunaLineTextBox focusApeMaterno;
        private Guna.UI.WinForms.GunaLineTextBox focusPaterno;
        private Guna.UI.WinForms.GunaComboBox cmbEstadoCivil;
        private Guna.UI.WinForms.GunaLineTextBox txtIdUsuario;
        private Guna.UI.WinForms.GunaLineTextBox txtActivo;
        private Guna.UI.WinForms.GunaLineTextBox focusMunicipio;
        private Guna.UI.WinForms.GunaLineTextBox focusEstado;
        private System.Windows.Forms.Label label13;
        private Guna.UI.WinForms.GunaLineTextBox focusBuscar;
        private Guna.UI.WinForms.GunaAdvenceButton btnImprimir;
        private Guna.UI.WinForms.GunaWinSwitch Activos;
        private System.Windows.Forms.Label lblActi;
        private System.Windows.Forms.TextBox txtNombre;
        private Guna.UI.WinForms.GunaLineTextBox FocusNombre;
        private System.Windows.Forms.TextBox txtApePaterno;
        private System.Windows.Forms.TextBox txtApeMaterno;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.TextBox txtBuscar;
        private Guna.UI.WinForms.GunaContextMenuStrip mcPersonas;
        private System.Windows.Forms.ToolStripMenuItem btnModificarPersona;
        private System.Windows.Forms.ToolStripMenuItem btnActivarPersona;
        private System.Windows.Forms.ToolStripMenuItem btnDesactivarPersona;
        private System.Windows.Forms.DataGridView dgvPersonas;
    }
}