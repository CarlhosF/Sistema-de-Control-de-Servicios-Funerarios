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
        string c="";
        string u = "";
        int rol;
        public SeleccionarEmpleado(string clv,string usu,int r)
        {
            InitializeComponent();
            c = clv;
            u = usu;
            rol = r;
        }

        private void SeleccionarEmpleado_Load(object sender, EventArgs e)
        {
            dt_Empleados.DataSource = CacheManager.CLS.EmpleadosCache.Listar_Empleados();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dt_Empleados.SelectedRows[0].Cells[0].Value.ToString());
            GUI.UsuarioNuevo f = new UsuarioNuevo(id,c,u,rol);
            f.Show();
            this.Close();
        }
    }
}
