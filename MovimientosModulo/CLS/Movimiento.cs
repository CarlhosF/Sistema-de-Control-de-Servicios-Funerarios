using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovimientosModulo.CLS
{
    public class Movimiento
    {
        int _idMovimiento;
        int _idVendedor;
        int _idContrato;
        String _Concepto;
        float _Abono;
        DateTime _fecha = new DateTime();
        public int idMovimiento { get => _idMovimiento; set => _idMovimiento = value; }
        public int idVendedor { get => _idVendedor; set => _idVendedor = value; }
        public int idContrato { get => _idContrato; set => _idContrato = value; }
        public String Concepto { get => _Concepto; set => _Concepto = value; }
        public float Abono { get => _Abono; set => _Abono = value; }
        public DateTime fecha { get => _fecha; set => _fecha = value; }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO movimientos (Fecha,idContrato,Concepto,Abono,idEmpleado)
            VALUES ('" + this.fecha.ToString("yyyy/MM/dd") + "'," + this.idContrato + ",'" + this.Concepto + "'," + this.Abono + "," + this.idVendedor+ "); ";
            Console.WriteLine(Sentencia);
            try
            {
                DataManager.CLS.OperacionBD Operacion = new DataManager.CLS.OperacionBD();
                if (Operacion.Insertar(Sentencia) > 0)
                {
                    Resultado = true;

                }
                else
                {
                    Resultado = false;
                }
            }
            catch
            {
                Resultado = false;
            }
            return Resultado;

        }
        
        public Boolean Eliminar(int id)
        {
            Boolean Resultado = false;
            String Sentencia = @"DELETE FROM movimientos WHERE idmovimientos = " + id + ";";
            try
            {
                DataManager.CLS.OperacionBD Operacion = new DataManager.CLS.OperacionBD();
                if (Operacion.Eliminar(Sentencia) > 0)
                {
                    Resultado = true;
                }
                else
                {
                    Resultado = false;
                }
            }
            catch
            {
                Resultado = false;
            }
            return Resultado;
        }

    }
}
