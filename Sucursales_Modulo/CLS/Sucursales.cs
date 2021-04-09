using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManager;
using CacheManager;
namespace Sucursales_Modulo.CLS
{
    public class Sucursales
    {
        int _idsucursales;
        String _Direccion;
        String _Telefono;
        int _Encargado;

        public string Direccion
        {
            get
            {
                return _Direccion;
            }
            set
            {
                _Direccion = value;
            }
        }
        public string Telefono
        {
            get
            {
                return _Telefono;
            }
            set
            {
                _Telefono = value;
            }
        }
        public int idsucursales
        {
            get
            {
                return _idsucursales;
            }
            set
            {
                _idsucursales = value;
            }
        }
        public int Encargado
        {
            get
            {
                return _Encargado;
            }
            set
            {
                _Encargado = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            int ultimoIngreso = CacheManager.CLS.SucursalCache.Ultima_Ingreso();
            String Sentencia = @"INSERT INTO sucursales(direccion,teledono) VALUES(' " + this._Direccion+ " ',' " + this._Telefono + " ');"+
                @"Insert into sucursales_encargado(idSucursal,idEncargado) values(" + ultimoIngreso + " '," + this._Encargado + " ')";
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
            String Sentencia = @"UPDATE sucursales SET direccion=' " + this._Direccion + " ' , telefono=' " + this._Telefono + " ' " +
                "WHERE idsucursales = " + this._idsucursales + ";";
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
        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            String Sentencia = @"DELETE FROM sucursales WHERE idsucursales = " + this._idsucursales + ";";
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
