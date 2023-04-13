using Capa.Entidades;
using Capa.Entidades.Cache;
using Capa.Interfaces;
using Capa.Logica.BLL;
using Capa.UI.Reportes;
using log4net;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Capa.UI.Procesos
{
    public partial class frmMuestraEntrenamientosAsig : Form
    {
        private Entrenamiento entrenamiento = new Entrenamiento();
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public frmMuestraEntrenamientosAsig()
        {
            InitializeComponent();
        }

        private void CargarEntrenamientos()
        {

            try
            {
                //string userId = UsuarioCache
                IUsuarioxEntrenamientoLN datosEntrenamiento = new UsuarioxEntrenamientoLN();
                IEntrenamientoLN logicaEntrenamiento = new EntrenamientoLN();
                List<Entrenamiento> listaEntrenamiento = new List<Entrenamiento>();
                List<UsuarioxEntrenamiento> listaUsEnt = new List<UsuarioxEntrenamiento>();
                listaUsEnt = datosEntrenamiento.ObtenerDatosByIdUsuario(UsuarioCache.Id);
                foreach (var item in listaUsEnt)
                {
                    listaEntrenamiento.Add(logicaEntrenamiento.ObtenerEntrenamientosPorId(item.IdEntrenamiento));
                }

                cmbEntrenamiento.DataSource = listaEntrenamiento;
                cmbEntrenamiento.DisplayMember = "Nombre";
                cmbEntrenamiento.ValueMember = "Id";
                cmbEntrenamiento.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error(ex.Message);
            }
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMuestraEntrenamientosAsig_Load(object sender, EventArgs e)
        {
            CargarEntrenamientos();
        }

        private void toolStripBtnMostrarDetalles_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripBtnMostrarDetalles_Click_1(object sender, EventArgs e)
        {
            frmReporteAsigEntrUser ofrm;

            try
            {
                if(cmbEntrenamiento.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar el ejercicio a mostrar");
                    return;
                }
                ofrm = new frmReporteAsigEntrUser(UsuarioCache.Id, (int)cmbEntrenamiento.SelectedValue);
                
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