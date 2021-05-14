using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**/using DataManager;
/**/using CacheManager;

namespace Servicios_Modulos.CLS
{
    class Servicio
    {
        int _idservicios;
        String _nombre;
        float _valorcontado;
        float _valorcuota;
        String _descripcion;
        float _prima;

        public int Idservicios { get => _idservicios; set => _idservicios = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public float Valorcontado { get => _valorcontado; set => _valorcontado = value; }
        public float Valorcuota { get => _valorcuota; set => _valorcuota = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public float Prima { get => _prima; set => _prima = value; }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO servicios(nombre,valorcontado,valorcuota,descripcion,prima) 
            VALUES(' " + this._nombre + " '," + this._valorcontado + ", " + this._valorcuota + " ,' " + this._descripcion + " '," + this._prima + " ); ";
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

        public Boolean Editar()
        {
            Boolean Resultado = false;
            String Sentencia = @"UPDATE servicios SET nombre=' " + this._nombre + " ' , valorcontado=" + this._valorcontado + ", valorcuota=" + this._valorcuota +", descripcion=' " + this._descripcion + " ' , prima=" + this._prima +"" +
                               "WHERE idservicios = "+ this._idservicios +";";
            Console.WriteLine(Sentencia);
            try
            {
                DataManager.CLS.OperacionBD Operacion = new DataManager.CLS.OperacionBD();
                if (Operacion.Actualizar(Sentencia) > 0)
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
            String Sentencia = @"DELETE FROM servicios WHERE idservicios = " + id + ";";
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
