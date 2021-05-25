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
        String Server = "Server=127.0.0.1;";
        String BD = "Database=funerariabd;";
        String User = "Uid=usuario;";
        String Password = "Pwd=contra;";

        public String Cargar() 
        {
            xml.Load("Conexion.xml");
           return xml.InnerText;
            
        }

        protected MySqlConnection _Conexion;

        public ConexionBD()
        {
            _Conexion = new MySqlConnection();
            Cargar();
            _Conexion.ConnectionString = Cargar();
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
