using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntregasModulo.GUI
{
    public partial class EntregasDetalles : Form
    {

        DataGridViewRow DRContrato;
        static int idContrato;
        int idServicio;
        int idTipoContrato;
        DataTable DTcontrato = new DataTable();
        DataTable DTServicio = new DataTable();
        DataTable DTtipoContrato = new DataTable();
        public EntregasDetalles(DataGridViewRow DR)
        {
            InitializeComponent();

            DRContrato = DR;
            idContrato = int.Parse(DRContrato.Cells[0].Value.ToString());
            DTcontrato = CacheManager.CLS.ContratosCache.Traer_Contrato(idContrato);
            idServicio = int.Parse(DTcontrato.Rows[0][3].ToString());
            idTipoContrato = int.Parse(DTcontrato.Rows[0][2].ToString());
            txbIDContrato.Text = idContrato.ToString();
            txbExtendido.Text = DRContrato.Cells[1].Value.ToString();
            txbFecha.Text = DRContrato.Cells[2].Value.ToString();
            txbCliente.Text = DRContrato.Cells[3].Value.ToString();
            txbVendedor.Text = DRContrato.Cells[4].Value.ToString();
            txbTratamiento.Text = DRContrato.Cells[7].Value.ToString();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.Parse(txbTratamientos.Text)>0) 
            {
                GUI.EntregaNueva f = new EntregaNueva(idContrato);
                f.ShowDialog();
                this.EntregasDetalles_Load(sender, e);
            }
            else 
            {
                MessageBox.Show("Este contrato ha alcanzado su limite de entregas");
            }
        }

        private void EntregasDetalles_Load(object sender, EventArgs e)
        {

            DTServicio = CacheManager.CLS.ServicioCache.Traer_Servicio(idServicio);
            DTtipoContrato = CacheManager.CLS.TipoDeContrato.Traer_TIpoDeConTrato(idTipoContrato);
            txbTratamientos.Text = CacheManager.CLS.DifuntosCache.Traer_Entregas_Disponibles(idContrato).ToString();
            txbServicio.Text = DTServicio.Rows[0][1].ToString();
            txbTipoContrato.Text = DTtipoContrato.Rows[0][1].ToString();
            txbEstado.Text = DTcontrato.Rows[0][8].ToString();
            if(int.Parse(txbTratamientos.Text)==0) 
            {
                btnEntregar.Enabled = true;
            }
            else
            {
                btnEntregar.Enabled = false;
            }
            dt_difuntos.DataSource = CacheManager.CLS.DifuntosCache.Listar_Difuntos(idContrato);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dt_difuntos.SelectedRows.Count>0)
            {
                int i = (int)dt_difuntos.SelectedRows[0].Cells[0].Value;
                GUI.EntregaEditor f = new EntregaEditor(i);
                f.ShowDialog();
                EntregasDetalles_Load(sender, e);
            }
            else 
            {
                MessageBox.Show("Seleccione una entrega");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dt_difuntos.SelectedRows.Count > 0)
            {
                int i = (int)dt_difuntos.SelectedRows[0].Cells[0].Value;
                CLS.difunto d = new CLS.difunto();
                if (d.Eliminar(i)) 
                {
                    MessageBox.Show("Registro eliminado");
                    this.EntregasDetalles_Load(sender,e);
                }
                else
                {
                    MessageBox.Show("Este registro no pudo eliminarse");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una entrega");
            }
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            Contratos_Modulo.CLS.Contrato c = new Contratos_Modulo.CLS.Contrato();
            c.ActualizarEstado(idContrato,"Entregado");
            MessageBox.Show("Contrato Entregado");
            this.Close();
        }
    }
}
