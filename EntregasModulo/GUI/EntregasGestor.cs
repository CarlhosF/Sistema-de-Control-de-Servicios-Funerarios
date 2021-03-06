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
    public partial class EntregasGestor : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            _DATOS.DataSource = CacheManager.CLS.ContratosCache.Listar_Contratos_Cancelados();
            dt_movimientos.DataSource = _DATOS.DataSource;
            this.UseWaitCursor = false;
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txb_Filtro.TextLength > 0)
            {
                _DATOS.Filter = "ID LIKE '%" + txb_Filtro.Text + "%' or extendido LIKE '%" + txb_Filtro.Text + "%'";
            }
            else
            {
                _DATOS.RemoveFilter();
            }
            dt_movimientos.AutoGenerateColumns = false;
            dt_movimientos.DataSource = _DATOS;
            lb_Registros.Text = (dt_movimientos.Rows.Count).ToString() + " Registros Encontrados";//Alertar cuantos registros han sido encontrados
            dt_movimientos.Columns[0].Width = 20;
            dt_movimientos.Columns[2].Width = 50;
            dt_movimientos.Columns[4].Width = 150;
        }
        public EntregasGestor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dt_movimientos.SelectedRows.Count>0) 
            {
                GUI.EntregasDetalles f = new EntregasDetalles(dt_movimientos.SelectedRows[0]);
                f.ShowDialog();
                Cargar();
            }
            else 
            {
                MessageBox.Show("Seleccione un contrato");
            }
        }

        private void EntregasGestor_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void txb_Filtro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
