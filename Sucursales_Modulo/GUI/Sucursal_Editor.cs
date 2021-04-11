using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sucursales_Modulo.CLS;
using CacheManager;
namespace Sucursales_Modulo.GUI
{
    public partial class Sucursal_Editor : Form
    {
        DataTable DT = new DataTable();


        public void Procesar() 
        {
        }

        public Sucursal_Editor(int id)
        {
            InitializeComponent();
            txb_idsucursal.Text = id.ToString();
            DT = CacheManager.CLS.SucursalCache.Traer_Sucursal(id);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {

            CLS.Sucursales Entidad = new CLS.Sucursales();
            Entidad.Direccion = txb_direccion.Text;
            Entidad.Telefono = txb_telefono.Text;
            Entidad.idsucursales = int.Parse(txb_idsucursal.Text);

            if (dt_encargado.SelectedRows.Count > 0)
            {
                Entidad.Encargado = (int) dt_encargado.SelectedRows[0].Cells[0].Value;
                if (Entidad.Editar())
                {
                    MessageBox.Show("Registro actualizado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();

                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la informacion");
                }
            }
            else 
            {
                if (Entidad.Editar_sin_Encargado())
                {
                    MessageBox.Show("Registro actualizado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();

                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la informacion");
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Sucursal_Editor_Load(object sender, EventArgs e)
        {
            

            dt_encargado.DataSource = CacheManager.CLS.EmpleadosCache.Listar_Empleados_Para_Encargado();
            DataRow DR = DT.Rows[0];
            txb_direccion.Text=DR["direccion"].ToString();
            txb_telefono.Text = DR["telefono"].ToString();

        }
    }
}
