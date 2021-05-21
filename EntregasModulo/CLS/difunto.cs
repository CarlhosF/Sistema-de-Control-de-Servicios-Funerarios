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
        public int iddifunto { get => _iddifunto; set => _iddifunto = value; }
        public int idcontrato { get => _idcontrato; set => _idcontrato = value; }
        public string nombres { get => _nombres; set => _nombres = value; }
        public string apellidos { get => _apellidos; set => _apellidos = value; }
        public string direccionDeToma { get => _direccionDeToma; set => _direccionDeToma = value; }
        public string direccionDeEntrega { get => _direccionDeEntrega; set => _direccionDeEntrega = value; }
        public string CausaMuerte { get => _CausaMuerte; set => _CausaMuerte = value; }
        public DateTime fechanacimiento { get => _fechanacimiento; set => _fechanacimiento = value; }
        public DateTime fechanMuerte { get => _fechanMuerte; set => _fechanMuerte = value; }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO difuntos(nombre,apellidos,Direcciondetoma,Direcciondeentrega,CausadeMuerte,FechadeMuerte,FechadeNacimiento,contrato) 
            VALUES('" + this._nombres + " ','" + this._apellidos + "','" + this.direccionDeToma + "','" + this._direccionDeEntrega + "','" + this.CausaMuerte + "','" + this.fechanMuerte.ToString("yyyy/MM/dd")+ "','" + this.fechanacimiento.ToString("yyyy/MM/dd") + "',"+this.idcontrato+"); ";
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
            String Sentencia = @"UPDATE difuntos SET nombre=' " + this.nombres + " ' , apellidos=' " + this.apellidos + " ' , Direcciondetoma=' " + this.direccionDeToma + " ' , Direcciondeentrega='" + this.direccionDeEntrega + "' , CausadeMuerte='" + this.CausaMuerte + "' , FechadeMuerte='" + this.fechanMuerte.ToString("yyyy/MM/dd") + "' , FechadeNacimiento='" + this.fechanacimiento.ToString("yyyy/MM/dd") + "',contrato="+this.idcontrato +
                         " WHERE iddifuntos = " + this.iddifunto + ";";
            
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
