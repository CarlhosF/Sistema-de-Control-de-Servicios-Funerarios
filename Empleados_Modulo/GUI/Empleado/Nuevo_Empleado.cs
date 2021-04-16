using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CacheManager;

namespace Empleados_Modulo.GUI.Empleado
{
    public partial class Nuevo_Empleado : Form
    {
        public Nuevo_Empleado()
        {
            InitializeComponent();
        }

        private void Nuevo_Empleado_Load(object sender, EventArgs e)
        {
            
            dt_Sucursal_Empleado.DataSource = CacheManager.CLS.SucursalCache.Listar_Sucursales();
           
        }

        private void btn_Agregar_Empleado_Click(object sender, EventArgs e)
        {
            CLS.Empleados empleado = new CLS.Empleados();
            empleado.Apellido = txb_Apellido_Empleado.Text;
            empleado.Nombre = txb_Nombre_Empleado.Text;
            empleado.Direccion = txb_direccion_Empleado.Text;
            empleado.Telefono = txb_telefono_Empleado.Text;
            empleado.DUI = txb_DUI_Empleado.Text;
            empleado.dt = date_FNacimineto_Empleado.Value;
            Int32 selectedRowCount = dt_Sucursal_Empleado.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {

                empleado.sucursal = (int)dt_Sucursal_Empleado.SelectedRows[0].Cells[0].Value;

                if (txb_Nombre_Empleado.Text != null && txb_Apellido_Empleado != null && txb_direccion_Empleado != null && txb_telefono_Empleado != null)
                {
                    try
                    {
                        if (empleado.Guardar())
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
                    MessageBox.Show("Rellena la informacion del empleado");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una sucursal  para el Empleado");
            }

            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
