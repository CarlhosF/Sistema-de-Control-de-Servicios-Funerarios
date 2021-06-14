using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CacheManager;
using DataManager;
namespace Empleados_Modulo.CLS
{
    public class Empleados
    {
        int _idEmpleado;
        string _Nombre;
        string _Apellido;
        DateTime _dt = new DateTime().ToUniversalTime();
        string _telefono;
        string _direccion;
        string _DUI;
        int _sucursal;
        string _fechaNacimiento;
        DateTime _fechaContratacion = new DateTime().ToUniversalTime();
        int _puesto;
        public DateTime dt 
        {
            get 
            {
                return _dt;
            }
            set 
            {
                _dt = value;
            }
        }
        public DateTime fechaContratacion
        {
            get
            {
                return _fechaContratacion;
            }
            set
            {
                _fechaContratacion = value;
            }
        }
        public int idEmpleado 
        {
            get 
            {
                return _idEmpleado;
            }
            set 
            {
                _idEmpleado = value;
            }
        
        }
        public int puesto
        {
            get
            {
                return _puesto;
            }
            set
            {
                _puesto = value;
            }

        }
        public int sucursal
        {
            get
            {
                return _sucursal;
            }
            set
            {
                _sucursal = value;
            }

        }
        public string Nombre 
        {
            get 
            {
                return _Nombre;
            }
            set 
            {
                _Nombre = value;
            }
        }
        public string DUI
        {
            get
            {
                return _DUI;
            }
            set
            {
                _DUI = value;
            }
        }
        public string Apellido 
        {
            get 
            {
                return _Apellido;
            }
            set 
            {
                _Apellido = value;
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


        public Boolean Guardar()
        {
            Boolean Resultado = false;
            int ultimoIngreso = CacheManager.CLS.SucursalCache.Ultima_Ingreso() + 1;
            String Sentencia = @"INSERT INTO empleados(nombres,apellidos,fechanacimiento,telefono,direccion,DUI,idsucursales,fechacontratacion,puesto) VALUES(' " + this._Nombre + " ',' " + this._Apellido + " ',' " + this.dt.ToString("yyyy/MM/dd") + " ',' " + this._telefono + " ',' " + this._direccion + " ',' " + this._DUI + " ', " + this._sucursal + " ,' " + this.fechaContratacion.ToString("yyyy/MM/dd") + " ', " + this.puesto + " );";
            Console.Write(Sentencia);

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
            String Sentencia = @"UPDATE empleados SET nombres=' " + this._Nombre + " ' , apellidos=' " + this._Apellido + " ', fechanacimiento=' " + this.dt.ToString("yyyy/MM/dd") + " ', telefono=' " + this._telefono + " ', direccion=' " + this._direccion + " ', DUI=' " + this._DUI + " ', idsucursales= " + this._sucursal + ", fechacontratacion=' " + this.fechaContratacion.ToString("yyyy/MM/dd") + " ', puesto= " + this._puesto + "  WHERE idEmpleados = " + this._idEmpleado + ";";
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
            String Sentencia = @"DELETE FROM empleados WHERE idEmpleados = " + id + ";";
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
