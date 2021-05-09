using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CacheManager.CLS
{
    public class UsuariosCache
    {
        public static DataTable Listar_Usuarios()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"select a.idusuarios, a.usuario,a.clave, a.rol,concat(c.nombres,c.apellidos) as empleado, c.DUI from usuarios a,empleados c where  a.idempleados=c.idempleados;";
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
        public static DataTable Listar_Usuarios_Neto()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"select * from usuarios;";
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
        public static DataTable Traer_Usuario(int id)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"select * from usuarios where idusuarios=" + id;
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
