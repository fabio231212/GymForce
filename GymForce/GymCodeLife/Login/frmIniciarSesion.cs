using Capa.Entidades.Cache;
using Capa.Interfaces;
using Capa.Logica.BLL;
using log4net;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Capa.UI.Login
{
    public partial class frmIniciarSesion : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public frmIniciarSesion()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapure();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        /// <summary>
        /// Método que elimina la palabra correo al entrar al textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Equals("EMAIL"))
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.LightGray;
            }
        }


        /// <summary>
        /// Método que coloca la palabra email si sale del textbox y no coloca nada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "EMAIL";
                txtCorreo.ForeColor = Color.Gainsboro;
            }
        }



        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("CONTRASEÑA"))
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.Gainsboro;
                txtPassword.UseSystemPasswordChar = false;
                pbVisible.BringToFront();
            }
        }

        private void pbVisible_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "CONTRASEÑA")
            {
                txtPassword.UseSystemPasswordChar = false;
                pbOcultar.BringToFront();
            }
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "CONTRASEÑA")
            {
                txtPassword.UseSystemPasswordChar = true;
                pbVisible.BringToFront();
            }
            else
            {
            }
        }
      
        private void frmIniciarSesion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnl1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        /// <summary>
        /// Método que cierra la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("¿Desea cerrar la aplicación?", "Atención", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                try
                {
                    System.Windows.Forms.Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    _MyLogControlEventos.Error(ex.Message);
                }

            }
            else
            {
                if (r == DialogResult.Yes && UsuarioCache.IdTipoUsuario == 1 || r == DialogResult.Yes && UsuarioCache.IdTipoUsuario == 2)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
        }
        /// <summary>
        /// Método que minimiza la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        /// <summary>
        /// Método que valida el login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                IUsuarioLN logica = new UsuarioLN();

                if (txtCorreo.Text == "EMAIL" || txtCorreo.Text == "")
                {
                    MessageBox.Show("Debe de ingresar su correo");
                    txtCorreo.Clear();
                    txtCorreo.Focus(); ;

                    return;
                }
                if (txtPassword.Text == "CONTRASEÑA" || txtPassword.Text == "")
                {
                    MessageBox.Show("Debe de ingresar una contraseña");
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                if (logica.VerificarAcceso(txtCorreo.Text, txtPassword.Text))
                {
                    UsuarioCache.FechaIngreso = DateTime.Now;
                    frmPrincipal frm = new frmPrincipal();
                    frm.Show();
                    this.Hide();
                    frm.FormClosed += VolverInicioDeSesion;
                }
                else
                {
                    MessageBox.Show("Email o contraseña incorrectos");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }

        private void VolverInicioDeSesion(Object sender, FormClosedEventArgs e)
        {
            txtCorreo.Clear();
            txtPassword.Clear();
            txtCorreo.Text = "EMAIL";
            txtPassword.Text = "CONTRASEÑA";
            txtPassword.UseSystemPasswordChar = false;
            this.Show();
        }


        /// <summary>
        /// Método que abre el frame para registrarse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCrearCuenta frmCrearCuenta = new frmCrearCuenta();
            frmCrearCuenta.Show();
            this.Hide();
            frmCrearCuenta.FormClosed += VolverInicioDeSesion;
        }
    }
}