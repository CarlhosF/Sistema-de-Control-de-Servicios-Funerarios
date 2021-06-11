using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CacheManager.CLS
{
    public static class ReporteCache
    {
        public static DataTable REPORTE(String pFechaInicio, String pFechaFinal)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT 
                                a.idMovimientos,
                                a.Fecha,
                                a.idContrato as 'Id Contrato',                                
								concat(c.nombres, ' ', c.apellidos) Cliente,
                                a.Abono
                                FROM movimientos a, contratos b, clientes c
                                WHERE a.idContrato = b.idContratos and c.idclientes = b.contratista
                                AND a.Fecha between '" + pFechaInicio + "' AND '" + pFechaFinal + @"'
                                group by a.idMovimientos;";           

            /*
             SELECT 
                                a.idMovimientos,
                                a.Fecha,
                                b.idclientes,                                
                                (select nombres FROM funerariabd.clientes z WHERE z.idclientes=b.idclientes) clientes,
                                a.Concepto,
                                round(sum(a.Abono),2) Total
                                FROM funerariabd.movimientos a, funerariabd.contratos b
                                WHERE a.idContrato=b.idContrato
                                AND Fecha between '" + pFechaInicio + "' AND '" + pFechaFinal + @"' 
                                group by a.idMovimientos;
             */
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
        public static DataTable REPORTE_CLIENTE_PAGO(Int32 pDia)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT                          
                                        c.idclientes as ID,
                                        b.Idcontratos as Contrato,
                                        concat(c.nombres,' ',c.apellidos) Cliente,
                                        c.direccion,
                                        c.telefono,
                                        c.dui
                                        FROM contratos b, clientes c
                                        WHERE  c.idclientes=b.contratista
                                        AND day(b.fecha)='" + pDia + @"'
                                        ;";
             
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
        public static DataTable REPORTE_CANCELACIONES(int pIdcontrato)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT                     
                                        b.idcontratos,     
                                        c.idclientes as ID,
                                        concat(c.nombres,' ',c.apellidos) Cliente,
                                        e.idTipoDeContrato,
                                        e.nombre as TipoContrato,
                                        d.idservicios,
                                        d.nombre as Servicio,
                                        b.fecha,
                                        b.extendido,
                                        b.Precio
                                        FROM contratos b, clientes c, servicios d, tipodecontrato e
                                        WHERE  c.idclientes=b.contratista
                                        AND b.idservicios=d.idservicios
                                        AND b.tipoDeContrato=e.idTipoDeContrato
                                        AND b.idcontratos='" + pIdcontrato + @"'
                                        ;";

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
