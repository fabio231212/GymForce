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
    public partial class frmReporteEjercByIdUser : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public frmReporteEjercByIdUser()
        {
            InitializeComponent();
        }

        private void frmReporteEjercByIdUser_Load(object sender, EventArgs e)
        {
       
        }

        private void toolStripTxtId_Enter(object sender, EventArgs e)
        {
            if (toolStripTxtId.Text.Equals("Identificación"))
            {
                toolStripTxtId.Text = "";
                toolStripTxtId.ForeColor = Color.White;
            }
        }

        private void toolStripTxtId_Leave(object sender, EventArgs e)
        {
            if (toolStripTxtId.Text == "")
            {
                toolStripTxtId.Text = "Identificación";
                toolStripTxtId.ForeColor = Color.White;
            }
        }

        private void toolStripBtnBuscar_Click(object sender, EventArgs e)
        {
            if (toolStripTxtId.Text == "" || toolStripTxtId.Text == "Identificación")
            {
                MessageBox.Show("Debe digitar la identificación");
                return;
            }
            try
            {
                this.usp_SelectEntreEjerByUsuarioTableAdapter.Fill(this.DsReportes.usp_SelectEntreEjerByUsuario,toolStripTxtId.Text.Trim());

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
