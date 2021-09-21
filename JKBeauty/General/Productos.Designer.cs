
namespace General
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mzButtonWindows1 = new BWCMM.MZButtonWindows();
            this.lb_Clientes = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Existencia = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Precio = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.FechaVencimiento = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jKBeautyMarcas = new General.JKBeautyMarcas();
            this.marcaTableAdapter = new General.JKBeautyMarcasTableAdapters.MarcaTableAdapter();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jKBeautyMarcas)).BeginInit();
            this.panel8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 556);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 51);
            this.panel2.TabIndex = 57;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.mzButtonWindows1);
            this.panel1.Controls.Add(this.lb_Clientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 51);
            this.panel1.TabIndex = 56;
            // 
            // mzButtonWindows1
            // 
            this.mzButtonWindows1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mzButtonWindows1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mzButtonWindows1.BackgroundImage")));
            this.mzButtonWindows1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mzButtonWindows1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mzButtonWindows1.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows;
            this.mzButtonWindows1.Location = new System.Drawing.Point(969, 12);
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
            this.lb_Clientes.Size = new System.Drawing.Size(102, 29);
            this.lb_Clientes.TabIndex = 21;
            this.lb_Clientes.Text = "Productos";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(858, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 48);
            this.button2.TabIndex = 61;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(858, 235);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(151, 48);
            this.Agregar.TabIndex = 60;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::General.Properties.Resources.Griz1;
            this.pictureBox1.Location = new System.Drawing.Point(858, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(459, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 29);
            this.label5.TabIndex = 67;
            this.label5.Text = "Fecha Vencimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(459, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 29);
            this.label4.TabIndex = 66;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 65;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 64;
            this.label2.Text = "Existencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 63;
            this.label1.Text = "Nombre";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID.Location = new System.Drawing.Point(31, 106);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(31, 29);
            this.lb_ID.TabIndex = 62;
            this.lb_ID.Text = "ID";
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.SystemColors.Control;
            this.ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ID.Location = new System.Drawing.Point(3, 8);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(192, 13);
            this.ID.TabIndex = 66;
            this.ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.ID);
            this.panel5.Location = new System.Drawing.Point(159, 97);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 38);
            this.panel5.TabIndex = 70;
            // 
            // Nombre
            // 
            this.Nombre.BackColor = System.Drawing.SystemColors.Control;
            this.Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nombre.Location = new System.Drawing.Point(3, 8);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(192, 13);
            this.Nombre.TabIndex = 66;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Nombre);
            this.panel3.Location = new System.Drawing.Point(163, 208);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 38);
            this.panel3.TabIndex = 70;
            // 
            // Existencia
            // 
            this.Existencia.BackColor = System.Drawing.SystemColors.Control;
            this.Existencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Existencia.Location = new System.Drawing.Point(3, 8);
            this.Existencia.Name = "Existencia";
            this.Existencia.Size = new System.Drawing.Size(192, 13);
            this.Existencia.TabIndex = 66;
            this.Existencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Existencia_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Existencia);
            this.panel4.Location = new System.Drawing.Point(637, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 38);
            this.panel4.TabIndex = 70;
            // 
            // Precio
            // 
            this.Precio.BackColor = System.Drawing.SystemColors.Control;
            this.Precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Precio.Location = new System.Drawing.Point(3, 8);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(192, 13);
            this.Precio.TabIndex = 66;
            this.Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Precio_KeyPress);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Precio);
            this.panel6.Location = new System.Drawing.Point(637, 208);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 38);
            this.panel6.TabIndex = 70;
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.BackColor = System.Drawing.SystemColors.Control;
            this.FechaVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FechaVencimiento.Location = new System.Drawing.Point(3, 15);
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.Size = new System.Drawing.Size(192, 13);
            this.FechaVencimiento.TabIndex = 66;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.FechaVencimiento);
            this.panel7.Location = new System.Drawing.Point(641, 325);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 38);
            this.panel7.TabIndex = 70;
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataMember = "Marca";
            this.marcaBindingSource.DataSource = this.jKBeautyMarcas;
            // 
            // jKBeautyMarcas
            // 
            this.jKBeautyMarcas.DataSetName = "JKBeautyMarcas";
            this.jKBeautyMarcas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcaTableAdapter
            // 
            this.marcaTableAdapter.ClearBeforeFill = true;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.textBox1);
            this.panel8.Location = new System.Drawing.Point(159, 325);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 38);
            this.panel8.TabIndex = 84;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(3, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 13);
            this.textBox1.TabIndex = 66;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 86;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(36, 398);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 141);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Marcas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(324, 113);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 607);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_ID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jKBeautyMarcas)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private BWCMM.MZButtonWindows mzButtonWindows1;
        private System.Windows.Forms.Label lb_Clientes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox FechaVencimiento;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox Precio;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Existencia;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox ID;
        private JKBeautyMarcas jKBeautyMarcas;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private JKBeautyMarcasTableAdapters.MarcaTableAdapter marcaTableAdapter;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}