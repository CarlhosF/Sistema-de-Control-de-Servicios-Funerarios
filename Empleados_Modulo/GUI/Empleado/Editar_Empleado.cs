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
            DataRow DR = DT.Rows[0];
            txb_Nombre_Empleado.Text = DR["nombres"].ToString();
            txb_Apellido_Empleado.Text = DR["apellidos"].ToString();
            txb_DUI_Empleado.Text = DR["DUI"].ToString();
            txb_direccion_Empleado.Text = DR["direccion"].ToString();
            txb_telefono_Empleado.Text = DR["telefono"].ToString();
            date_FNacimineto_Empleado.Value= DateTime.Parse(DR["fechanacimiento"].ToString());

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Editar_Empleado_Click(object sender, EventArgs e)
        {

        }
    }
}
