using capa.Entidades;
using Capa.Entidades;
using Capa.Interfaces;
using Capa.Logica.BLL;
using Capa.UI.Filtro;
using Capa.UI.Reportes;
using Capa.UI.Util;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.UI.Procesos
{
    public partial class frmFacturacion : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private EncFactura _EncFactura = new EncFactura();
        double valorDolar = 0;
        //Concepto concepto = new Concepto();
        //IConceptoLN logicaConcepto = new ConceptoLN();
        public frmFacturacion()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            this.dgvCarrito.DefaultCellStyle.ForeColor = Color.Blue;   
           
        }

        private void CargarTarjetas()
        {
            ITarjetaLN logica = new TarjetaLN();
            try
            {
                cmbTarjetas.DataSource = logica.SeleccionarTodas();
                cmbTarjetas.DisplayMember = "Nombre";
                cmbTarjetas.ValueMember = "Id";
                cmbTarjetas.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            
            try
            {
                Utilitarios.CultureInfo();
                valorDolar = Utilitarios.ConsumoDolar();
                IFacturaLN logicaFactura = new FacturaLN();
                this.txtIdFactura.Text = logicaFactura.GetCurrentNumeroFactura().ToString();
                CargarTarjetas();
                CargarDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmMulta frm = null;
            if (txtNombreConcepto.Text == "" || txtIdConcepto.Text == ""  || txtPrecioConcepto.Text == "")
            {
                MessageBox.Show("Seleccione el concepto");
                return;
            }
            IFacturaLN datosFactura = new FacturaLN();
            IConceptoLN conceptoLN = new ConceptoLN();
           
            DetFactura detFactura = new DetFactura();

            try
            {

                if (_EncFactura == null)
                {
                    MessageBox.Show("Debe agregar los datos del encabezado de la factura para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (_EncFactura._ListaFacturaDetalle.FindAll(p => p.IdConcepto == int.Parse(txtIdConcepto.Text)).Count > 0)
                {
                    MessageBox.Show("El concepto ya fue agregado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(int.Parse(txtIdConcepto.Text) == 1) //si es multa
                {
                    frm = new frmMulta(int.Parse( txtIdConcepto.Text));
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        txtIdConcepto.Text = frm._Concepto.Id.ToString();
                        txtPrecioConcepto.Text = frm._Concepto.Precio.ToString();                   
                    }
                }
                detFactura.Secuencia = _EncFactura._ListaFacturaDetalle.Count == 0 ? 1 : _EncFactura._ListaFacturaDetalle.Max(p => p.Secuencia) + 1;
                detFactura.IdFactura = _EncFactura.IdFactura;
                detFactura.IdConcepto = int.Parse(txtIdConcepto.Text);
                detFactura.Impuesto = 0.13;
                detFactura._Concepto = conceptoLN.ObtenerConceptosPorId(detFactura.IdConcepto);

            
                        //this.concepto = dgvDatos.SelectedRows[0].DataBoundItem as Concepto;
                        string[] lineaConcepto = {detFactura.Secuencia.ToString(),
                                         this.txtIdConcepto.Text,
                                         this.txtNombreConcepto.Text,
                                         detFactura._Concepto.Descripcion,
                                         this.txtPrecioConcepto.Text,
                                         
                                         };
                    dgvCarrito.Rows.Add(lineaConcepto);


                   


                    _EncFactura.AddDetalle(detFactura);


                    txtSubTotal.Text = "$" + _EncFactura.getSubtotal().ToString();
                    txtImpuesto.Text = "$" + _EncFactura.getImpuesto().ToString();
                    this.txtTotal.Text = "$" + _EncFactura.getTotal().ToString();
                    txtTotalColones.Text = "₡" + (_EncFactura.getTotal() * valorDolar).ToString("N2");

              
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    _MyLogControlEventos.Error(ex.Message);
                }

        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Usuario user = null;
            frmFiltroUsuario frm = new frmFiltroUsuario();

            try
            {
                erpError.Clear();
                if (cmbTarjetas.SelectedIndex == -1)
                {
                    erpError.SetError(cmbTarjetas, "Debe indicar el tipo de tarjeta");
                    return;
                }
                if (string.IsNullOrEmpty(this.txtNumTarjeta.Text))
                {
                    erpError.SetError(txtNumTarjeta, "Debe digitar su número de tarjeta");
                    return;
                }
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    user = frm._User;
                    txtId.Text = user.Id.ToString();
                    txtNombre.Text = user.Nombre;
                  
                }

                _EncFactura.IdFactura = int.Parse(txtIdFactura.Text);
         
                _EncFactura.IdTarjeta = (int)cmbTarjetas.SelectedValue;
                //_EncFactura.IdUsuario = UsuarioCache.Id;
                _EncFactura.IdUsuario = txtId.Text;
                _EncFactura.NumeroTarjeta = int.Parse(txtNumTarjeta.Text);
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

        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {
            IFacturaLN facturaLN = new FacturaLN();

            try
            {
                txtNumTarjeta.Clear();
                cmbTarjetas.SelectedIndex = -1;
                txtId.Clear();
                txtNombre.Clear();
                txtSubTotal.Clear();
                txtImpuesto.Clear();
                txtTotal.Clear();
                txtTotalColones.Clear();
                _EncFactura = new EncFactura();
                this.dgvCarrito.Rows.Clear();
             

               
                // Mostar Numero de factura
                this.txtIdFactura.Text = facturaLN.GetNextNumeroFactura().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }

        private void btnBuscarConcepto_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "" || txtId.Text == "")
            {
                MessageBox.Show("Seleccione el usuario");
                return;
            }
            Concepto concepto = null;
            try
            {
                frmFiltroConcepto frm = new frmFiltroConcepto();

                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    concepto = frm._Concepto;
                    txtIdConcepto.Text = concepto.Id.ToString();
                    txtNombreConcepto.Text = concepto.Nombre;
                    txtPrecioConcepto.Text = concepto.Precio.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }

        private void toolStripBtnFacturar_Click(object sender, EventArgs e)
        {

            IFacturaLN logica = new FacturaLN();
            string rutaImagen = @"c:\temp\qr.png";
            int numeroFactura = 0;
            try
            {
                if (_EncFactura == null)
                {
                    MessageBox.Show("No hay datos por facturar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (_EncFactura._ListaFacturaDetalle.Count == 0)
                {
                    MessageBox.Show("No hay items en la factura ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _EncFactura.FechaFacturacion = DateTime.Now;
                _EncFactura.ProximoPago = _EncFactura.FechaFacturacion.AddMonths(1);
                logica.Guardar(_EncFactura);

                numeroFactura = _EncFactura.IdFactura;

                if (_EncFactura == null)
                    MessageBox.Show("Error al crear factura!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    toolStripBtnNuevo_Click(null, null);

                //Si existe borrelo
                if (File.Exists(rutaImagen))
                    File.Delete(rutaImagen);

                // Crear imagen quickresponse
                Image quickResponseImage = QuickResponse.QuickResponseGenerador(numeroFactura.ToString(), 53);

                // Salvarla en c:\temp para luego ser leida
                quickResponseImage.Save(rutaImagen, ImageFormat.Png);

                frmReporteFactura ofrmReporteFactura = new frmReporteFactura(numeroFactura);
                ofrmReporteFactura.ShowDialog();
                _EncFactura = new EncFactura();
            }
            catch (Exception er)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error(er.Message);
            }
        }
    }
}
