using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using CacheManager;

namespace CacheManager.CLS
{
    public class EmpleadosCache
    {
        
        public static DataTable Listar_Empleados_Para_Encargado()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"select concat(nombres, apellidos) as 'nombre', direccion from empleados;";
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
