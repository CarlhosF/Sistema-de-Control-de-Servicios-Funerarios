using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CacheManager.CLS
{
    public static class ServicioCache
    {
        public static DataTable Listar_Servicios()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.idservicios as 'ID', a.nombre, a.valorcontado as 'Precio al Contado', a.valorcuota as 'Precio por Cuotas', a.descripcion, a.prima
            FROM servicios a;";
            try
            {
                Resultados = Consultor.Consultar(Consulta);
            }
            catch
            {
                Resultados = new DataTable();

            }
            return Resultados;
        }
        public static DataTable Traer_Servicio(int id)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.idservicios as 'ID', a.nombre, a.valorcontado as 'Precio al Contado', a.valorcuota as 'Precio por Cuotas', a.descripcion, a.prima
            FROM servicios a Where idservicios="+id;
            try
            {
                Resultados = Consultor.Consultar(Consulta);
            }
            catch
            {
                Resultados = new DataTable();

            }
            return Resultados;
        }

    

    }
}
