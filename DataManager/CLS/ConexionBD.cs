using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataManager.CLS
{
    public class ConexionBD
    {
        String _CadenaConexion = "Server=127.0.0.1;Database=funerariabd;Uid=usuario;Pwd=contra;";
        protected MySqlConnection _Conexion;

        public ConexionBD()
        {
            _Conexion = new MySqlConnection();
            _Conexion.ConnectionString = _CadenaConexion;
        }

        protected Boolean Conectar()
        {
            Boolean Conectado = false;

            try
            {
                _Conexion.Open();
                Conectado = true;
            }
            catch
            {
                Conectado = false;
            }
            return Conectado;//para saber si estoy conectado o no
        }

        protected void Desconectar()
        {
            try
            {
                if (_Conexion.State == System.Data.ConnectionState.Open)
                {
                    _Conexion.Close();
                }
            }
            catch
            {

            }
        }

    }
}
