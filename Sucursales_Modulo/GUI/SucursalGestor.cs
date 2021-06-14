using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sucursales_Modulo.GUI
{
    public partial class SucursalGestor : Form
    {
        BindingSource _DATOS = new BindingSource();
        
        private void Cargar()
        {
            _DATOS.DataSource = CacheManager.CLS.SucursalCache.Listar_Sucursales();
            dt_sucursales.DataSource = _DATOS.DataSource;
            this.UseWaitCursor = false;
            FiltrarLocalmente();
        }
        private void FiltrarLocalmente()
        {
            if (txb_Filtro.TextLength > 0)
            {
                _DATOS.Filter = "direccion LIKE '%" + txb_Filtro.Text + "%' ";
            }
            else
            {
                _DATOS.RemoveFilter();
            }
            dt_sucursales.AutoGenerateColumns = false;
            dt_sucursales.DataSource = _DATOS;
            lb_Registros.Text = (dt_sucursales.Rows.Count-1).ToString() + " Registros Encontrados";//Alertar cuantos registros han sido encontrados
            dt_sucursales.Columns[1].Width = 475;
            dt_sucursales.Columns[0].Width = 20;
            


        }
        public SucursalGestor()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SucursalGestor_Load(object sender, EventArgs e)
        {
            Cargar();    
        }

        private void txb_Filtro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (dt_sucursales.SelectedRows.Count > 0)
            {
                int id = (int)dt_sucursales.SelectedRows[0].Cells[0].Value;
                GUI.Sucursal_Editor f = new Sucursal_Editor(id);
                f.Show();

                Cargar();
            }
            else 
            {
                MessageBox.Show("Seleccione una sucursal");
            }

            
;        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            GUI.SucursalNueva f = new SucursalNueva();
            f.Show();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dt_sucursales.SelectedRows.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("¿Desea Eliminar la Sucursal ID: " + dt_sucursales.SelectedRows[0].Cells[0].Value + " ?", "Confirmacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        int id = (int)dt_sucursales.SelectedRows[0].Cells[0].Value;

                        CLS.Sucursales s = new CLS.Sucursales();
                        if (s.Eliminar(id))
                        {
                            MessageBox.Show("Empleado eliminado");
                        }
                        else
                        {
                            MessageBox.Show("NO se puede eliminar este empleado por que se encuentra en un contrato");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una Sucursal");
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar Sucursal");
            }
            Cargar();
        }
    }
}
