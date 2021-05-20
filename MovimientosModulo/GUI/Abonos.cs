using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovimientosModulo.GUI
{
    public partial class Abonos : Form
    {
        DataGridViewRow DRContrato;
        int idContrato;
        int idServicio;
        int idTipoContrato;
        DataTable DTcontrato = new DataTable();
        DataTable DTServicio = new DataTable();
        DataTable DTtipoContrato = new DataTable();
        public Abonos( DataGridViewRow DR)
        {
            InitializeComponent();
            DRContrato = DR;
            idContrato= int.Parse(DRContrato.Cells[0].Value.ToString());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GUI.AbonoNuevo f = new AbonoNuevo(idContrato);
            f.ShowDialog();
            Abonos_Load(sender,e);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Abonos_Load(object sender, EventArgs e)
        {
            DTcontrato = CacheManager.CLS.ContratosCache.Traer_Contrato(idContrato);
            idServicio = int.Parse(DTcontrato.Rows[0][3].ToString());
            idTipoContrato= int.Parse(DTcontrato.Rows[0][2].ToString());
            DTServicio = CacheManager.CLS.ServicioCache.Traer_Servicio(idServicio);
            DTtipoContrato = CacheManager.CLS.TipoDeContrato.Traer_TIpoDeConTrato(idTipoContrato);
    
            txbIDContrato.Text = DRContrato.Cells[0].Value.ToString();
            txbExtendido.Text= DRContrato.Cells[1].Value.ToString();
            txbFecha.Text= DRContrato.Cells[2].Value.ToString();
            txbCliente.Text= DRContrato.Cells[3].Value.ToString();
            txbVendedor.Text= DRContrato.Cells[4].Value.ToString();
            txbEstado.Text= DRContrato.Cells[5].Value.ToString();
            txbMonto.Text= DRContrato.Cells[6].Value.ToString();
            txbServicio.Text = DTServicio.Rows[0][1].ToString();
            txbTipoContrato.Text= DTtipoContrato.Rows[0][1].ToString();
            txbAbonado.Text = CacheManager.CLS.MovimientosCache.Total_De_Abonos(idContrato).ToString();
            float monto = float.Parse(txbMonto.Text);
            float Abonado = 0;
            try { Abonado = float.Parse(txbAbonado.Text); }
            catch { }

            txbSaldoPendiente.Text = (monto-Abonado).ToString();

            dt_movimientos.DataSource = CacheManager.CLS.MovimientosCache.Listar_Movimienttos_Para_Credito(idContrato);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dt_movimientos.SelectedRows.Count>0)
            {
                CLS.Movimiento m = new CLS.Movimiento();
                int ide = int.Parse(dt_movimientos.SelectedRows[0].Cells[0].Value.ToString());
                try 
                {
                    if (m.Eliminar(ide)) 
                    {
                        MessageBox.Show("Abono Eliminado");
                        this.Abonos_Load(sender,e);
                    }

                }
                catch 
                {
                    MessageBox.Show("Error al eliminar el registro");
                } 
            } 
            else
            {
                MessageBox.Show("Seleccione un abono");   
            }
        }
    }
}
