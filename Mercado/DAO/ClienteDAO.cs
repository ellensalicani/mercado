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
    public class ClienteDAO
    {
        private V.ClienteV cadastrov;
        private MySqlConnection con;
        private Connection conexao;

        public void InserirCliente(String nome, String sobrenome, String cpf, int ddd, int telefone, String email, DateTime dataNasc, String pais, String estado,
            String rua, int numero, String bairro, int cep, String cidade)
        {
            var nomeCompleto = nome + " " + sobrenome;

            con = new MySqlConnection();
            cadastrov = new V.ClienteV();
            conexao = new Connection();
            con.ConnectionString = conexao.getConnectionString();
            String query = "INSERT INTO cliente(ID, nome_completo, nome, sobrenome, cpf, ddd, telefone, email, data_nascimento, pais, estado, rua, numero, bairro, cep, cidade)";
            query += " VALUES (null, ?nomeCompleto, ?nome, ?sobrenome, ?cpf, ?ddd, ?telefone, ?email, ?dataNasc, ?pais, ?estado, ?rua, ?numero, ?bairro, ?cep, ?cidade)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?nomeCompleto", nomeCompleto);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?sobrenome", sobrenome);
                cmd.Parameters.AddWithValue("?cpf", cpf);
                cmd.Parameters.AddWithValue("?ddd", ddd);
                cmd.Parameters.AddWithValue("?telefone", telefone);
                cmd.Parameters.AddWithValue("?email", email);
                cmd.Parameters.AddWithValue("?dataNasc", dataNasc);
                cmd.Parameters.AddWithValue("?pais", pais);
                cmd.Parameters.AddWithValue("?estado", estado);
                cmd.Parameters.AddWithValue("?rua", rua);
                cmd.Parameters.AddWithValue("?numero", numero);
                cmd.Parameters.AddWithValue("?bairro", bairro);
                cmd.Parameters.AddWithValue("?cep", cep);
                cmd.Parameters.AddWithValue("?cidade", cidade);
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

        public void AlterarCliente(int id, String nome, String sobrenome, String cpf, int ddd, int telefone, String email, DateTime dataNasc, String pais, String estado,
            String rua, int numero, String bairro, int cep, String cidade)
        {
            var nomeCompleto = nome + " " + sobrenome;

            con = new MySqlConnection();
            cadastrov = new V.ClienteV();
            conexao = new Connection();
            con.ConnectionString = conexao.getConnectionString();
            String query = "update cliente set nome_completo = ?nomeCompleto, nome = ?nome, sobrenome = ?sobrenome, cpf = ?cpf, ddd = ?ddd, telefone = ?telefone, email = ?email, data_nascimento = ?dataNasc, pais = ?pais, estado = ?estado, rua = ?rua, numero = ?numero, bairro = ?bairro, cep = ?cep, cidade = ?cidade";
            query += " where id = ?id";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id", id);
                cmd.Parameters.AddWithValue("?nomeCompleto", nomeCompleto);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?sobrenome", sobrenome);
                cmd.Parameters.AddWithValue("?cpf", cpf);
                cmd.Parameters.AddWithValue("?ddd", ddd);
                cmd.Parameters.AddWithValue("?telefone", telefone);
                cmd.Parameters.AddWithValue("?email", email);
                cmd.Parameters.AddWithValue("?dataNasc", dataNasc);
                cmd.Parameters.AddWithValue("?pais", pais);
                cmd.Parameters.AddWithValue("?estado", estado);
                cmd.Parameters.AddWithValue("?rua", rua);
                cmd.Parameters.AddWithValue("?numero", numero);
                cmd.Parameters.AddWithValue("?bairro", bairro);
                cmd.Parameters.AddWithValue("?cep", cep);
                cmd.Parameters.AddWithValue("?cidade", cidade);
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

        public void ExcluirCliente(int id)
        {
            con = new MySqlConnection();
            cadastrov = new V.ClienteV();
            conexao = new Connection();
            con.ConnectionString = conexao.getConnectionString();
            String query = "delete from cliente where id = ?id";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id", id);

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
