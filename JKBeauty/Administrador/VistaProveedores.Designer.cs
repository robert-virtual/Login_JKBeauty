
namespace Administrador
{
    partial class VistaProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaProveedores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mzButtonWindows1 = new BWCMM.MZButtonWindows();
            this.lb_Clientes = new System.Windows.Forms.Label();
            this.datagridview1 = new System.Windows.Forms.DataGridView();
            this.Correo = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.direccion_proveedor = new System.Windows.Forms.TextBox();
            this.nom_proveedor = new System.Windows.Forms.TextBox();
            this.cod_proveedor = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.productos_proveedor = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 542);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 51);
            this.panel2.TabIndex = 60;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.mzButtonWindows1);
            this.panel1.Controls.Add(this.lb_Clientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 51);
            this.panel1.TabIndex = 59;
            // 
            // mzButtonWindows1
            // 
            this.mzButtonWindows1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mzButtonWindows1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mzButtonWindows1.BackgroundImage")));
            this.mzButtonWindows1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mzButtonWindows1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mzButtonWindows1.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows;
            this.mzButtonWindows1.Location = new System.Drawing.Point(1031, 12);
            this.mzButtonWindows1.Name = "mzButtonWindows1";
            this.mzButtonWindows1.ParentControl = this;
            this.mzButtonWindows1.Size = new System.Drawing.Size(40, 24);
            this.mzButtonWindows1.TabIndex = 22;
            this.mzButtonWindows1.TipoButton = BWCMM.MZButtonWindows.ModeButton.Null;
            // 
            // lb_Clientes
            // 
            this.lb_Clientes.AutoSize = true;
            this.lb_Clientes.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Clientes.Location = new System.Drawing.Point(69, 12);
            this.lb_Clientes.Name = "lb_Clientes";
            this.lb_Clientes.Size = new System.Drawing.Size(198, 29);
            this.lb_Clientes.TabIndex = 21;
            this.lb_Clientes.Text = "Lista de Proveedores";
            // 
            // datagridview1
            // 
            this.datagridview1.AllowUserToAddRows = false;
            this.datagridview1.AllowUserToDeleteRows = false;
            this.datagridview1.AllowUserToResizeColumns = false;
            this.datagridview1.AllowUserToResizeRows = false;
            this.datagridview1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datagridview1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Fuchsia;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview1.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridview1.EnableHeadersVisualStyles = false;
            this.datagridview1.Location = new System.Drawing.Point(12, 114);
            this.datagridview1.Name = "datagridview1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Fuchsia;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridview1.Size = new System.Drawing.Size(762, 422);
            this.datagridview1.TabIndex = 61;
            this.datagridview1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview1_CellClick);
            // 
            // Correo
            // 
            this.Correo.BackColor = System.Drawing.SystemColors.Control;
            this.Correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Correo.Location = new System.Drawing.Point(780, 334);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(250, 13);
            this.Correo.TabIndex = 85;
            this.Correo.Text = "Correo";
            this.Correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Telefono
            // 
            this.Telefono.BackColor = System.Drawing.SystemColors.Control;
            this.Telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Telefono.Location = new System.Drawing.Point(780, 290);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(258, 13);
            this.Telefono.TabIndex = 80;
            this.Telefono.Text = "Telefono";
            this.Telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // direccion_proveedor
            // 
            this.direccion_proveedor.BackColor = System.Drawing.SystemColors.Control;
            this.direccion_proveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.direccion_proveedor.Location = new System.Drawing.Point(788, 248);
            this.direccion_proveedor.Name = "direccion_proveedor";
            this.direccion_proveedor.Size = new System.Drawing.Size(250, 13);
            this.direccion_proveedor.TabIndex = 81;
            this.direccion_proveedor.Text = "Direccion";
            this.direccion_proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nom_proveedor
            // 
            this.nom_proveedor.BackColor = System.Drawing.SystemColors.Control;
            this.nom_proveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nom_proveedor.Location = new System.Drawing.Point(784, 204);
            this.nom_proveedor.Name = "nom_proveedor";
            this.nom_proveedor.Size = new System.Drawing.Size(254, 13);
            this.nom_proveedor.TabIndex = 78;
            this.nom_proveedor.Text = "Nombre Proveedor";
            this.nom_proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cod_proveedor
            // 
            this.cod_proveedor.BackColor = System.Drawing.SystemColors.Control;
            this.cod_proveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cod_proveedor.Location = new System.Drawing.Point(784, 160);
            this.cod_proveedor.Name = "cod_proveedor";
            this.cod_proveedor.Size = new System.Drawing.Size(254, 13);
            this.cod_proveedor.TabIndex = 77;
            this.cod_proveedor.Text = "Codigo Proveedor";
            this.cod_proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(780, 353);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(258, 10);
            this.panel8.TabIndex = 89;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(780, 267);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(258, 10);
            this.panel7.TabIndex = 88;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(780, 179);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(258, 10);
            this.panel5.TabIndex = 86;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(780, 223);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(258, 10);
            this.panel6.TabIndex = 87;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(780, 309);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 10);
            this.panel4.TabIndex = 84;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(780, 394);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 13);
            this.panel3.TabIndex = 82;
            // 
            // productos_proveedor
            // 
            this.productos_proveedor.BackColor = System.Drawing.SystemColors.Control;
            this.productos_proveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productos_proveedor.Location = new System.Drawing.Point(788, 375);
            this.productos_proveedor.Name = "productos_proveedor";
            this.productos_proveedor.Size = new System.Drawing.Size(250, 13);
            this.productos_proveedor.TabIndex = 90;
            this.productos_proveedor.Text = "Productos";
            this.productos_proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(930, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 45);
            this.button2.TabIndex = 104;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(780, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 45);
            this.button1.TabIndex = 103;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 32);
            this.button3.TabIndex = 110;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // VistaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 593);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productos_proveedor);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.direccion_proveedor);
            this.Controls.Add(this.nom_proveedor);
            this.Controls.Add(this.cod_proveedor);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.datagridview1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaProveedores";
            this.Text = "VistaProveedores";
            this.Load += new System.EventHandler(this.VistaProveedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private BWCMM.MZButtonWindows mzButtonWindows1;
        private System.Windows.Forms.Label lb_Clientes;
        private System.Windows.Forms.DataGridView datagridview1;
        private System.Windows.Forms.TextBox productos_proveedor;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.TextBox direccion_proveedor;
        private System.Windows.Forms.TextBox nom_proveedor;
        private System.Windows.Forms.TextBox cod_proveedor;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}