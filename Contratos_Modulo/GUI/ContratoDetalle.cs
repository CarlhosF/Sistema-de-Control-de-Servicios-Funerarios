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
    public partial class ContratoDetalle : Form
    {
        DataGridViewRow DRContrato;
        int idContrato;
        int idServicio;
        int idTipoContrato;
        DataTable DTcontrato = new DataTable();
        DataTable DTServicio = new DataTable();
        DataTable DTtipoContrato = new DataTable();

        DataTable Bene1 = new DataTable();
        DataTable Bene2 = new DataTable();
        public ContratoDetalle(DataGridViewRow DR)
        {
            InitializeComponent();
            DRContrato = DR;
            idContrato = int.Parse(DRContrato.Cells[0].Value.ToString());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ContratoDetalle_Load(object sender, EventArgs e)
        {
            DTcontrato = CacheManager.CLS.ContratosCache.Traer_Contrato(idContrato);
            idServicio = int.Parse(DTcontrato.Rows[0][3].ToString());
            idTipoContrato = int.Parse(DTcontrato.Rows[0][2].ToString());
            DTServicio = CacheManager.CLS.ServicioCache.Traer_Servicio(idServicio);
            DTtipoContrato = CacheManager.CLS.TipoDeContrato.Traer_TIpoDeConTrato(idTipoContrato);
            
            txbIDServicio.Text = DTcontrato.Rows[0]["idServicios"].ToString();
            txbIDTipoContrato.Text= DTcontrato.Rows[0]["tipoDeContrato"].ToString();
            txbIDContratista.Text= DTcontrato.Rows[0]["contratista"].ToString();
            txbIDVendedor.Text= DTcontrato.Rows[0]["vendedor"].ToString();
            txbIDBeneficiario1.Text=DTcontrato.Rows[0]["Beneficiario1"].ToString();
            Bene1 = CacheManager.CLS.ClientesCache.Traer_Clientes((int)DTcontrato.Rows[0]["Beneficiario1"]);
            txbIDBeneficiario2.Text= DTcontrato.Rows[0]["Beneficiario2"].ToString();
            Bene2 = CacheManager.CLS.ClientesCache.Traer_Clientes((int)DTcontrato.Rows[0]["Beneficiario2"]);
            txbIDContrato.Text = DRContrato.Cells[0].Value.ToString();
            txbExtendido.Text = DRContrato.Cells[1].Value.ToString();
            txbFecha.Text = DRContrato.Cells[5].Value.ToString();
            txbCliente.Text = DRContrato.Cells[7].Value.ToString();
            txbVendedor.Text = DRContrato.Cells[6].Value.ToString(); 
            txbEstado.Text = DTcontrato.Rows[0]["Estado"].ToString();
            txbMonto.Text = DTcontrato.Rows[0]["Monto"].ToString();
            txbServicio.Text = DTServicio.Rows[0][1].ToString();
            txbTipoContrato.Text = DTtipoContrato.Rows[0][1].ToString();
            txbFormaPago.Text= DRContrato.Cells[4].Value.ToString();
            txbBeneficiario1.Text = Bene1.Rows[0]["nombres"].ToString() + " " + Bene1.Rows[0]["nombres"].ToString();
            txbBeneficiario2.Text = Bene2.Rows[0]["nombres"].ToString() + " " + Bene2.Rows[0]["nombres"].ToString();
            txbObservaciones.Text = DTcontrato.Rows[0]["Observaciones"].ToString();

            if (txbEstado.Text == "Activo" || txbEstado.Text == "Moroso")
            {
                bntVerEntrg.Enabled = false;
                bntImprimir.Enabled = false;
            }
            if (txbFormaPago.Text == "Contado")
            {
                btnVerPagos.Enabled = false;
            }
        }

        private void bntImprimir_Click(object sender, EventArgs e)
        {

            //reporte de cancelaciones
            try
            {
                Reporte.GUI.ReporteCancelaciones f = new Reporte.GUI.ReporteCancelaciones(idContrato);
                f.Show();
            }
            catch
            {
            }
        }

        private void btnVerPagos_Click(object sender, EventArgs e)
        {
            dt_Elementos.DataSource = CacheManager.CLS.MovimientosCache.Listar_Movimienttos_Para_Credito(idContrato);
        }

        private void bntVerEntrg_Click(object sender, EventArgs e)
        {
            dt_Elementos.DataSource = CacheManager.CLS.DifuntosCache.Listar_Difuntos(idContrato);
        }
    }
}
