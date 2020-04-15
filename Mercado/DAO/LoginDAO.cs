using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado.DAO
{
    class LoginDAO
    {
        private V.LoginV loginv;
        private MySqlConnection con;
        private Conexao.Connection conexao;

        public bool ValidarLogin(String username, String senha)
        {
            con = new MySqlConnection();
            loginv = new V.LoginV();
            conexao = new Conexao.Connection();
            con.ConnectionString = conexao.getConnectionString();
            String query = "SELECT * FROM funcionarios WHERE username = ?username AND senha = ?senha";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?username", username);
                cmd.Parameters.AddWithValue("?senha", senha);
                cmd.ExecuteNonQuery();
                MySqlDataReader result = cmd.ExecuteReader();

                return result.Read();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
