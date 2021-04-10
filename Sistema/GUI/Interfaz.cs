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
            if (f.Size.Height > pn_contenedor.Size.Height || f.Size.Width > pn_contenedor.Size.Width)
            {
                f.Size = new Size( pn_contenedor.Size.Width, pn_contenedor.Size.Height);
            }
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
    }
}
