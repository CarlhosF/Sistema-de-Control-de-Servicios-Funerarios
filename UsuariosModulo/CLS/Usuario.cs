using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CacheManager;
namespace UsuariosModulo.CLS
{
    class Usuario
    {
        int _idusuario;
        String _usuario;
        String _clave;
        String _idrol;
        int _idempleado;
        public string usuario 
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public string clave
        {
            get { return _clave; }
            set { _clave = value; }
        }
        public int idusuario 
        {
            get { return _idusuario; }
            set { _idusuario = value; }
        }
        public int idempleado
        {
            get { return _idempleado; }
            set { _idempleado = value; }
        }
        public String idrol
        {
            get { return _idrol; }
            set { _idrol = value; }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO usuarios(usuario,clave,rol,idempleados) 
            VALUES('" + this.usuario + "','" + this.clave + "',' " + this.idrol + " ',' " + this.idempleado + " '); ";
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
            String Sentencia = @"UPDATE usuarios SET usuario=' " + this.usuario + " ' , rol=' " + this.idrol + " ' , idempleados= " + this.idempleado + "  "+
                               "WHERE idusuarios = " + this._idusuario + ";";
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
            String Sentencia = @"DELETE FROM usuarios WHERE idusuarios = " + id + ";";
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
