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
    public class ProdutoDAO
    {
        private V.ProdutoV produtov;
        private MySqlConnection con;
        private Connection conexao;

        public void InserirProduto( string nomeProduto, decimal precoCompra, DateTime dataVenc, int idFornecedor, int idCategoria, int qtdEstoque, string codigoBarra, decimal precoVenda)
        {
            con = new MySqlConnection();
            produtov = new V.ProdutoV();
            conexao = new Connection();
            con.ConnectionString = conexao.getConnectionString();
            String query = "INSERT INTO produto(codigo_produto, nome_produto, preco_compra, data_vencimento, id_fornecedor, id_categoria, qnt_estoque, codigo_barra, preco_venda)";
            query += " VALUES (null, ?nomeProduto, ?precoCompra, ?dataVenc, ?idFornecedor, ?idCategoria, ?qtdEstoque, ?codigoBarra, ?precoVenda)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?nomeProduto", nomeProduto);
                cmd.Parameters.AddWithValue("?precoCompra", precoCompra);
                cmd.Parameters.AddWithValue("?dataVenc", dataVenc);
                cmd.Parameters.AddWithValue("?idFornecedor", idFornecedor);
                cmd.Parameters.AddWithValue("?idCategoria", idCategoria);
                cmd.Parameters.AddWithValue("?qtdEstoque", qtdEstoque);
                cmd.Parameters.AddWithValue("?codigoBarra", codigoBarra);
                cmd.Parameters.AddWithValue("?precoVenda", precoVenda);
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

        public void AlterarProduto(int codigoProduto, string nomeProduto, decimal precoCompra, DateTime dataVenc, int idFornecedor, int idCategoria, int qtdEstoque, string codigoBarra, decimal precoVenda)
        {
            con = new MySqlConnection();
            produtov = new V.ProdutoV();
            conexao = new Connection();
            con.ConnectionString = conexao.getConnectionString();
            String query = "update produto set nome_produto = ?nomeProduto, preco_compra = ?precoCompra, data_vencimento = ?dataVenc, id_fornecedor = ?idFornecedor, id_categoria = ?idCategoria, qnt_estoque = ?qtdEstoque, codigo_barra = ?codigoBarra, preco_venda = ?precoVenda";
            query += " where codigo_produto = ?codigoProduto";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?codigoProduto", codigoProduto);
                cmd.Parameters.AddWithValue("?nomeProduto", nomeProduto);
                cmd.Parameters.AddWithValue("?precoCompra", precoCompra);
                cmd.Parameters.AddWithValue("?dataVenc", dataVenc);
                cmd.Parameters.AddWithValue("?idFornecedor", idFornecedor);
                cmd.Parameters.AddWithValue("?idCategoria", idCategoria);
                cmd.Parameters.AddWithValue("?qtdEstoque", qtdEstoque);
                cmd.Parameters.AddWithValue("?codigoBarra", codigoBarra);
                cmd.Parameters.AddWithValue("?precoVenda", precoVenda);
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

        public void ExcluirProduto(int id)
        {
            con = new MySqlConnection();
            produtov = new V.ProdutoV();
            conexao = new Connection();
            con.ConnectionString = conexao.getConnectionString();
            String query = "delete from produto where codigo_produto = ?codigoProduto";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?codigoProduto", id);

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
