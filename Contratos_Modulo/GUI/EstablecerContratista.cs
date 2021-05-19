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
    public partial class EstablecerContratista : Form
    {
        BindingSource _DATOS = new BindingSource();
        public int id { get; set; }

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
        public EstablecerContratista()
        {
            InitializeComponent();
        }

        private void EstablecerContratista_Load(object sender, EventArgs e)
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dt_clientes.SelectedRows.Count>0) 
            {
                this.id = int.Parse(dt_clientes.SelectedRows[0].Cells[0].Value.ToString());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
