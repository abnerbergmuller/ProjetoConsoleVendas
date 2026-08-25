using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoConsoleVendas.Connection
{
    public class ConnectionFactory
    {
        //Metodo que conecta o banco de dados

        public MySqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString;
            return new MySqlConnection(connectionString);
        }
    }
}
