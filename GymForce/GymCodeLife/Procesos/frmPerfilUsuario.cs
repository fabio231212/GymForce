using Capa.Entidades;
using Capa.Entidades.Cache;
using Capa.Interfaces;
using Capa.Logica.BLL;
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

namespace Capa.UI.Procesos
{
    public partial class frmPerfilUsuario : Form
    {
        public frmPerfilUsuario()
        {
            InitializeComponent();
        }

        private void frmPerfilUsuario_Load(object sender, EventArgs e)
        {

            IGeneroLN logicaGenero = new GeneroLN();
            mskId.Text = UsuarioCache.Id;
            txtNombre.Text = UsuarioCache.Nombre;
            txtApellidos.Text = UsuarioCache.Apellidos;
            txtCorreo.Text = UsuarioCache.Correo;
            txtAltura.Text = UsuarioCache.Altura.ToString();
            txtPeso.Text = UsuarioCache.Peso.ToString();
            mskTelefono.Text = UsuarioCache.Telefono.ToString();
            txtContrasena.Text = UsuarioCache.Contrasenna;
            txtConfirmarContra.Text = UsuarioCache.Contrasenna;
            this.pbFotoUsuario.Image = new Bitmap(new MemoryStream(UsuarioCache.Imagen));
            this.pbFotoUsuario.Tag = UsuarioCache.Imagen;
            pbFotoUsuario.Tag = UsuarioCache.Imagen;


        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAltura_Click(object sender, EventArgs e)
        {

        }

        private void lblContrasena_Click(object sender, EventArgs e)
        {

        }
    }
}
