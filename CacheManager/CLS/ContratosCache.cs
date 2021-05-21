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
            String Consulta = @"SELECT a.idcontratos as ID, a.extendido, b.nombre as Contrato, c.nombre as Servicio, a.formaspago, a.fecha, concat(d.nombres,' ',d.apellidos) as Vendedor,
                    concat(e.nombres,' ',e.apellidos) as Contratista, a.estado,a.monto
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
        public static DataTable Listar_Contratos_ActivosMoroso()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"select a.idcontratos,a.extendido,a.fecha,concat(b.nombres,' ',b.apellidos) as cliente,concat(e.nombres,' ',e.apellidos) as 'Vendido por:',a.estado,a.monto
                        from contratos a,clientes b, usuarios c, empleados e
                        where  a.contratista=b.idclientes and c.idempleados=e.idempleados and a.vendedor=c.idusuarios and  (a.formaspago='Cuotas' and a.estado='Activo' or a.estado='Moroso')
                        order by a.idcontratos;";
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
        public static DataTable Listar_Contratos_Cancelados()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"select a.idcontratos,a.extendido,a.fecha,concat(b.nombres,' ',b.apellidos) as cliente,concat(e.nombres,' ',e.apellidos) as 'Vendido por:',d.nombre as Contrato,f.nombre as Servicio,d.tratamiento as 'Tratamientos disponible'
                        from contratos a,clientes b, usuarios c, empleados e,tipodecontrato d, servicios f
                        where a.idservicios=f.idservicios and d.idtipodecontrato=a.tipoDeContrato and a.contratista=b.idclientes and c.idempleados=e.idempleados and a.vendedor=c.idusuarios and  (a.estado='Cancelado')
                        order by a.idcontratos;";
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
