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
    public partial class SucursalNueva : Form
    {
        BindingSource _DATOS = new BindingSource();
        public SucursalNueva()
        {
            InitializeComponent();
        }
        private void Cargar()
        {
            _DATOS.DataSource = CacheManager.CLS.EmpleadosCache.Listar_Empleados_Para_Encargado();
            dt_empleado.DataSource = _DATOS.DataSource;
        }

        private void dt_empleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SucursalNueva_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Sucursales_Modulo.CLS.Sucursales sucursal = new CLS.Sucursales();
            sucursal.Direccion = txb_direccion.Text;
            sucursal.Telefono = txb_telefono.Text;
            
            Int32 selectedRowCount = dt_empleado.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                
                sucursal.Encargado = (int)dt_empleado.SelectedRows[0].Cells[0].Value;

                if (txb_direccion.Text != null && txb_telefono != null)
                {
                    try
                    {
                        if (sucursal.Guardar())
                        {
                            MessageBox.Show("Registro guardado exitosamente");
                        }
                        else
                        {
                            MessageBox.Show("NO se pudo realizar la insercion a la tabla");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error, NO se pudo realizar la insercion a la tabla");
                    }
                }
                else
                {
                    MessageBox.Show("Rellena la informacion de la sucursal");
                }
            }
            else 
            {
                MessageBox.Show("Selecciona un encargado para la sucursal");
            }


            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lb_Direccion_Click(object sender, EventArgs e)
        {

        }
    }
}
