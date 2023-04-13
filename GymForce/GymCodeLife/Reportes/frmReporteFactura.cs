using capa.Entidades;
using Capa.Entidades;
using Capa.Interfaces;
using Capa.Logica.BLL;
using log4net;
using Microsoft.Reporting.WinForms;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.UI.Reportes
{
    public partial class frmReporteFactura : Form
    {

        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
         int _IdFactura = 0;
        public frmReporteFactura(int idFactura)
        {
            InitializeComponent();
            _IdFactura = idFactura;
        }

        private void frmReporteFactura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DsReportes.Factura' table. You can move, or remove it, as needed.
            this.FacturaTableAdapter.Fill(this.DsReportes.Factura, _IdFactura);
            string ruta = @"file:///" + @"C:/TEMP/qr.png";
            // Habilitar imagenes externas
            this.rptVisor.LocalReport.EnableExternalImages = true;
            ReportParameter param = new ReportParameter("quickresponse", ruta);
            this.rptVisor.LocalReport.SetParameters(param);
            this.rptVisor.RefreshReport();

        }

        private async  void toolStripBtnEnviarEmail_Click(object sender, EventArgs e)
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
            
                

                MessageBox.Show(await EnviarFacturaAsync());
            }

            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido el siguiente error: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error(ex.Message);
            }
        }

        public  Task<string> EnviarFacturaAsync()
        {
            return Task.Run(() =>
            {
                Usuario user = null;
                IUsuarioLN logica = new UsuarioLN();
                user = logica.SeleccionarPorId(logica.ObtenerUsuarioIdByIdFac(_IdFactura));

                MailMessage mensaje = new MailMessage();
                mensaje.IsBodyHtml = true;
                mensaje.Subject = "GymForce";
                mensaje.Body = "¡Hola! Esperamos que se encuentre bien. Le adjuntamos su factura de compra";
                mensaje.From = new MailAddress("gymforcecr@hotmail.com");
                mensaje.To.Add(user.Correo);
                SmtpClient smtp = new SmtpClient("smtp.office365.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("gymforcecr@hotmail.com", "proyectoprogra3");
                smtp.EnableSsl = true;
                Attachment attachment = new Attachment(@"c:\temp\reporteFactura.pdf");
                mensaje.Attachments.Add(attachment);
                smtp.Send(mensaje);
                Cursor.Current = Cursors.WaitCursor;
                return "mensaje enviado correctamente";
              
            });
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
