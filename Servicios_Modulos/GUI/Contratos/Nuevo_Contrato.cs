using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios_Modulos.GUI.Servicios
{
    public partial class Nuevo_Servicio : Form
    {
        public Nuevo_Servicio()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CLS.TipoContrato tc = new CLS.TipoContrato();
            
            try
            {
                tc.Nombre = txb_Nombre.Text;
                tc.Descripcion = txb_Descripcion.Text;
                tc.Factor = float.Parse(txb_factor.Text);
                tc.Tratamientos = int.Parse(txbTratamiento.Text);

                if (tc.Guardar())
                {
                    MessageBox.Show("Registro Guardado exitosamente");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error al ingersar, intente rellenar los campos debidamente");
            }
        }

        private void txb_factor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txbTratamiento_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txbTratamiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
