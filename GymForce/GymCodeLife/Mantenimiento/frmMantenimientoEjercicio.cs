using Capa.Entidades;
using Capa.Interfaces;
using Capa.Logica.BLL;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.UI.Mantenimiento
{
    public partial class frmMantenimientoEjercicio : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private EstadoMantenimiento estadoMantenimiento;
        public frmMantenimientoEjercicio()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que carga los datos al frame
        /// </summary>
        private void CargarDatos()
        {
            try
            {
                dgvDatos.AutoGenerateColumns = false;
                dgvDatos.RowTemplate.Height = 100;
                dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                IEjercicioLN datos = new EjercicioLN();
                dgvDatos.DataSource = datos.ObtenerEjercicios();

                IEntrenamientoLN datosEntrenamiento = new EntrenamientoLN();
                List<Entrenamiento> lista = datosEntrenamiento.ObtenerEntrenamientos();
                cmbEntrenamiento.DataSource = datosEntrenamiento.ObtenerEntrenamientos();
                cmbEntrenamiento.DisplayMember = "Nombre";
                cmbEntrenamiento.ValueMember = "Id";
                cmbEntrenamiento.SelectedIndex = -1;

                ITipoEjercicioLN datosTipoEjercicio = new TipoEjercicioLN();
                List<TipoEjercicio> listaEjercicios = datosTipoEjercicio.ObtenerTodos();
                cmbEjercicio.DataSource = datosTipoEjercicio.ObtenerTodos();
                cmbEjercicio.DisplayMember = "Nombre";
                cmbEjercicio.ValueMember = "Id";
                cmbEjercicio.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }


        /// <summary>
        /// Método que limpia los campos y 
        /// </summary>
        /// <param name="estado"></param>
        private void CambiarEstado(EstadoMantenimiento estado)
        {
      

            txtId.Clear();
            txtDescripcion.Clear();
            txtNombre.Clear();
            txtPeso.Clear();
            txtRepeticiones.Clear();
            txtSeries.Clear();
            txtTiempoDescanso.Clear();
            cmbEjercicio.SelectedIndex = -1;
            cmbEntrenamiento.SelectedIndex = -1;

            this.pbFotoEjercicio.Image = Capa.UI.Properties.Resources.icons8_user_120px_1;

            switch (estado)
            {
                case EstadoMantenimiento.Nuevo:
                    estadoMantenimiento = EstadoMantenimiento.Nuevo;
                    txtId.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtNombre.Enabled = true;
                    cmbEjercicio.Enabled = true;
                    cmbEntrenamiento.Enabled = true;
                    pbFotoEjercicio.Enabled = true;
                    txtPeso.Enabled = true;
                    txtRepeticiones.Enabled = true;
                    txtSeries.Enabled = true;
                    txtTiempoDescanso.Enabled = true;


                    break;

                case EstadoMantenimiento.Editar:
                    estadoMantenimiento = EstadoMantenimiento.Editar;
                    txtId.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtNombre.Enabled = true;
                    cmbEjercicio.Enabled = true;
                    cmbEntrenamiento.Enabled = true;
                    pbFotoEjercicio.Enabled = true;
                    txtPeso.Enabled = true;
                    txtRepeticiones.Enabled = true;
                    txtSeries.Enabled = true;
                    txtTiempoDescanso.Enabled = true;
                    break;

                case EstadoMantenimiento.Borrar:
                    estadoMantenimiento = EstadoMantenimiento.Borrar;
                    break;

                case EstadoMantenimiento.Ninguno:
                    estadoMantenimiento = EstadoMantenimiento.Ninguno;
                    break;
            }
        }


        /// <summary>
        /// Método que ejecuta cambiarestado a nuevo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {
            CambiarEstado(EstadoMantenimiento.Nuevo);
        }

        private void toolStripBtnEditar_Click(object sender, EventArgs e)
        {
            CambiarEstado(EstadoMantenimiento.Editar);
            Ejercicio oEjercicio = null;
            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    oEjercicio = dgvDatos.SelectedRows[0].DataBoundItem as Ejercicio;
                    txtId.Text = oEjercicio.Id.ToString();
                    txtNombre.Text = oEjercicio.Nombre;
                    txtDescripcion.Text = oEjercicio.Descripcion;
                    this.pbFotoEjercicio.Image = new Bitmap(new MemoryStream(oEjercicio.Imagen));
                    this.pbFotoEjercicio.Tag = oEjercicio.Imagen;
                    txtPeso.Text = oEjercicio.Peso.ToString();
                    txtRepeticiones.Text = oEjercicio.CantRepeticiones.ToString();
                    txtSeries.Text = oEjercicio.Series.ToString();
                    txtTiempoDescanso.Text = oEjercicio.TiempoDescanso.ToString();

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
        /// Método que elimina el registro seleccionado de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnEliminar_Click(object sender, EventArgs e)
        {
            IEjercicioLN logica = new EjercicioLN();
            Ejercicio oEjercicio = null;
            if (this.dgvDatos.SelectedRows.Count > 0)
            {
                oEjercicio = dgvDatos.SelectedRows[0].DataBoundItem as Ejercicio;
                if (MessageBox.Show($"¿Seguro que desea borrar el registro {oEjercicio.Id} ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logica.Eliminar(oEjercicio.Id);
                    CargarDatos();
                }
            }
        }


        /// <summary>
        /// Método que cierra el frame
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            ErrorProvider oErrorProvider = new ErrorProvider();

            if (txtId.Text.Equals(""))
            {
                oErrorProvider.SetError(txtId, "Debe digitar un identificador");
                txtId.Focus();
                return;
            }
            if (!int.TryParse(txtId.Text, out resultado))
            {
                MessageBox.Show("El id debe ser numérico", "¡Atención!");
                txtId.Focus();
                return;
            }
            if (!int.TryParse(txtPeso.Text, out resultado))
            {
                MessageBox.Show("El peso debe ser numérico", "¡Atención!");
                txtPeso.Focus();
                return;
            }
            if (!int.TryParse(txtRepeticiones.Text, out resultado))
            {
                MessageBox.Show("Las repeticiones deben ser numéricas", "¡Atención!");
                txtRepeticiones.Focus();
                return;
            }
            if (!int.TryParse(txtSeries.Text, out resultado))
            {
                MessageBox.Show("Las series deben ser numéricas", "¡Atención!");
                txtSeries.Focus();
                return;
            }
            if (!int.TryParse(txtTiempoDescanso.Text, out resultado))
            {
                MessageBox.Show("El tiempo debe ser numérico", "¡Atención!");
                txtTiempoDescanso.Focus();
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
           
            if (cmbEjercicio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de ejercicio", "¡Atención!");
                return;
            }
            if (cmbEjercicio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de entrenamiento", "¡Atención!");
                return;
            }
            try
            {
                IEjercicioLN logica = new EjercicioLN();
                Ejercicio ejercicio = new Ejercicio();
                ejercicio.Id = int.Parse(txtId.Text);
                ejercicio.Nombre = txtNombre.Text;
                ejercicio.Descripcion = txtDescripcion.Text;
                ejercicio.Imagen = (byte[])pbFotoEjercicio.Tag;
                ejercicio.IdEntrenamiento = (int)cmbEntrenamiento.SelectedValue;
                ejercicio.IdTipoEjercicio = (int)cmbEjercicio.SelectedValue;
                ejercicio.Peso = double.Parse(txtPeso.Text);
                ejercicio.CantRepeticiones = int.Parse(txtRepeticiones.Text);
                ejercicio.Series = int.Parse(txtSeries.Text);
                ejercicio.TiempoDescanso = int.Parse(txtTiempoDescanso.Text);


                if (estadoMantenimiento == EstadoMantenimiento.Nuevo)
                {
                    logica.Guardar(ejercicio);
                }
                else
                {
                    logica.Actualizar(ejercicio);
                }

                CargarDatos();
                CambiarEstado(EstadoMantenimiento.Nuevo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }


        /// <summary>
        /// Método para seleccionar una imagen de usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbFotoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                pbFotoEjercicio.Image = null;
                OpenFileDialog opt = new OpenFileDialog();
                opt.Title = "Seleccione la Imagen ";
                opt.SupportMultiDottedExtensions = true;
                opt.DefaultExt = "*.jpg";
                opt.Filter = "Archivos de Imagenes (*.jpg)|*.jpg| All files (*.*)|*.*";
                opt.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                opt.FileName = "";

                if (opt.ShowDialog(this) == DialogResult.OK)
                {
                    //ruta = opt.FileName.Trim();
                    this.pbFotoEjercicio.ImageLocation = opt.FileName;
                    pbFotoEjercicio.SizeMode = PictureBoxSizeMode.StretchImage;

                    byte[] cadenaBytes = File.ReadAllBytes(opt.FileName);

                    // Guarla la imagenen Bytes en el Tag de la imagen.
                    pbFotoEjercicio.Tag = (byte[])cadenaBytes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMantenimientoEjercicio_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CambiarEstado(EstadoMantenimiento.Ninguno);
        }
    }
}
