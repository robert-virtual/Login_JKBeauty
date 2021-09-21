
namespace Informe
{
    partial class Form2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.JKBeautyDataSet = new Informe.JKBeautyDataSet();
            this.Detalle_FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Detalle_FacturaTableAdapter = new Informe.JKBeautyDataSetTableAdapters.Detalle_FacturaTableAdapter();
            this.FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturaTableAdapter = new Informe.JKBeautyDataSetTableAdapters.FacturaTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.JKBeautyDataSet1 = new Informe.JKBeautyDataSet1();
            this.ProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductosTableAdapter = new Informe.JKBeautyDataSet1TableAdapters.ProductosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.JKBeautyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_FacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JKBeautyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // JKBeautyDataSet
            // 
            this.JKBeautyDataSet.DataSetName = "JKBeautyDataSet";
            this.JKBeautyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Detalle_FacturaBindingSource
            // 
            this.Detalle_FacturaBindingSource.DataMember = "Detalle_Factura";
            this.Detalle_FacturaBindingSource.DataSource = this.JKBeautyDataSet;
            // 
            // Detalle_FacturaTableAdapter
            // 
            this.Detalle_FacturaTableAdapter.ClearBeforeFill = true;
            // 
            // FacturaBindingSource
            // 
            this.FacturaBindingSource.DataMember = "Factura";
            this.FacturaBindingSource.DataSource = this.JKBeautyDataSet;
            // 
            // FacturaTableAdapter
            // 
            this.FacturaTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 67);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Informe.informe2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 67);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 383);
            this.reportViewer1.TabIndex = 1;
            // 
            // JKBeautyDataSet1
            // 
            this.JKBeautyDataSet1.DataSetName = "JKBeautyDataSet1";
            this.JKBeautyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductosBindingSource
            // 
            this.ProductosBindingSource.DataMember = "Productos";
            this.ProductosBindingSource.DataSource = this.JKBeautyDataSet1;
            // 
            // ProductosTableAdapter
            // 
            this.ProductosTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JKBeautyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_FacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JKBeautyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource Detalle_FacturaBindingSource;
        private JKBeautyDataSet JKBeautyDataSet;
        private System.Windows.Forms.BindingSource FacturaBindingSource;
        private JKBeautyDataSetTableAdapters.Detalle_FacturaTableAdapter Detalle_FacturaTableAdapter;
        private JKBeautyDataSetTableAdapters.FacturaTableAdapter FacturaTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProductosBindingSource;
        private JKBeautyDataSet1 JKBeautyDataSet1;
        private JKBeautyDataSet1TableAdapters.ProductosTableAdapter ProductosTableAdapter;
    }
}