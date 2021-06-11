using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reporte.GUI
{
    public partial class ReporteCancelaciones : Form
    {
        int ID;
        public ReporteCancelaciones(Int32 id)
        {
            
            InitializeComponent();
            ID = id;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            /*
            DataTable Datos = new DataTable();
            Datos = CacheManager.CLS.ReporteCache.REPORTE_CANCELACIONES(txbIDContrato);
            REP.ReporteCancelaciones Reporte = new REP.ReporteCancelaciones();
            Reporte.SetDataSource(Datos);
            crvVisor.ReportSource = Reporte;*/
        }

        private void ReporteCancelaciones_Load(object sender, EventArgs e)
        {
            DataTable Datos = new DataTable();
            Datos = CacheManager.CLS.ReporteCache.REPORTE_CANCELACIONES(ID);
            REP.ReporteCancelaciones Reporte = new REP.ReporteCancelaciones();
            Reporte.SetDataSource(Datos);
            crvVisor.ReportSource = Reporte;
        }
    }
}
