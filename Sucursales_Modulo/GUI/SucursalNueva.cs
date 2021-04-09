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

        }
    }
}
