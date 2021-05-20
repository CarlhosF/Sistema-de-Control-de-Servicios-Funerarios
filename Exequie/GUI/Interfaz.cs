
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Exequie.GUI
{
    public partial class Interfaz : Form
    {
        SesionManager.CLS.Sesion Sesion = SesionManager.CLS.Sesion.Instancia;
        public Interfaz()
        {
            InitializeComponent();
        }

        private void Interfaz_Load(object sender, EventArgs e)
        {
           
            lb_session_rol.Text = Sesion.Rol;
            lb_session_nombre.Text = Sesion.Empleado;

           
        }
      

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btn_Usuarios_Click_1(object sender, EventArgs e)
        {
            pn_contenedor.Controls.Clear();
            UsuariosModulo.GUI.UsuariosGestor f = new UsuariosModulo.GUI.UsuariosGestor();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pn_contenedor.Controls.Add(f);
            pn_contenedor.Tag = f;

            f.Show();
        }

        private void btn_Personal_Click_1(object sender, EventArgs e)
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

        private void btn_Sucursales_Click_1(object sender, EventArgs e)
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

        private void btn_Clientes_Click_1(object sender, EventArgs e)
        {
            pn_contenedor.Controls.Clear();
            Clientes_Modulo.GUI.ClientesGestor f = new Clientes_Modulo.GUI.ClientesGestor();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pn_contenedor.Controls.Add(f);
            pn_contenedor.Tag = f;

            f.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btn_CerrarSesion_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
            
        }

        private void btnSercicios_Click(object sender, EventArgs e)
        {
            pn_contenedor.Controls.Clear();
            Servicios_Modulos.GUI.Servicios_Gestor f = new Servicios_Modulos.GUI.Servicios_Gestor();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pn_contenedor.Controls.Add(f);
            pn_contenedor.Tag = f;

            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pn_contenedor.Controls.Clear();
            Exequie.Informacion f = new Informacion();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pn_contenedor.Controls.Add(f);
            pn_contenedor.Tag = f;

            f.Show();
        }

        private void btnContratos_Click(object sender, EventArgs e)
        {
            pn_contenedor.Controls.Clear();
            Contratos_Modulo.GUI.ContratosGestor f = new Contratos_Modulo.GUI.ContratosGestor();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pn_contenedor.Controls.Add(f);
            pn_contenedor.Tag = f;

            f.Show();
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            pn_contenedor.Controls.Clear();
            MovimientosModulo.GUI.MovimientosGestor f = new MovimientosModulo.GUI.MovimientosGestor();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pn_contenedor.Controls.Add(f);
            pn_contenedor.Tag = f;

            f.Show();
        }
    }
}
