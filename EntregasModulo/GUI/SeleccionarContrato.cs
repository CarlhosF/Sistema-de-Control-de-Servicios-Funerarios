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
    public partial class SeleccionarContrato : Form
    {
        BindingSource _DATOS = new BindingSource();
        public int id { get; set; }

        private void Cargar()
        {
            _DATOS.DataSource = CacheManager.CLS.ContratosCache.Listar_Contratos_Cancelados();
            dt_contratos.DataSource = _DATOS.DataSource;
            this.UseWaitCursor = false;
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txb_Filtro.TextLength > 0)
            {
                _DATOS.Filter = "extendido LIKE '%" + txb_Filtro.Text + "%' or fecha LIKE '%" + txb_Filtro.Text + "%'";
            }
            else
            {
                _DATOS.RemoveFilter();
            }
            dt_contratos.AutoGenerateColumns = false;
            dt_contratos.DataSource = _DATOS;
            lb_Registros.Text = (dt_contratos.Rows.Count).ToString() + " Registros Encontrados";//Alertar cuantos registros han sido encontrados

        }
        public SeleccionarContrato()
        {
            InitializeComponent();
        }

        private void SeleccionarContrato_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dt_contratos.SelectedRows.Count > 0)
            {
                id = int.Parse(dt_contratos.SelectedRows[0].Cells[0].Value.ToString());
                this.DialogResult = DialogResult.OK;
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Seleccione un contrato");
            }
        }
    }
}
