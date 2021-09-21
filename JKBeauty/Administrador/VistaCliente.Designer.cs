
namespace Administrador
{
    partial class VistaCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaCliente));
            this.datagridview1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mzButtonWindows1 = new BWCMM.MZButtonWindows();
            this.lb_Clientes = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.PrimerNombre = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PrimerApellido = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.SegundoNombre = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Correo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.datagridview1.Location = new System.Drawing.Point(12, 123);
            this.datagridview1.Name = "datagridview1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Fuchsia;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridview1.Size = new System.Drawing.Size(749, 422);
            this.datagridview1.TabIndex = 2;
            this.datagridview1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 595);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 51);
            this.panel2.TabIndex = 54;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.mzButtonWindows1);
            this.panel1.Controls.Add(this.lb_Clientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 51);
            this.panel1.TabIndex = 53;
            // 
            // mzButtonWindows1
            // 
            this.mzButtonWindows1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mzButtonWindows1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mzButtonWindows1.BackgroundImage")));
            this.mzButtonWindows1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mzButtonWindows1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mzButtonWindows1.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows;
            this.mzButtonWindows1.Location = new System.Drawing.Point(1019, 12);
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
            this.lb_Clientes.Size = new System.Drawing.Size(156, 29);
            this.lb_Clientes.TabIndex = 21;
            this.lb_Clientes.Text = "Lista de Clientes";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(767, 171);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(258, 10);
            this.panel5.TabIndex = 72;
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.SystemColors.Control;
            this.ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ID.Location = new System.Drawing.Point(771, 152);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(254, 13);
            this.ID.TabIndex = 66;
            this.ID.Text = "ID";
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(767, 215);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(258, 10);
            this.panel6.TabIndex = 73;
            // 
            // PrimerNombre
            // 
            this.PrimerNombre.BackColor = System.Drawing.SystemColors.Control;
            this.PrimerNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrimerNombre.Location = new System.Drawing.Point(771, 196);
            this.PrimerNombre.Name = "PrimerNombre";
            this.PrimerNombre.Size = new System.Drawing.Size(254, 13);
            this.PrimerNombre.TabIndex = 67;
            this.PrimerNombre.Text = "Primer Nombre";
            this.PrimerNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(767, 301);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 10);
            this.panel4.TabIndex = 71;
            // 
            // PrimerApellido
            // 
            this.PrimerApellido.BackColor = System.Drawing.SystemColors.Control;
            this.PrimerApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrimerApellido.Location = new System.Drawing.Point(771, 282);
            this.PrimerApellido.Name = "PrimerApellido";
            this.PrimerApellido.Size = new System.Drawing.Size(254, 13);
            this.PrimerApellido.TabIndex = 68;
            this.PrimerApellido.Text = "Apellido";
            this.PrimerApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(767, 386);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 13);
            this.panel3.TabIndex = 70;
            // 
            // Telefono
            // 
            this.Telefono.BackColor = System.Drawing.SystemColors.Control;
            this.Telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Telefono.Location = new System.Drawing.Point(767, 367);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(258, 13);
            this.Telefono.TabIndex = 69;
            this.Telefono.Text = "Telefono";
            this.Telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SegundoNombre
            // 
            this.SegundoNombre.BackColor = System.Drawing.SystemColors.Control;
            this.SegundoNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SegundoNombre.Location = new System.Drawing.Point(775, 240);
            this.SegundoNombre.Name = "SegundoNombre";
            this.SegundoNombre.Size = new System.Drawing.Size(250, 13);
            this.SegundoNombre.TabIndex = 70;
            this.SegundoNombre.Text = "Segundo Nombre";
            this.SegundoNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(767, 259);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(258, 10);
            this.panel7.TabIndex = 74;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(767, 345);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(258, 10);
            this.panel8.TabIndex = 75;
            // 
            // Direccion
            // 
            this.Direccion.BackColor = System.Drawing.SystemColors.Control;
            this.Direccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Direccion.Location = new System.Drawing.Point(775, 326);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(250, 13);
            this.Direccion.TabIndex = 71;
            this.Direccion.Text = "Direccion";
            this.Direccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Location = new System.Drawing.Point(767, 430);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(258, 13);
            this.panel9.TabIndex = 76;
            // 
            // Correo
            // 
            this.Correo.BackColor = System.Drawing.SystemColors.Control;
            this.Correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Correo.Location = new System.Drawing.Point(775, 411);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(250, 13);
            this.Correo.TabIndex = 72;
            this.Correo.Text = "Correo";
            this.Correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(917, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 45);
            this.button2.TabIndex = 104;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(767, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 45);
            this.button1.TabIndex = 103;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 32);
            this.button3.TabIndex = 105;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // VistaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 646);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.PrimerApellido);
            this.Controls.Add(this.SegundoNombre);
            this.Controls.Add(this.PrimerNombre);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.datagridview1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaCliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VistaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Clientes;
        private BWCMM.MZButtonWindows mzButtonWindows1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox PrimerNombre;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox PrimerApellido;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox SegundoNombre;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

