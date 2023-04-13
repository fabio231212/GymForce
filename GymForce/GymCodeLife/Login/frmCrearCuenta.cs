using capa.Entidades;
using Capa.Entidades;
using Capa.Interfaces;
using Capa.Logica;
using Capa.Logica.BLL;
using log4net;
using System;
using System.IO;
using System.Windows.Forms;

namespace Capa.UI
{
    public partial class frmCrearCuenta : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public frmCrearCuenta()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que cierra este form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Método que carga el combobox de países con los países obtenidos de la base de datos por medio de la
        /// instancia creada de PaisLN
        /// </summary>
        private void CargarPaises()
        {
            IGeneroLN logicaPais = new GeneroLN();
            cmbGénero.DataSource = logicaPais.ObtenerGenero() ;
            cmbGénero.DisplayMember = "Descripcion";
            cmbGénero.ValueMember = "Id";
        }

 

        private void lnkTienesCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Método que ejecuta al método de cargar países
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCrearCuenta_Load_1(object sender, EventArgs e)
        {
            CargarPaises();
        }


        /// <summary>
        /// Método para seleccionar la imagen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error(ex.Message);
            }
        }


        /// <summary>
        /// Método que hace visible los datos ingresados de contraseñas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbVisible_Click(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = false;
            txtConfirmarContra.UseSystemPasswordChar = false;
            pbOcultar.BringToFront();
        }

        /// <summary>
        /// Método que oculta los datos de los txt de contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbOcultar_Click(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = true;
            txtConfirmarContra.UseSystemPasswordChar = true;
            pbVisible.BringToFront();
        }

        /// <summary>
        /// Método que obtiene todos los datos ingresados y con estos crea una instancia de la clase Usuario y con
        /// otra instancia de UsuarioLN la guarda en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            erpError.Clear();


            if (!mskId.MaskFull)
            {
                erpError.SetError(mskId, "El id debe de tener 9 dígitos");
                return;
            }
            if (txtNombre.Text == "")
            {
                erpError.SetError(txtNombre, "Debe digitar su nombre");
                return;
            }
            if (txtApellidos.Text == "")
            {
                erpError.SetError(txtApellidos, "Debe digitar sus apellidos");
                return;
            }
            if (txtCorreo.Text == "")
            {
                erpError.SetError(txtCorreo, "Debe digitar su email");
                return;
            }
            if (!mskTelefono.MaskFull)
            {
                erpError.SetError(mskTelefono, "El número telefónico debe tener 8 dígitos");
                return;
            }
            if (cmbGénero.SelectedItem == null)
            {
                erpError.SetError(cmbGénero, "Debe seleccionar su país de residencia");
                return;
            }
            if (mskAltura.Text == "")
            {
                erpError.SetError(mskAltura, "Debe digitar su altura");
                return;
            }
            if (txtPeso.Text == "")
            {
                erpError.SetError(txtPeso, "Debe digitar su Peso");
                return;
            }
            if (txtContrasena.Text == "")
            {
                erpError.SetError(txtContrasena, "Digite su contraseña");
                return;
            }
            if (txtConfirmarContra.Text == "")
            {
                erpError.SetError(txtConfirmarContra, "Confirme su contraseña");
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
            if (this.pbFotoUsuario.Tag == null)
            {
                MessageBox.Show("La Imagen  es un dato requerido !", "Atención");
                return;
            }
            try
            {


                Usuario user = new Usuario
                {
                    Id = mskId.Text,
                    Nombre = txtNombre.Text,
                    Apellidos = txtApellidos.Text,
                    Correo = txtCorreo.Text,
                    Telefono = int.Parse(mskTelefono.Text),
                    IdGenero = (int)cmbGénero.SelectedValue,
                    IdTipoUsuario = 3,
                    FechaNacimiento = dtpFechaNacimiento.Value,
                    Contrasenna = txtContrasena.Text,
                    Imagen = (byte[])pbFotoUsuario.Tag,
                    Altura = double.Parse(mskAltura.Text),
                    Peso = double.Parse(txtPeso.Text),
                    
                    

                };
                user.CalculaIMC();
                user.CalculaMetabolismo();

                IUsuarioLN logica = new UsuarioLN();
                logica.Guardar(user);
                MessageBox.Show("¡Bienvenido, inicie sesión para disfrutar todas las opciones que ofrecemos!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
    }
}