using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregasModulo.CLS
{
    public class difunto
    {
        int _iddifunto;
        int _idcontrato;
        String _nombres;
        String _apellidos;
        String _direccionDeToma;
        String _direccionDeEntrega;
        DateTime _fechanacimiento;
        DateTime _fechanMuerte;
        String _CausaMuerte;

        public int Iddifunto
        {
            get
            {
                return _iddifunto;
            }

            set
            {
                _iddifunto = value;
            }
        }

        public int Idcontrato
        {
            get
            {
                return _idcontrato;
            }

            set
            {
                _idcontrato = value;
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

        public string DireccionDeToma
        {
            get
            {
                return _direccionDeToma;
            }

            set
            {
                _direccionDeToma = value;
            }
        }

        public string DireccionDeEntrega
        {
            get
            {
                return _direccionDeEntrega;
            }

            set
            {
                _direccionDeEntrega = value;
            }
        }

        public DateTime Fechanacimiento
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

        public DateTime FechanMuerte
        {
            get
            {
                return _fechanMuerte;
            }

            set
            {
                _fechanMuerte = value;
            }
        }

        public string CausaMuerte
        {
            get
            {
                return _CausaMuerte;
            }

            set
            {
                _CausaMuerte = value;
            }
        }

        /*
public int iddifunto { get => _iddifunto; set => _iddifunto = value; }
public int idcontrato { get => _idcontrato; set => _idcontrato = value; }
public string nombres { get => _nombres; set => _nombres = value; }
public string apellidos { get => _apellidos; set => _apellidos = value; }
public string direccionDeToma { get => _direccionDeToma; set => _direccionDeToma = value; }
public string direccionDeEntrega { get => _direccionDeEntrega; set => _direccionDeEntrega = value; }
public string CausaMuerte { get => _CausaMuerte; set => _CausaMuerte = value; }
public DateTime fechanacimiento { get => _fechanacimiento; set => _fechanacimiento = value; }
public DateTime fechanMuerte { get => _fechanMuerte; set => _fechanMuerte = value; }
*/
        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO difuntos(nombre,apellidos,Direcciondetoma,Direcciondeentrega,CausadeMuerte,FechadeMuerte,FechadeNacimiento,contrato) 
            VALUES('" + this.Nombres + " ','" + this.Apellidos + "','" + this.DireccionDeToma + "','" + this.DireccionDeEntrega + "','" + this.CausaMuerte + "','" + this.FechanMuerte.ToString("yyyy/MM/dd")+ "','" + this.Fechanacimiento.ToString("yyyy/MM/dd") + "',"+this.Idcontrato+"); ";
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
            String Sentencia = @"UPDATE difuntos SET nombre=' " + this.Nombres + " ' , apellidos=' " + this.Apellidos + " ' , Direcciondetoma=' " + this.DireccionDeToma + " ' , Direcciondeentrega='" + this.DireccionDeEntrega + "' , CausadeMuerte='" + this.CausaMuerte + "' , FechadeMuerte='" + this.FechanMuerte.ToString("yyyy/MM/dd") + "' , FechadeNacimiento='" + this.Fechanacimiento.ToString("yyyy/MM/dd") + "',contrato="+this.Idcontrato +
                         " WHERE iddifuntos = " + this.Iddifunto + ";";
            
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
            String Sentencia = @"DELETE FROM difuntos WHERE iddifuntos = " + id + ";";
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
