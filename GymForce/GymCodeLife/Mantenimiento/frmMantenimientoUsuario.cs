using Capa.Entidades;
using Capa.Entidades.Cache;
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
    public partial class frmMantenimientoUsuario : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public frmMantenimientoUsuario()
        {
            InitializeComponent();
        }

        private void VerificarTipoUsuario()
        {

        }

        /// <summary>
        /// Método que llena el dgv con los Usuarios de la base de datos y el comboBox con los países y tipos de usuario
        /// </summary>
        private void CargarDatos()
        {
            try
            {
                dgvDatosUsuario.AutoGenerateColumns = false;
                dgvDatosUsuario.RowTemplate.Height = 100;
                dgvDatosUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                IUsuarioLN logica = new UsuarioLN();
                dgvDatosUsuario.DataSource = logica.ObtenerUsuarios();

                IGeneroLN logicaPais = new GeneroLN();
                cmbGenero.DataSource = logicaPais.ObtenerGenero();
                cmbGenero.DisplayMember = "Descripcion";
                cmbGenero.ValueMember = "Id";
                cmbGenero.SelectedIndex = -1;

                ITipoUsuarioLN logicaTipoUsuario = new TipoUsuarioLN();
                cmbTipoUsuario.DataSource = logicaTipoUsuario.ObtenerTodos();
                cmbTipoUsuario.DisplayMember = "Descripcion";
                cmbTipoUsuario.ValueMember = "Id";
                cmbTipoUsuario.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _MyLogControlEventos.Error(ex.Message);

            }
        }

        private void frmMantenimientoUsuario_Load(object sender, EventArgs e)
        {
            CargarDatos();
            VerificarTipoUsuario();
        }

        private void CambiarEstado(EstadoMantenimiento estado)
        {
            mskId.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            mskTelefono.Clear();
            cmbGenero.SelectedIndex = -1;
            dtpFechaNacimiento.ResetText();
            cmbTipoUsuario.SelectedIndex = -1;
            txtContrasena.Clear();
            txtConfirmarContra.Clear();
            txtPeso.Clear();
            mskAltura.Clear();

            mskId.Enabled = false;
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtCorreo.Enabled = false;
            mskTelefono.Enabled = false;
            cmbGenero.Enabled = false;
            dtpFechaNacimiento.Enabled = false;
            cmbTipoUsuario.Enabled = false;
            txtContrasena.Enabled = false;
            txtConfirmarContra.Enabled = false;

            // Colocar la imagen de usuario por defecto
            this.pbFotoUsuario.Image = Capa.UI.Properties.Resources.icons8_user_120px_1;

            switch (estado)
            {
                case EstadoMantenimiento.Nuevo:
                    mskId.Enabled = true;
                    txtNombre.Enabled = true;
                    txtApellidos.Enabled = true;
                    txtCorreo.Enabled = true;
                    mskTelefono.Enabled = true;
                    cmbGenero.Enabled = true;
                    dtpFechaNacimiento.Enabled = true;
                    cmbTipoUsuario.Enabled = true;
                    txtContrasena.Enabled = true;
                    txtConfirmarContra.Enabled = true;

                    mskId.Focus();
                    break;

                case EstadoMantenimiento.Editar:
                    mskId.Enabled = true;
                    txtNombre.Enabled = true;
                    txtApellidos.Enabled = true;
                    txtCorreo.Enabled = true;
                    mskTelefono.Enabled = true;
                    cmbGenero.Enabled = true;
                    dtpFechaNacimiento.Enabled = true;
                    cmbTipoUsuario.Enabled = true;
                    txtContrasena.Enabled = true;
                    txtConfirmarContra.Enabled = true;
                    mskId.Focus();
                    break;

                case EstadoMantenimiento.Borrar:
                    break;

                case EstadoMantenimiento.Ninguno:
                    break;
            }
        }

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

        private void toolStripBtnEditar_Click(object sender, EventArgs e)
        {
            Usuario oUsuario = null;
            try
            {
                if (this.dgvDatosUsuario.SelectedRows.Count > 0)
                {
                    // Cambiar de estado
                    this.CambiarEstado(EstadoMantenimiento.Editar);
                    //Extraer el DTO seleccionado
                    oUsuario = this.dgvDatosUsuario.SelectedRows[0].DataBoundItem as Usuario;

                    this.mskId.Text = oUsuario.Id.ToString();
                    this.txtNombre.Text = oUsuario.Nombre.ToString();
                    this.txtApellidos.Text = oUsuario.Apellidos.ToString();
                    this.txtCorreo.Text = oUsuario.Correo.ToString();
                    this.mskTelefono.Text = oUsuario.Telefono.ToString();
                    this.dtpFechaNacimiento.Value = oUsuario.FechaNacimiento;
                    mskAltura.Text = oUsuario.Altura.ToString();
                    txtPeso.Text = oUsuario.Peso.ToString();
                    this.txtContrasena.Text = oUsuario.Contrasenna;
                    this.txtConfirmarContra.Text = oUsuario.Contrasenna;
                    this.pbFotoUsuario.Image = new Bitmap(new MemoryStream(oUsuario.Imagen));
                    this.pbFotoUsuario.Tag = oUsuario.Imagen;
                    pbFotoUsuario.Tag = oUsuario.Imagen;
                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }

        private void toolStripBtnEliminar_Click(object sender, EventArgs e)
        {
            UsuarioLN logica = new UsuarioLN();

            try
            {
                if (this.dgvDatosUsuario.SelectedRows.Count > 0)
                {
                    this.CambiarEstado(EstadoMantenimiento.Borrar);

                    Usuario oUsuario = this.dgvDatosUsuario.SelectedRows[0].DataBoundItem as Usuario;
                    if (MessageBox.Show($"¿Seguro que desea borrar el registro {oUsuario.Id} {oUsuario.Nombre}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        logica.Eliminar(oUsuario.Id);
                        this.CargarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int resultado = 0;
           
            ErrorProvider oErrorProvider = new ErrorProvider();

            if (this.pbFotoUsuario.Tag == null)
            {
                MessageBox.Show("La Imagen  es un dato requerido !", "Atención");
                return;
            }

            if (!mskId.MaskFull)
            {
                oErrorProvider.SetError(mskId, "El id debe de tener 9 dígitos");
                return;
            }
            if (txtNombre.Text == "")
            {
                oErrorProvider.SetError(txtNombre, "Debe digitar su nombre");
                return;
            }
            if (cmbTipoUsuario.SelectedIndex == 2)
            {
                if (!int.TryParse(txtPeso.Text, out resultado))
            {
                oErrorProvider.SetError(txtPeso, "El peso debe ser numérico");
                return;
            }
            
                if (txtCorreo.Text == "")
                {
                    oErrorProvider.SetError(txtCorreo, "Debe digitar su email");
                    return;
                }
                if (!mskTelefono.MaskFull)
                {
                    oErrorProvider.SetError(mskTelefono, "El número telefónico debe tener 8 dígitos");
                    return;
                }
                if (cmbGenero.SelectedItem == null)
                {
                    oErrorProvider.SetError(cmbGenero, "Debe de seleccionar género");
                    return;
                }
                if (!mskAltura.MaskFull)
                {
                    oErrorProvider.SetError(mskAltura, "Digite correctamente su altura");
                    return;
                }
              
            }
            if (txtContrasena.Text == "")
            {
                oErrorProvider.SetError(txtContrasena, "Digite su contraseña");
                return;
            }
            if (txtConfirmarContra.Text == "")
            {
                oErrorProvider.SetError(mskTelefono, "Confirme su contraseña");
                return;
            }
            if (txtContrasena.Text.Length < 8)
            {
                MessageBox.Show("Su contraseña debe de contener 8 dígitos o más");
                return;
            }
            if (!txtContrasena.Text.Equals(txtConfirmarContra.Text))
            {
                MessageBox.Show("Las contraseñas no coindiden. Inténtelo de nuevo");
                return;
            }
            try
            {
                Usuario user = new Usuario();
                if (cmbTipoUsuario.SelectedIndex == 0 || cmbTipoUsuario.SelectedIndex == 1)
                {
                    user.Id = mskId.Text;
                    user.Nombre = txtNombre.Text;
                    user.Apellidos = txtApellidos.Text;
                    user.Correo = txtNombre.Text + "@gmail.com";
                    user.Telefono = 0;
                    user.IdGenero = 3;
                    user.IdTipoUsuario = (int)cmbTipoUsuario.SelectedValue;
                    user.FechaNacimiento = new DateTime(2008, 5, 1, 8, 30, 52);
                    user.Contrasenna = txtContrasena.Text;
                    user.Imagen = (byte[])pbFotoUsuario.Tag;
                    user.Peso = 0;
                    user.Altura = 0;
                }
                else
                {
                    user.Id = mskId.Text;
                    user.Nombre = txtNombre.Text;
                    user.Apellidos = txtApellidos.Text;
                    user.Correo = txtCorreo.Text;
                    user.Telefono = int.Parse(mskTelefono.Text);
                    user.IdGenero = (int)cmbGenero.SelectedValue;
                    user.IdTipoUsuario = (int)cmbTipoUsuario.SelectedValue;
                    user.FechaNacimiento = dtpFechaNacimiento.Value;
                    user.Contrasenna = txtContrasena.Text;
                    user.Imagen = (byte[])pbFotoUsuario.Tag;
                    user.Peso = Double.Parse(txtPeso.Text);
                    user.Altura = Double.Parse(mskAltura.Text);
                    user.CalculaIMC();
                    user.CalculaMetabolismo();
                }

                

                

                //if (cmbGenero.SelectedItem == null)
                //{
                //    oErrorProvider.SetError(, "Escoja un tipo de usuario");
                //    return;
                //}
                IUsuarioLN logica = new UsuarioLN();
                logica.Guardar(user);
                CargarDatos();
                CambiarEstado(EstadoMantenimiento.Ninguno);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }

        private void pbFotoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                pbFotoUsuario.Image = null;
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
                    this.pbFotoUsuario.ImageLocation = opt.FileName;
                    pbFotoUsuario.SizeMode = PictureBoxSizeMode.StretchImage;

                    byte[] cadenaBytes = File.ReadAllBytes(opt.FileName);

                    // Guarla la imagenen Bytes en el Tag de la imagen.
                    pbFotoUsuario.Tag = (byte[])cadenaBytes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }

        private void cmbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e) {
            lblCorreo.Visible = true;
            txtCorreo.Visible = true;
            lblTelefono.Visible = true;
            mskTelefono.Visible = true;
            lblGenero.Visible = true;
            cmbGenero.Visible = true;
            lblFechaNacimiento.Visible = true;
            dtpFechaNacimiento.Visible = true;
            //lblTipoUsuario.Visible = false;
            //cmbTipoUsuario.Visible = false;
            lblContrasena.Visible = true;
            txtContrasena.Visible = true;
            lblConfirmarContra.Visible = true;
            txtConfirmarContra.Visible = true;
            lblPeso.Visible = true;
            txtPeso.Visible = true;
            lblAltura.Visible = true;
            mskAltura.Visible = true;



            if (cmbTipoUsuario.SelectedIndex == 0 || (int)cmbTipoUsuario.SelectedIndex == 1)
            {
                lblCorreo.Visible = false;
                txtCorreo.Visible = false;
                lblTelefono.Visible = false;
                mskTelefono.Visible = false;
                lblGenero.Visible = false;
                cmbGenero.Visible = false;
                lblFechaNacimiento.Visible = false;
                dtpFechaNacimiento.Visible = false;
                //lblTipoUsuario.Visible = false;
                //cmbTipoUsuario.Visible = false;
                //lblContrasena.Visible = false;
                //txtContrasena.Visible = false;
                //lblConfirmarContra.Visible = false;
                //txtConfirmarContra.Visible = false;
                lblPeso.Visible = false;
                txtPeso.Visible = false;
                lblAltura.Visible = false;
                mskAltura.Visible = false;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CambiarEstado(EstadoMantenimiento.Ninguno);
        }
    }
}
