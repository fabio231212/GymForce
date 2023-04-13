using Capa.Entidades;
using Capa.Interfaces;
using Capa.Logica.BLL;
using Capa.UI.Filtro;
using Capa.UI.Reportes;
using log4net;
using System;
using System.Windows.Forms;

namespace Capa.UI.Procesos
{
    public partial class frmAsignaEntrenamiento : Form
    {
        private Usuario user = null;
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public frmAsignaEntrenamiento()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            IEntrenamientoLN logica = new EntrenamientoLN();
            try
            {
                cmbEntrenamiento.DataSource = logica.ObtenerEntrenamientos();
                cmbEntrenamiento.DisplayMember = "Nombre";
                cmbEntrenamiento.ValueMember = "Id";
                cmbEntrenamiento.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            cmbEntrenamiento.SelectedIndex = -1;
            txtDia.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmFiltroUsuario frm = new frmFiltroUsuario();

            try
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    user = frm._User;
                    txtId.Text = user.Id.ToString();
                    txtNombre.Text = user.Nombre;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }

        private void frmAsignaEntrenamiento_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            IFacturaLN datosFactura = new FacturaLN();
            int result = 0;
            try
            {
                result = DateTime.Compare(datosFactura.fechaProximoPagoById(user.Id), DateTime.Now);
                
                erpError.Clear();
                if (cmbEntrenamiento.SelectedIndex == -1)
                {
                    erpError.SetError(cmbEntrenamiento, "Debe indicar el entrenamiento");
                    return;
                }
                if (string.IsNullOrEmpty(this.txtId.Text) || string.IsNullOrEmpty(this.txtNombre.Text))
                {
                    erpError.SetError(txtNombre, "Debe buscar el cliente");
                    return;
                }
                if (string.IsNullOrEmpty(txtDia.Text))
                {
                    erpError.SetError(txtDia, "Debe digitar el día");
                    return;
                }

                if (result < 0)
                {
                    MessageBox.Show("Usuario moroso");
                    return;
                }
                UsuarioxEntrenamiento userEntr = new UsuarioxEntrenamiento();
                Entrenamiento entr = new Entrenamiento();
                IEntrenamientoLN logicaEntrenamiento = new EntrenamientoLN();
                IUsuarioxEntrenamientoLN logicaUserEnt = new UsuarioxEntrenamientoLN();

                entr = logicaEntrenamiento.ObtenerEntrenamientosPorId((int)cmbEntrenamiento.SelectedValue);
                userEntr.IdEntrenamiento = entr.Id;
                userEntr.IdUsuario = user.Id;
                userEntr.Dia = txtDia.Text;
                logicaUserEnt.Guardar(userEntr);
                MessageBox.Show("Entrenamiento asignado correctamente");
                LimpiarCampos();
            }
            catch(InvalidCastException exNoEncontrado)
            {
                MessageBox.Show("El usuario no tiene registro de compras");
                _MyLogControlEventos.Error(exNoEncontrado.Message);
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

        private void toolStripBtnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                frmReporteEntrAsig ofrmReporte = new frmReporteEntrAsig(user.Id,user.Correo);
                ofrmReporte.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}