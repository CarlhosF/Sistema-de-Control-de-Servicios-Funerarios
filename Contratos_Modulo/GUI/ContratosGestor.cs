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
    public partial class ContratosGestor : Form
    {
        BindingSource _DATOS = new BindingSource();
        public ContratosGestor()
        {
            InitializeComponent();
        }
        private void Cargar()
        {
            _DATOS.DataSource = CacheManager.CLS.ContratosCache.Listar_Contratos();
            dt_contratos.DataSource = _DATOS.DataSource;
            this.UseWaitCursor = false;
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txb_Filtro.TextLength > 0)
            {
                _DATOS.Filter = "Vendedor LIKE '%" + txb_Filtro.Text+ "%' or contratista LIKE '%" + txb_Filtro.Text + "%'"; 
            }
            else
            {
                _DATOS.RemoveFilter();
            }
            dt_contratos.AutoGenerateColumns = false;
            dt_contratos.DataSource = _DATOS;
            lb_Registros.Text = (dt_contratos.Rows.Count).ToString() + " Registros Encontrados";//Alertar cuantos registros han sido encontrados
            dt_contratos.Columns[0].Width = 20;
            dt_contratos.Columns[4].Width = 40;
            dt_contratos.Columns[5].Width = 40;
            dt_contratos.Columns[8].Width = 50;
            dt_contratos.Columns[9].Width = 50;
        }

        private void ContratosGestor_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GUI.ContratoNuevo f = new ContratoNuevo();
            f.ShowDialog();
            Cargar();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnDetallar_Click(object sender, EventArgs e)
        {
            if (dt_contratos.SelectedRows.Count > 0)
            {
                GUI.ContratoDetalle cd = new ContratoDetalle(dt_contratos.SelectedRows[0]);
                cd.ShowDialog();
                Cargar();
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dt_contratos.SelectedRows.Count > 0)
            {
                GUI.ContratoDetalle cd = new ContratoDetalle(dt_contratos.SelectedRows[0]);
                cd.ShowDialog();
                Cargar();
            }
            else
            {
                MessageBox.Show("Seleccione un contrato");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (SesionManager.CLS.Sesion.Instancia.Rol != "Vendedor")
            {
                if (dt_contratos.SelectedRows.Count > 0)
                {
                    GUI.btnSelecBene1 f = new btnSelecBene1((int)dt_contratos.SelectedRows[0].Cells[0].Value);
                    f.ShowDialog();
                    Cargar();
                }
                else
                {
                    MessageBox.Show("Seleccione un contrato");
                }
            }
            else
            {
                MessageBox.Show("Acceso Denegado");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (SesionManager.CLS.Sesion.Instancia.Rol != "Vendedor")
            {
                if (dt_contratos.SelectedRows.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("¿Desea Eliminar el Contrato ID: " + dt_contratos.SelectedRows[0].Cells[0].Value + " ?", "Confirmacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        int id = (int)dt_contratos.SelectedRows[0].Cells[0].Value;
                        CLS.Contrato co = new CLS.Contrato();
                        try
                        {
                            if (co.Eliminar(id))
                            {
                                MessageBox.Show("Contrato eliminado");
                            }
                            else
                            {
                                MessageBox.Show("Este contrato no puede eliminarse");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Error al eliminar");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Seleccione un contrato");
                }
            }
            else
            {
                MessageBox.Show("Acceso Denegado");
            }
        }

        private void txb_Filtro_Click(object sender, EventArgs e)
        {

        }

        private void txb_Filtro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }
    }
}
