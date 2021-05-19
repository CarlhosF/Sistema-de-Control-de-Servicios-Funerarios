using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Contratos_Modulo.GUI
{
    public partial class EstablecerSaldo : Form
    {
        BindingSource _DATOSS = new BindingSource();
        BindingSource _DATOSTC = new BindingSource();
        public String servicio { get; set; }
        public String contrato { get; set; }
        public int formadePago { get; set; }
        public float saldo { get; set; }
        GUI.ContratoNuevo VistaPrincipal= new ContratoNuevo();
        public EstablecerSaldo(GUI.ContratoNuevo CN)
        {
            InitializeComponent();
            VistaPrincipal = CN;
        }
       
        private void CargarServicios()
        {
            _DATOSS.DataSource = CacheManager.CLS.ServicioCache.Listar_Servicios();
            dt_Servicios.DataSource = _DATOSS.DataSource;
            this.UseWaitCursor = false;
            FiltrarSevicios();
        }

        private void FiltrarSevicios()
        {
            if (txbFiltroServicio.TextLength > 0)
            {
                _DATOSS.Filter = "nombre LIKE '%" + txbFiltroServicio.Text + "%'";
            }
            else
            {
                _DATOSS.RemoveFilter();
            }
            dt_Servicios.AutoGenerateColumns = false;
            dt_Servicios.DataSource = _DATOSS;
            dt_Servicios.Columns[0].Visible = false;
            

        }
        private void CargarContratos()
        {
            _DATOSTC.DataSource = CacheManager.CLS.TipoDeContrato.Listar_TipoDeContrato();
            dt_TipoContrato.DataSource = _DATOSTC.DataSource;
            this.UseWaitCursor = false;
            FiltrarContratos();
        }

        private void FiltrarContratos()
        {
            if (txbFiltroTipoContr.TextLength > 0)
            {
                _DATOSTC.Filter = "nombre LIKE '%" + txbFiltroTipoContr.Text + "%'";
            }
            else
            {
                _DATOSTC.RemoveFilter();
            }
            dt_TipoContrato.AutoGenerateColumns = false;
            dt_TipoContrato.DataSource = _DATOSTC;
            dt_TipoContrato.Columns[0].Visible = false;

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EstablecerSaldo_Load(object sender, EventArgs e)
        {
            CargarServicios();
            CargarContratos();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            FiltrarContratos();
        }

        private void txbFiltroServicio_Click(object sender, EventArgs e)
        {
            FiltrarSevicios();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dt_Servicios.SelectedRows.Count > 0 && dt_TipoContrato.SelectedRows.Count > 0 && listBox1.SelectedIndex >= 0)
            {
                this.servicio = dt_Servicios.SelectedRows[0].Cells[0].Value.ToString();
                this.contrato = dt_TipoContrato.SelectedRows[0].Cells[0].Value.ToString();
                this.formadePago = listBox1.SelectedIndex;
                if (listBox1.SelectedIndex == 1)
                { this.saldo = float.Parse(dt_Servicios.SelectedRows[0].Cells[2].Value.ToString()) * float.Parse(dt_TipoContrato.SelectedRows[0].Cells[3].Value.ToString()); }
                if (listBox1.SelectedIndex == 0)
                { this.saldo = float.Parse(dt_Servicios.SelectedRows[0].Cells[3].Value.ToString()) * float.Parse(dt_TipoContrato.SelectedRows[0].Cells[3].Value.ToString()); }
                this.formadePago = listBox1.SelectedIndex;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else 
            {
                MessageBox.Show("Rellene los campos para continuar");
            }
        }
    }
}
