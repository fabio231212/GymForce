
namespace Capa.UI.Procesos
{
    partial class frmMuestraEntrenamientosAsig
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
            this.tspMantenimientos = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnMostrarDetalles = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.lblEntrenamiento = new System.Windows.Forms.Label();
            this.cmbEntrenamiento = new System.Windows.Forms.ComboBox();
            this.tspMantenimientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspMantenimientos
            // 
            this.tspMantenimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.tspMantenimientos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnMostrarDetalles,
            this.toolStripBtnSalir});
            this.tspMantenimientos.Location = new System.Drawing.Point(0, 0);
            this.tspMantenimientos.Name = "tspMantenimientos";
            this.tspMantenimientos.Size = new System.Drawing.Size(773, 59);
            this.tspMantenimientos.TabIndex = 54;
            this.tspMantenimientos.Text = "toolStrip1";
            // 
            // toolStripBtnMostrarDetalles
            // 
            this.toolStripBtnMostrarDetalles.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnMostrarDetalles.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripBtnMostrarDetalles.Image = global::Capa.UI.Properties.Resources.icons8_new_document_35px;
            this.toolStripBtnMostrarDetalles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnMostrarDetalles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnMostrarDetalles.Name = "toolStripBtnMostrarDetalles";
            this.toolStripBtnMostrarDetalles.Size = new System.Drawing.Size(114, 56);
            this.toolStripBtnMostrarDetalles.Text = "Mostrar Detalles";
            this.toolStripBtnMostrarDetalles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnMostrarDetalles.Click += new System.EventHandler(this.toolStripBtnMostrarDetalles_Click_1);
            // 
            // toolStripBtnSalir
            // 
            this.toolStripBtnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripBtnSalir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripBtnSalir.Image = global::Capa.UI.Properties.Resources.icons8_Close_35px;
            this.toolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalir.Name = "toolStripBtnSalir";
            this.toolStripBtnSalir.Size = new System.Drawing.Size(39, 56);
            this.toolStripBtnSalir.Text = "Salir";
            this.toolStripBtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnSalir.Click += new System.EventHandler(this.toolStripBtnSalir_Click);
            // 
            // lblEntrenamiento
            // 
            this.lblEntrenamiento.AutoSize = true;
            this.lblEntrenamiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrenamiento.ForeColor = System.Drawing.Color.LightGray;
            this.lblEntrenamiento.Location = new System.Drawing.Point(232, 199);
            this.lblEntrenamiento.Name = "lblEntrenamiento";
            this.lblEntrenamiento.Size = new System.Drawing.Size(101, 16);
            this.lblEntrenamiento.TabIndex = 130;
            this.lblEntrenamiento.Text = "Entrenamiento";
            this.lblEntrenamiento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbEntrenamiento
            // 
            this.cmbEntrenamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(165)))));
            this.cmbEntrenamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntrenamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEntrenamiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEntrenamiento.ForeColor = System.Drawing.Color.White;
            this.cmbEntrenamiento.FormattingEnabled = true;
            this.cmbEntrenamiento.Location = new System.Drawing.Point(232, 218);
            this.cmbEntrenamiento.Name = "cmbEntrenamiento";
            this.cmbEntrenamiento.Size = new System.Drawing.Size(242, 29);
            this.cmbEntrenamiento.TabIndex = 131;
            // 
            // frmMuestraEntrenamientosAsig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(773, 462);
            this.Controls.Add(this.lblEntrenamiento);
            this.Controls.Add(this.cmbEntrenamiento);
            this.Controls.Add(this.tspMantenimientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMuestraEntrenamientosAsig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMuestraEntrenamientosAsig";
            this.Load += new System.EventHandler(this.frmMuestraEntrenamientosAsig_Load);
            this.tspMantenimientos.ResumeLayout(false);
            this.tspMantenimientos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspMantenimientos;
        private System.Windows.Forms.ToolStripButton toolStripBtnMostrarDetalles;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.Label lblEntrenamiento;
        private System.Windows.Forms.ComboBox cmbEntrenamiento;
    }
}