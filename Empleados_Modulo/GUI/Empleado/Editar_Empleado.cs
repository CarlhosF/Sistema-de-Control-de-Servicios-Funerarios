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
    public partial class Editar_Empleado : Form
    {
        DataTable DT = new DataTable();
        public Editar_Empleado(int id)
        {
            InitializeComponent();
            txb_ID_Empleado.Text = id.ToString();
            DT = CacheManager.CLS.EmpleadosCache.Traer_Empleado(id);
        }

        private void Editar_Empleado_Load(object sender, EventArgs e)
        {
            dt_Sucursal_Empleado.DataSource = CacheManager.CLS.SucursalCache.Listar_Sucursales();
            dt_puesto.DataSource = CacheManager.CLS.PuestoCache.Listar_Puestos();
            DataRow DR = DT.Rows[0];
            txb_Nombre_Empleado.Text = DR["nombres"].ToString();
            txb_Apellido_Empleado.Text = DR["apellidos"].ToString();
            txb_DUI_Empleado.Text = DR["DUI"].ToString();
            txb_direccion_Empleado.Text = DR["direccion"].ToString();
            txb_telefono_Empleado.Text = DR["telefono"].ToString();
            date_FNacimineto_Empleado.Value= DateTime.Parse(DR["fechanacimiento"].ToString());
            date_Contratacion.Value= DateTime.Parse(DR["fechaContratacion"].ToString());

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Editar_Empleado_Click(object sender, EventArgs e)
        {

            CLS.Empleados Entidad = new CLS.Empleados();
            Entidad.Nombre = txb_Nombre_Empleado.Text;
            Entidad.Apellido = txb_Apellido_Empleado.Text;
            Entidad.DUI = txb_DUI_Empleado.Text;
            Entidad.Direccion = txb_direccion_Empleado.Text;
            Entidad.Telefono = txb_telefono_Empleado.Text;
            Entidad.fechaContratacion = date_Contratacion.Value;
            Entidad.dt = date_FNacimineto_Empleado.Value;
            Entidad.idEmpleado = int.Parse(txb_ID_Empleado.Text);
            Entidad.sucursal=(int)dt_Sucursal_Empleado.SelectedRows[0].Cells[0].Value;
            Entidad.puesto= (int)dt_puesto.SelectedRows[0].Cells[0].Value;

            if (Entidad.Editar())
            {
                MessageBox.Show("Registro actualizado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

            }
            else
            {
                MessageBox.Show("No se pudo actualizar la informacion");
            }

        }

        private void lb_fNacimiento_Empleado_Click(object sender, EventArgs e)
        {

        }

        private void date_FNacimineto_Empleado_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
