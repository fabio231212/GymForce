using Capa.Entidades.Cache;
using Capa.Interfaces;
using Capa.Logica.BLL;
using Capa.UI.Mantenimiento;
using Capa.UI.Procesos;
using Capa.UI.Reportes;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Capa.UI
{
    public partial class frmPrincipal : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void TsMenuItemClientes_Click(object sender, EventArgs e)
        {
            frmMantenimientoUsuario ofrmMantenimientoCliente;

            try
            {
                ofrmMantenimientoCliente = new frmMantenimientoUsuario();
                ofrmMantenimientoCliente.MdiParent = this;
                ofrmMantenimientoCliente.Show();
            }
            catch (Exception ex)
            {

           MessageBox.Show("Se ha producido el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        private void VerificarTipoUsuario()
        {
            if(UsuarioCache.IdTipoUsuario == 1)
            {
                miPerfilToolStripMenuItem.Visible = false;
                MostrarEntrenaToolStripMenuItem.Visible = false;
            }
            if (UsuarioCache.IdTipoUsuario == 2)
            {
                toolStripMenuItemMantenimientos.Visible = false;
                TsMenuItemFacturacion.Visible = false;
                miPerfilToolStripMenuItem.Visible = false;
              


            }
            if (UsuarioCache.IdTipoUsuario == 3)
            {
                toolStripMenuItemMantenimientos.Visible = false;
                TsMenuItemFacturacion.Visible = false;
                asignarEntrenamientosToolStripMenuItem.Visible = false;
                ToolStripMenuItemReportes.Visible = false;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                HistorialCache.Ingreso = DateTime.Now;
                VerificarTipoUsuario();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error(ex.Message);
            }
            
        }

        private void TsMenuItemEntrenamientos_Click(object sender, EventArgs e)
        {
            frmMantenimientoEntrenamiento ofrmMantenimientoEntrenamiento;

            try
            {
                ofrmMantenimientoEntrenamiento = new frmMantenimientoEntrenamiento();
                ofrmMantenimientoEntrenamiento.MdiParent = this;
                ofrmMantenimientoEntrenamiento.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error(ex.Message);
            }
        }

        private void TsMenuItemEjercicios_Click(object sender, EventArgs e)
        {
            frmMantenimientoEjercicio ofrmMantenimientoEjercicio;

            try
            {
                ofrmMantenimientoEjercicio = new frmMantenimientoEjercicio();
                ofrmMantenimientoEjercicio.MdiParent = this;
                ofrmMantenimientoEjercicio.Show();
            }
            catch (Exception er)
            {

                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error(er.Message);
            }
        }

        private void TsMenuItemFacturacion_Click(object sender, EventArgs e)
        {
            frmFacturacion ofrmFacturacion;

            try
            {
                ofrmFacturacion = new frmFacturacion();
                ofrmFacturacion.MdiParent = this;
                ofrmFacturacion.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error(ex.Message);

            }
        }

        private void asignarEntrenamientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsignaEntrenamiento ofrmAsignarEntrenamiento;

            try
            {
                ofrmAsignarEntrenamiento = new frmAsignaEntrenamiento();
                ofrmAsignarEntrenamiento.MdiParent = this;
                ofrmAsignarEntrenamiento.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMuestraEntrenamientosAsig ofrm;

            try
            {
                ofrm= new frmMuestraEntrenamientosAsig();
                ofrm.MdiParent = this;
                ofrm.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error(ex.Message);
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var r = MessageBox.Show("¿Desea Cerrar Sesión?", "Atención", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes && UsuarioCache.IdTipoUsuario == 3)
                {
                    UsuarioCache.FechaEgreso = DateTime.Now;
                    IUsuarioLN logicaUsuario = new UsuarioLN();
                    logicaUsuario.InsertaIngresoEgreso();
                    this.Close();
                }
                else
                {
                    if(r == DialogResult.Yes && UsuarioCache.IdTipoUsuario == 1 || r == DialogResult.Yes && UsuarioCache.IdTipoUsuario == 2)
                    {
                        this.Close();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _MyLogControlEventos.Error(ex.Message);

            }
        }

        private void miPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void MostrarEntrenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMuestraEntrenamientosAsig ofrm;

            try
            {
                ofrm = new frmMuestraEntrenamientosAsig();
                ofrm.MdiParent = this;
                ofrm.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error(ex.Message);
            }
        }

        private void miPerfilToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPerfilUsuario ofrm;

            try
            {
                ofrm = new frmPerfilUsuario();
                ofrm.MdiParent = this;
                ofrm.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error(ex.Message);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
             var r = MessageBox.Show("¿Desea cerrar la aplicación?", "Atención", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes && UsuarioCache.IdTipoUsuario == 3)
            {
                try
                {
                    UsuarioCache.FechaEgreso = DateTime.Now;
                    IUsuarioLN logicaUsuario = new UsuarioLN();
                    logicaUsuario.InsertaIngresoEgreso();
                    System.Windows.Forms.Application.Exit();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    _MyLogControlEventos.Error(ex.Message);

                }

            }
            else
            {
                if(r == DialogResult.Yes && UsuarioCache.IdTipoUsuario == 1 || r == DialogResult.Yes && UsuarioCache.IdTipoUsuario == 2)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
      
        }

        private void ejerciciosMásUtilizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteEjerMasUtilizados ofrm;

            try
            {
                ofrm = new frmReporteEjerMasUtilizados();
                ofrm.MdiParent = this;
                ofrm.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error(ex.Message);
            }
        }

        private void FacturaByFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteFacturaByFecha ofrm;

            try
            {
                ofrm = new frmReporteFacturaByFecha();
                ofrm.MdiParent = this;
                ofrm.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error(ex.Message);
            }
        }

        
        private void EjerciciosByTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteEjerciciosByTipo ofrm;

            try
            {
                ofrm = new frmReporteEjerciciosByTipo();
                ofrm.MdiParent = this;
                ofrm.Show();
            }
            catch (Exception er)
            {

                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error(er.Message);
            }
        }

        private void ejerciciosPorUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteEjercByIdUser ofrm;

            try
            {
                ofrm = new frmReporteEjercByIdUser();
                ofrm.MdiParent = this;
                ofrm.Show();
            }
            catch (Exception er)
            {

                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error(er.Message);
            }
        }

        private void usuariosMorososToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteUsuariosMorosos ofrm;

            try
            {
                ofrm = new frmReporteUsuariosMorosos();
                ofrm.MdiParent = this;
                ofrm.Show();
            }
            catch (Exception er)
            {

                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error(er.Message);
            }
        }
    }
}
