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
    public partial class btnSelecBene1 : Form
    {
        int idContrato;
        DataTable DTContrato = new DataTable();
        DataTable Cliente = new DataTable();

        public btnSelecBene1(int id)
        {
            InitializeComponent();
            idContrato = id;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContratoCorrector_Load(object sender, EventArgs e)
        {
            txbIDcontrato.Text = idContrato.ToString();
            DTContrato = CacheManager.CLS.ContratosCache.Traer_Contrato(idContrato);
            txbIDContratista.Text = DTContrato.Rows[0]["Contratista"].ToString();
            Cliente = CacheManager.CLS.ClientesCache.Traer_Clientes(int.Parse(txbIDContratista.Text));
            txbContratista.Text = Cliente.Rows[0]["nombres"].ToString() + " " + Cliente.Rows[0]["apellidos"].ToString();
            txbIDBene1.Text= DTContrato.Rows[0]["Beneficiario1"].ToString();
            Cliente = CacheManager.CLS.ClientesCache.Traer_Clientes(int.Parse(txbIDBene1.Text));
            txbBene1.Text = Cliente.Rows[0]["nombres"].ToString() + " " + Cliente.Rows[0]["apellidos"].ToString();
            txbIDBene2.Text = DTContrato.Rows[0]["Beneficiario2"].ToString();
            Cliente = CacheManager.CLS.ClientesCache.Traer_Clientes(int.Parse(txbIDBene2.Text));
            txbBene2.Text = Cliente.Rows[0]["nombres"].ToString() + " " + Cliente.Rows[0]["apellidos"].ToString();
            txbExtendido.Text = DTContrato.Rows[0]["Extendido"].ToString();
            txbObservaciones.Text = DTContrato.Rows[0]["Observaciones"].ToString();
            dtpFecha.Value =DateTime.Parse(DTContrato.Rows[0]["Fecha"].ToString());
            lstbEstado.SelectedItem= DTContrato.Rows[0]["Estado"].ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
