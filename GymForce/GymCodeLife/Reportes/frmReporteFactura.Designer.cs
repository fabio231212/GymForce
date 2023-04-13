﻿
namespace Capa.UI.Reportes
{
    partial class frmReporteFactura
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
            this.FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsReportes = new Capa.UI.Reportes.DsReportes();
            this.rptVisor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturaTableAdapter = new Capa.UI.Reportes.DsReportesTableAdapters.FacturaTableAdapter();
            this.tspBarraSuperior = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnEnviarEmail = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsReportes)).BeginInit();
            this.tspBarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // FacturaBindingSource
            // 
            this.FacturaBindingSource.DataMember = "Factura";
            this.FacturaBindingSource.DataSource = this.DsReportes;
            // 
            // DsReportes
            // 
            this.DsReportes.DataSetName = "DsReportes";
            this.DsReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptVisor
            // 
            reportDataSource1.Name = "ReporteFactura";
            reportDataSource1.Value = this.FacturaBindingSource;
            this.rptVisor.LocalReport.DataSources.Add(reportDataSource1);
            this.rptVisor.LocalReport.ReportEmbeddedResource = "Capa.UI.Reportes.rptReporteFactura.rdlc";
            this.rptVisor.Location = new System.Drawing.Point(0, 55);
            this.rptVisor.Name = "rptVisor";
            this.rptVisor.ServerReport.BearerToken = null;
            this.rptVisor.Size = new System.Drawing.Size(800, 398);
            this.rptVisor.TabIndex = 0;
            // 
            // FacturaTableAdapter
            // 
            this.FacturaTableAdapter.ClearBeforeFill = true;
            // 
            // tspBarraSuperior
            // 
            this.tspBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.tspBarraSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnEnviarEmail,
            this.toolStripBtnSalir});
            this.tspBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tspBarraSuperior.Name = "tspBarraSuperior";
            this.tspBarraSuperior.Size = new System.Drawing.Size(800, 59);
            this.tspBarraSuperior.TabIndex = 4;
            this.tspBarraSuperior.Text = "toolStrip1";
            // 
            // toolStripBtnEnviarEmail
            // 
            this.toolStripBtnEnviarEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripBtnEnviarEmail.ForeColor = System.Drawing.Color.White;
            this.toolStripBtnEnviarEmail.Image = global::Capa.UI.Properties.Resources.icons8_send_35px;
            this.toolStripBtnEnviarEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnEnviarEmail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnEnviarEmail.Name = "toolStripBtnEnviarEmail";
            this.toolStripBtnEnviarEmail.Size = new System.Drawing.Size(103, 56);
            this.toolStripBtnEnviarEmail.Text = "Enviar a email ";
            this.toolStripBtnEnviarEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnEnviarEmail.Click += new System.EventHandler(this.toolStripBtnEnviarEmail_Click);
            // 
            // toolStripBtnSalir
            // 
            this.toolStripBtnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripBtnSalir.ForeColor = System.Drawing.Color.White;
            this.toolStripBtnSalir.Image = global::Capa.UI.Properties.Resources.icons8_Close_35px;
            this.toolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalir.Name = "toolStripBtnSalir";
            this.toolStripBtnSalir.Size = new System.Drawing.Size(39, 56);
            this.toolStripBtnSalir.Text = "Salir";
            this.toolStripBtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnSalir.Click += new System.EventHandler(this.toolStripBtnSalir_Click);
            // 
            // frmReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tspBarraSuperior);
            this.Controls.Add(this.rptVisor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReporteFactura";
            this.Load += new System.EventHandler(this.frmReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsReportes)).EndInit();
            this.tspBarraSuperior.ResumeLayout(false);
            this.tspBarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptVisor;
        private System.Windows.Forms.BindingSource FacturaBindingSource;
        private DsReportes DsReportes;
        private DsReportesTableAdapters.FacturaTableAdapter FacturaTableAdapter;
        private System.Windows.Forms.ToolStrip tspBarraSuperior;
        private System.Windows.Forms.ToolStripButton toolStripBtnEnviarEmail;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
    }
}