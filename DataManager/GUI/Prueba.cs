using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataManager.GUI
{
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            CLS.OperacionBD operacion = new CLS.OperacionBD();
            dtgDatos.DataSource = operacion.Consultar("SELECT * FROM sistema.empleados;");

        }
    }
}
