
namespace Capa.UI
{
    partial class frmPrincipal
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
            this.mspMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.miPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMenuItemClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMenuItemEjercicios = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMenuItemEntrenamientos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMenuItemFacturacion = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarEntrenamientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MostrarEntrenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.ejerciciosMasUtilizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FacturaByFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EjerciciosByTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejerciciosPorUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosMorososToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mspMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mspMenuPrincipal
            // 
            this.mspMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(165)))));
            this.mspMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemArchivo,
            this.toolStripMenuItemMantenimientos,
            this.toolStripMenuItemProcesos,
            this.ToolStripMenuItemReportes,
            this.toolStripMenuItemAcercaDe});
            this.mspMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mspMenuPrincipal.Name = "mspMenuPrincipal";
            this.mspMenuPrincipal.Size = new System.Drawing.Size(779, 73);
            this.mspMenuPrincipal.TabIndex = 2;
            this.mspMenuPrincipal.Text = "menuStrip1";
            // 
            // toolStripMenuItemArchivo
            // 
            this.toolStripMenuItemArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPerfilToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.toolStripMenuItemArchivo.Image = global::Capa.UI.Properties.Resources.icons8_report_file_50px;
            this.toolStripMenuItemArchivo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemArchivo.Name = "toolStripMenuItemArchivo";
            this.toolStripMenuItemArchivo.Size = new System.Drawing.Size(62, 69);
            this.toolStripMenuItemArchivo.Text = "Archivo";
            this.toolStripMenuItemArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // miPerfilToolStripMenuItem
            // 
            this.miPerfilToolStripMenuItem.Name = "miPerfilToolStripMenuItem";
            this.miPerfilToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.miPerfilToolStripMenuItem.Text = "Mi perfil";
            this.miPerfilToolStripMenuItem.Click += new System.EventHandler(this.miPerfilToolStripMenuItem_Click_1);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripMenuItemMantenimientos
            // 
            this.toolStripMenuItemMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsMenuItemClientes,
            this.TsMenuItemEjercicios,
            this.TsMenuItemEntrenamientos});
            this.toolStripMenuItemMantenimientos.Image = global::Capa.UI.Properties.Resources.icons8_maintenance_date_50px;
            this.toolStripMenuItemMantenimientos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemMantenimientos.Name = "toolStripMenuItemMantenimientos";
            this.toolStripMenuItemMantenimientos.Size = new System.Drawing.Size(106, 69);
            this.toolStripMenuItemMantenimientos.Text = "Mantenimientos";
            this.toolStripMenuItemMantenimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // TsMenuItemClientes
            // 
            this.TsMenuItemClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsMenuItemClientes.Name = "TsMenuItemClientes";
            this.TsMenuItemClientes.Size = new System.Drawing.Size(157, 22);
            this.TsMenuItemClientes.Text = "Clientes";
            this.TsMenuItemClientes.Click += new System.EventHandler(this.TsMenuItemClientes_Click);
            // 
            // TsMenuItemEjercicios
            // 
            this.TsMenuItemEjercicios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsMenuItemEjercicios.Name = "TsMenuItemEjercicios";
            this.TsMenuItemEjercicios.Size = new System.Drawing.Size(157, 22);
            this.TsMenuItemEjercicios.Text = "Ejercicios";
            this.TsMenuItemEjercicios.Click += new System.EventHandler(this.TsMenuItemEjercicios_Click);
            // 
            // TsMenuItemEntrenamientos
            // 
            this.TsMenuItemEntrenamientos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsMenuItemEntrenamientos.Name = "TsMenuItemEntrenamientos";
            this.TsMenuItemEntrenamientos.Size = new System.Drawing.Size(157, 22);
            this.TsMenuItemEntrenamientos.Text = "Entrenamientos";
            this.TsMenuItemEntrenamientos.Click += new System.EventHandler(this.TsMenuItemEntrenamientos_Click);
            // 
            // toolStripMenuItemProcesos
            // 
            this.toolStripMenuItemProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsMenuItemFacturacion,
            this.asignarEntrenamientosToolStripMenuItem,
            this.MostrarEntrenaToolStripMenuItem});
            this.toolStripMenuItemProcesos.Image = global::Capa.UI.Properties.Resources.icons8_process_50px;
            this.toolStripMenuItemProcesos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemProcesos.Name = "toolStripMenuItemProcesos";
            this.toolStripMenuItemProcesos.Size = new System.Drawing.Size(66, 69);
            this.toolStripMenuItemProcesos.Text = "Procesos";
            this.toolStripMenuItemProcesos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // TsMenuItemFacturacion
            // 
            this.TsMenuItemFacturacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsMenuItemFacturacion.Name = "TsMenuItemFacturacion";
            this.TsMenuItemFacturacion.Size = new System.Drawing.Size(215, 22);
            this.TsMenuItemFacturacion.Text = "Facturación";
            this.TsMenuItemFacturacion.Click += new System.EventHandler(this.TsMenuItemFacturacion_Click);
            // 
            // asignarEntrenamientosToolStripMenuItem
            // 
            this.asignarEntrenamientosToolStripMenuItem.Name = "asignarEntrenamientosToolStripMenuItem";
            this.asignarEntrenamientosToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.asignarEntrenamientosToolStripMenuItem.Text = "Asignar Entrenamientos";
            this.asignarEntrenamientosToolStripMenuItem.Click += new System.EventHandler(this.asignarEntrenamientosToolStripMenuItem_Click);
            // 
            // MostrarEntrenaToolStripMenuItem
            // 
            this.MostrarEntrenaToolStripMenuItem.Name = "MostrarEntrenaToolStripMenuItem";
            this.MostrarEntrenaToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.MostrarEntrenaToolStripMenuItem.Text = "Entrenamientos Asignados";
            this.MostrarEntrenaToolStripMenuItem.Click += new System.EventHandler(this.MostrarEntrenaToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemReportes
            // 
            this.ToolStripMenuItemReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejerciciosMasUtilizadosToolStripMenuItem,
            this.FacturaByFechaToolStripMenuItem,
            this.EjerciciosByTipoToolStripMenuItem,
            this.ejerciciosPorUsuarioToolStripMenuItem,
            this.usuariosMorososToolStripMenuItem});
            this.ToolStripMenuItemReportes.Image = global::Capa.UI.Properties.Resources.icons8_report_file_50px;
            this.ToolStripMenuItemReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItemReportes.Name = "ToolStripMenuItemReportes";
            this.ToolStripMenuItemReportes.Size = new System.Drawing.Size(65, 69);
            this.ToolStripMenuItemReportes.Text = "Reportes";
            this.ToolStripMenuItemReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ejerciciosMasUtilizadosToolStripMenuItem
            // 
            this.ejerciciosMasUtilizadosToolStripMenuItem.Name = "ejerciciosMasUtilizadosToolStripMenuItem";
            this.ejerciciosMasUtilizadosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ejerciciosMasUtilizadosToolStripMenuItem.Text = "Ejercicios más utilizados";
            this.ejerciciosMasUtilizadosToolStripMenuItem.Click += new System.EventHandler(this.ejerciciosMásUtilizadosToolStripMenuItem_Click);
            // 
            // FacturaByFechaToolStripMenuItem
            // 
            this.FacturaByFechaToolStripMenuItem.Name = "FacturaByFechaToolStripMenuItem";
            this.FacturaByFechaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.FacturaByFechaToolStripMenuItem.Text = "Facturas por fecha";
            this.FacturaByFechaToolStripMenuItem.Click += new System.EventHandler(this.FacturaByFechaToolStripMenuItem_Click);
            // 
            // EjerciciosByTipoToolStripMenuItem
            // 
            this.EjerciciosByTipoToolStripMenuItem.Name = "EjerciciosByTipoToolStripMenuItem";
            this.EjerciciosByTipoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.EjerciciosByTipoToolStripMenuItem.Text = "Ejercicios por tipo";
            this.EjerciciosByTipoToolStripMenuItem.Click += new System.EventHandler(this.EjerciciosByTipoToolStripMenuItem_Click);
            // 
            // ejerciciosPorUsuarioToolStripMenuItem
            // 
            this.ejerciciosPorUsuarioToolStripMenuItem.Name = "ejerciciosPorUsuarioToolStripMenuItem";
            this.ejerciciosPorUsuarioToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ejerciciosPorUsuarioToolStripMenuItem.Text = "Ejercicios por Usuario";
            this.ejerciciosPorUsuarioToolStripMenuItem.Click += new System.EventHandler(this.ejerciciosPorUsuarioToolStripMenuItem_Click);
            // 
            // toolStripMenuItemAcercaDe
            // 
            this.toolStripMenuItemAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemAcercaDe.Name = "toolStripMenuItemAcercaDe";
            this.toolStripMenuItemAcercaDe.Size = new System.Drawing.Size(12, 69);
            // 
            // usuariosMorososToolStripMenuItem
            // 
            this.usuariosMorososToolStripMenuItem.Name = "usuariosMorososToolStripMenuItem";
            this.usuariosMorososToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.usuariosMorososToolStripMenuItem.Text = "Usuarios Morosos";
            this.usuariosMorososToolStripMenuItem.Click += new System.EventHandler(this.usuariosMorososToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(779, 476);
            this.Controls.Add(this.mspMenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mspMenuPrincipal.ResumeLayout(false);
            this.mspMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem TsMenuItemClientes;
        private System.Windows.Forms.ToolStripMenuItem TsMenuItemEjercicios;
        private System.Windows.Forms.ToolStripMenuItem TsMenuItemEntrenamientos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProcesos;
        private System.Windows.Forms.ToolStripMenuItem TsMenuItemFacturacion;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemReportes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem asignarEntrenamientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemArchivo;
        private System.Windows.Forms.ToolStripMenuItem miPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MostrarEntrenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejerciciosMasUtilizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FacturaByFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EjerciciosByTipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejerciciosPorUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosMorososToolStripMenuItem;
    }
}