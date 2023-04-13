﻿
namespace Capa.UI.Reportes
{
    partial class frmReporteUsuariosMorosos
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
            this.tspBarraSuperior = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.rptVisor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usp_SelectUsuariosMorososBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsReportes = new Capa.UI.Reportes.DsReportes();
            this.usp_SelectUsuariosMorososTableAdapter = new Capa.UI.Reportes.DsReportesTableAdapters.usp_SelectUsuariosMorososTableAdapter();
            this.tspBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usp_SelectUsuariosMorososBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // tspBarraSuperior
            // 
            this.tspBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.tspBarraSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnSalir});
            this.tspBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tspBarraSuperior.Name = "tspBarraSuperior";
            this.tspBarraSuperior.Size = new System.Drawing.Size(800, 59);
            this.tspBarraSuperior.TabIndex = 7;
            this.tspBarraSuperior.Text = "toolStrip1";
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
            // rptVisor
            // 
            reportDataSource1.Name = "UsuariosMorosos";
            reportDataSource1.Value = this.usp_SelectUsuariosMorososBindingSource;
            this.rptVisor.LocalReport.DataSources.Add(reportDataSource1);
            this.rptVisor.LocalReport.ReportEmbeddedResource = "Capa.UI.Reportes.rptUsuariosMorosos.rdlc";
            this.rptVisor.Location = new System.Drawing.Point(0, 62);
            this.rptVisor.Name = "rptVisor";
            this.rptVisor.ServerReport.BearerToken = null;
            this.rptVisor.Size = new System.Drawing.Size(800, 386);
            this.rptVisor.TabIndex = 8;
            // 
            // usp_SelectUsuariosMorososBindingSource
            // 
            this.usp_SelectUsuariosMorososBindingSource.DataMember = "usp_SelectUsuariosMorosos";
            this.usp_SelectUsuariosMorososBindingSource.DataSource = this.DsReportes;
            // 
            // DsReportes
            // 
            this.DsReportes.DataSetName = "DsReportes";
            this.DsReportes.EnforceConstraints = false;
            this.DsReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usp_SelectUsuariosMorososTableAdapter
            // 
            this.usp_SelectUsuariosMorososTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteUsuariosMorosos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptVisor);
            this.Controls.Add(this.tspBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteUsuariosMorosos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReporteUsuariosMorosos";
            this.Load += new System.EventHandler(this.frmReporteUsuariosMorosos_Load);
            this.tspBarraSuperior.ResumeLayout(false);
            this.tspBarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usp_SelectUsuariosMorososBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspBarraSuperior;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private Microsoft.Reporting.WinForms.ReportViewer rptVisor;
        private System.Windows.Forms.BindingSource usp_SelectUsuariosMorososBindingSource;
        private DsReportes DsReportes;
        private DsReportesTableAdapters.usp_SelectUsuariosMorososTableAdapter usp_SelectUsuariosMorososTableAdapter;
    }
}