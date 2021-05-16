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
    public partial class SeleccionarEmpleado : Form
    {
        int id;
        string c="";
        string u = "";
        int rol;
        Boolean orig;
        public SeleccionarEmpleado(int i,string clv,string usu,int r, Boolean o)
        {
            InitializeComponent();
            c = clv;
            u = usu;
            rol = r;
            orig = o;
            id = i;
        }

        private void SeleccionarEmpleado_Load(object sender, EventArgs e)
        {
            dt_Empleados.DataSource = CacheManager.CLS.EmpleadosCache.Listar_Empleados();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (dt_Empleados.SelectedRows.Count > 0) 
            {
                int ide = int.Parse(dt_Empleados.SelectedRows[0].Cells[0].Value.ToString());
                if (orig) 
                {
                    GUI.UsuarioNuevo f = new UsuarioNuevo(ide, c, u, rol);
                    f.Show();
                    this.Close();
                }
                else
                {
                    GUI.UsuarioEditar f = new UsuarioEditar(id,ide, c, u, rol);
                    f.Show();
                    this.Close();
                }
            }else
            {
                MessageBox.Show("Seleccione el Empleado");
            }
        }
    }
}
