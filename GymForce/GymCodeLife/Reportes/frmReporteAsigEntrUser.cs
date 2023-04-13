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
    public partial class frmReporteAsigEntrUser : Form
    {
        private string idUsuario;
        private int idEntrenamiento;
        public frmReporteAsigEntrUser(string idUsuario, int idEntrenamiento)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.idEntrenamiento = idEntrenamiento;
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReporteAsigEntrUser_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'DsReportes.EntrenamientoAsigByIdUserIdEntr' table. You can move, or remove it, as needed.
                this.EntrenamientoAsigByIdUserIdEntrTA.Fill(this.DsReportes.EntrenamientoAsigByIdUserIdEntr, idUsuario, idEntrenamiento);

                this.rptVisor.RefreshReport();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
