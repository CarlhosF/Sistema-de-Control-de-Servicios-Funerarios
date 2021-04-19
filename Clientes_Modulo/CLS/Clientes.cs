using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManager;
using CacheManager;
namespace Clientes_Modulo.CLS
{
    public class Clientes
    {
        int _idclientes;
        String _nombres;
        String _apellidos;
        String _dui;
        String _direccion;
        String _fechanacimiento;
        String _telefono;
        String _oficio;

        public int Idclientes
        {
            get
            {
                return _idclientes;
            }

            set
            {
                _idclientes = value;
            }
        }

        public string Nombres
        {
            get
            {
                return _nombres;
            }

            set
            {
                _nombres = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return _apellidos;
            }

            set
            {
                _apellidos = value;
            }
        }

        public string Dui
        {
            get
            {
                return _dui;
            }

            set
            {
                _dui = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _direccion;
            }

            set
            {
                _direccion = value;
            }
        }

        public string Fechanacimiento
        {
            get
            {
                return _fechanacimiento;
            }

            set
            {
                _fechanacimiento = value;
            }
        }

        public string Telefono
        {
            get
            {
                return _telefono;
            }

            set
            {
                _telefono = value;
            }
        }

        public string Oficio
        {
            get
            {
                return _oficio;
            }

            set
            {
                _oficio = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO clientes(nombres,apellidos,dui,direccion,fechanacimiento,telefono,oficio) 
            VALUES(' " + this._nombres + " ',' " + this._apellidos + " ',' " + this._dui + " ',' " + this._direccion + " ',' " + this._fechanacimiento + " ',' " + this._telefono + " ',' " + this._oficio + " '); ";
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
            String Sentencia = @"UPDATE clientes SET nombres=' " + this._nombres + " ' , apellidos=' " + this._apellidos + " ' , dui=' " + this._dui + " ' , direccion=' " + this._direccion + " ' , fechanacimiento=' " + this._fechanacimiento + " ' , telefono=' " + this._telefono + " ' , oficio=' " + this._oficio + " ' " +
                               "WHERE idclientes = " + this._idclientes + ";";
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
            String Sentencia = @"DELETE FROM clientes WHERE idclientes = " + id + ";";
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
