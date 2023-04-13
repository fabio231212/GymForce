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

namespace Capa.UI.Reportes
{
    public partial class frmReporteFacturaByFecha : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public frmReporteFacturaByFecha()
        {
            InitializeComponent();
        }

        private void frmFacturaByFecha_Load(object sender, EventArgs e)
        {
        }

        private void toolStripBtnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                this.usp_SelectFacturaByFechasTableAdapter.Fill(this.DsReportes.usp_SelectFacturaByFechas, new DateTime(dtpDesde.Value.Year,
                    dtpDesde.Value.Month, dtpDesde.Value.Day, 0, 0, 0), new DateTime(dtpHasta.Value.Year,
                                                   dtpHasta.Value.Month, dtpHasta.Value.Day, 23, 59, 59));

                this.rptVisor.RefreshReport();
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
    }
}
