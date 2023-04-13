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
    public partial class frmReporteUsuariosMorosos : Form
    {
        public frmReporteUsuariosMorosos()
        {
            InitializeComponent();
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReporteUsuariosMorosos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DsReportes.usp_SelectUsuariosMorosos' table. You can move, or remove it, as needed.
            this.usp_SelectUsuariosMorososTableAdapter.Fill(this.DsReportes.usp_SelectUsuariosMorosos);

            this.rptVisor.RefreshReport();
        }
    }
}
