using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CacheManager.CLS
{
    public static class Cache
    {
        public static DataTable PERMISOS_DE_UN_ROL(String pIDRol)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT
            a.IDOpcion,
            a.Opcion,
            IF(IFNULL((SELECT IDPermiso FROM permisos z WHERE z.IDRol=" + pIDRol + @" AND a.IDOpcion=z.IDOpcion),0)=0,0,1) as seleccion,
            IFNULL((SELECT IDPermiso FROM permisos z WHERE z.IDRol=" + pIDRol + @" AND a.IDOpcion=z.IDOpcion),0) as IDPermiso
            FROM opciones a ORDER BY Opcion ASC;";
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

        public static DataTable TODOS_LOS_ROLES()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT idroles, nombre FROM roles ORDER BY Rol;";
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



        public static DataTable INICIAR_SESION(String pUsuario, String pClave)//PARAMETRIZAR p
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.idusuarios, a.Usuario, 
        CONCAT(b.Nombres, ' ', b.Apellidos) Empleado,
		a.rol as 'rol' FROM usuarios a, empleados b
        WHERE a.Usuario = '" + pUsuario+ @"'
        AND a.clave = '" + pClave + @"'
        AND a.idempleados = b.idempleados ";
            
            try
            {
                Resultados = Consultor.Consultar(Consulta);
                Console.Write("Consulta hecha");
            }
            catch
            {
                Resultados = new DataTable();

            }
            return Resultados;
        }

    }
}
