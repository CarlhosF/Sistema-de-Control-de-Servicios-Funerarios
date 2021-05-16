using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CacheManager;
namespace UsuariosModulo.GUI
{
    public partial class UsuariosGestor : Form
    {
        BindingSource _DATOS = new BindingSource();
        public UsuariosGestor()
        {
            InitializeComponent();
        }
        private void Cargar()
        {
            _DATOS.DataSource = CacheManager.CLS.UsuariosCache.Listar_Usuarios();
            dt_usuarios.DataSource = _DATOS.DataSource;
            this.UseWaitCursor = false;
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txb_Filtro.TextLength > 0)
            {
                _DATOS.Filter = "nombres LIKE '%" + txb_Filtro.Text + "%' or apellidos LIKE '%" + txb_Filtro.Text + "%'";
            }
            else
            {
                _DATOS.RemoveFilter();
            }
            dt_usuarios.AutoGenerateColumns = false;
            dt_usuarios.DataSource = _DATOS;
            lb_Registros.Text = (dt_usuarios.Rows.Count).ToString() + " Registros Encontrados";//Alertar cuantos registros han sido encontrados
            //dt_usuarios.Columns[4].Width = 875; 
        }
        private void UsuariosGestor_Load(object sender, EventArgs e)
        {
            Cargar();
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GUI.UsuarioNuevo f = new UsuarioNuevo();
            f.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dt_usuarios.SelectedRows.Count > 0)
            {
                int id = (int)dt_usuarios.SelectedRows[0].Cells[0].Value;
                CLS.Usuario c = new CLS.Usuario();
                c.Eliminar(id);
                Cargar();
            }
            else 
            {
                MessageBox.Show("Seleccione un usuario");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dt_usuarios.SelectedRows.Count > 0)
            {
                int id = (int)dt_usuarios.SelectedRows[0].Cells[0].Value;
                GUI.UsuarioEditar f = new UsuarioEditar(id);
                f.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un usuario");
            }
        }
    }
}
