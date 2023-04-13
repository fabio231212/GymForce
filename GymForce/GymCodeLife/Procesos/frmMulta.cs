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

namespace Capa.UI.Procesos
{
    public partial class frmMulta : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public Concepto _Concepto { get; private set; } = null;
        private int id;
        public frmMulta(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmMulta_Load(object sender, EventArgs e)
        {
            try
            {
                txtMonto.SelectAll();
                IConceptoLN logicaConcepto = new ConceptoLN();
                _Concepto = logicaConcepto.ObtenerConceptosPorId(id);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
         
        }

        private void toolStripBtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int resultado = 0;
                if (!int.TryParse(txtMonto.Text, out resultado))
                {
                    MessageBox.Show("El id debe ser numérico", "¡Atención!");
                    txtMonto.Focus();
                    return;
                }

                IConceptoLN logicaConcepto = new ConceptoLN();
                logicaConcepto.UpdateConceptoMulta(id, double.Parse(txtMonto.Text));
                _Concepto = logicaConcepto.ObtenerConceptosPorId(id);
                MessageBox.Show("Monto de la multa actualizado correctamente");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error(ex.Message);
            }
          
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
