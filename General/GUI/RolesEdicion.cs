using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class RolesEdicion : Form
    {

        private void Procesar()
        {
            CLS.Roles oEntidad = new CLS.Roles();//objeto oEntidad
            oEntidad.IDRol = txbIDRol.Text;
            oEntidad.Rol = txbRol.Text;
            try
            {
                if (txbIDRol.TextLength > 0)
                {
                    //ESTOY EDITANDO
                    if (oEntidad.Editar())
                    {
                        MessageBox.Show("Registro actualizado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un problema al actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //Close();
                    }
                }
                else
                {
                    //AGREGANDO O GUARDANDO UNO NUEVO
                    if (oEntidad.Guardar())
                    {
                        MessageBox.Show("Registro ingresado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un problema al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //Close();
                    }
                }
            }
            catch
            {

            }
        }

        private Boolean Comprobar()
        {
            Boolean Resultado = true;
            Notificador.Clear();
            if (txbRol.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbRol, "Este campo no puede quedar vacio");
            }
            return Resultado;
        }


        public RolesEdicion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Comprobar())
            {
                Procesar();
            }

        }

        private void txbIDRol_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
