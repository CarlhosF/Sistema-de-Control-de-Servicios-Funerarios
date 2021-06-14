using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clientes_Modulo.GUI
{
    public partial class ClientesGestor : Form
    {
        BindingSource _DATOS = new BindingSource();

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
            lb_Registros.Text = (dt_clientes.Rows.Count ).ToString() + " Registros Encontrados";//Alertar cuantos registros han sido encontrados
            dt_clientes.Columns[0].Width = 20;
            dt_clientes.Columns[6].Width = 50;
            dt_clientes.Columns[5].Width = 50;
        }

        public ClientesGestor()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
         
                // Do something

                if (dt_clientes.SelectedRows.Count > 0)
                {
                DialogResult dr = MessageBox.Show("¿Desea Eliminar el Cliente"+dt_clientes.SelectedRows[0].Cells[1].Value+" "+ dt_clientes.SelectedRows[0].Cells[2].Value+" ?", "Confirmacion", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    int id = (int)dt_clientes.SelectedRows[0].Cells[0].Value;
                    CLS.Clientes c = new CLS.Clientes();
                    if (c.Eliminar(id))
                    {
                        MessageBox.Show("Cliente eliminado");
                    }
                    else
                    {
                        MessageBox.Show("Este cliente no puede eliminarse por que poseé contratos");
                    }
                    Cargar();
                }
                
            }
            else
            {
                MessageBox.Show("Seleccione el Cliente a eliminar");
            }

        }

        private void ClientesGestor_Load(object sender, EventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GUI.ClienteNuevo f = new ClienteNuevo();
            f.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dt_clientes.SelectedRows.Count > 0)
            {
                int id = (int)dt_clientes.SelectedRows[0].Cells[0].Value;
                GUI.ClienteEditor f = new ClienteEditor(id);
                f.Show();

                Cargar();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente");
            }
        }
    }
}
