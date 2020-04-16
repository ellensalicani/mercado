using Mercado.Conexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado.DAO
{
    public class FornecedorDAO
    {
        private V.FornecedorV fornecedorV;
        private MySqlConnection con;
        private Connection conexao;

        public void InserirFornecedor(String cnpj, String razaoSocial, String nomeFantasia, int ddd, int telefone, int ramal, String pais, String estado,
            String rua, int numero, String bairro, int cep, String cidade)
        {
            con = new MySqlConnection();
            fornecedorV = new V.FornecedorV();
            conexao = new Connection();
            con.ConnectionString = conexao.getConnectionString();
            String query = "INSERT INTO fornecedor(codigo_fornecedor, cnpj, razao_social, nome_fantasia, ddd, telefone, ramal, pais, estado, rua, numero, bairro, cep, cidade)";
            query += " VALUES (null, ?cnpj, ?razaoSocial, ?nomeFantasia, ?ddd, ?telefone, ?ramal, ?pais, ?estado, ?rua, ?numero, ?bairro, ?cep, ?cidade)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?cnpj", cnpj);
                cmd.Parameters.AddWithValue("?razaoSocial", razaoSocial);
                cmd.Parameters.AddWithValue("?nomeFantasia", nomeFantasia);
                cmd.Parameters.AddWithValue("?ddd", ddd);
                cmd.Parameters.AddWithValue("?telefone", telefone);
                cmd.Parameters.AddWithValue("?ramal", ramal);
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

        public void AlterarFornecedor(int codForn, String razaoSocial, String nomeFantasia, int ddd, int telefone, int ramal, String pais, String estado,
            String rua, int numero, String bairro, int cep, String cidade)
        {
            con = new MySqlConnection();
            fornecedorV = new V.FornecedorV();
            conexao = new Connection();
            con.ConnectionString = conexao.getConnectionString();
            String query = "update fornecedor set razao_social = ?razaoSocial, nome_fantasia = ?nomeFantasia, ddd = ?ddd, telefone = ?telefone, ramal = ?ramal, pais = ?pais, estado = ?estado, rua = ?rua, numero = ?numero, bairro = ?bairro, cep = ?cep, cidade = ?cidade";
            query += " where codigo_fornecedor = ?codForn";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?codForn", codForn);
                cmd.Parameters.AddWithValue("?razaoSocial", razaoSocial);
                cmd.Parameters.AddWithValue("?nomeFantasia", nomeFantasia);
                cmd.Parameters.AddWithValue("?ddd", ddd);
                cmd.Parameters.AddWithValue("?telefone", telefone);
                cmd.Parameters.AddWithValue("?ramal", ramal);
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

        public void ExcluirFornecedor(int id)
        {
            con = new MySqlConnection();
            fornecedorV = new V.FornecedorV();
            conexao = new Connection();
            con.ConnectionString = conexao.getConnectionString();
            String query = "delete from fornecedor where codigo_fornecedor = ?id";
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
