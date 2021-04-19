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
    public partial class ClienteEditor : Form
    {
        DataTable DT = new DataTable();


        public void Procesar()
        {
        }

        public ClienteEditor(int id)
        {
            InitializeComponent();
            txb_idclientes.Text = id.ToString();
            DT = CacheManager.CLS.ClientesCache.Traer_Clientes(id);   //tengo dudas
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CLS.Clientes Entidad = new CLS.Clientes();
            Entidad.Nombres = txb_nombres.Text;
            Entidad.Apellidos = txb_apellidos.Text;
            Entidad.Dui = txb_dui.Text;
            Entidad.Direccion = txb_direccion.Text;

            Entidad.Fechanacimiento = dp_fechanacimiento.Value.ToString("d");
            Entidad.Telefono = txb_telefono.Text;
            Entidad.Oficio = txb_oficio.Text;
            Entidad.Idclientes = int.Parse(txb_idclientes.Text);
            
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

        private void ClienteEditor_Load(object sender, EventArgs e)
        {
            
            DataRow DR = DT.Rows[0];

            txb_nombres.Text = DR["nombres"].ToString();
            txb_apellidos.Text = DR["apellidos"].ToString();
            txb_dui.Text = DR["dui"].ToString();

            txb_direccion.Text = DR["direccion"].ToString();

            txb_telefono.Text = DR["telefono"].ToString();
            txb_oficio.Text = DR["oficio"].ToString();
        }
    }
}
