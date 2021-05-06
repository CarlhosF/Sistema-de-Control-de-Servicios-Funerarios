using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados_Modulo.GUI.Puesto
{
    public partial class PuestoEditor : Form
    {
        DataTable DT = new DataTable();
        public PuestoEditor(int id)
        {
            InitializeComponent();
            txb_ID.Text = id.ToString();
            DT = CacheManager.CLS.PuestoCache.Traer_Puesto(id);
        }

        private void PuestoEditor_Load(object sender, EventArgs e)
        {
            DataRow DR = DT.Rows[0];
            txb_Descripcion.Text= DR["descripcion"].ToString();
            txb_Nombre.Text = DR["nombre"].ToString();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            CLS.Puesto p = new CLS.Puesto();
            p.idpuesto = int.Parse(txb_ID.Text);
            p.Descripcion = txb_Descripcion.Text;
            p.Nombre = txb_Nombre.Text;

            if (p.Editar())
            {
                MessageBox.Show("Registro actualizao exitosamente");
             }
            else 
            {
                MessageBox.Show("Error al actualizar el registro");
            }
            this.Close();
            
        }
    }
}
