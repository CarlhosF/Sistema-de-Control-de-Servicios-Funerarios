using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clientes_Modulo.GUI
{
    public partial class ClienteNuevo : Form
    {
        BindingSource _DATOS = new BindingSource();

        public ClienteNuevo()
        {
            InitializeComponent();
        }

        private void Cargar()
        {
            _DATOS.DataSource = CacheManager.CLS.ClientesCache.Listar_Clientes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Clientes_Modulo.CLS.Clientes clientes = new CLS.Clientes();

            clientes.Nombres = txb_nombres.Text;
            clientes.Apellidos = txb_apellidos.Text;
            clientes.Dui = txb_dui.Text;

            clientes.Direccion = txb_direccion.Text;
            clientes.Fechanacimiento = dp_fechanacimiento.Value.ToString("d");
            clientes.Telefono = txb_telefono.Text;
            clientes.Oficio = txb_oficio.Text;
            
                if (txb_nombres.Text != null && txb_apellidos.Text != null && txb_dui.Text != null && txb_direccion.Text != null && txb_telefono.Text != null && txb_oficio.Text != null && dp_fechanacimiento.Value.ToString("d")!=null )
                {
                    try
                    {
                        if (clientes.Guardar())
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
                    MessageBox.Show("Rellena la informacion del cliente");
                }           
        }

        private void ClienteNuevo_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
