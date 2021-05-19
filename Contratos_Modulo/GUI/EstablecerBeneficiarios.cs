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
    public partial class EstablecerBeneficiarios : Form
    {
        BindingSource _DATOS = new BindingSource();
        public int id1 { get; set; }
        public int id2 { get; set; }

        private void Cargar()
        {
            _DATOS.DataSource = CacheManager.CLS.ClientesCache.Listar_Clientes();
            dt_clientes.DataSource = _DATOS.DataSource;
            this.UseWaitCursor = false;
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txb_Filtro.TextLength > 0)
            {
                _DATOS.Filter = "nombres LIKE '%" + txb_Filtro.Text + "%' or apellidos LIKE '%" + txb_Filtro.Text + "%'";
            }
            else
            {
                _DATOS.RemoveFilter();
            }
            dt_clientes.AutoGenerateColumns = false;
            dt_clientes.DataSource = _DATOS;
            lb_Registros.Text = (dt_clientes.Rows.Count).ToString() + " Registros Encontrados";//Alertar cuantos registros han sido encontrados

        }
        public EstablecerBeneficiarios()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void EstablecerBeneficiarios_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (dt_clientes.SelectedRows.Count == 2)
            {
                this.id1 = int.Parse(dt_clientes.SelectedRows[0].Cells[0].Value.ToString());
                this.id2 = int.Parse(dt_clientes.SelectedRows[1].Cells[0].Value.ToString());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dt_clientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dt_clientes.SelectedRows.Count > 2)
            {
                dt_clientes.SelectedRows[0].Selected = false;
            }
        }

        private void txb_Filtro_Click(object sender, EventArgs e)
        {

        }

        private void txb_Filtro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }
    }
}
