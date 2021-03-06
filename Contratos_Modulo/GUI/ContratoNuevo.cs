using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contratos_Modulo.GUI
{
    public partial class ContratoNuevo : Form
    {
        CLS.Contrato contrato = new CLS.Contrato();

        public ContratoNuevo()
        {
            InitializeComponent();
        }
        public ContratoNuevo(CLS.Contrato c)
        {
            InitializeComponent();
            contrato = c;
        }

        private void ContratoNuevo_Load(object sender, EventArgs e)
        {
            SesionManager.CLS.Sesion se = SesionManager.CLS.Sesion.Instancia;
            txbVendedor.Text = se.Empleado;
            txbIDVendedor.Text = se.IDUsuario;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEstablecerSaldo_Click(object sender, EventArgs e)
        {
            GUI.EstablecerSaldo ES = new EstablecerSaldo(this);
            using (var form = new EstablecerSaldo(this))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txbIDServicios.Text = form.servicio;
                    txbIDTipoContrato.Text = form.contrato;
                    txbSaldo.Text = form.saldo.ToString();
                    listBox1.SelectedIndex = form.formadePago;
                    DataTable  DTS = CacheManager.CLS.ServicioCache.Traer_Servicio(int.Parse(txbIDServicios.Text));
                    DataTable DTTC = CacheManager.CLS.TipoDeContrato.Traer_TIpoDeConTrato(int.Parse(txbIDTipoContrato.Text));
                    txbServicio.Text = DTS.Rows[0]["nombre"].ToString();
                    txbTipoContrato.Text =DTTC.Rows[0]["nombre"].ToString();
                }
            }
        }

        private void btnEstablecerContratista_Click(object sender, EventArgs e)
        {
            using (var form = new EstablecerContratista())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txbIDContratista.Text = form.id.ToString();
                    DataTable DT = CacheManager.CLS.ClientesCache.Traer_Clientes(form.id);
                    txbContratista.Text = DT.Rows[0]["nombres"].ToString()+" "+ DT.Rows[0]["apellidos"].ToString();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var form = new EstablecerContratista())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txbIDBeneficiario1.Text = form.id.ToString();
                    DataTable DT1 = CacheManager.CLS.ClientesCache.Traer_Clientes(form.id);
                    txbBene1.Text = DT1.Rows[0]["nombres"].ToString() + " " + DT1.Rows[0]["apellidos"].ToString();
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txbIDContratista.Text != txbIDBeneficiario1.Text && txbIDBeneficiario1.Text != txbIDBeneficiario2.Text && txbIDBeneficiario2.Text != txbIDContratista.Text)
            {
                if (txbSaldo.Text.Length > 0 && txbContratista.Text.Length > 0 && txbExtendido.Text.Length > 0)
                {
                    try
                    {
                        contrato.Extendido = txbExtendido.Text;
                        contrato.IdServicio = int.Parse(txbIDServicios.Text);
                        contrato.IdTipoDeContrato = int.Parse(txbIDTipoContrato.Text);
                        contrato.FormaDePago = listBox1.SelectedItem.ToString();
                        contrato.Fecha = dtp_fecha.Value;
                        contrato.Idvendedor = int.Parse(txbIDVendedor.Text);
                        contrato.Contratista = int.Parse(txbIDContratista.Text);
                        contrato.Saldo = float.Parse(txbSaldo.Text);
                        contrato.Beneficiario1 = int.Parse(txbIDBeneficiario1.Text);
                        contrato.Beneficiario2 = int.Parse(txbIDBeneficiario2.Text);
                        contrato.Observaciones = txbObservaciones.Text;
                        if (contrato.FormaDePago == "Contado") { contrato.Estado = "Cancelado"; }
                        if (contrato.Guardar())
                        {
                            MessageBox.Show("Registro añadido");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se puede añadir este registro");
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Error al añadir, pruebe rellenar todos los campos");
                    }
                }
                else
                {
                    MessageBox.Show("Rellene los campos antes de aceptar");
                }
            }
            else 
            {
                MessageBox.Show("El contratista como los dos beneficiarios de");
            }
        }

        private void bntBene2_Click(object sender, EventArgs e)
        {
            using (var form = new EstablecerContratista())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txbIDBeneficiario2.Text = form.id.ToString();
                    DataTable DT1 = CacheManager.CLS.ClientesCache.Traer_Clientes(form.id);
                    txbBene2.Text = DT1.Rows[0]["nombres"].ToString() + " " + DT1.Rows[0]["apellidos"].ToString();

                }
            }
        }
    }
}
