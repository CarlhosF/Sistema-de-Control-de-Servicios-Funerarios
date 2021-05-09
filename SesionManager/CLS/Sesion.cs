using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesionManager.CLS
{
    public sealed class Sesion
    {
        private static Sesion instancia = null;
        private static object padlock = new object();
        //MIS ATRIBUTOS
        String _Usuario;// ctrl +R+E Solo lectura borrar el set
        String _Rol;// ctrl +R+E Solo lectura borrar el set
        String _IDUsuario;// ctrl +R+E Solo lectura borrar el set
        String _Empleado;// ctrl +R+E Solo lectura borrar el set

        public static Sesion Instancia
        {
            get
            {
                if (instancia == null)
                {
                    lock (padlock)
                    {
                        if (instancia == null)
                        {
                            instancia = new Sesion();

                        }
                    }
                }
                return instancia;
            }
        }

        public string Usuario
        {
            get
            {
                return _Usuario;
            }
            /* solo para probar un concepto
            set
            {
                _Usuario = value;
            }*/
        }

        public string Rol
        {
            get
            {
                return _Rol;
            }
            /*
            set
            {
                _Rol = value;
            }*/
        }

        public string IDUsuario
        {
            get
            {
                return _IDUsuario;
            }
            /*
            set
            {
                _IDUsuario = value;
            }*/
        }

        public string Empleado
        {
            get
            {
                return _Empleado;
            }
            /*
            set
            {
                _Empleado = value;
            }*/
        }

        private Sesion()
        {
            //Usuario = "N/A";
        }

        public Boolean IniciarSesion(String pUsuario, String pClave)//esto ya se hizo en otra clase
        {
            Boolean Autorizado = false;
            DataTable DatosSesion = new DataTable();
            try
            {
                DatosSesion = CacheManager.CLS.Cache.INICIAR_SESION(pUsuario, pClave);
                if (DatosSesion.Rows.Count == 1)//validar que solo venga una fila
                {
                    _Usuario = DatosSesion.Rows[0]["idusuarios"].ToString();
                    _IDUsuario = DatosSesion.Rows[0]["Usuario"].ToString();
                    _Rol = DatosSesion.Rows[0]["rol"].ToString();
                    _Empleado = DatosSesion.Rows[0]["Empleado"].ToString();
                    //autorizar
                    Autorizado = true;
                    Console.Write("Autorizado");
                }
                else
                {
                    Autorizado = false;
                }
            }
            catch
            {
                Autorizado = false;

            }

            return Autorizado;
        }


    }
}
