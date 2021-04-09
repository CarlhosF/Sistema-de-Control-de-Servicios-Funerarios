using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sucursales_Modulo;
namespace Sistema.GUI
{
    public partial class Interfaz : Form
    {
        public Interfaz()
        {
            InitializeComponent();
        }

        private void btn_Sucursales_Click(object sender, EventArgs e)
        {
            Sucursales_Modulo.GUI.SucursalGestor f = new Sucursales_Modulo.GUI.SucursalGestor();
            f.Show();
        }
    }
}
