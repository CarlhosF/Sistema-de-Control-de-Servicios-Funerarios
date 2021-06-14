
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
            if (Sesion.Rol == "Vendedor")
            {
                btnPoliticas.Visible = false;
                btn_Usuarios.Visible = false;
                btn_Personal.Visible = false;
                btn_Sucursales.Visible = false;

            }
            else
            {
                if (Sesion.Rol == "Gerente")
                {
                    btnPoliticas.Visible = false;
                    btn_Usuarios.Visible = false;

                }
            }
            lbrol.Text = Sesion.Rol;
            lbUsuario.Text = Sesion.Empleado;
            this.btn_Clientes_Click_1(sender,e);


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
            lbTitulo.Text = "USUARIOS";

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
            lbTitulo.Text = "EMPLEADOS";

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
            lbTitulo.Text = "SUCURSALES";

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
            lbTitulo.Text = "CLIENTES";

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
            lbTitulo.Text = "POLITICAS DE NEGOCIOS";

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
            lbTitulo.Text = "INFORMACIÓN";

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
            lbTitulo.Text = "CONTRATOS";

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
            lbTitulo.Text = "ABONOS";

            f.Show();
        }

        private void btnDifuntos_Click(object sender, EventArgs e)
        {
            pn_contenedor.Controls.Clear();
            EntregasModulo.GUI.EntregasGestor f = new EntregasModulo.GUI.EntregasGestor();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pn_contenedor.Controls.Add(f);
            pn_contenedor.Tag = f;
            lbTitulo.Text = "ENTREGAS";

            f.Show();
        }

        private void pn_botones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbrol_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbUsuario_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
