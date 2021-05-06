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
    public partial class PuestoNuevo : Form
    {
        public PuestoNuevo()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            CLS.Puesto puesto = new CLS.Puesto();
            puesto.Nombre = txb_Nombre.Text;
            puesto.Descripcion = txb_Descripcion.Text;
            if (txb_Descripcion.Text != null && txb_Descripcion.Text != null)
            {
                try
                {
                    if (puesto.Guardar())
                    {
                        MessageBox.Show("Registro guardado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("NO se pudo realizar la insercion a la tabla");
                    }
                }
                catch
                {
                    MessageBox.Show("Error, NO se pudo realizar la insercion a la tabla");
                }

            }
            else
            {
                MessageBox.Show("Rellena la informacion del puesto");
            }

        }
    }
}
