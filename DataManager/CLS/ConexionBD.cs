using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Reflection;
using System.Xml;

namespace DataManager.CLS
{
    public class ConexionBD
    {
        XmlDocument xml = new XmlDocument();
        String Server = "bs2vkycio293yyx8k5ho-mysql.services.clever-cloud.com";
        String BD = "bs2vkycio293yyx8k5ho";
        String User = "ulpsvvxkuul8err8";
        String Password = "Woij0iK5icvCY0WxEoQr";

       
        

        protected MySqlConnection _Conexion;

        public ConexionBD()
        {
            _Conexion = new MySqlConnection();
            _Conexion.ConnectionString = $"server={Server};uid={User};pwd={Password};database={BD}";
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
