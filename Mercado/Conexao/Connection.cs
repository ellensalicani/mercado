using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Mercado.Conexao
{
    public class Connection
    {
        private String connectionString;

        public String getConnectionString()
        {
            connectionString = ConfigurationManager.ConnectionStrings["firma.Properties.Settings.crudConnectionString"].ConnectionString;
            return connectionString;
        }
    }
}
