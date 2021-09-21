
namespace Factura
{
    partial class Factura
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NombreEmpleado = new System.Windows.Forms.TextBox();
            this.Empleado = new System.Windows.Forms.Label();
            this.mzButtonWindows1 = new BWCMM.MZButtonWindows();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Actualizar = new System.Windows.Forms.Button();
            this.Calcular = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.ProcesarDetalle = new System.Windows.Forms.Button();
            this.GuardarFactura = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Direccion = new System.Windows.Forms.TextBox();
            this.textBox_Telefono = new System.Windows.Forms.TextBox();
            this.textBox_NombreCliente = new System.Windows.Forms.TextBox();
            this.textBox_IDCliente = new System.Windows.Forms.TextBox();
            this.BuscarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.NombreCliente = new System.Windows.Forms.Label();
            this.lb_Clientes = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_IdFactura = new System.Windows.Forms.TextBox();
            this.MetodoPago = new System.Windows.Forms.Label();
            this.ID_Factura = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.descrpProducto = new System.Windows.Forms.TextBox();
            this.NomPRoducto = new System.Windows.Forms.Label();
            this.textBox_Descuento = new System.Windows.Forms.TextBox();
            this.textBox_Precio = new System.Windows.Forms.TextBox();
            this.textBox_Cantidad = new System.Windows.Forms.TextBox();
            this.textBox_NombreProducto = new System.Windows.Forms.TextBox();
            this.textBox_IdProducto = new System.Windows.Forms.TextBox();
            this.Descuento = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.ID_Producto = new System.Windows.Forms.Label();
            this.BuscarProducto = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.Impuesto = new System.Windows.Forms.Label();
            this.TotalFinal = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.DescuentoTotal = new System.Windows.Forms.Label();
            this.MetodoPago2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NombreEmpleado);
            this.panel1.Controls.Add(this.Empleado);
            this.panel1.Controls.Add(this.mzButtonWindows1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 69);
            this.panel1.TabIndex = 0;
            // 
            // NombreEmpleado
            // 
            this.NombreEmpleado.Location = new System.Drawing.Point(82, 36);
            this.NombreEmpleado.Name = "NombreEmpleado";
            this.NombreEmpleado.Size = new System.Drawing.Size(177, 20);
            this.NombreEmpleado.TabIndex = 38;
            // 
            // Empleado
            // 
            this.Empleado.AutoSize = true;
            this.Empleado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empleado.ForeColor = System.Drawing.Color.Black;
            this.Empleado.Location = new System.Drawing.Point(3, 37);
            this.Empleado.Name = "Empleado";
            this.Empleado.Size = new System.Drawing.Size(71, 20);
            this.Empleado.TabIndex = 38;
            this.Empleado.Text = "Empleado";
            // 
            // mzButtonWindows1
            // 
            this.mzButtonWindows1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mzButtonWindows1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mzButtonWindows1.BackgroundImage")));
            this.mzButtonWindows1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mzButtonWindows1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mzButtonWindows1.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows;
            this.mzButtonWindows1.Location = new System.Drawing.Point(1006, 3);
            this.mzButtonWindows1.Name = "mzButtonWindows1";
            this.mzButtonWindows1.ParentControl = this;
            this.mzButtonWindows1.Size = new System.Drawing.Size(40, 24);
            this.mzButtonWindows1.TabIndex = 0;
            this.mzButtonWindows1.TipoButton = BWCMM.MZButtonWindows.ModeButton.Null;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Actualizar);
            this.panel2.Controls.Add(this.Calcular);
            this.panel2.Controls.Add(this.Limpiar);
            this.panel2.Controls.Add(this.ProcesarDetalle);
            this.panel2.Controls.Add(this.GuardarFactura);
            this.panel2.Location = new System.Drawing.Point(887, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 474);
            this.panel2.TabIndex = 1;
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(4, 312);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(176, 50);
            this.Actualizar.TabIndex = 4;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(4, 256);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(176, 50);
            this.Calcular.TabIndex = 3;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(4, 84);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(176, 50);
            this.Limpiar.TabIndex = 2;
            this.Limpiar.Text = "Crear Nueva Factura";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // ProcesarDetalle
            // 
            this.ProcesarDetalle.Location = new System.Drawing.Point(4, 200);
            this.ProcesarDetalle.Name = "ProcesarDetalle";
            this.ProcesarDetalle.Size = new System.Drawing.Size(176, 50);
            this.ProcesarDetalle.TabIndex = 1;
            this.ProcesarDetalle.Text = "Procesar Detalle";
            this.ProcesarDetalle.UseVisualStyleBackColor = true;
            this.ProcesarDetalle.Click += new System.EventHandler(this.ProcesarDetalle_Click);
            // 
            // GuardarFactura
            // 
            this.GuardarFactura.Location = new System.Drawing.Point(4, 140);
            this.GuardarFactura.Name = "GuardarFactura";
            this.GuardarFactura.Size = new System.Drawing.Size(176, 54);
            this.GuardarFactura.TabIndex = 0;
            this.GuardarFactura.Text = "Guardar Factura";
            this.GuardarFactura.UseVisualStyleBackColor = true;
            this.GuardarFactura.Click += new System.EventHandler(this.GuardarFactura_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Direccion);
            this.groupBox1.Controls.Add(this.textBox_Telefono);
            this.groupBox1.Controls.Add(this.textBox_NombreCliente);
            this.groupBox1.Controls.Add(this.textBox_IDCliente);
            this.groupBox1.Controls.Add(this.BuscarCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Telefono);
            this.groupBox1.Controls.Add(this.NombreCliente);
            this.groupBox1.Controls.Add(this.lb_Clientes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 184);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente";
            // 
            // textBox_Direccion
            // 
            this.textBox_Direccion.Location = new System.Drawing.Point(140, 148);
            this.textBox_Direccion.Name = "textBox_Direccion";
            this.textBox_Direccion.Size = new System.Drawing.Size(156, 21);
            this.textBox_Direccion.TabIndex = 35;
            // 
            // textBox_Telefono
            // 
            this.textBox_Telefono.Location = new System.Drawing.Point(140, 108);
            this.textBox_Telefono.Name = "textBox_Telefono";
            this.textBox_Telefono.Size = new System.Drawing.Size(156, 21);
            this.textBox_Telefono.TabIndex = 34;
            // 
            // textBox_NombreCliente
            // 
            this.textBox_NombreCliente.Location = new System.Drawing.Point(140, 73);
            this.textBox_NombreCliente.Name = "textBox_NombreCliente";
            this.textBox_NombreCliente.Size = new System.Drawing.Size(156, 21);
            this.textBox_NombreCliente.TabIndex = 33;
            // 
            // textBox_IDCliente
            // 
            this.textBox_IDCliente.Location = new System.Drawing.Point(140, 36);
            this.textBox_IDCliente.Name = "textBox_IDCliente";
            this.textBox_IDCliente.Size = new System.Drawing.Size(78, 21);
            this.textBox_IDCliente.TabIndex = 32;
            this.textBox_IDCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_IDCliente_KeyPress);
            // 
            // BuscarCliente
            // 
            this.BuscarCliente.Location = new System.Drawing.Point(359, 21);
            this.BuscarCliente.Name = "BuscarCliente";
            this.BuscarCliente.Size = new System.Drawing.Size(74, 25);
            this.BuscarCliente.TabIndex = 4;
            this.BuscarCliente.Text = "Buscar";
            this.BuscarCliente.UseVisualStyleBackColor = true;
            this.BuscarCliente.Click += new System.EventHandler(this.BuscarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Direccion";
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono.ForeColor = System.Drawing.Color.Black;
            this.Telefono.Location = new System.Drawing.Point(8, 110);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(61, 20);
            this.Telefono.TabIndex = 24;
            this.Telefono.Text = "Telefono";
            // 
            // NombreCliente
            // 
            this.NombreCliente.AutoSize = true;
            this.NombreCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCliente.ForeColor = System.Drawing.Color.Black;
            this.NombreCliente.Location = new System.Drawing.Point(8, 75);
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Size = new System.Drawing.Size(57, 20);
            this.NombreCliente.TabIndex = 23;
            this.NombreCliente.Text = "Nombre";
            // 
            // lb_Clientes
            // 
            this.lb_Clientes.AutoSize = true;
            this.lb_Clientes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Clientes.ForeColor = System.Drawing.Color.Black;
            this.lb_Clientes.Location = new System.Drawing.Point(7, 36);
            this.lb_Clientes.Name = "lb_Clientes";
            this.lb_Clientes.Size = new System.Drawing.Size(98, 20);
            this.lb_Clientes.TabIndex = 22;
            this.lb_Clientes.Text = "Codigo Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MetodoPago2);
            this.groupBox2.Controls.Add(this.textBox_IdFactura);
            this.groupBox2.Controls.Add(this.MetodoPago);
            this.groupBox2.Controls.Add(this.ID_Factura);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(444, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 184);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Factura";
            // 
            // textBox_IdFactura
            // 
            this.textBox_IdFactura.Location = new System.Drawing.Point(10, 59);
            this.textBox_IdFactura.Name = "textBox_IdFactura";
            this.textBox_IdFactura.Size = new System.Drawing.Size(156, 21);
            this.textBox_IdFactura.TabIndex = 36;
            this.textBox_IdFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_IdFactura_KeyPress);
            // 
            // MetodoPago
            // 
            this.MetodoPago.AutoSize = true;
            this.MetodoPago.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetodoPago.ForeColor = System.Drawing.Color.Black;
            this.MetodoPago.Location = new System.Drawing.Point(6, 83);
            this.MetodoPago.Name = "MetodoPago";
            this.MetodoPago.Size = new System.Drawing.Size(111, 20);
            this.MetodoPago.TabIndex = 27;
            this.MetodoPago.Text = "Metodo de Pago";
            // 
            // ID_Factura
            // 
            this.ID_Factura.AutoSize = true;
            this.ID_Factura.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Factura.ForeColor = System.Drawing.Color.Black;
            this.ID_Factura.Location = new System.Drawing.Point(6, 25);
            this.ID_Factura.Name = "ID_Factura";
            this.ID_Factura.Size = new System.Drawing.Size(100, 20);
            this.ID_Factura.TabIndex = 26;
            this.ID_Factura.Text = "Codigo Factura";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.descrpProducto);
            this.groupBox3.Controls.Add(this.NomPRoducto);
            this.groupBox3.Controls.Add(this.textBox_Descuento);
            this.groupBox3.Controls.Add(this.textBox_Precio);
            this.groupBox3.Controls.Add(this.textBox_Cantidad);
            this.groupBox3.Controls.Add(this.textBox_NombreProducto);
            this.groupBox3.Controls.Add(this.textBox_IdProducto);
            this.groupBox3.Controls.Add(this.Descuento);
            this.groupBox3.Controls.Add(this.Precio);
            this.groupBox3.Controls.Add(this.Cantidad);
            this.groupBox3.Controls.Add(this.Descripcion);
            this.groupBox3.Controls.Add(this.ID_Producto);
            this.groupBox3.Controls.Add(this.BuscarProducto);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(5, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(882, 94);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Productos";
            // 
            // descrpProducto
            // 
            this.descrpProducto.Location = new System.Drawing.Point(282, 51);
            this.descrpProducto.Name = "descrpProducto";
            this.descrpProducto.Size = new System.Drawing.Size(177, 21);
            this.descrpProducto.TabIndex = 37;
            // 
            // NomPRoducto
            // 
            this.NomPRoducto.AutoSize = true;
            this.NomPRoducto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomPRoducto.ForeColor = System.Drawing.Color.Black;
            this.NomPRoducto.Location = new System.Drawing.Point(131, 25);
            this.NomPRoducto.Name = "NomPRoducto";
            this.NomPRoducto.Size = new System.Drawing.Size(63, 20);
            this.NomPRoducto.TabIndex = 36;
            this.NomPRoducto.Text = "Producto";
            // 
            // textBox_Descuento
            // 
            this.textBox_Descuento.Location = new System.Drawing.Point(700, 51);
            this.textBox_Descuento.Name = "textBox_Descuento";
            this.textBox_Descuento.Size = new System.Drawing.Size(78, 21);
            this.textBox_Descuento.TabIndex = 35;
            this.textBox_Descuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Descuento_KeyPress);
            // 
            // textBox_Precio
            // 
            this.textBox_Precio.Location = new System.Drawing.Point(600, 51);
            this.textBox_Precio.Name = "textBox_Precio";
            this.textBox_Precio.Size = new System.Drawing.Size(78, 21);
            this.textBox_Precio.TabIndex = 34;
            this.textBox_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Precio_KeyPress);
            // 
            // textBox_Cantidad
            // 
            this.textBox_Cantidad.Location = new System.Drawing.Point(491, 51);
            this.textBox_Cantidad.Name = "textBox_Cantidad";
            this.textBox_Cantidad.Size = new System.Drawing.Size(78, 21);
            this.textBox_Cantidad.TabIndex = 33;
            this.textBox_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Cantidad_KeyPress);
            // 
            // textBox_NombreProducto
            // 
            this.textBox_NombreProducto.Location = new System.Drawing.Point(128, 51);
            this.textBox_NombreProducto.Name = "textBox_NombreProducto";
            this.textBox_NombreProducto.Size = new System.Drawing.Size(127, 21);
            this.textBox_NombreProducto.TabIndex = 32;
            // 
            // textBox_IdProducto
            // 
            this.textBox_IdProducto.Location = new System.Drawing.Point(28, 51);
            this.textBox_IdProducto.Name = "textBox_IdProducto";
            this.textBox_IdProducto.Size = new System.Drawing.Size(78, 21);
            this.textBox_IdProducto.TabIndex = 31;
            this.textBox_IdProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_IdProducto_KeyPress);
            // 
            // Descuento
            // 
            this.Descuento.AutoSize = true;
            this.Descuento.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descuento.ForeColor = System.Drawing.Color.Black;
            this.Descuento.Location = new System.Drawing.Point(696, 28);
            this.Descuento.Name = "Descuento";
            this.Descuento.Size = new System.Drawing.Size(73, 20);
            this.Descuento.TabIndex = 30;
            this.Descuento.Text = "Descuento";
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio.ForeColor = System.Drawing.Color.Black;
            this.Precio.Location = new System.Drawing.Point(596, 28);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(48, 20);
            this.Precio.TabIndex = 29;
            this.Precio.Text = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad.ForeColor = System.Drawing.Color.Black;
            this.Cantidad.Location = new System.Drawing.Point(487, 28);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(61, 20);
            this.Cantidad.TabIndex = 28;
            this.Cantidad.Text = "Cantidad";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.ForeColor = System.Drawing.Color.Black;
            this.Descripcion.Location = new System.Drawing.Point(287, 25);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(80, 20);
            this.Descripcion.TabIndex = 27;
            this.Descripcion.Text = "Descripcion";
            // 
            // ID_Producto
            // 
            this.ID_Producto.AutoSize = true;
            this.ID_Producto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Producto.ForeColor = System.Drawing.Color.Black;
            this.ID_Producto.Location = new System.Drawing.Point(24, 27);
            this.ID_Producto.Name = "ID_Producto";
            this.ID_Producto.Size = new System.Drawing.Size(21, 20);
            this.ID_Producto.TabIndex = 26;
            this.ID_Producto.Text = "ID";
            // 
            // BuscarProducto
            // 
            this.BuscarProducto.Location = new System.Drawing.Point(803, 11);
            this.BuscarProducto.Name = "BuscarProducto";
            this.BuscarProducto.Size = new System.Drawing.Size(74, 25);
            this.BuscarProducto.TabIndex = 26;
            this.BuscarProducto.Text = "Buscar";
            this.BuscarProducto.UseVisualStyleBackColor = true;
            this.BuscarProducto.Click += new System.EventHandler(this.BuscarProducto_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(0, 364);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(438, 184);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscar  Cliente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(426, 106);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(444, 364);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(438, 184);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Buscar Producto";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 72);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(426, 106);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView3);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(0, 554);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(882, 184);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Detalle";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IDFactura,
            this.Cliente,
            this.NombreProducto,
            this.DescripcionProducto,
            this.CantidadProducto,
            this.PrecioVenta,
            this.Total});
            this.dataGridView3.Location = new System.Drawing.Point(13, 20);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(863, 106);
            this.dataGridView3.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // IDFactura
            // 
            this.IDFactura.HeaderText = "NO# Factura";
            this.IDFactura.Name = "IDFactura";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Nombre Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Producto";
            this.NombreProducto.Name = "NombreProducto";
            // 
            // DescripcionProducto
            // 
            this.DescripcionProducto.HeaderText = "Descripcion";
            this.DescripcionProducto.Name = "DescripcionProducto";
            // 
            // CantidadProducto
            // 
            this.CantidadProducto.HeaderText = "Cantidad";
            this.CantidadProducto.Name = "CantidadProducto";
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio";
            this.PrecioVenta.Name = "PrecioVenta";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtFactura);
            this.groupBox7.Controls.Add(this.txtImpuesto);
            this.groupBox7.Controls.Add(this.Impuesto);
            this.groupBox7.Controls.Add(this.TotalFinal);
            this.groupBox7.Controls.Add(this.txtSubTotal);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.txtDescuento);
            this.groupBox7.Controls.Add(this.DescuentoTotal);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.Black;
            this.groupBox7.Location = new System.Drawing.Point(889, 554);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(185, 184);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Totales";
            // 
            // txtFactura
            // 
            this.txtFactura.BackColor = System.Drawing.SystemColors.Control;
            this.txtFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFactura.Enabled = false;
            this.txtFactura.Location = new System.Drawing.Point(101, 124);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(78, 14);
            this.txtFactura.TabIndex = 42;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.BackColor = System.Drawing.SystemColors.Control;
            this.txtImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImpuesto.Enabled = false;
            this.txtImpuesto.Location = new System.Drawing.Point(101, 23);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(78, 14);
            this.txtImpuesto.TabIndex = 41;
            // 
            // Impuesto
            // 
            this.Impuesto.AutoSize = true;
            this.Impuesto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Impuesto.ForeColor = System.Drawing.Color.Black;
            this.Impuesto.Location = new System.Drawing.Point(6, 20);
            this.Impuesto.Name = "Impuesto";
            this.Impuesto.Size = new System.Drawing.Size(64, 20);
            this.Impuesto.TabIndex = 40;
            this.Impuesto.Text = "Impuesto";
            // 
            // TotalFinal
            // 
            this.TotalFinal.AutoSize = true;
            this.TotalFinal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFinal.ForeColor = System.Drawing.Color.Black;
            this.TotalFinal.Location = new System.Drawing.Point(6, 118);
            this.TotalFinal.Name = "TotalFinal";
            this.TotalFinal.Size = new System.Drawing.Size(37, 20);
            this.TotalFinal.TabIndex = 39;
            this.TotalFinal.Text = "Total";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(95, 91);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(78, 14);
            this.txtSubTotal.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "SubTotal";
            // 
            // txtDescuento
            // 
            this.txtDescuento.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Location = new System.Drawing.Point(95, 57);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(78, 14);
            this.txtDescuento.TabIndex = 36;
            // 
            // DescuentoTotal
            // 
            this.DescuentoTotal.AutoSize = true;
            this.DescuentoTotal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescuentoTotal.ForeColor = System.Drawing.Color.Black;
            this.DescuentoTotal.Location = new System.Drawing.Point(6, 54);
            this.DescuentoTotal.Name = "DescuentoTotal";
            this.DescuentoTotal.Size = new System.Drawing.Size(73, 20);
            this.DescuentoTotal.TabIndex = 31;
            this.DescuentoTotal.Text = "Descuento";
            // 
            // MetodoPago2
            // 
            this.MetodoPago2.Location = new System.Drawing.Point(10, 113);
            this.MetodoPago2.Name = "MetodoPago2";
            this.MetodoPago2.Size = new System.Drawing.Size(156, 21);
            this.MetodoPago2.TabIndex = 37;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1074, 766);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Factura_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BuscarProducto;
        private BWCMM.MZButtonWindows mzButtonWindows1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button Calcular;
        public System.Windows.Forms.Button Limpiar;
        public System.Windows.Forms.Button ProcesarDetalle;
        public System.Windows.Forms.Button GuardarFactura;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.GroupBox groupBox7;
        public System.Windows.Forms.Button BuscarCliente;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label Telefono;
        public System.Windows.Forms.Label NombreCliente;
        public System.Windows.Forms.Label lb_Clientes;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.Label ID_Factura;
        public System.Windows.Forms.DataGridView dataGridView3;
        public System.Windows.Forms.Label MetodoPago;
        public System.Windows.Forms.TextBox textBox_Descuento;
        public System.Windows.Forms.TextBox textBox_Precio;
        public System.Windows.Forms.TextBox textBox_Cantidad;
        public System.Windows.Forms.TextBox textBox_NombreProducto;
        public System.Windows.Forms.TextBox textBox_IdProducto;
        public System.Windows.Forms.Label Descuento;
        public System.Windows.Forms.Label Precio;
        public System.Windows.Forms.Label Cantidad;
        public System.Windows.Forms.Label Descripcion;
        public System.Windows.Forms.Label ID_Producto;
        public System.Windows.Forms.TextBox textBox_IdFactura;
        public System.Windows.Forms.TextBox textBox_Direccion;
        public System.Windows.Forms.TextBox textBox_Telefono;
        public System.Windows.Forms.TextBox textBox_NombreCliente;
        public System.Windows.Forms.TextBox textBox_IDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        public System.Windows.Forms.TextBox txtDescuento;
        public System.Windows.Forms.Label DescuentoTotal;
        public System.Windows.Forms.TextBox txtSubTotal;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label TotalFinal;
        public System.Windows.Forms.TextBox txtImpuesto;
        public System.Windows.Forms.Label Impuesto;
        public System.Windows.Forms.TextBox txtFactura;
        public System.Windows.Forms.TextBox descrpProducto;
        public System.Windows.Forms.Label NomPRoducto;
        public System.Windows.Forms.TextBox NombreEmpleado;
        public System.Windows.Forms.Label Empleado;
        public System.Windows.Forms.Button Actualizar;
        public System.Windows.Forms.TextBox MetodoPago2;
    }
}

