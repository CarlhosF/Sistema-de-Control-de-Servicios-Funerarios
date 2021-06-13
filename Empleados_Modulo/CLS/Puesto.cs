using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_Modulo.CLS
{
    public class Puesto
    {
        int _idpuesto;
        string _Nombre;
        string _Descripcion;

        public int idpuesto 
        {
            get { return _idpuesto; }
            set { _idpuesto = value; }
        
        }
        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }

        }
        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }

        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            int ultimoIngreso = CacheManager.CLS.SucursalCache.Ultima_Ingreso() + 1;
            String Sentencia = @"INSERT INTO puestos(nombre,descripcion) VALUES(' " + this._Nombre + " ',' " + this._Descripcion+"');";
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
            catch( Exception e)
            {
                Console.WriteLine(e.Message);
                Resultado = false;
            }
            return Resultado;

        }
        public Boolean Editar()
        {
            Boolean Resultado = false;
            String Sentencia = @"UPDATE puestos SET nombre=' " + this._Nombre + " ' , descripcion=' " + this.Descripcion + "' WHERE idpuestos = " + this.idpuesto + ";";
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
            String Sentencia = @"DELETE FROM puestos WHERE idpuestos = " + id + ";";
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
