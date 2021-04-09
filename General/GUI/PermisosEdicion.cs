using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class PermisosEdicion : Form
    {
        BindingSource Permisos = new BindingSource();
        private void CargarPermisos()
        {
            try
            {
                Permisos.DataSource = CacheManager.CLS.Cache.PERMISOS_DE_UN_ROL(cbbRoles.SelectedValue.ToString());
                dtgPermisos.AutoGenerateColumns = false;
                dtgPermisos.DataSource = Permisos;
                cbbRoles.DisplayMember = "Rol";
                cbbRoles.ValueMember = "IDRol";
            }
            catch
            {
            }

        }

        private void CargarRoles()
        {
            DataTable Roles = new DataTable();

            try
            {
                Roles = CacheManager.CLS.Cache.TODOS_LOS_ROLES();
                cbbRoles.DataSource = Roles;
                cbbRoles.DisplayMember = "Rol";
                cbbRoles.ValueMember = "IDRol";
            }
            catch
            {
                Roles = new DataTable();
            }
        }

        public PermisosEdicion()
        {
            InitializeComponent();
        }

        private void PermisosEdicion_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }

        private void cbbRoles_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarPermisos();
        }

        private void dtgPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String valor;
            try
            {
                if (e.ColumnIndex == 0)
                {
                    valor = dtgPermisos.CurrentRow.Cells["IDPermiso"].Value.ToString();
                    CLS.Permisos Entidad = new CLS.Permisos();
                    if (valor.Equals("0"))
                    {
                        //ASIGNANDO EL PERMISO
                        Entidad.IDOpcion = dtgPermisos.CurrentRow.Cells["IDOpcion"].Value.ToString();
                        Entidad.IDRol = cbbRoles.SelectedValue.ToString();
                        if (Entidad.Guardar())
                        {
                            CargarPermisos();
                        }
                    }
                    else
                    {
                        //REVOCANDO EL PERMISO
                        Entidad.IDPermiso = dtgPermisos.CurrentRow.Cells["IDPermiso"].Value.ToString();
                        if (Entidad.Eliminar())
                        {
                            CargarPermisos();
                        }
                    }
                }
            }
            catch
            {

            }

        }
    }
}
