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

        public int idcontratos { get => _idcontratos; set => _idcontratos = value; }
        public int idTipoDeContrato { get => _idTipoDeContrato; set => _idTipoDeContrato = value; }
        public int idServicio { get => _idServicio; set => _idServicio = value; }
        public string extendido { get => _extendido; set => _extendido = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string FormaDePago { get => _FormaDePago; set => _FormaDePago = value; }
        public string observaciones { get => _observaciones; set => _observaciones = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public int idvendedor { get => _idvendedor; set => _idvendedor = value; }
        public int idcliente { get => _contratista; set => _contratista = value; }
        public string estado { get => _estado; set => _estado = value; }
        public float saldo { get => _saldo; set => _saldo = value; }
        public int beneficiario1 { get => _beneficiario1; set => _beneficiario1 = value; }
        public int beneficiario2 { get => _beneficiario2; set => _beneficiario2 = value; }


        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO contratos (extendido,tipoDeContrato,idservicios,formaspago,fecha,vendedor,contratista,Estado,Saldo,Beneficiario1,Beneficiario2,observaciones)
            VALUES ('"+this._extendido+"',"+this.idTipoDeContrato+","+this._idServicio+", '"+this.FormaDePago+"', '"+this.Fecha.ToString("yyyy/MM/dd")+"',"+this.idvendedor+","+this.idcliente+",'"+this.Estado+"',"+this.saldo+","+this.beneficiario1+","+this.beneficiario2+", '"+this.observaciones+"'); ";
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
