using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.UI.Reportes
{
    public partial class frmReporteEntrAsig : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private string idUser = "";
        private string correo = "";
        public frmReporteEntrAsig(string  idUsuario,string correo)
        {
            InitializeComponent();
            idUser = idUsuario;
            this.correo = correo;
        }


        /// <summary>
        /// Método que agrega los parámetros para poder mostrar el reporte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmReporteEntrAsig_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DsReportes.EntrenamientoAsig' table. You can move, or remove it, as needed.
            this.EntrenamientoAsigTableAdapter.Fill(this.DsReportes.EntrenamientoAsig,idUser);

            this.rptVisor.RefreshReport();
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Método que pasa el reporte a pdf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnEnviarEmail_Click(object sender, EventArgs e)
        {
            string ruta = @"c:\temp\reporteFactura.pdf";
            try
            {
                if (!Directory.Exists(@"c:\temp"))
                    Directory.CreateDirectory(@"c:\temp");

                byte[] Bytes = this.rptVisor.LocalReport.Render(format: "PDF", deviceInfo: "");

                using (FileStream stream = new FileStream(ruta, FileMode.Create))
                {
                    stream.Write(Bytes, 0, Bytes.Length);
                }
                EnviarFactura();
                MessageBox.Show("¡Reporte envíado con éxito!");
            }

            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido el siguiente error: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error(ex.Message);
            }
        }


        /// <summary>
        /// Método que envía el correo
        /// </summary>
        public void EnviarFactura()
        {

         

            MailMessage mensaje = new MailMessage();
            mensaje.IsBodyHtml = true;
            mensaje.Subject = "GymForce";
            mensaje.Body = "¡Hola! Esperamos que se encuentre bien. Le adjuntamos su reporte de entrenamiento";
            mensaje.From = new MailAddress("gymforcecr@hotmail.com");
            mensaje.To.Add(correo);
            SmtpClient smtp = new SmtpClient("smtp.office365.com");
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential("gymforcecr@hotmail.com", "proyectoprogra3");
            smtp.EnableSsl = true;
            Attachment attachment = new Attachment(@"c:\temp\reporteFactura.pdf");
            mensaje.Attachments.Add(attachment);
            smtp.Send(mensaje);
        }

    }
}
