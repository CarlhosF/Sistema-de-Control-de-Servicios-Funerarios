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
            tc.Nombre = txb_Nombre.Text;
            tc.Descripcion = txb_Descripcion.Text;
            tc.factor = float.Parse(txb_factor.Text);
            tc.tratamientos = int.Parse(txbTratamiento.Text);

            try
            {
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
    }
}
