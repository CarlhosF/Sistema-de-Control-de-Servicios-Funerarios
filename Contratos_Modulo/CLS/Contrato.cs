using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos_Modulo.CLS
{
   public  class Contrato
    {
        int _idcontratos;
        int _idTipoDeContrato;
        int _idServicio;
        String _extendido;
        String _FormaDePago;
        String _observaciones;
        String _Estado = "Activo";
        DateTime _Fecha = new DateTime().ToUniversalTime();
        int _idvendedor; 
        int _contratista;
        String _estado;
        float _saldo;
        int _beneficiario1;
        int _beneficiario2;

        public int Idcontratos
        {
            get
            {
                return _idcontratos;
            }

            set
            {
                _idcontratos = value;
            }
        }

        public int IdTipoDeContrato
        {
            get
            {
                return _idTipoDeContrato;
            }

            set
            {
                _idTipoDeContrato = value;
            }
        }

        public int IdServicio
        {
            get
            {
                return _idServicio;
            }

            set
            {
                _idServicio = value;
            }
        }

        public string Extendido
        {
            get
            {
                return _extendido;
            }

            set
            {
                _extendido = value;
            }
        }

        public string FormaDePago
        {
            get
            {
                return _FormaDePago;
            }

            set
            {
                _FormaDePago = value;
            }
        }

        public string Observaciones
        {
            get
            {
                return _observaciones;
            }

            set
            {
                _observaciones = value;
            }
        }

        public string Estado
        {
            get
            {
                return _Estado;
            }

            set
            {
                _Estado = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return _Fecha;
            }

            set
            {
                _Fecha = value;
            }
        }

        public int Idvendedor
        {
            get
            {
                return _idvendedor;
            }

            set
            {
                _idvendedor = value;
            }
        }

        public int Contratista
        {
            get
            {
                return _contratista;
            }

            set
            {
                _contratista = value;
            }
        }

        public string Estado1
        {
            get
            {
                return _estado;
            }

            set
            {
                _estado = value;
            }
        }

        public float Saldo
        {
            get
            {
                return _saldo;
            }

            set
            {
                _saldo = value;
            }
        }

        public int Beneficiario1
        {
            get
            {
                return _beneficiario1;
            }

            set
            {
                _beneficiario1 = value;
            }
        }

        public int Beneficiario2
        {
            get
            {
                return _beneficiario2;
            }

            set
            {
                _beneficiario2 = value;
            }
        }

        /*
public int idcontratos { get => _idcontratos; set => _idcontratos = value; }
public int idTipoDeContrato { get => _idTipoDeContrato; set => _idTipoDeContrato = value; }
public int idServicio{ get => _idServicio; set => _idServicio = value; }
public string extendido{ get => _extendido; set => _extendido = value; }
public string Estado{ get => _Estado; set => _Estado = value; }
public string FormaDePago{ get => _FormaDePago; set => _FormaDePago = value; }
public string observaciones{ get => _observaciones; set => _observaciones = value; }
public DateTime Fecha{ get => _Fecha; set => _Fecha = value; }
public int idvendedor{ get => _idvendedor; set => _idvendedor = value; }
public int idcliente { get => _contratista; set => _contratista = value; }
public string estado{ get => _estado; set => _estado = value; }
public float saldo{ get => _saldo; set => _saldo = value; }
public int beneficiario1{ get => _beneficiario1; set => _beneficiario1 = value; }
public int beneficiario2{ get => _beneficiario2; set => _beneficiario2 = value; }
*/

        public Boolean Guardar()
        {
            
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO contratos (extendido,tipoDeContrato,idservicios,formaspago,fecha,vendedor,contratista,Estado,monto,Beneficiario1,Beneficiario2,observaciones)
            VALUES ('"+this.Extendido+"',"+this.IdTipoDeContrato+","+this.IdServicio+", '"+this.FormaDePago+"', '"+this.Fecha.ToString("yyyy/MM/dd")+"',"+this.Idvendedor+","+this.Contratista+",'"+this.Estado+"',"+this.Saldo+","+this.Beneficiario1+","+this.Beneficiario2+", '"+this.Observaciones+"'); ";
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

        public Boolean ActualizarEstado(int id,string e)
        {
            Boolean Resultado = false;
            String Sentencia = @"update contratos SET Estado = '"+e+"' WHERE idcontratos ="+id+";";
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
        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            String Sentencia = @"update contratos SET Estado = '" + this.Estado + "',Extendido='"+this.Extendido+"', Observaciones='"+this.Observaciones+ "', fecha='"+ this.Fecha.ToString("yyyy/MM/dd") + "',contratista="+this.Contratista+ ",Beneficiario1="+this.Beneficiario1+ ",Beneficiario2=" + this.Beneficiario2 + " WHERE idcontratos =" + this.Idcontratos + ";";
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

        public Boolean Eliminar(int id)
        {
            Boolean Resultado = false;
            String Sentencia = @"DELETE FROM contratos WHERE idcontratos = " + id + ";";
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
