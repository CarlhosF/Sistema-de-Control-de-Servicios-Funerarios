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
    public partial class MovimientosGestor : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            _DATOS.DataSource = CacheManager.CLS.ContratosCache.Listar_Contratos_ActivosMoroso();
            dt_movimientos.DataSource = _DATOS.DataSource;
            this.UseWaitCursor = false;
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txb_Filtro.TextLength > 0)
            {
                _DATOS.Filter = "cliente LIKE '%" + txb_Filtro.Text + "%'";
            }
            else
            {
                _DATOS.RemoveFilter();
            }
            dt_movimientos.AutoGenerateColumns = false;
            dt_movimientos.DataSource = _DATOS;
            lb_Registros.Text = (dt_movimientos.Rows.Count).ToString() + " Registros Encontrados";//Alertar cuantos registros han sido encontrados

        }
        public MovimientosGestor()
        {
            InitializeComponent();
        }

        private void MovimientosGestor_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void txb_Filtro_Click(object sender, EventArgs e)
        {

        }

        private void txb_Filtro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dt_movimientos.SelectedRows.Count > 0)
            {
                DataGridViewRow DR = dt_movimientos.SelectedRows[0];
                GUI.Abonos f = new Abonos(DR);
                f.ShowDialog();
                Cargar();
            }
            else
            {
                MessageBox.Show("Seleccione una cuenta");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //reporte de movimientos
            try
            {
                Reporte.GUI.ReporteMovimientos f = new Reporte.GUI.ReporteMovimientos();
                //f.MdiParent = this;
                f.Show();
            }
            catch
            {
            }
        }

        private void btnPagoDia_Click(object sender, EventArgs e)
        {

            //reporte de cliente pago
            try
            {
                Reporte.GUI.ReporteClientePago f = new Reporte.GUI.ReporteClientePago();
                f.Show();
            }
            catch
            {
            }
        }
    }
}
