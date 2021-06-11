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
    public partial class ReporteClientePago : Form
    {
        public ReporteClientePago()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            DataTable Datos = new DataTable();
            Datos = CacheManager.CLS.ReporteCache.REPORTE_CLIENTE_PAGO(dtpDia.Value.Day);
            REP.ReporteClientePago Reporte = new REP.ReporteClientePago();
            Reporte.SetDataSource(Datos);
            crvVisor.ReportSource = Reporte;
        }
    }
}
