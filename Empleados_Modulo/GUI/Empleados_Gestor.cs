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
namespace Empleados_Modulo.GUI
{
    public partial class Empleados_Gestor : Form
    {
        public Empleados_Gestor()
        {
            InitializeComponent();
        }

        private void Empleados_Gestor_Load(object sender, EventArgs e)
        {
            dt_Empleados.DataSource = CacheManager.CLS.EmpleadosCache.Listar_Empleados();
        }

        private void Empleados_Click(object sender, EventArgs e)
        {

        }
    }
}
