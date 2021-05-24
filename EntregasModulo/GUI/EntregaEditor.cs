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
    public partial class EntregaEditor : Form
    {
        DataTable DT = new DataTable();
        int idcontrato;
        public EntregaEditor(int id)
        {
            InitializeComponent();
            DT = CacheManager.CLS.DifuntosCache.Traer_Difuntos(id);
            
        }

        private void EntregaEditor_Load(object sender, EventArgs e)
        {
            txbID.Text = DT.Rows[0][0].ToString();
            txb_nombres.Text= DT.Rows[0][1].ToString();
            txb_apellidos.Text= DT.Rows[0][2].ToString();
            txbdireccionToma.Text=DT.Rows[0][3].ToString();
            txbdireccionEntrega.Text= DT.Rows[0][4].ToString();
            txb_Causa.Text= DT.Rows[0][5].ToString();
            dtp_muerte.Value = DateTime.Parse(DT.Rows[0][6].ToString());
            dp_fechanacimiento.Value= DateTime.Parse(DT.Rows[0][7].ToString());
            idcontrato= int.Parse(DT.Rows[0][8].ToString());
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
                difunto.iddifunto = int.Parse(txbID.Text);
                difunto.idcontrato = idcontrato;
                difunto.nombres = txb_nombres.Text;
                difunto.apellidos = txb_apellidos.Text;
                difunto.CausaMuerte = txb_Causa.Text;
                difunto.direccionDeEntrega = txbdireccionEntrega.Text;
                difunto.direccionDeToma = txbdireccionToma.Text;
                difunto.fechanacimiento = dp_fechanacimiento.Value;
                difunto.fechanMuerte = dtp_muerte.Value;
                if (difunto.Editar())
                {
                    MessageBox.Show("Registro actualizado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se puede actualizar ese registro");
                }
            }
            catch
            {
                MessageBox.Show("Error al actualizar registro, intente rellenar los campos");
            }

        }
    }
}
