using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios_Modulos.GUI.Contratos
{
    public partial class Nuevo_Contrato : Form
    {
        public Nuevo_Contrato()
        {
            InitializeComponent();
        }

        private void Nuevo_Contrato_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CLS.Servicio s = new CLS.Servicio();
            s.Nombre = txbNombre.Text;
            s.Valorcontado = float.Parse(txbValorContado.Text);
            s.Valorcuota = float.Parse(txbValorCuota.Text);
            s.Prima = float.Parse(txbPrima.Text);
            s.Descripcion = txbDescripcion.Text;

            try
            {
                if (s.Guardar()) 
                {
                    MessageBox.Show("Registro añadido exitosamente");
                    this.Close();
                }
            }
            catch 
            {
                MessageBox.Show("No se pudo añadir el registro, intente rellenar debidamente los campos");
            }


        }
    }
}
