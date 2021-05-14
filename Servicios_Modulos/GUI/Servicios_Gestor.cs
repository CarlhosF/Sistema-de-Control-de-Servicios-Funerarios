using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CacheManager;

namespace Servicios_Modulos.GUI
{
    public partial class Servicios_Gestor : Form
    {
        BindingSource _DATOS = new BindingSource();
        public Servicios_Gestor()
        {
            InitializeComponent();
        }

        private void btnAgregarS_Click(object sender, EventArgs e)
        {
            GUI.Contratos.Nuevo_Contrato f = new Contratos.Nuevo_Contrato();
            f.Show();
            Cargar();
        }
        public void Cargar()
        {
            dt_Servicios.DataSource = CacheManager.CLS.ServicioCache.Listar_Servicios();
            dt_TipoDeContrato.DataSource = CacheManager.CLS.TipoDeContrato.Listar_TipoDeContrato();


        }

        private void Servicios_Gestor_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void dt_Servicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_EliminarServicio_Click(object sender, EventArgs e)
        {
            if (dt_Servicios.SelectedRows.Count > 0)
            {
                int id = (int)dt_Servicios.SelectedRows[0].Cells[0].Value;
                CLS.Servicio s = new CLS.Servicio();
                s.Eliminar(id);
                Cargar();
            }
            else 
            {
                MessageBox.Show("Seleccione el servicio a eliminar");
            }
        }

        private void btn_ActualizarServicio_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btn_ActualizarContrato_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btn_AgregarContrato_Click(object sender, EventArgs e)
        {
            GUI.Servicios.Nuevo_Servicio f = new Servicios.Nuevo_Servicio();
            f.Show();
            Cargar();
        }

        private void btn_EliminarTipoContr_Click(object sender, EventArgs e)
        {
            if (dt_TipoDeContrato.SelectedRows.Count > 0)
            {
                int id = (int)dt_TipoDeContrato.SelectedRows[0].Cells[0].Value;
                CLS.TipoContrato s = new CLS.TipoContrato();
                s.Eliminar(id);
                Cargar();
            }
            else
            {
                MessageBox.Show("Seleccione el Tipo de Contrato a eliminar");
            }
        }
    }
}
