using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CacheManager.CLS
{
    public static class ContratosCache
    {
        public static DataTable Listar_Contratos()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.idcontratos as ID, a.extendido, b.nombre as Contrato, c.nombre as Servicio, a.formaspago, a.fecha, concat(d.nombres,d.apellidos) as Vendedor,
                    concat(e.nombres,e.apellidos) as Contratista, a.estado,a.saldo,(select concat(b.nombres,b.apellidos)   from contratos a, clientes b where a.beneficiario1=b.idclientes) as beneficiario_1,(select concat(b.nombres,b.apellidos)   from contratos a, clientes b where a.beneficiario2=b.idclientes) as beneficiario_2
                    FROM contratos a, tipodecontrato b,servicios c, empleados d, clientes e ,usuarios f
                    WHERE a.tipodecontrato=b.idTipoDeContrato && a.idservicios=c.idservicios  && a.contratista=e.idclientes && f.idusuarios=a.vendedor && d.idempleados=f.idempleados;";
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
        public static DataTable Listar_ContratosNetos()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"select * from contratos;";
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
        public static DataTable Traer_Contrato(int id)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"select * from contratos where idcontratos=" + id;
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
