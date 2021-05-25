using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contratos_Modulo.GUI
{
    public partial class ContratoDetalle : Form
    {
        DataGridViewRow DRContrato;
        int idContrato;
        int idServicio;
        int idTipoContrato;
        DataTable DTcontrato = new DataTable();
        DataTable DTServicio = new DataTable();
        DataTable DTtipoContrato = new DataTable();
        public ContratoDetalle(DataGridViewRow DR)
        {
            InitializeComponent();
            DRContrato = DR;
            idContrato = int.Parse(DRContrato.Cells[0].Value.ToString());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ContratoDetalle_Load(object sender, EventArgs e)
        {

        }
    }
}
