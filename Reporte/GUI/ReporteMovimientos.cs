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
    public partial class ReporteMovimientos : Form
    {
        public ReporteMovimientos()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataTable Datos = new DataTable();
            Datos = CacheManager.CLS.ReporteCache.REPORTE(dtpFechaInicio.Text,dtpFechaFinal.Text);
            REP.ReporteMovimientos Reporte = new REP.ReporteMovimientos();
            Reporte.SetDataSource(Datos);
            crvVisor.ReportSource = Reporte;

        }
    }
}
