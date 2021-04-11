using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CacheManager.CLS
{
    public static class SucursalCache
    {
        
        public static DataTable Listar_Sucursales()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.idsucursales as 'ID', a.direccion, a.telefono, concat(b.nombres,b.apellidos) as'Encargado'
            FROM sucursales a, empleados b, sucursales_encargados c where c.idEncargado = b.idempleados and c.idSucursal=a.idsucursales;";
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
        public static DataTable Traer_Sucursal(int id)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.idsucursales as 'ID', a.direccion, a.telefono, concat(b.nombres,b.apellidos) as'Encargado'
                                FROM sucursales a, empleados b, sucursales_encargados c 
                                where a.idsucursales="+id+" and c.idSucursal="+id+" and b.idempleados=c.idEncargado;";
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

        public static int Ultima_Ingreso() 
        {
            int id=-1;
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"select idsucursales
                                  from sucursales
                                 order by idsucursales desc
                                 limit 1;";
            try
            {
                Resultados = Consultor.Consultar(Consulta);
            }
            catch
            {
                Resultados = new DataTable();

            }
            if (Resultados.Rows.Count == 1)//validar que solo venga una fila
            {
                id = (int)Convert.ToInt64(Resultados.Rows[0]["idsucursales"]);
              
            }

            return id;
        }
    }
}
