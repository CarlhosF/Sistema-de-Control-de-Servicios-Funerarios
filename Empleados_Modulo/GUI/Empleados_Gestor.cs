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
namespace Empleados_Modulo.GUI
{
    public partial class Empleados_Gestor : Form
    {
        BindingSource _Usuario = new BindingSource();
        BindingSource _Roles = new BindingSource();
        BindingSource _DATOS = new BindingSource();
        public Empleados_Gestor()
        {
            InitializeComponent();
        }

        private void Empleados_Gestor_Load(object sender, EventArgs e)
        {

            Cargar();
        
        }

        private void Empleados_Click(object sender, EventArgs e)
        {

        }
        private void FiltrarEmpleadoLocalmente()
        {
            if (tb_Filtrar_Empleado.TextLength > 0)
            {
                _DATOS.Filter = "nombres  LIKE '%" + tb_Filtrar_Empleado.Text + "%' or apellidos LIKE '%" + tb_Filtrar_Empleado.Text + "%' ";
            }
            else
            {
                _DATOS.RemoveFilter();
            }
            dt_Empleados.AutoGenerateColumns = false;
            dt_Empleados.DataSource = _DATOS;
            dt_Empleados.Text = (dt_Empleados.Rows.Count - 1).ToString() + " Registros Encontrados";//Alertar cuantos registros han sido encontrados
            
            dt_Empleados.Columns[0].Width = 20;
            ;
        }
        private void Cargar()
        {
            _DATOS.DataSource = CacheManager.CLS.EmpleadosCache.Listar_Empleados();
            _Usuario.DataSource = CacheManager.CLS.PuestoCache.Listar_Puestos();
            _Roles.DataSource = CacheManager.CLS.RolesCache.Listar_Roles();
            dt_Empleados.DataSource = _DATOS.DataSource;
            dt_Puestos.DataSource = _Usuario.DataSource;
            
            FiltrarEmpleadoLocalmente();
        }

        private void btn_Agragar_Empleado_Click(object sender, EventArgs e)
        {
            GUI.Empleado.Nuevo_Empleado f = new Empleado.Nuevo_Empleado();
            f.Show();
            Cargar();
        }

        private void tb_Filtrar_Empleado_TextChanged(object sender, EventArgs e)
        {
            FiltrarEmpleadoLocalmente();
        }

        private void btn_Eliminar_Empleado_Click(object sender, EventArgs e)
        {
            if (dt_Empleados.SelectedRows.Count > 0)
            {
                CLS.Empleados empleado = new CLS.Empleados();
                int id = 0;
                id = (int)dt_Empleados.SelectedRows[0].Cells[0].Value;
                empleado.Eliminar(id);
            }
            else
            {
                MessageBox.Show("Seleccione el Empleado a eliminar");
            }
            Cargar();
        }

        private void btn_Editar_Empleado_Click(object sender, EventArgs e)
        {
            if (dt_Empleados.SelectedRows.Count > 0)
            {
               
                int id = -1;
                id = (int)dt_Empleados.SelectedRows[0].Cells[0].Value;
                GUI.Empleado.Editar_Empleado f = new Empleado.Editar_Empleado(id);
                f.Show(); ;
            }
            else
            {
                MessageBox.Show("Seleccione el Puesto a eliminar");
            }

            Cargar();
        }

        private void btn_Actualizar_Empleado_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void dt_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dt_roles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cargar();
        }

        private void btn_Agregar_puesto_Click(object sender, EventArgs e)
        {
            GUI.Puesto.PuestoNuevo f = new Puesto.PuestoNuevo();
            f.Show();
        }

        private void btn_Actualizar_puesto_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btn_Eliminar_puesto_Click(object sender, EventArgs e)
        {
            if (dt_Puestos.SelectedRows.Count > 0)
            {
                CLS.Puesto p = new CLS.Puesto();
                int id = 0;
                id = (int)dt_Puestos.SelectedRows[0].Cells[0].Value;
                p.Eliminar(id);
            }
            Cargar();
        }

        private void btn_Editar_puesto_Click(object sender, EventArgs e)
        {
            if (dt_Puestos.SelectedRows.Count > 0)
            {

                int id = -1;
                id = (int)dt_Puestos.SelectedRows[0].Cells[0].Value;
                GUI.Puesto.PuestoEditor f = new Puesto.PuestoEditor(id);
                f.Show();
            }

            Cargar();
        }

        private void tb_Filtrar_Empleado_Click(object sender, EventArgs e)
        {

        }
    }
}
