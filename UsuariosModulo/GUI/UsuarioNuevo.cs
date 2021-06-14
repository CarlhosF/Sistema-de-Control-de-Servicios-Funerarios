using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsuariosModulo.GUI
{
    public partial class UsuarioNuevo : Form
    {
        
        
        public UsuarioNuevo(int id, string c, string u, int rol)
        {
            InitializeComponent();
            EstablecerEmpleado(id,c,u,rol);
            
        }
        public UsuarioNuevo()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void EstablecerEmpleado(int id,string c,string u, int rol) 
        {
            DataTable DT = new DataTable();
            DT = CacheManager.CLS.EmpleadosCache.Traer_Empleado(id);
            if (DT.Rows.Count>0) 
            {
                DataRow DR = DT.Rows[0];
                String nombre = DR["nombres"].ToString() + DR["apellidos"].ToString();
                txb_IdEmpleado.Text = DR["idempleados"].ToString();
                txb_Empleado.Text = nombre;
                txb_clave.Text = c;
                txb_usuario.Text = u;
                lst_Rol.SelectedIndex = rol;
            }

        }
        private void UsuarioNuevo_Load(object sender, EventArgs e)
        {
             
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TraerEmpleado_Click(object sender, EventArgs e)
        {
            GUI.SeleccionarEmpleado f = new SeleccionarEmpleado(0,txb_clave.Text,txb_usuario.Text,lst_Rol.SelectedIndex,true);
            f.Show();
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            CLS.Usuario usuario = new CLS.Usuario();
           


            try
            {
                usuario.idrol = lst_Rol.SelectedItem.ToString().Replace(" ", "");
                usuario.usuario = txb_usuario.Text.Replace(" ", "");
                usuario.clave = txb_clave.Text.Replace(" ", "");
                usuario.idempleado = int.Parse(txb_IdEmpleado.Text);
                usuario.usuario.Replace(" ", "");
                usuario.clave.Replace(" ", "");
                usuario.idrol.Replace(" ", "");
                if (usuario.Guardar())
                {
                    MessageBox.Show("Registro añadido");
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Error al añadir el registro");
                }
            }
            catch 
            {
                MessageBox.Show("Error,no se pudo añadir, prueber rellenar correctamente");
            }

        }
    }
}
