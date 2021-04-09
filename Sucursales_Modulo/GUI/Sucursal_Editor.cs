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
namespace Sucursales_Modulo.GUI
{
    public partial class Sucursal_Editor : Form
    {
        public void Procesar() 
        {
        }
        
        public Sucursal_Editor(int id)
        {
            InitializeComponent();
            txb_idsucursal.Text = id.ToString();
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

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
