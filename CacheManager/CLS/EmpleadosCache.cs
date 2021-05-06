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
            String Consulta = @"SELECT idempleados as 'ID',concat(nombres, apellidos) as 'Nombre', direccion
                              FROM empleados
                             WHERE idempleados NOT IN (SELECT idEncargado
                                                   FROM sucursales_encargados);";
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
        public static DataTable Listar_Empleados()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.idEmpleados,a.nombres, a.apellidos,a.fechanacimiento,a.direccion,a.telefono,a.fechacontratacion,b.direccion as 'Labora en: ',
                                c.nombre as 'Puesto: '
                                from empleados a, sucursales b, puestos c
                                where a.idsucursales=b.idsucursales and a.puesto = c.idpuestos;";
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

        public static DataTable Traer_Empleado(int id)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT * from empleados where idempleados="+id;
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
