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
        float SA;
        public AbonoNuevo(int id,float sp)
        {
            InitializeComponent();
            idC = id;
            SA = sp;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txbAbono.Text.Length > 0)
            {
                CLS.Movimiento mov = new CLS.Movimiento();
                mov.Fecha = DateTime.Now;
                mov.IdVendedor = int.Parse(SesionManager.CLS.Sesion.Instancia.IDUsuario);
                mov.Concepto = txbConcepto.Text;
                mov.Abono = float.Parse(txbAbono.Text);
                mov.IdContrato = idC;
                if (mov.Abono > SA)
                {
                    MessageBox.Show("El abono supera el saldo pendiente");
                }
                else
                {
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
            else
            {
                MessageBox.Show("Escriba el abono");
            }
        }
    }
}
