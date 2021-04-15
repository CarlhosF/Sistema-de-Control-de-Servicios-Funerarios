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
using Empleados_Modulo;
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
            pn_contenedor.Controls.Clear();
            Sucursales_Modulo.GUI.SucursalGestor f = new Sucursales_Modulo.GUI.SucursalGestor();
            
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pn_contenedor.Controls.Add(f);
            pn_contenedor.Tag = f;
            
            f.Show();
        }

        private void Interfaz_Load(object sender, EventArgs e)
        {

        }

        private void btn_Personal_Click(object sender, EventArgs e)
        {
            pn_contenedor.Controls.Clear();
            Empleados_Modulo.GUI.Empleados_Gestor f = new Empleados_Modulo.GUI.Empleados_Gestor();
          
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pn_contenedor.Controls.Add(f);
            pn_contenedor.Tag = f;

            f.Show();
        }
    }
}
