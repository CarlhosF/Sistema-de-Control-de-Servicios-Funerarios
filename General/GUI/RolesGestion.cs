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
    public partial class RolesGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            _DATOS.DataSource = CacheManager.CLS.Cache.TODOS_LOS_ROLES();
            FiltrarLocalmente();

        }

        private void FiltrarLocalmente()
        {
            if (txbFiltrar.TextLength > 0)
            {
                _DATOS.Filter = "Rol LIKE '%" + txbFiltrar.Text + "%' ";
            }
            else
            {
                _DATOS.RemoveFilter();
            }
            dtgRoles.AutoGenerateColumns = false;
            dtgRoles.DataSource = _DATOS;
            lblRegistros.Text = dtgRoles.Rows.Count.ToString() + " Registros Encontrados";//Alertar cuantos registros han sido encontrados
        }






        public RolesGestion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                RolesEdicion f = new RolesEdicion();
                f.ShowDialog();
                Cargar();//PARA REFRESCAR
            }
            catch
            {

            }

        }

        private void RolesGestion_Load(object sender, EventArgs e)
        {
            Cargar();

        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RolesEdicion f = new RolesEdicion();
                    f.txbIDRol.Text = dtgRoles.CurrentRow.Cells["IDRol"].Value.ToString();
                    f.txbRol.Text = dtgRoles.CurrentRow.Cells["Rol"].Value.ToString();
                    f.ShowDialog();
                    Cargar();
                }
            }
            catch
            {

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.Roles oEntidad = new CLS.Roles();
                    oEntidad.IDRol = dtgRoles.CurrentRow.Cells["IDRol"].Value.ToString();
                    if (oEntidad.Eliminar())
                    {
                        MessageBox.Show("Registro ELIMINADO correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar();
                    }
                    else
                    {
                        MessageBox.Show("Registro NO pudo ser ELIMINADO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
            catch
            {

            }

        }

        private void dtgRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
