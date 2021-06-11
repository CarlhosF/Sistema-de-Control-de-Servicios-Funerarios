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

        public int IdMovimiento
        {
            get
            {
                return _idMovimiento;
            }

            set
            {
                _idMovimiento = value;
            }
        }

        public int IdVendedor
        {
            get
            {
                return _idVendedor;
            }

            set
            {
                _idVendedor = value;
            }
        }

        public int IdContrato
        {
            get
            {
                return _idContrato;
            }

            set
            {
                _idContrato = value;
            }
        }

        public string Concepto
        {
            get
            {
                return _Concepto;
            }

            set
            {
                _Concepto = value;
            }
        }

        public float Abono
        {
            get
            {
                return _Abono;
            }

            set
            {
                _Abono = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return _fecha;
            }

            set
            {
                _fecha = value;
            }
        }

        /*
public int idMovimiento { get => _idMovimiento; set => _idMovimiento = value; }
public int idVendedor { get => _idVendedor; set => _idVendedor = value; }
public int idContrato { get => _idContrato; set => _idContrato = value; }
public String Concepto { get => _Concepto; set => _Concepto = value; }
public float Abono { get => _Abono; set => _Abono = value; }
public DateTime fecha { get => _fecha; set => _fecha = value; }
*/
        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO movimientos (Fecha,idContrato,Concepto,Abono,idEmpleado)
            VALUES ('" + this.Fecha.ToString("yyyy/MM/dd") + "'," + this.IdContrato + ",'" + this.Concepto + "'," + this.Abono + "," + this.IdVendedor+ "); ";
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
