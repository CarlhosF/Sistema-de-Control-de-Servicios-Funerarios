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
    public partial class ContratosGestor : Form
    {
        BindingSource _DATOS = new BindingSource();
        public ContratosGestor()
        {
            InitializeComponent();
        }
        private void Cargar()
        {
            _DATOS.DataSource = CacheManager.CLS.ContratosCache.Listar_Contratos();
            dt_contratos.DataSource = _DATOS.DataSource;
            this.UseWaitCursor = false;
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txb_Filtro.TextLength > 0)
            {
                _DATOS.Filter = "extendido LIKE '%" + txb_Filtro.Text + "%'";
            }
            else
            {
                _DATOS.RemoveFilter();
            }
            dt_contratos.AutoGenerateColumns = false;
            dt_contratos.DataSource = _DATOS;
            lb_Registros.Text = (dt_contratos.Rows.Count).ToString() + " Registros Encontrados";//Alertar cuantos registros han sido encontrados

        }

        private void ContratosGestor_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GUI.ContratoNuevo f = new ContratoNuevo();
            f.Show();

        }
    }
}
