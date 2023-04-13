using Capa.Entidades;
using Capa.Interfaces;
using Capa.Logica.BLL;
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

namespace Capa.UI.Mantenimiento
{
    public partial class frmMantenimientoEntrenamiento : Form
    {

        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public frmMantenimientoEntrenamiento()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Método que limpia los campos cambiando el estado mantenimiento a nuevo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                this.CambiarEstado(EstadoMantenimiento.Nuevo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }


        /// <summary>
        /// Método que coloca los valores seleccionados de la tabla en los inputs y actualiza 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnEditar_Click(object sender, EventArgs e)
        {
            Entrenamiento oEntrenamiento = null;
            try
            {
                if (this.dgvDatosCertificacion.SelectedRows.Count > 0)
                {
                    oEntrenamiento = dgvDatosCertificacion.SelectedRows[0].DataBoundItem as Entrenamiento;
                    txtId.Text = oEntrenamiento.Id.ToString();
                    txtNombre.Text = oEntrenamiento.Nombre;
                    txtDescripcion.Text = oEntrenamiento.Descripcion;
                   
                }
                else
                {
                    MessageBox.Show("¡Seleccione el registro!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }

        /// <summary>
        /// Método que elimina el registro seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                IEntrenamientoLN logica = new EntrenamientoLN();
                Entrenamiento oEntrenamiento = null;
                if (this.dgvDatosCertificacion.SelectedRows.Count > 0)
                {
                    oEntrenamiento = dgvDatosCertificacion.SelectedRows[0].DataBoundItem as Entrenamiento;
                    if (MessageBox.Show($"¿Seguro que desea borrar la certificación {oEntrenamiento.Nombre}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        logica.Eliminar(oEntrenamiento.Id);
                        CargarDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CambiarEstado(EstadoMantenimiento estado)
        {
      
            txtId.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
     

            switch (estado)
            {
                case EstadoMantenimiento.Nuevo:
                    txtId.Enabled = true;
                    txtNombre.Enabled = true;
                    txtDescripcion.Enabled = true;
          
                    txtId.Focus();
                    break;

                case EstadoMantenimiento.Editar:
                    txtId.Enabled = true;
                    txtNombre.Enabled = true;
                    txtDescripcion.Enabled = true;
          
                    break;

                case EstadoMantenimiento.Borrar:
                    break;

                case EstadoMantenimiento.Ninguno:
                    break;
            }
        }

        /// <summary>
        /// Método que carga los datos en el frame
        /// </summary>
        private void CargarDatos()
        {
            try
            {
                dgvDatosCertificacion.AutoGenerateColumns = false;
                dgvDatosCertificacion.RowTemplate.Height = 100;
                dgvDatosCertificacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                IEntrenamientoLN logica = new EntrenamientoLN();
                dgvDatosCertificacion.DataSource = logica.ObtenerEntrenamientos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ErrorProvider oErrorProvider = new ErrorProvider();

            if (!txtId.Text.All(Char.IsDigit))
            {
                oErrorProvider.SetError(txtId, "Debe digitar un identificador");
                txtId.Focus();
                return;
            }
            if (txtNombre.Text.Equals(""))
            {
                oErrorProvider.SetError(txtId, "Debe digitar un nombre");
                txtNombre.Focus();
                return;
            }
            if (txtDescripcion.Text.Equals(""))
            {
                oErrorProvider.SetError(txtId, "Debe digitar una descripción");
                txtDescripcion.Focus();
                return;
            }
           

            try
            {
                IEntrenamientoLN logica = new EntrenamientoLN();
               Entrenamiento entrenamiento = new Entrenamiento();
                entrenamiento.Id = int.Parse(txtId.Text);
                entrenamiento.Nombre = txtNombre.Text;
                entrenamiento.Descripcion = txtDescripcion.Text;
           

                logica.Guardar(entrenamiento);
                CargarDatos();
                CambiarEstado(EstadoMantenimiento.Ninguno);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CambiarEstado(EstadoMantenimiento.Ninguno);
        }

        private void frmMantenimientoEntrenamiento_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
