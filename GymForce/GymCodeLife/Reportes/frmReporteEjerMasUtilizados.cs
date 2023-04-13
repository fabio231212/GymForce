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
    public partial class frmReporteEjerMasUtilizados : Form
    {
        public frmReporteEjerMasUtilizados()
        {
            InitializeComponent();
        }

        private void frmReporteEjerMasUtilizados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DsReportes.usp_SelectEjerMasUtilizados' table. You can move, or remove it, as needed.
            this.usp_SelectEjerMasUtilizadosTableAdapter.Fill(this.DsReportes.usp_SelectEjerMasUtilizados);

            this.rptVisor.RefreshReport();
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
