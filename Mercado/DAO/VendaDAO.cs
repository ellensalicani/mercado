using MySql.Data.MySqlClient;
using Firma.Helpers;
using Mercado.Conexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mime;
using System.Net.Configuration;
using System.Net;
using System.Configuration;
using System.Web;

namespace Mercado.DAO
{
    class VendaDAO
    {
        private V.VendaV vendav;
        private MySqlConnection con;
        private Connection conexao;

        public void InserirVenda(Double valor_unitario, Double valor_total, int qnt_produto, DateTime datahora_venda, int id_produto, int id_cliente)
        {
            con = new MySqlConnection();
            vendav = new V.VendaV();
            conexao = new Connection();
            con.ConnectionString = conexao.getConnectionString();
            String query = "INSERT INTO cliente(codigo_venda, valor_unitario, valor_total, qnt_produto, datahora_venda, id_produto, id_cliente)";
            query += " VALUES (null, ?valor_unitario, ?valor_total, ?qnt_produto, ?datahora_venda, ?id_produto, ?id_cliente)";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?valor_unitario", valor_unitario);
                cmd.Parameters.AddWithValue("?valor_total", valor_total);
                cmd.Parameters.AddWithValue("?qnt_produto", qnt_produto);
                cmd.Parameters.AddWithValue("?datahora_venda", datahora_venda);
                cmd.Parameters.AddWithValue("?id_produto", id_produto);
                cmd.Parameters.AddWithValue("?id_cliente", id_cliente);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                con.Close();
            }

        }

    }
}
