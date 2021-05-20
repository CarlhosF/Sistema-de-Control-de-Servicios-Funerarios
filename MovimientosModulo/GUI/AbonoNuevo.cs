using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovimientosModulo.GUI
{
    public partial class AbonoNuevo : Form
    {
        int idC;
        public AbonoNuevo(int id)
        {
            InitializeComponent();
            idC = id;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CLS.Movimiento mov = new CLS.Movimiento();
            mov.fecha = DateTime.Now;
            mov.idVendedor = int.Parse(SesionManager.CLS.Sesion.Instancia.IDUsuario);
            mov.Concepto = txbConcepto.Text;
            mov.Abono = float.Parse(txbAbono.Text);
            mov.idContrato = idC;

            try
            {
                if (mov.Guardar()) 
                {
                    MessageBox.Show("Abono Guardado con exito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Este registro no se puede añadir");
                }
            }
            catch
            {
                MessageBox.Show("Error al ingresar el abono, intente rellenar los campos");
            }
        }
    }
}
