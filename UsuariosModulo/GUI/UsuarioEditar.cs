using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CacheManager.CLS;
namespace UsuariosModulo.GUI
{
    public partial class UsuarioEditar : Form
    {
        public UsuarioEditar(int id)
        {
            InitializeComponent();
            DataTable DT = CacheManager.CLS.UsuariosCache.Traer_Usuario(id);
            DataRow DR = DT.Rows[0];
            //String nombre = DR["nombres"].ToString()
            txbID.Text = DR["idusuarios"].ToString();
            txb_clave.Text = DR["clave"].ToString();
            txb_usuario.Text = DR["usuario"].ToString();
            txb_IdEmpleado.Text = DR["idempleados"].ToString();
            DataTable DTE = CacheManager.CLS.EmpleadosCache.Traer_Empleado(int.Parse(DR["idempleados"].ToString()));
            DataRow DRE = DTE.Rows[0];
            txb_Empleado.Text= DRE["nombres"].ToString() + DRE["apellidos"].ToString();
            string rol= DR["rol"].ToString();
            int ro;
            if (rol == "Administrador") { ro = 0; } else { if (rol == "Gerente") { ro = 2; } else { ro = 1; } }
            lst_Rol.SelectedIndex = ro;
            
        }
        public UsuarioEditar(int id,int ide,string cl,string usu, int rol)
        {
            InitializeComponent();
            txbID.Text = id.ToString();
            txb_Empleado.Text = ide.ToString();
            txb_clave.Text = cl;
            txb_usuario.Text = usu;
            lst_Rol.SelectedIndex = rol;
            DataTable DTE = CacheManager.CLS.EmpleadosCache.Traer_Empleado(ide);
            DataRow DRE = DTE.Rows[0];
            txb_Empleado.Text = DRE["nombres"].ToString() + DRE["apellidos"].ToString();

        }

        private void UsuarioEditar_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TraerEmpleado_Click(object sender, EventArgs e)
        {
            GUI.SeleccionarEmpleado f = new SeleccionarEmpleado(int.Parse(txbID.Text),txb_clave.Text,txb_usuario.Text,lst_Rol.SelectedIndex,false);
            f.Show();
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            CLS.Usuario u = new CLS.Usuario();
            u.idrol = lst_Rol.SelectedItem.ToString();
            u.idusuario = int.Parse(txbID.Text);
            u.clave = txb_clave.Text;
            u.usuario = txb_usuario.Text;
            u.idempleado = int.Parse(txb_IdEmpleado.Text);
            try
            {
                if (u.Editar())
                {
                    MessageBox.Show("Registro actualizado");
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("No se pudo actualizar");
                }
            }
            catch
            {
                MessageBox.Show("Error al actualizar, intente rellenar todos los campos");
            }



        }
    }
}
