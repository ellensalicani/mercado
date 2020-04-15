using Firma.Helpers;
using MySql.Data.MySqlClient;
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
using Mercado.Conexao;

namespace Mercado.DAO
{
    public class FuncionarioDAO
    {
        private V.FuncionarioV cadastrov;
        private MySqlConnection con;
        private Connection conexao;

        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        public void ListarFuncionarios()
        {
            con = new MySqlConnection();
            cadastrov = new V.FuncionarioV();
            conexao = new Connection();
            con.ConnectionString = conexao.getConnectionString();
            String query = "SELECT * FROM funcionarios";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
               
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

        public void InserirFuncionario(String nome, String sobrenome, String cargo, String cpf, int ddd, int telefone, String email, int idade, String pais, String estado,
            String rua, int numero, String bairro, int cep, String cidade)
        {

            var senha = CreatePassword(6);

            var nomeCompleto = nome + " " + sobrenome;
            var username = nome.Substring(0, 1) + sobrenome.Substring(0, 5);

            con = new MySqlConnection();
            cadastrov = new V.FuncionarioV();
            conexao = new Connection();
            con.ConnectionString = conexao.getConnectionString();
            String query = "INSERT INTO funcionarios(ID, nome, sobrenome, username, senha, nome_completo, idade, cargo, cpf, ddd, telefone, email, pais, estado, rua, numero, bairro, cep, cidade)";
            query += " VALUES (null, ?nome, ?sobrenome, ?username, ?senha, ?nomeCompleto, ?idade, ?cargo, ?cpf, ?ddd, ?telefone, ?email, ?pais, ?estado, ?rua, ?numero, ?bairro, ?cep, ?cidade)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?sobrenome", sobrenome);
                cmd.Parameters.AddWithValue("?username", username);
                cmd.Parameters.AddWithValue("?senha", senha);
                cmd.Parameters.AddWithValue("?nomeCompleto", nomeCompleto);
                cmd.Parameters.AddWithValue("?cargo", cargo);
                cmd.Parameters.AddWithValue("?cpf", cpf);
                cmd.Parameters.AddWithValue("?ddd", ddd);
                cmd.Parameters.AddWithValue("?telefone", telefone);
                cmd.Parameters.AddWithValue("?email", email);
                cmd.Parameters.AddWithValue("?idade", idade);
                cmd.Parameters.AddWithValue("?pais", pais);
                cmd.Parameters.AddWithValue("?estado", estado);
                cmd.Parameters.AddWithValue("?rua", rua);
                cmd.Parameters.AddWithValue("?numero", numero);
                cmd.Parameters.AddWithValue("?bairro", bairro);
                cmd.Parameters.AddWithValue("?cep", cep);
                cmd.Parameters.AddWithValue("?cidade", cidade);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                Email.EnviarEmail(username, senha, email);
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

        public void AlterarFuncionario(int id, String nome, String sobrenome, String cargo, String cpf, int ddd, int telefone, String email, int idade, String pais, String estado,
            String rua, int numero, String bairro, int cep, String cidade)
        {

            var senha = CreatePassword(6);

            var nomeCompleto = nome + " " + sobrenome;
            var username = nome.Substring(0, 1) + sobrenome.Substring(0, 5);

            con = new MySqlConnection();
            cadastrov = new V.FuncionarioV();
            conexao = new Connection();
            con.ConnectionString = conexao.getConnectionString();
            String query = "update funcionarios set nome = ?nome, sobrenome = ?sobrenome, username = ?username, senha = ?senha, nome_completo = ?nomeCompleto, idade = ?idade, cargo = ?cargo, cpf = ?cpf, ddd = ?ddd, telefone = ?telefone, email = ?email, pais = ?pais, estado = ?estado, rua = ?rua, numero = ?numero, bairro = ?bairro, cep = ?cep, cidade = ?cidade";
            query += " where id = ?id";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id", id);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?sobrenome", sobrenome);
                cmd.Parameters.AddWithValue("?username", username);
                cmd.Parameters.AddWithValue("?senha", senha);
                cmd.Parameters.AddWithValue("?nomeCompleto", nomeCompleto);
                cmd.Parameters.AddWithValue("?cargo", cargo);
                cmd.Parameters.AddWithValue("?cpf", cpf);
                cmd.Parameters.AddWithValue("?ddd", ddd);
                cmd.Parameters.AddWithValue("?telefone", telefone);
                cmd.Parameters.AddWithValue("?email", email);
                cmd.Parameters.AddWithValue("?idade", idade);
                cmd.Parameters.AddWithValue("?pais", pais);
                cmd.Parameters.AddWithValue("?estado", estado);
                cmd.Parameters.AddWithValue("?rua", rua);
                cmd.Parameters.AddWithValue("?numero", numero);
                cmd.Parameters.AddWithValue("?bairro", bairro);
                cmd.Parameters.AddWithValue("?cep", cep);
                cmd.Parameters.AddWithValue("?cidade", cidade);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                Email.EnviarEmail(username, senha, email);
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

        public void ExcluirFuncionario(int id)
        {
            con = new MySqlConnection();
            cadastrov = new V.FuncionarioV();
            conexao = new Connection();
            con.ConnectionString = conexao.getConnectionString();
            String query = "delete from funcionarios where id = ?id";
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
