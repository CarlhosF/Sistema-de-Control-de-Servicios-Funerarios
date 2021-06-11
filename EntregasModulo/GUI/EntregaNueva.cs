using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntregasModulo.GUI
{
    public partial class EntregaNueva : Form
    {
        int idcontrato;
        public EntregaNueva(int id)
        {
            InitializeComponent();
            idcontrato = id;
        }

        private void EntregaNueva_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {


            try
            {
                CLS.difunto difunto = new CLS.difunto();
                difunto.Idcontrato = idcontrato;
                difunto.Nombres = txb_nombres.Text;
                difunto.Apellidos = txb_apellidos.Text;
                difunto.CausaMuerte = txb_Causa.Text;
                difunto.DireccionDeEntrega = txbdireccionEntrega.Text;
                difunto.DireccionDeToma = txbdireccionToma.Text;
                difunto.Fechanacimiento = dp_fechanacimiento.Value;
                difunto.FechanMuerte = dtp_muerte.Value;
                if (difunto.Guardar())
                {
                    MessageBox.Show("Registro añadido");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se puede añadir ese registro");
                }
            }
            catch 
            {
                MessageBox.Show("Error al añadir registro, intente rellenar los campos");
            }


        }
    }
}
