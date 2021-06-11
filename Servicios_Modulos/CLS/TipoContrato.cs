using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**/using DataManager;
/**/using CacheManager;

namespace Servicios_Modulos.CLS
{
    class TipoContrato
    {
        int _idTipoDeContrato;
        String _nombre;
        String _Descripcion;
        float _factor;
        int _tratamientos;

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

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }

            set
            {
                _Descripcion = value;
            }
        }

        public float Factor
        {
            get
            {
                return _factor;
            }

            set
            {
                _factor = value;
            }
        }

        public int Tratamientos
        {
            get
            {
                return _tratamientos;
            }

            set
            {
                _tratamientos = value;
            }
        }

        /*
public int IdTipoDeContrato { get => _idTipoDeContrato; set => _idTipoDeContrato = value; }
public float factor { get => _factor; set => _factor = value; }
public string Nombre { get => _nombre; set => _nombre = value; }
public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
public int tratamientos { get => _tratamientos; set => _tratamientos = value; }
*/
        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO tipodecontrato(nombre,Descripcion,factor,tratamiento) 
            VALUES('" + this.Nombre + "','" + this.Descripcion + "', " + this.Factor + ","+this.Tratamientos+" ); ";
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
            String Sentencia = @"UPDATE tipodecontrato SET nombre=' " + this.Nombre + " ' , Descripcion=' " + this.Descripcion + " ' " +",factor="+this.Factor+""+
                               "WHERE idTipoDeContrato = " + this.IdTipoDeContrato + ";";
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
            String Sentencia = @"DELETE FROM tipodecontrato WHERE idTipoDeContrato = " + id + ";";
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
