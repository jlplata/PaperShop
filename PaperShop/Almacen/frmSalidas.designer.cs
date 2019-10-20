namespace PaperShop
{
    partial class frmSalidas
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
            this.txtidsalida = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtgran_total = new System.Windows.Forms.TextBox();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.Id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbbuscar_producto = new System.Windows.Forms.GroupBox();
            this.txtcantidadproducto = new System.Windows.Forms.TextBox();
            this.txtid_producto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtprecio_venta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtcve_producto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidusuario = new System.Windows.Forms.TextBox();
            this.grbSalida = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.lblid_cliente = new System.Windows.Forms.Label();
            this.lblid_trabajador = new System.Windows.Forms.Label();
            this.lblid_caja = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbcliente = new System.Windows.Forms.ComboBox();
            this.cmbtrabajador = new System.Windows.Forms.ComboBox();
            this.cmbcaja = new System.Windows.Forms.ComboBox();
            this.txtactivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblhora_registro = new System.Windows.Forms.Label();
            this.lblfecha_registro = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbfactura = new System.Windows.Forms.ComboBox();
            this.focustotal = new Guna.UI.WinForms.GunaLineTextBox();
            this.focusdes = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnregistrar_salida = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btncancelar_salida = new Guna.UI.WinForms.GunaAdvenceButton();
            this.focusClave = new Guna.UI.WinForms.GunaLineTextBox();
            this.focusCant = new Guna.UI.WinForms.GunaLineTextBox();
            this.focusNom = new Guna.UI.WinForms.GunaLineTextBox();
            this.foucuspre = new Guna.UI.WinForms.GunaLineTextBox();
            this.focusgran = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnliberar_salida = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btncancelar_producto = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.grbbuscar_producto.SuspendLayout();
            this.grbSalida.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtidsalida
            // 
            this.txtidsalida.Location = new System.Drawing.Point(498, 163);
            this.txtidsalida.Name = "txtidsalida";
            this.txtidsalida.ReadOnly = true;
            this.txtidsalida.Size = new System.Drawing.Size(100, 20);
            this.txtidsalida.TabIndex = 32;
            this.txtidsalida.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(583, 476);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 21);
            this.label8.TabIndex = 31;
            this.label8.Text = "Gran Total:";
            // 
            // txtgran_total
            // 
            this.txtgran_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtgran_total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtgran_total.Enabled = false;
            this.txtgran_total.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgran_total.ForeColor = System.Drawing.Color.White;
            this.txtgran_total.Location = new System.Drawing.Point(670, 475);
            this.txtgran_total.Name = "txtgran_total";
            this.txtgran_total.Size = new System.Drawing.Size(133, 22);
            this.txtgran_total.TabIndex = 30;
            this.txtgran_total.Enter += new System.EventHandler(this.txtgran_total_Enter);
            this.txtgran_total.Leave += new System.EventHandler(this.txtgran_total_Leave);
            // 
            // dgvproductos
            // 
            this.dgvproductos.AllowUserToAddRows = false;
            this.dgvproductos.AllowUserToDeleteRows = false;
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_producto,
            this.Nombre,
            this.Precio_Venta,
            this.Cantidad,
            this.Total});
            this.dgvproductos.Location = new System.Drawing.Point(57, 305);
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.Size = new System.Drawing.Size(881, 150);
            this.dgvproductos.TabIndex = 27;
            // 
            // Id_producto
            // 
            this.Id_producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id_producto.HeaderText = "Id_producto";
            this.Id_producto.Name = "Id_producto";
            this.Id_producto.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Precio_Venta
            // 
            this.Precio_Venta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio_Venta.HeaderText = "Precio_Venta";
            this.Precio_Venta.Name = "Precio_Venta";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // grbbuscar_producto
            // 
            this.grbbuscar_producto.BackColor = System.Drawing.Color.Transparent;
            this.grbbuscar_producto.Controls.Add(this.txtcantidadproducto);
            this.grbbuscar_producto.Controls.Add(this.txtid_producto);
            this.grbbuscar_producto.Controls.Add(this.label7);
            this.grbbuscar_producto.Controls.Add(this.txtprecio_venta);
            this.grbbuscar_producto.Controls.Add(this.label6);
            this.grbbuscar_producto.Controls.Add(this.txtnombre);
            this.grbbuscar_producto.Controls.Add(this.label5);
            this.grbbuscar_producto.Controls.Add(this.txtcantidad);
            this.grbbuscar_producto.Controls.Add(this.txtcve_producto);
            this.grbbuscar_producto.Controls.Add(this.label4);
            this.grbbuscar_producto.Controls.Add(this.focusClave);
            this.grbbuscar_producto.Controls.Add(this.focusCant);
            this.grbbuscar_producto.Controls.Add(this.focusNom);
            this.grbbuscar_producto.Controls.Add(this.foucuspre);
            this.grbbuscar_producto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbbuscar_producto.ForeColor = System.Drawing.Color.White;
            this.grbbuscar_producto.Location = new System.Drawing.Point(57, 199);
            this.grbbuscar_producto.Name = "grbbuscar_producto";
            this.grbbuscar_producto.Size = new System.Drawing.Size(881, 100);
            this.grbbuscar_producto.TabIndex = 26;
            this.grbbuscar_producto.TabStop = false;
            this.grbbuscar_producto.Text = "Buscar Producto";
            // 
            // txtcantidadproducto
            // 
            this.txtcantidadproducto.Enabled = false;
            this.txtcantidadproducto.Location = new System.Drawing.Point(842, 30);
            this.txtcantidadproducto.Name = "txtcantidadproducto";
            this.txtcantidadproducto.Size = new System.Drawing.Size(33, 29);
            this.txtcantidadproducto.TabIndex = 9;
            this.txtcantidadproducto.Visible = false;
            // 
            // txtid_producto
            // 
            this.txtid_producto.Enabled = false;
            this.txtid_producto.Location = new System.Drawing.Point(845, 9);
            this.txtid_producto.Name = "txtid_producto";
            this.txtid_producto.Size = new System.Drawing.Size(29, 29);
            this.txtid_producto.TabIndex = 8;
            this.txtid_producto.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(609, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Precio:";
            // 
            // txtprecio_venta
            // 
            this.txtprecio_venta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtprecio_venta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtprecio_venta.Enabled = false;
            this.txtprecio_venta.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio_venta.ForeColor = System.Drawing.Color.White;
            this.txtprecio_venta.Location = new System.Drawing.Point(572, 51);
            this.txtprecio_venta.Name = "txtprecio_venta";
            this.txtprecio_venta.Size = new System.Drawing.Size(133, 22);
            this.txtprecio_venta.TabIndex = 6;
            this.txtprecio_venta.Enter += new System.EventHandler(this.txtprecio_venta_Enter);
            this.txtprecio_venta.Leave += new System.EventHandler(this.txtprecio_venta_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(464, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre:";
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Enabled = false;
            this.txtnombre.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.White;
            this.txtnombre.Location = new System.Drawing.Point(433, 52);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(133, 22);
            this.txtnombre.TabIndex = 4;
            this.txtnombre.Enter += new System.EventHandler(this.txtnombre_Enter);
            this.txtnombre.Leave += new System.EventHandler(this.txtnombre_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(329, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcantidad.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.ForeColor = System.Drawing.Color.White;
            this.txtcantidad.Location = new System.Drawing.Point(294, 52);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(133, 22);
            this.txtcantidad.TabIndex = 2;
            this.txtcantidad.Enter += new System.EventHandler(this.txtcantidad_Enter);
            this.txtcantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtcantidad_KeyDown);
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcantidad_KeyPress);
            this.txtcantidad.Leave += new System.EventHandler(this.txtcantidad_Leave);
            // 
            // txtcve_producto
            // 
            this.txtcve_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtcve_producto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcve_producto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcve_producto.ForeColor = System.Drawing.Color.White;
            this.txtcve_producto.Location = new System.Drawing.Point(155, 50);
            this.txtcve_producto.Name = "txtcve_producto";
            this.txtcve_producto.Size = new System.Drawing.Size(133, 22);
            this.txtcve_producto.TabIndex = 1;
            this.txtcve_producto.Enter += new System.EventHandler(this.txtcve_producto_Enter);
            this.txtcve_producto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtcve_producto_KeyDown);
            this.txtcve_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcve_producto_KeyPress);
            this.txtcve_producto.Leave += new System.EventHandler(this.txtcve_producto_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(172, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Clave Producto:";
            // 
            // txtidusuario
            // 
            this.txtidusuario.Location = new System.Drawing.Point(384, 163);
            this.txtidusuario.Name = "txtidusuario";
            this.txtidusuario.ReadOnly = true;
            this.txtidusuario.Size = new System.Drawing.Size(100, 20);
            this.txtidusuario.TabIndex = 23;
            this.txtidusuario.Visible = false;
            // 
            // grbSalida
            // 
            this.grbSalida.BackColor = System.Drawing.Color.Transparent;
            this.grbSalida.Controls.Add(this.txttotal);
            this.grbSalida.Controls.Add(this.focustotal);
            this.grbSalida.Controls.Add(this.label12);
            this.grbSalida.Controls.Add(this.txtdescripcion);
            this.grbSalida.Controls.Add(this.lblid_cliente);
            this.grbSalida.Controls.Add(this.lblid_trabajador);
            this.grbSalida.Controls.Add(this.lblid_caja);
            this.grbSalida.Controls.Add(this.label11);
            this.grbSalida.Controls.Add(this.label10);
            this.grbSalida.Controls.Add(this.label9);
            this.grbSalida.Controls.Add(this.cmbcliente);
            this.grbSalida.Controls.Add(this.cmbtrabajador);
            this.grbSalida.Controls.Add(this.cmbcaja);
            this.grbSalida.Controls.Add(this.txtactivo);
            this.grbSalida.Controls.Add(this.label3);
            this.grbSalida.Controls.Add(this.lblhora_registro);
            this.grbSalida.Controls.Add(this.lblfecha_registro);
            this.grbSalida.Controls.Add(this.label2);
            this.grbSalida.Controls.Add(this.label1);
            this.grbSalida.Controls.Add(this.cmbfactura);
            this.grbSalida.Controls.Add(this.focusdes);
            this.grbSalida.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSalida.ForeColor = System.Drawing.Color.White;
            this.grbSalida.Location = new System.Drawing.Point(57, 22);
            this.grbSalida.Name = "grbSalida";
            this.grbSalida.Size = new System.Drawing.Size(881, 125);
            this.grbSalida.TabIndex = 22;
            this.grbSalida.TabStop = false;
            this.grbSalida.Text = "Salidas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(550, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 21);
            this.label12.TabIndex = 90;
            this.label12.Text = "Descripcion:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdescripcion.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.ForeColor = System.Drawing.Color.White;
            this.txtdescripcion.Location = new System.Drawing.Point(554, 48);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(288, 22);
            this.txtdescripcion.TabIndex = 89;
            // 
            // lblid_cliente
            // 
            this.lblid_cliente.AutoSize = true;
            this.lblid_cliente.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_cliente.ForeColor = System.Drawing.Color.White;
            this.lblid_cliente.Location = new System.Drawing.Point(363, 25);
            this.lblid_cliente.Name = "lblid_cliente";
            this.lblid_cliente.Size = new System.Drawing.Size(22, 21);
            this.lblid_cliente.TabIndex = 88;
            this.lblid_cliente.Text = "id";
            // 
            // lblid_trabajador
            // 
            this.lblid_trabajador.AutoSize = true;
            this.lblid_trabajador.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_trabajador.ForeColor = System.Drawing.Color.White;
            this.lblid_trabajador.Location = new System.Drawing.Point(236, 25);
            this.lblid_trabajador.Name = "lblid_trabajador";
            this.lblid_trabajador.Size = new System.Drawing.Size(22, 21);
            this.lblid_trabajador.TabIndex = 87;
            this.lblid_trabajador.Text = "id";
            // 
            // lblid_caja
            // 
            this.lblid_caja.AutoSize = true;
            this.lblid_caja.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_caja.ForeColor = System.Drawing.Color.White;
            this.lblid_caja.Location = new System.Drawing.Point(100, 25);
            this.lblid_caja.Name = "lblid_caja";
            this.lblid_caja.Size = new System.Drawing.Size(22, 21);
            this.lblid_caja.TabIndex = 86;
            this.lblid_caja.Text = "id";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(278, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 21);
            this.label11.TabIndex = 13;
            this.label11.Text = "Cliente:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(151, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 21);
            this.label10.TabIndex = 12;
            this.label10.Text = "Trabajador:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(18, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Caja:";
            // 
            // cmbcliente
            // 
            this.cmbcliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cmbcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcliente.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcliente.ForeColor = System.Drawing.Color.White;
            this.cmbcliente.FormattingEnabled = true;
            this.cmbcliente.Location = new System.Drawing.Point(273, 52);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.Size = new System.Drawing.Size(121, 25);
            this.cmbcliente.TabIndex = 10;
            this.cmbcliente.SelectedIndexChanged += new System.EventHandler(this.Cmbcliente_SelectedIndexChanged);
            // 
            // cmbtrabajador
            // 
            this.cmbtrabajador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cmbtrabajador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtrabajador.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtrabajador.ForeColor = System.Drawing.Color.White;
            this.cmbtrabajador.FormattingEnabled = true;
            this.cmbtrabajador.Location = new System.Drawing.Point(146, 52);
            this.cmbtrabajador.Name = "cmbtrabajador";
            this.cmbtrabajador.Size = new System.Drawing.Size(121, 25);
            this.cmbtrabajador.TabIndex = 9;
            this.cmbtrabajador.SelectedIndexChanged += new System.EventHandler(this.Cmbtrabajador_SelectedIndexChanged);
            // 
            // cmbcaja
            // 
            this.cmbcaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cmbcaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcaja.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcaja.ForeColor = System.Drawing.Color.White;
            this.cmbcaja.FormattingEnabled = true;
            this.cmbcaja.Location = new System.Drawing.Point(16, 52);
            this.cmbcaja.Name = "cmbcaja";
            this.cmbcaja.Size = new System.Drawing.Size(121, 25);
            this.cmbcaja.TabIndex = 8;
            this.cmbcaja.SelectedIndexChanged += new System.EventHandler(this.Cmbcaja_SelectedIndexChanged);
            // 
            // txtactivo
            // 
            this.txtactivo.BackColor = System.Drawing.Color.White;
            this.txtactivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtactivo.Enabled = false;
            this.txtactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtactivo.ForeColor = System.Drawing.Color.White;
            this.txtactivo.Location = new System.Drawing.Point(538, 86);
            this.txtactivo.Name = "txtactivo";
            this.txtactivo.Size = new System.Drawing.Size(100, 22);
            this.txtactivo.TabIndex = 7;
            this.txtactivo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(487, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Activo:";
            this.label3.Visible = false;
            // 
            // lblhora_registro
            // 
            this.lblhora_registro.AutoSize = true;
            this.lblhora_registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora_registro.ForeColor = System.Drawing.Color.White;
            this.lblhora_registro.Location = new System.Drawing.Point(143, 97);
            this.lblhora_registro.Name = "lblhora_registro";
            this.lblhora_registro.Size = new System.Drawing.Size(111, 16);
            this.lblhora_registro.TabIndex = 5;
            this.lblhora_registro.Text = "Hora de Registro";
            // 
            // lblfecha_registro
            // 
            this.lblfecha_registro.AutoSize = true;
            this.lblfecha_registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha_registro.ForeColor = System.Drawing.Color.White;
            this.lblfecha_registro.Location = new System.Drawing.Point(16, 97);
            this.lblfecha_registro.Name = "lblfecha_registro";
            this.lblfecha_registro.Size = new System.Drawing.Size(119, 16);
            this.lblfecha_registro.TabIndex = 4;
            this.lblfecha_registro.Text = "Fecha de Registro";
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttotal.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.ForeColor = System.Drawing.Color.White;
            this.txttotal.Location = new System.Drawing.Point(415, 51);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(109, 18);
            this.txttotal.TabIndex = 3;
            this.txttotal.Visible = false;
            this.txttotal.Enter += new System.EventHandler(this.txttotal_Enter);
            this.txttotal.Leave += new System.EventHandler(this.txttotal_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(411, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(272, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Factura:";
            // 
            // cmbfactura
            // 
            this.cmbfactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfactura.ForeColor = System.Drawing.Color.White;
            this.cmbfactura.FormattingEnabled = true;
            this.cmbfactura.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbfactura.Location = new System.Drawing.Point(334, 84);
            this.cmbfactura.Name = "cmbfactura";
            this.cmbfactura.Size = new System.Drawing.Size(121, 29);
            this.cmbfactura.TabIndex = 0;
            // 
            // focustotal
            // 
            this.focustotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focustotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focustotal.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focustotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.focustotal.ForeColor = System.Drawing.Color.White;
            this.focustotal.LineColor = System.Drawing.Color.White;
            this.focustotal.LineSize = 2;
            this.focustotal.Location = new System.Drawing.Point(415, 48);
            this.focustotal.Name = "focustotal";
            this.focustotal.PasswordChar = '\0';
            this.focustotal.ReadOnly = true;
            this.focustotal.Size = new System.Drawing.Size(133, 26);
            this.focustotal.TabIndex = 91;
            this.focustotal.Enter += new System.EventHandler(this.focustotal_Enter);
            // 
            // focusdes
            // 
            this.focusdes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focusdes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focusdes.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focusdes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.focusdes.ForeColor = System.Drawing.Color.White;
            this.focusdes.LineColor = System.Drawing.Color.White;
            this.focusdes.LineSize = 2;
            this.focusdes.Location = new System.Drawing.Point(554, 48);
            this.focusdes.Name = "focusdes";
            this.focusdes.PasswordChar = '\0';
            this.focusdes.ReadOnly = true;
            this.focusdes.Size = new System.Drawing.Size(288, 26);
            this.focusdes.TabIndex = 92;
            // 
            // btnregistrar_salida
            // 
            this.btnregistrar_salida.AnimationHoverSpeed = 0.07F;
            this.btnregistrar_salida.AnimationSpeed = 0.03F;
            this.btnregistrar_salida.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnregistrar_salida.BorderColor = System.Drawing.Color.Black;
            this.btnregistrar_salida.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnregistrar_salida.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnregistrar_salida.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnregistrar_salida.CheckedForeColor = System.Drawing.Color.White;
            this.btnregistrar_salida.CheckedImage = null;
            this.btnregistrar_salida.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btnregistrar_salida.FocusedColor = System.Drawing.Color.Empty;
            this.btnregistrar_salida.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar_salida.ForeColor = System.Drawing.Color.White;
            this.btnregistrar_salida.Image = null;
            this.btnregistrar_salida.ImageSize = new System.Drawing.Size(20, 20);
            this.btnregistrar_salida.LineBottom = 5;
            this.btnregistrar_salida.LineColor = System.Drawing.Color.Transparent;
            this.btnregistrar_salida.Location = new System.Drawing.Point(69, 153);
            this.btnregistrar_salida.Name = "btnregistrar_salida";
            this.btnregistrar_salida.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnregistrar_salida.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnregistrar_salida.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnregistrar_salida.OnHoverImage = null;
            this.btnregistrar_salida.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnregistrar_salida.OnPressedColor = System.Drawing.Color.Black;
            this.btnregistrar_salida.Size = new System.Drawing.Size(100, 30);
            this.btnregistrar_salida.TabIndex = 90;
            this.btnregistrar_salida.Text = "Regresar";
            this.btnregistrar_salida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnregistrar_salida.Click += new System.EventHandler(this.Btnregistrar_salida_Click);
            // 
            // btncancelar_salida
            // 
            this.btncancelar_salida.AnimationHoverSpeed = 0.07F;
            this.btncancelar_salida.AnimationSpeed = 0.03F;
            this.btncancelar_salida.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btncancelar_salida.BorderColor = System.Drawing.Color.Black;
            this.btncancelar_salida.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btncancelar_salida.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btncancelar_salida.CheckedBorderColor = System.Drawing.Color.Black;
            this.btncancelar_salida.CheckedForeColor = System.Drawing.Color.White;
            this.btncancelar_salida.CheckedImage = null;
            this.btncancelar_salida.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btncancelar_salida.FocusedColor = System.Drawing.Color.Empty;
            this.btncancelar_salida.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar_salida.ForeColor = System.Drawing.Color.White;
            this.btncancelar_salida.Image = null;
            this.btncancelar_salida.ImageSize = new System.Drawing.Size(20, 20);
            this.btncancelar_salida.LineBottom = 5;
            this.btncancelar_salida.LineColor = System.Drawing.Color.Transparent;
            this.btncancelar_salida.Location = new System.Drawing.Point(826, 153);
            this.btncancelar_salida.Name = "btncancelar_salida";
            this.btncancelar_salida.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btncancelar_salida.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btncancelar_salida.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btncancelar_salida.OnHoverImage = null;
            this.btncancelar_salida.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btncancelar_salida.OnPressedColor = System.Drawing.Color.Black;
            this.btncancelar_salida.Size = new System.Drawing.Size(100, 30);
            this.btncancelar_salida.TabIndex = 91;
            this.btncancelar_salida.Text = "Cancelar";
            this.btncancelar_salida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btncancelar_salida.Click += new System.EventHandler(this.Btncancelar_salida_Click);
            // 
            // focusClave
            // 
            this.focusClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focusClave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focusClave.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focusClave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.focusClave.ForeColor = System.Drawing.Color.White;
            this.focusClave.LineColor = System.Drawing.Color.White;
            this.focusClave.LineSize = 2;
            this.focusClave.Location = new System.Drawing.Point(155, 50);
            this.focusClave.Name = "focusClave";
            this.focusClave.PasswordChar = '\0';
            this.focusClave.ReadOnly = true;
            this.focusClave.Size = new System.Drawing.Size(133, 26);
            this.focusClave.TabIndex = 93;
            this.focusClave.Enter += new System.EventHandler(this.focusClave_Enter);
            // 
            // focusCant
            // 
            this.focusCant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focusCant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focusCant.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focusCant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.focusCant.ForeColor = System.Drawing.Color.White;
            this.focusCant.LineColor = System.Drawing.Color.White;
            this.focusCant.LineSize = 2;
            this.focusCant.Location = new System.Drawing.Point(294, 50);
            this.focusCant.Name = "focusCant";
            this.focusCant.PasswordChar = '\0';
            this.focusCant.ReadOnly = true;
            this.focusCant.Size = new System.Drawing.Size(133, 26);
            this.focusCant.TabIndex = 94;
            this.focusCant.Enter += new System.EventHandler(this.focusCant_Enter);
            // 
            // focusNom
            // 
            this.focusNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focusNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focusNom.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focusNom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.focusNom.ForeColor = System.Drawing.Color.White;
            this.focusNom.LineColor = System.Drawing.Color.White;
            this.focusNom.LineSize = 2;
            this.focusNom.Location = new System.Drawing.Point(433, 50);
            this.focusNom.Name = "focusNom";
            this.focusNom.PasswordChar = '\0';
            this.focusNom.ReadOnly = true;
            this.focusNom.Size = new System.Drawing.Size(133, 26);
            this.focusNom.TabIndex = 95;
            this.focusNom.Enter += new System.EventHandler(this.focusNom_Enter);
            // 
            // foucuspre
            // 
            this.foucuspre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.foucuspre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.foucuspre.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.foucuspre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.foucuspre.ForeColor = System.Drawing.Color.White;
            this.foucuspre.LineColor = System.Drawing.Color.White;
            this.foucuspre.LineSize = 2;
            this.foucuspre.Location = new System.Drawing.Point(572, 50);
            this.foucuspre.Name = "foucuspre";
            this.foucuspre.PasswordChar = '\0';
            this.foucuspre.ReadOnly = true;
            this.foucuspre.Size = new System.Drawing.Size(133, 26);
            this.foucuspre.TabIndex = 96;
            this.foucuspre.Enter += new System.EventHandler(this.gunaLineTextBox1_Enter);
            // 
            // focusgran
            // 
            this.focusgran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focusgran.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focusgran.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focusgran.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.focusgran.ForeColor = System.Drawing.Color.White;
            this.focusgran.LineColor = System.Drawing.Color.White;
            this.focusgran.LineSize = 2;
            this.focusgran.Location = new System.Drawing.Point(670, 469);
            this.focusgran.Name = "focusgran";
            this.focusgran.PasswordChar = '\0';
            this.focusgran.ReadOnly = true;
            this.focusgran.Size = new System.Drawing.Size(133, 32);
            this.focusgran.TabIndex = 97;
            this.focusgran.Enter += new System.EventHandler(this.focusgran_Enter);
            // 
            // btnliberar_salida
            // 
            this.btnliberar_salida.AnimationHoverSpeed = 0.07F;
            this.btnliberar_salida.AnimationSpeed = 0.03F;
            this.btnliberar_salida.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnliberar_salida.BorderColor = System.Drawing.Color.Black;
            this.btnliberar_salida.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnliberar_salida.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnliberar_salida.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnliberar_salida.CheckedForeColor = System.Drawing.Color.White;
            this.btnliberar_salida.CheckedImage = null;
            this.btnliberar_salida.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btnliberar_salida.FocusedColor = System.Drawing.Color.Empty;
            this.btnliberar_salida.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnliberar_salida.ForeColor = System.Drawing.Color.White;
            this.btnliberar_salida.Image = null;
            this.btnliberar_salida.ImageSize = new System.Drawing.Size(20, 20);
            this.btnliberar_salida.LineBottom = 5;
            this.btnliberar_salida.LineColor = System.Drawing.Color.Transparent;
            this.btnliberar_salida.Location = new System.Drawing.Point(826, 476);
            this.btnliberar_salida.Name = "btnliberar_salida";
            this.btnliberar_salida.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnliberar_salida.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnliberar_salida.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnliberar_salida.OnHoverImage = null;
            this.btnliberar_salida.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnliberar_salida.OnPressedColor = System.Drawing.Color.Black;
            this.btnliberar_salida.Size = new System.Drawing.Size(100, 30);
            this.btnliberar_salida.TabIndex = 98;
            this.btnliberar_salida.Text = "Regresar";
            this.btnliberar_salida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnliberar_salida.Click += new System.EventHandler(this.Btnliberar_salida_Click);
            // 
            // btncancelar_producto
            // 
            this.btncancelar_producto.AnimationHoverSpeed = 0.07F;
            this.btncancelar_producto.AnimationSpeed = 0.03F;
            this.btncancelar_producto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btncancelar_producto.BorderColor = System.Drawing.Color.Black;
            this.btncancelar_producto.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btncancelar_producto.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btncancelar_producto.CheckedBorderColor = System.Drawing.Color.Black;
            this.btncancelar_producto.CheckedForeColor = System.Drawing.Color.White;
            this.btncancelar_producto.CheckedImage = null;
            this.btncancelar_producto.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btncancelar_producto.FocusedColor = System.Drawing.Color.Empty;
            this.btncancelar_producto.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar_producto.ForeColor = System.Drawing.Color.White;
            this.btncancelar_producto.Image = null;
            this.btncancelar_producto.ImageSize = new System.Drawing.Size(20, 20);
            this.btncancelar_producto.LineBottom = 5;
            this.btncancelar_producto.LineColor = System.Drawing.Color.Transparent;
            this.btncancelar_producto.Location = new System.Drawing.Point(69, 476);
            this.btncancelar_producto.Name = "btncancelar_producto";
            this.btncancelar_producto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btncancelar_producto.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btncancelar_producto.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btncancelar_producto.OnHoverImage = null;
            this.btncancelar_producto.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btncancelar_producto.OnPressedColor = System.Drawing.Color.Black;
            this.btncancelar_producto.Size = new System.Drawing.Size(100, 30);
            this.btncancelar_producto.TabIndex = 99;
            this.btncancelar_producto.Text = "Cancelar";
            this.btncancelar_producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btncancelar_producto.Click += new System.EventHandler(this.Btncancelar_producto_Click);
            // 
            // frmSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1036, 530);
            this.Controls.Add(this.btncancelar_producto);
            this.Controls.Add(this.btnliberar_salida);
            this.Controls.Add(this.btncancelar_salida);
            this.Controls.Add(this.btnregistrar_salida);
            this.Controls.Add(this.txtidsalida);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtgran_total);
            this.Controls.Add(this.dgvproductos);
            this.Controls.Add(this.grbbuscar_producto);
            this.Controls.Add(this.txtidusuario);
            this.Controls.Add(this.grbSalida);
            this.Controls.Add(this.focusgran);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmSalidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSalidas";
            this.Load += new System.EventHandler(this.FrmSalidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.grbbuscar_producto.ResumeLayout(false);
            this.grbbuscar_producto.PerformLayout();
            this.grbSalida.ResumeLayout(false);
            this.grbSalida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtidsalida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtgran_total;
        private System.Windows.Forms.DataGridView dgvproductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.GroupBox grbbuscar_producto;
        private System.Windows.Forms.TextBox txtcantidadproducto;
        private System.Windows.Forms.TextBox txtid_producto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtprecio_venta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtcve_producto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtidusuario;
        private System.Windows.Forms.GroupBox grbSalida;
        private System.Windows.Forms.TextBox txtactivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblhora_registro;
        private System.Windows.Forms.Label lblfecha_registro;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbfactura;
        private System.Windows.Forms.Label lblid_cliente;
        private System.Windows.Forms.Label lblid_trabajador;
        private System.Windows.Forms.Label lblid_caja;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbcliente;
        private System.Windows.Forms.ComboBox cmbtrabajador;
        private System.Windows.Forms.ComboBox cmbcaja;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtdescripcion;
        private Guna.UI.WinForms.GunaLineTextBox focustotal;
        private Guna.UI.WinForms.GunaLineTextBox focusdes;
        private Guna.UI.WinForms.GunaLineTextBox focusClave;
        private Guna.UI.WinForms.GunaLineTextBox focusCant;
        private Guna.UI.WinForms.GunaLineTextBox focusNom;
        private Guna.UI.WinForms.GunaLineTextBox foucuspre;
        private Guna.UI.WinForms.GunaAdvenceButton btnregistrar_salida;
        private Guna.UI.WinForms.GunaAdvenceButton btncancelar_salida;
        private Guna.UI.WinForms.GunaLineTextBox focusgran;
        private Guna.UI.WinForms.GunaAdvenceButton btnliberar_salida;
        private Guna.UI.WinForms.GunaAdvenceButton btncancelar_producto;
    }
}