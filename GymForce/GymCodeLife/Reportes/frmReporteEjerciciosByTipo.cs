using Capa.Entidades;
using Capa.Interfaces;
using Capa.Logica.BLL;
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
    public partial class frmReporteEjerciciosByTipo : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public frmReporteEjerciciosByTipo()
        {
            InitializeComponent();
        }

        private void toolStripBtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
              if(cmbEjercicio.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un tipo de ejercicio");

                }
                this.usp_SelectEjerciciosByTipoTableAdapter.Fill(this.DsReportes.usp_SelectEjerciciosByTipo,(int) cmbEjercicio.SelectedValue);
                this.reportViewer1.RefreshReport();
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

        private void frmReporteEjerciciosByTipo_Load(object sender, EventArgs e)
        {
            try
            {
                ITipoEjercicioLN logica = new TipoEjercicioLN();
                List<TipoEjercicio> lista = logica.ObtenerTodos();
                cmbEjercicio.DataSource = lista;
                cmbEjercicio.DisplayMember = "Nombre";
                cmbEjercicio.ValueMember = "Id";
                cmbEjercicio.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }


            
        }
    }
}
