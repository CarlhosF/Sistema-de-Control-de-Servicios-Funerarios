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

        private void btnEstablecerContra_Click(object sender, EventArgs e)
        {
            using (var form = new EstablecerContratista())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txbIDContratista.Text = form.id.ToString();
                    DataTable DT = CacheManager.CLS.ClientesCache.Traer_Clientes(form.id);
                    txbContratista.Text = DT.Rows[0]["nombres"].ToString() + " " + DT.Rows[0]["apellidos"].ToString();
                }
            }
        }

        private void btnEstableceBene1_Click(object sender, EventArgs e)
        {
            using (var form = new EstablecerContratista())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txbIDBene1.Text = form.id.ToString();
                    DataTable DT = CacheManager.CLS.ClientesCache.Traer_Clientes(form.id);
                    txbBene1.Text = DT.Rows[0]["nombres"].ToString() + " " + DT.Rows[0]["apellidos"].ToString();
                }
            }
        }

        private void btnEstableceBene2_Click(object sender, EventArgs e)
        {
            using (var form = new EstablecerContratista())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txbIDBene2.Text = form.id.ToString();
                    DataTable DT = CacheManager.CLS.ClientesCache.Traer_Clientes(form.id);
                    txbBene2.Text = DT.Rows[0]["nombres"].ToString() + " " + DT.Rows[0]["apellidos"].ToString();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CLS.Contrato co = new CLS.Contrato();
            co.Idcontratos = int.Parse(txbIDcontrato.Text);
            co.Fecha = dtpFecha.Value;
            co.Observaciones = txbObservaciones.Text;
            co.Extendido = txbExtendido.Text;
            co.Estado = lstbEstado.SelectedItem.ToString();
            co.Contratista= int.Parse(txbIDContratista.Text);
            co.Beneficiario1= int.Parse(txbIDBene1.Text);
            co.Beneficiario2= int.Parse(txbIDBene2.Text);
            try
            {
                if (co.Corregir())
                {
                    MessageBox.Show("Registro actualizado");
                }
                else
                {
                    MessageBox.Show("NO se pudo actualizar el contrato");
                }
            }
            catch
            {
                MessageBox.Show("Error al actualizar el registro");
            }

        }
    }
}
