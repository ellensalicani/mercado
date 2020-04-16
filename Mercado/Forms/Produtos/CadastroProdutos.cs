using Mercado.Conexao;
using Mercado.DAO;
using Mercado.V;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado.Forms
{
    public partial class CadastroProdutos : MaterialSkin.Controls.MaterialForm
    {
        private ProdutoV prodV;
        private ProdutoDAO prodDAO;
        private Connection conexao;

        public CadastroProdutos()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            tbNome.Clear();
            tbDataVenc.Clear();
            tbValorCompra.Clear();
            tbValorVenda.Clear();
            tbCodigoBarra.Clear();
            tbQtdEstoque.Clear();
            cbFornecedor.Items.Clear();
            cbCategoria.Items.Clear();
        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {
            PreencheComboCategoria();
            PreencheComboFornecedor();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                prodV = new ProdutoV();
                prodV.NomeProduto = tbNome.Text;
                prodV.DataVenc = Convert.ToDateTime(tbDataVenc.Text);
                prodV.PrecoCompra = Convert.ToInt32(tbValorCompra.Text);
                prodV.PrecoVenda = Convert.ToInt32(tbValorVenda.Text);
                prodV.IdCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
                prodV.IdFornecedor = Convert.ToInt32(cbFornecedor.SelectedValue);
                prodV.InserirProduto();
                LimparCampos();

                MessageBox.Show("Produdo cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto: " + ex);
            }
        }

        private void PreencheComboCategoria()
        {
            conexao = new Connection();
            string connectionString = conexao.getConnectionString();
            string query = "SELECT id, tipo_categoria FROM categoria";
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    conn.Open();
                    try
                    {
                        adapter.Fill(dt);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Erro: " + e.ToString());
                    }
                }
            }

            cbCategoria.DataSource = dt;
            cbCategoria.ValueMember = "id";
            cbCategoria.DisplayMember = "tipo_categoria";
        }

        private void PreencheComboFornecedor()
        {
            conexao = new Connection();
            string connectionString = conexao.getConnectionString();
            string query = "SELECT codigo_fornecedor, nome_fantasia FROM fornecedor";
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    conn.Open();
                    try
                    {
                        adapter.Fill(dt);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Erro: " + e.ToString());
                    }
                }
            }

            cbFornecedor.DataSource = dt;
            cbFornecedor.ValueMember = "codigo_fornecedor";
            cbFornecedor.DisplayMember = "nome_fantasia";
        }
    }
}
