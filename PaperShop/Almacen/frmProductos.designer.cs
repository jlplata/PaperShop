namespace PaperShop
{
    partial class frmProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmproductos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desactivarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblid_proveedor = new System.Windows.Forms.Label();
            this.lblid_categoria = new System.Windows.Forms.Label();
            this.cmbproveedor = new System.Windows.Forms.ComboBox();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            this.txtprecio_venta = new System.Windows.Forms.TextBox();
            this.txtprecio_compra = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtcve_producto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpathfile = new System.Windows.Forms.TextBox();
            this.lblimg = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblhoraregistro = new System.Windows.Forms.Label();
            this.lblfecharegistro = new System.Windows.Forms.Label();
            this.grbusuarios = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnagregar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.imgpro = new System.Windows.Forms.PictureBox();
            this.txtIdUsuario = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtActivo = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBox1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.focusNomb = new Guna.UI.WinForms.GunaLineTextBox();
            this.focusDes = new Guna.UI.WinForms.GunaLineTextBox();
            this.focusCveProd = new Guna.UI.WinForms.GunaLineTextBox();
            this.focusCantidad = new Guna.UI.WinForms.GunaLineTextBox();
            this.focusComp = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.btnCancelar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnModificar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnGuardar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnNuevo = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblActi = new System.Windows.Forms.Label();
            this.Activos = new Guna.UI.WinForms.GunaWinSwitch();
            this.btnImprimir = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.focusBuscar = new Guna.UI.WinForms.GunaLineTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.cmproductos.SuspendLayout();
            this.grbusuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgpro)).BeginInit();
            this.gunaPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmproductos
            // 
            this.cmproductos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.desactivarToolStripMenuItem,
            this.activarToolStripMenuItem});
            this.cmproductos.Name = "cmproductos";
            this.cmproductos.Size = new System.Drawing.Size(129, 70);
            this.cmproductos.Opening += new System.ComponentModel.CancelEventHandler(this.Cmproductos_Opening);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.ModificarToolStripMenuItem_Click);
            // 
            // desactivarToolStripMenuItem
            // 
            this.desactivarToolStripMenuItem.Name = "desactivarToolStripMenuItem";
            this.desactivarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.desactivarToolStripMenuItem.Text = "Desactivar";
            this.desactivarToolStripMenuItem.Click += new System.EventHandler(this.DesactivarToolStripMenuItem_Click);
            // 
            // activarToolStripMenuItem
            // 
            this.activarToolStripMenuItem.Name = "activarToolStripMenuItem";
            this.activarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.activarToolStripMenuItem.Text = "Activar";
            this.activarToolStripMenuItem.Click += new System.EventHandler(this.ActivarToolStripMenuItem_Click);
            // 
            // lblid_proveedor
            // 
            this.lblid_proveedor.AutoSize = true;
            this.lblid_proveedor.Location = new System.Drawing.Point(303, 351);
            this.lblid_proveedor.Name = "lblid_proveedor";
            this.lblid_proveedor.Size = new System.Drawing.Size(25, 21);
            this.lblid_proveedor.TabIndex = 63;
            this.lblid_proveedor.Text = "ID";
            this.lblid_proveedor.Visible = false;
            // 
            // lblid_categoria
            // 
            this.lblid_categoria.AutoSize = true;
            this.lblid_categoria.Location = new System.Drawing.Point(303, 249);
            this.lblid_categoria.Name = "lblid_categoria";
            this.lblid_categoria.Size = new System.Drawing.Size(25, 21);
            this.lblid_categoria.TabIndex = 62;
            this.lblid_categoria.Text = "ID";
            this.lblid_categoria.Visible = false;
            // 
            // cmbproveedor
            // 
            this.cmbproveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cmbproveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbproveedor.ForeColor = System.Drawing.Color.White;
            this.cmbproveedor.FormattingEnabled = true;
            this.cmbproveedor.Location = new System.Drawing.Point(122, 348);
            this.cmbproveedor.Name = "cmbproveedor";
            this.cmbproveedor.Size = new System.Drawing.Size(176, 29);
            this.cmbproveedor.TabIndex = 61;
            this.cmbproveedor.SelectedIndexChanged += new System.EventHandler(this.Cmbproveedor_SelectedIndexChanged);
            this.cmbproveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmbproveedor_KeyDown);
            this.cmbproveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmbproveedor_KeyPress);
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cmbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcategoria.ForeColor = System.Drawing.Color.White;
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.Location = new System.Drawing.Point(122, 246);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(175, 29);
            this.cmbcategoria.TabIndex = 60;
            this.cmbcategoria.SelectedIndexChanged += new System.EventHandler(this.Cmbcategoria_SelectedIndexChanged);
            this.cmbcategoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmbcategoria_KeyDown);
            this.cmbcategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmbcategoria_KeyPress);
            // 
            // txtprecio_venta
            // 
            this.txtprecio_venta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtprecio_venta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtprecio_venta.ForeColor = System.Drawing.Color.White;
            this.txtprecio_venta.Location = new System.Drawing.Point(122, 313);
            this.txtprecio_venta.Name = "txtprecio_venta";
            this.txtprecio_venta.Size = new System.Drawing.Size(175, 22);
            this.txtprecio_venta.TabIndex = 59;
            this.txtprecio_venta.Enter += new System.EventHandler(this.txtprecio_venta_Enter);
            this.txtprecio_venta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtprecio_venta_KeyDown);
            this.txtprecio_venta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtprecio_venta_KeyPress);
            this.txtprecio_venta.Leave += new System.EventHandler(this.txtprecio_venta_Leave);
            // 
            // txtprecio_compra
            // 
            this.txtprecio_compra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtprecio_compra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtprecio_compra.ForeColor = System.Drawing.Color.White;
            this.txtprecio_compra.Location = new System.Drawing.Point(122, 282);
            this.txtprecio_compra.Name = "txtprecio_compra";
            this.txtprecio_compra.Size = new System.Drawing.Size(175, 22);
            this.txtprecio_compra.TabIndex = 58;
            this.txtprecio_compra.Enter += new System.EventHandler(this.txtprecio_compra_Enter);
            this.txtprecio_compra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtprecio_compra_KeyDown);
            this.txtprecio_compra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtprecio_compra_KeyPress);
            this.txtprecio_compra.Leave += new System.EventHandler(this.txtprecio_compra_Leave);
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.ForeColor = System.Drawing.Color.White;
            this.txtnombre.Location = new System.Drawing.Point(122, 214);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(175, 22);
            this.txtnombre.TabIndex = 57;
            this.txtnombre.Enter += new System.EventHandler(this.txtnombre_Enter);
            this.txtnombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtnombre_KeyDown);
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnombre_KeyPress);
            this.txtnombre.Leave += new System.EventHandler(this.txtnombre_Leave);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdescripcion.ForeColor = System.Drawing.Color.White;
            this.txtdescripcion.Location = new System.Drawing.Point(122, 183);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(175, 22);
            this.txtdescripcion.TabIndex = 56;
            this.txtdescripcion.Enter += new System.EventHandler(this.txtdescripcion_Enter);
            this.txtdescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtdescripcion_KeyDown);
            this.txtdescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtdescripcion_KeyPress);
            this.txtdescripcion.Leave += new System.EventHandler(this.txtdescripcion_Leave);
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcantidad.ForeColor = System.Drawing.Color.White;
            this.txtcantidad.Location = new System.Drawing.Point(122, 154);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(175, 22);
            this.txtcantidad.TabIndex = 55;
            this.txtcantidad.Enter += new System.EventHandler(this.txtcantidad_Enter);
            this.txtcantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtcantidad_KeyDown);
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcantidad_KeyPress);
            this.txtcantidad.Leave += new System.EventHandler(this.txtcantidad_Leave);
            // 
            // txtcve_producto
            // 
            this.txtcve_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtcve_producto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcve_producto.ForeColor = System.Drawing.Color.White;
            this.txtcve_producto.Location = new System.Drawing.Point(122, 120);
            this.txtcve_producto.Name = "txtcve_producto";
            this.txtcve_producto.Size = new System.Drawing.Size(175, 22);
            this.txtcve_producto.TabIndex = 54;
            this.txtcve_producto.Enter += new System.EventHandler(this.txtcve_producto_Enter);
            this.txtcve_producto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtcve_producto_KeyDown);
            this.txtcve_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcve_producto_KeyPress);
            this.txtcve_producto.Leave += new System.EventHandler(this.txtcve_producto_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 21);
            this.label9.TabIndex = 53;
            this.label9.Text = "Proveedor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 21);
            this.label8.TabIndex = 52;
            this.label8.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 51;
            this.label7.Text = "Descripcion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 21);
            this.label6.TabIndex = 50;
            this.label6.Text = "Precio Venta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 49;
            this.label4.Text = "Precio Compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 47;
            this.label2.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "Cve. Producto:";
            // 
            // txtpathfile
            // 
            this.txtpathfile.Location = new System.Drawing.Point(56, 62);
            this.txtpathfile.Name = "txtpathfile";
            this.txtpathfile.Size = new System.Drawing.Size(100, 29);
            this.txtpathfile.TabIndex = 45;
            this.txtpathfile.Visible = false;
            // 
            // lblimg
            // 
            this.lblimg.AutoSize = true;
            this.lblimg.Location = new System.Drawing.Point(148, 22);
            this.lblimg.Name = "lblimg";
            this.lblimg.Size = new System.Drawing.Size(0, 21);
            this.lblimg.TabIndex = 44;
            this.lblimg.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 417);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 21);
            this.label12.TabIndex = 30;
            this.label12.Text = "Id Usuario:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 21);
            this.label11.TabIndex = 29;
            this.label11.Text = "Activo:";
            // 
            // lblhoraregistro
            // 
            this.lblhoraregistro.AutoSize = true;
            this.lblhoraregistro.Location = new System.Drawing.Point(242, 33);
            this.lblhoraregistro.Name = "lblhoraregistro";
            this.lblhoraregistro.Size = new System.Drawing.Size(104, 21);
            this.lblhoraregistro.TabIndex = 28;
            this.lblhoraregistro.Text = "Hora_Registro";
            // 
            // lblfecharegistro
            // 
            this.lblfecharegistro.AutoSize = true;
            this.lblfecharegistro.Location = new System.Drawing.Point(242, 10);
            this.lblfecharegistro.Name = "lblfecharegistro";
            this.lblfecharegistro.Size = new System.Drawing.Size(110, 21);
            this.lblfecharegistro.TabIndex = 27;
            this.lblfecharegistro.Text = "Fecha_Registro";
            // 
            // grbusuarios
            // 
            this.grbusuarios.Controls.Add(this.label5);
            this.grbusuarios.Controls.Add(this.btnagregar);
            this.grbusuarios.Controls.Add(this.imgpro);
            this.grbusuarios.Controls.Add(this.txtIdUsuario);
            this.grbusuarios.Controls.Add(this.txtActivo);
            this.grbusuarios.Controls.Add(this.txtprecio_venta);
            this.grbusuarios.Controls.Add(this.gunaLineTextBox1);
            this.grbusuarios.Controls.Add(this.txtnombre);
            this.grbusuarios.Controls.Add(this.focusNomb);
            this.grbusuarios.Controls.Add(this.txtdescripcion);
            this.grbusuarios.Controls.Add(this.focusDes);
            this.grbusuarios.Controls.Add(this.txtcve_producto);
            this.grbusuarios.Controls.Add(this.focusCveProd);
            this.grbusuarios.Controls.Add(this.lblimg);
            this.grbusuarios.Controls.Add(this.lblid_proveedor);
            this.grbusuarios.Controls.Add(this.label1);
            this.grbusuarios.Controls.Add(this.lblid_categoria);
            this.grbusuarios.Controls.Add(this.lblfecharegistro);
            this.grbusuarios.Controls.Add(this.cmbproveedor);
            this.grbusuarios.Controls.Add(this.lblhoraregistro);
            this.grbusuarios.Controls.Add(this.cmbcategoria);
            this.grbusuarios.Controls.Add(this.label11);
            this.grbusuarios.Controls.Add(this.label12);
            this.grbusuarios.Controls.Add(this.txtprecio_compra);
            this.grbusuarios.Controls.Add(this.txtcantidad);
            this.grbusuarios.Controls.Add(this.label9);
            this.grbusuarios.Controls.Add(this.txtpathfile);
            this.grbusuarios.Controls.Add(this.label8);
            this.grbusuarios.Controls.Add(this.label2);
            this.grbusuarios.Controls.Add(this.label7);
            this.grbusuarios.Controls.Add(this.label3);
            this.grbusuarios.Controls.Add(this.label6);
            this.grbusuarios.Controls.Add(this.label4);
            this.grbusuarios.Controls.Add(this.focusCantidad);
            this.grbusuarios.Controls.Add(this.focusComp);
            this.grbusuarios.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbusuarios.ForeColor = System.Drawing.Color.White;
            this.grbusuarios.Location = new System.Drawing.Point(16, 12);
            this.grbusuarios.Name = "grbusuarios";
            this.grbusuarios.Size = new System.Drawing.Size(364, 456);
            this.grbusuarios.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 32);
            this.label5.TabIndex = 90;
            this.label5.Text = "Productos";
            // 
            // btnagregar
            // 
            this.btnagregar.AnimationHoverSpeed = 0.07F;
            this.btnagregar.AnimationSpeed = 0.03F;
            this.btnagregar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnagregar.BorderColor = System.Drawing.Color.Black;
            this.btnagregar.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnagregar.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnagregar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnagregar.CheckedForeColor = System.Drawing.Color.White;
            this.btnagregar.CheckedImage = null;
            this.btnagregar.CheckedLineColor = System.Drawing.Color.DodgerBlue;
            this.btnagregar.FocusedColor = System.Drawing.Color.Empty;
            this.btnagregar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Image = null;
            this.btnagregar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnagregar.LineBottom = 5;
            this.btnagregar.LineColor = System.Drawing.Color.Transparent;
            this.btnagregar.Location = new System.Drawing.Point(197, 84);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnagregar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnagregar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnagregar.OnHoverImage = null;
            this.btnagregar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnagregar.OnPressedColor = System.Drawing.Color.Black;
            this.btnagregar.Size = new System.Drawing.Size(100, 30);
            this.btnagregar.TabIndex = 89;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // imgpro
            // 
            this.imgpro.BackColor = System.Drawing.Color.Transparent;
            this.imgpro.Image = global::PaperShop.Properties.Resources.prod;
            this.imgpro.Location = new System.Drawing.Point(122, 33);
            this.imgpro.Name = "imgpro";
            this.imgpro.Size = new System.Drawing.Size(70, 81);
            this.imgpro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgpro.TabIndex = 39;
            this.imgpro.TabStop = false;
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
            this.txtIdUsuario.Location = new System.Drawing.Point(121, 417);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.PasswordChar = '\0';
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(176, 26);
            this.txtIdUsuario.TabIndex = 88;
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
            this.txtActivo.Location = new System.Drawing.Point(121, 383);
            this.txtActivo.Name = "txtActivo";
            this.txtActivo.PasswordChar = '\0';
            this.txtActivo.ReadOnly = true;
            this.txtActivo.Size = new System.Drawing.Size(176, 26);
            this.txtActivo.TabIndex = 87;
            // 
            // gunaLineTextBox1
            // 
            this.gunaLineTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.gunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox1.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.gunaLineTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox1.ForeColor = System.Drawing.Color.White;
            this.gunaLineTextBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLineTextBox1.LineSize = 2;
            this.gunaLineTextBox1.Location = new System.Drawing.Point(122, 313);
            this.gunaLineTextBox1.Name = "gunaLineTextBox1";
            this.gunaLineTextBox1.PasswordChar = '\0';
            this.gunaLineTextBox1.ReadOnly = true;
            this.gunaLineTextBox1.Size = new System.Drawing.Size(175, 26);
            this.gunaLineTextBox1.TabIndex = 86;
            this.gunaLineTextBox1.Enter += new System.EventHandler(this.gunaLineTextBox1_Enter);
            // 
            // focusNomb
            // 
            this.focusNomb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focusNomb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focusNomb.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focusNomb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.focusNomb.ForeColor = System.Drawing.Color.White;
            this.focusNomb.LineColor = System.Drawing.Color.Gainsboro;
            this.focusNomb.LineSize = 2;
            this.focusNomb.Location = new System.Drawing.Point(122, 214);
            this.focusNomb.Name = "focusNomb";
            this.focusNomb.PasswordChar = '\0';
            this.focusNomb.ReadOnly = true;
            this.focusNomb.Size = new System.Drawing.Size(175, 26);
            this.focusNomb.TabIndex = 84;
            this.focusNomb.Enter += new System.EventHandler(this.focusNomb_Enter);
            // 
            // focusDes
            // 
            this.focusDes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focusDes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focusDes.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focusDes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.focusDes.ForeColor = System.Drawing.Color.White;
            this.focusDes.LineColor = System.Drawing.Color.Gainsboro;
            this.focusDes.LineSize = 2;
            this.focusDes.Location = new System.Drawing.Point(122, 182);
            this.focusDes.Name = "focusDes";
            this.focusDes.PasswordChar = '\0';
            this.focusDes.ReadOnly = true;
            this.focusDes.Size = new System.Drawing.Size(175, 26);
            this.focusDes.TabIndex = 83;
            this.focusDes.Enter += new System.EventHandler(this.focusDes_Enter);
            // 
            // focusCveProd
            // 
            this.focusCveProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focusCveProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focusCveProd.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focusCveProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.focusCveProd.ForeColor = System.Drawing.Color.White;
            this.focusCveProd.LineColor = System.Drawing.Color.Gainsboro;
            this.focusCveProd.LineSize = 2;
            this.focusCveProd.Location = new System.Drawing.Point(122, 120);
            this.focusCveProd.Name = "focusCveProd";
            this.focusCveProd.PasswordChar = '\0';
            this.focusCveProd.ReadOnly = true;
            this.focusCveProd.Size = new System.Drawing.Size(175, 26);
            this.focusCveProd.TabIndex = 81;
            this.focusCveProd.Enter += new System.EventHandler(this.focusCveProd_Enter);
            // 
            // focusCantidad
            // 
            this.focusCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focusCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focusCantidad.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focusCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.focusCantidad.ForeColor = System.Drawing.Color.White;
            this.focusCantidad.LineColor = System.Drawing.Color.Gainsboro;
            this.focusCantidad.LineSize = 2;
            this.focusCantidad.Location = new System.Drawing.Point(122, 152);
            this.focusCantidad.Name = "focusCantidad";
            this.focusCantidad.PasswordChar = '\0';
            this.focusCantidad.ReadOnly = true;
            this.focusCantidad.Size = new System.Drawing.Size(175, 26);
            this.focusCantidad.TabIndex = 82;
            this.focusCantidad.Enter += new System.EventHandler(this.focusCantidad_Enter);
            // 
            // focusComp
            // 
            this.focusComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.focusComp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.focusComp.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.focusComp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.focusComp.ForeColor = System.Drawing.Color.White;
            this.focusComp.LineColor = System.Drawing.Color.Gainsboro;
            this.focusComp.LineSize = 2;
            this.focusComp.Location = new System.Drawing.Point(122, 281);
            this.focusComp.Name = "focusComp";
            this.focusComp.PasswordChar = '\0';
            this.focusComp.ReadOnly = true;
            this.focusComp.Size = new System.Drawing.Size(175, 26);
            this.focusComp.TabIndex = 85;
            this.focusComp.Enter += new System.EventHandler(this.focusComp_Enter);
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaPanel4.Controls.Add(this.btnCancelar);
            this.gunaPanel4.Controls.Add(this.btnModificar);
            this.gunaPanel4.Controls.Add(this.btnGuardar);
            this.gunaPanel4.Controls.Add(this.btnNuevo);
            this.gunaPanel4.Location = new System.Drawing.Point(12, 486);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(395, 40);
            this.gunaPanel4.TabIndex = 84;
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
            this.btnCancelar.Location = new System.Drawing.Point(292, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnCancelar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancelar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnCancelar.OnHoverImage = null;
            this.btnCancelar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnCancelar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancelar.Size = new System.Drawing.Size(101, 40);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancelar.Click += new System.EventHandler(this.Btncancelar_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(191, 0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnModificar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModificar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnModificar.OnHoverImage = null;
            this.btnModificar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnModificar.OnPressedColor = System.Drawing.Color.Black;
            this.btnModificar.Size = new System.Drawing.Size(101, 40);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModificar.Click += new System.EventHandler(this.Btnmodificar_Click);
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
            this.btnGuardar.Location = new System.Drawing.Point(90, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnGuardar.OnHoverImage = null;
            this.btnGuardar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardar.Size = new System.Drawing.Size(101, 40);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGuardar.Click += new System.EventHandler(this.Btnguardar_Click);
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
            this.btnNuevo.Size = new System.Drawing.Size(90, 40);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNuevo.Click += new System.EventHandler(this.Btnnuevo_Click);
            // 
            // lblActi
            // 
            this.lblActi.AutoSize = true;
            this.lblActi.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActi.ForeColor = System.Drawing.Color.White;
            this.lblActi.Location = new System.Drawing.Point(809, 43);
            this.lblActi.Name = "lblActi";
            this.lblActi.Size = new System.Drawing.Size(57, 21);
            this.lblActi.TabIndex = 69;
            this.lblActi.Text = "Activos";
            // 
            // Activos
            // 
            this.Activos.BaseColor = System.Drawing.SystemColors.Control;
            this.Activos.Checked = true;
            this.Activos.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.Activos.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Activos.FillColor = System.Drawing.Color.White;
            this.Activos.Location = new System.Drawing.Point(763, 43);
            this.Activos.Name = "Activos";
            this.Activos.Size = new System.Drawing.Size(40, 22);
            this.Activos.TabIndex = 68;
            this.Activos.CheckedChanged += new System.EventHandler(this.Activos_CheckedChanged);
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
            this.btnImprimir.Location = new System.Drawing.Point(642, 34);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnImprimir.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnImprimir.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.btnImprimir.OnHoverImage = null;
            this.btnImprimir.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.btnImprimir.OnPressedColor = System.Drawing.Color.Black;
            this.btnImprimir.Size = new System.Drawing.Size(100, 30);
            this.btnImprimir.TabIndex = 64;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnImprimir.Click += new System.EventHandler(this.Btnimprimir_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(477, 43);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(158, 22);
            this.txtBuscar.TabIndex = 67;
            this.txtBuscar.TextChanged += new System.EventHandler(this.Txtbuscar_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcve_producto_KeyPress);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
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
            this.focusBuscar.Location = new System.Drawing.Point(476, 41);
            this.focusBuscar.Name = "focusBuscar";
            this.focusBuscar.PasswordChar = '\0';
            this.focusBuscar.Size = new System.Drawing.Size(160, 26);
            this.focusBuscar.TabIndex = 66;
            this.focusBuscar.Enter += new System.EventHandler(this.focusBuscar_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(422, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 21);
            this.label13.TabIndex = 65;
            this.label13.Text = "Buscar:";
            // 
            // dgvproductos
            // 
            this.dgvproductos.AllowUserToAddRows = false;
            this.dgvproductos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvproductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvproductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvproductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.dgvproductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvproductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.ContextMenuStrip = this.cmproductos;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvproductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvproductos.EnableHeadersVisualStyles = false;
            this.dgvproductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.dgvproductos.Location = new System.Drawing.Point(364, 96);
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvproductos.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvproductos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvproductos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.dgvproductos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvproductos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvproductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.dgvproductos.RowTemplate.ReadOnly = true;
            this.dgvproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproductos.Size = new System.Drawing.Size(516, 372);
            this.dgvproductos.TabIndex = 87;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(892, 545);
            this.Controls.Add(this.dgvproductos);
            this.Controls.Add(this.lblActi);
            this.Controls.Add(this.gunaPanel4);
            this.Controls.Add(this.Activos);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.focusBuscar);
            this.Controls.Add(this.grbusuarios);
            this.Controls.Add(this.label13);
            this.Name = "frmProductos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.cmproductos.ResumeLayout(false);
            this.grbusuarios.ResumeLayout(false);
            this.grbusuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgpro)).EndInit();
            this.gunaPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblid_proveedor;
        private System.Windows.Forms.Label lblid_categoria;
        private System.Windows.Forms.ComboBox cmbproveedor;
        private System.Windows.Forms.ComboBox cmbcategoria;
        private System.Windows.Forms.TextBox txtprecio_venta;
        private System.Windows.Forms.TextBox txtprecio_compra;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtcve_producto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpathfile;
        private System.Windows.Forms.Label lblimg;
        private System.Windows.Forms.PictureBox imgpro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblhoraregistro;
        private System.Windows.Forms.Label lblfecharegistro;
        private System.Windows.Forms.ContextMenuStrip cmproductos;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desactivarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activarToolStripMenuItem;
        private System.Windows.Forms.Panel grbusuarios;
        private Guna.UI.WinForms.GunaLineTextBox focusCveProd;
        private Guna.UI.WinForms.GunaLineTextBox focusCantidad;
        private Guna.UI.WinForms.GunaLineTextBox focusDes;
        private Guna.UI.WinForms.GunaLineTextBox focusNomb;
        private Guna.UI.WinForms.GunaLineTextBox focusComp;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox1;
        private Guna.UI.WinForms.GunaLineTextBox txtIdUsuario;
        private Guna.UI.WinForms.GunaLineTextBox txtActivo;
        private Guna.UI.WinForms.GunaAdvenceButton btnagregar;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaAdvenceButton btnCancelar;
        private Guna.UI.WinForms.GunaAdvenceButton btnModificar;
        private Guna.UI.WinForms.GunaAdvenceButton btnGuardar;
        private Guna.UI.WinForms.GunaAdvenceButton btnNuevo;
        private System.Windows.Forms.Label lblActi;
        private Guna.UI.WinForms.GunaWinSwitch Activos;
        private Guna.UI.WinForms.GunaAdvenceButton btnImprimir;
        private System.Windows.Forms.TextBox txtBuscar;
        private Guna.UI.WinForms.GunaLineTextBox focusBuscar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvproductos;
    }
}