using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DataManager.CLS
{
    public class OperacionBD : ConexionBD
    {
    
        private Int32 EjecutarSentencia(String pSentencia)
        {
            MySqlCommand Comando = new MySqlCommand();
            Int32 NumeroFilasAfectadas = 0;

            try
            {
                if (base.Conectar())
                {
                    Comando.Connection = base._Conexion;
                    Comando.CommandText = pSentencia;
                    NumeroFilasAfectadas = Comando.ExecuteNonQuery();
                    base.Desconectar();
                }

            }
            catch
            {
                NumeroFilasAfectadas = 0;
            }
            return NumeroFilasAfectadas;
        }

        public DataTable Consultar(String pConsulta)//parametrizar
        {
            MySqlCommand Comando = new MySqlCommand();
            MySqlDataAdapter Adaptador = new MySqlDataAdapter();
            DataTable Resultado = new DataTable();//agregar using
            try
            {
                if (base.Conectar())
                {
                    Comando.Connection = base._Conexion;
                    Comando.CommandType = CommandType.Text;
                    Comando.CommandText = pConsulta;
                    Adaptador.SelectCommand = Comando;
                    Adaptador.Fill(Resultado);
                    base.Desconectar();
                }
            }
            catch
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public Int32 Insertar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }

        public Int32 Actualizar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }

        public Int32 Eliminar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }    

    }
}
