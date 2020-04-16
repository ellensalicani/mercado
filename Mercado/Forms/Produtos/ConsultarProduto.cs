using Mercado.Conexao;
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

namespace Mercado.Forms.Produtos
{
    public partial class ConsultarProduto : MaterialSkin.Controls.MaterialForm
    {
        private V.ProdutoV prodv;
        private DAO.ProdutoDAO funcDAO;
        private Connection conexao;
        private Int32 catchRowIndex;

        public ConsultarProduto()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            tbId.Clear();
            tbNome.Clear();
            tbDataVenc.Clear();
            tbValorCompra.Clear();
            tbValorVenda.Clear();
            tbQtdEstoque.Clear();
            tbCodigoBarra.Clear();
            cbFornecedor.Items.Clear();
            cbCategoria.Items.Clear();
        }

        private void CarregarDados()
        {
            conexao = new Connection();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string connectionString = conexao.getConnectionString();
            string query = "SELECT codigo_produto, nome_produto, data_vencimento, preco_compra, preco_venda, codigo_barra, qnt_estoque, id_fornecedor, id_categoria FROM produto";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            dataGridView1.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4], dataTable.Rows[i][5], dataTable.Rows[i][6], dataTable.Rows[i][7]
                                , dataTable.Rows[i][8]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);

                    }
                }
                conn.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            catchRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                tbId.Text = row.Cells[0].Value.ToString();
                tbNome.Text = row.Cells[1].Value.ToString();
                tbDataVenc.Text = row.Cells[2].Value.ToString();
                tbValorCompra.Text = row.Cells[3].Value.ToString();
                tbValorVenda.Text = row.Cells[4].Value.ToString();
                tbCodigoBarra.Text = row.Cells[5].Value.ToString();
                tbQtdEstoque.Text = row.Cells[6].Value.ToString();
                cbFornecedor.Text = row.Cells[7].Value.ToString();
                cbCategoria.Text = row.Cells[8].Value.ToString();
            }
        }

        private void ConsultarProduto_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbId.Text != "")
            {
                tbId.Enabled = true;
                tbNome.Enabled = true;
                tbDataVenc.Enabled = true;
                tbValorCompra.Enabled = true;
                tbValorVenda.Enabled = true;
                tbQtdEstoque.Enabled = true;
                tbCodigoBarra.Enabled = true;
                cbFornecedor.Enabled = true;
                cbCategoria.Enabled = true;
            }
            else
            {
                MessageBox.Show("Selecione um funcionário para habilitar os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                prodv = new V.ProdutoV();
                prodv.NomeProduto = tbNome.Text;
                prodv.DataVenc = Convert.ToDateTime(tbDataVenc.Text);
                prodv.PrecoCompra = Convert.ToDecimal(tbValorCompra.Text);
                prodv.PrecoVenda = Convert.ToDecimal(tbValorVenda.Text);
                prodv.CodigoBarra = tbCodigoBarra.Text;
                prodv.QtdEstoque = Convert.ToInt32(tbQtdEstoque.Text);
                prodv.IdFornecedor = Convert.ToInt32(cbFornecedor.SelectedValue);
                prodv.IdCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
                prodv.AlterarProduto();
                LimparCampos();
                CarregarDados();

                MessageBox.Show("Produto atualizado com sucesso!!", "Sucesso", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);

            } catch(Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto: " + ex);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Deseja realmente excluir " + tbNome.Text + "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    prodv = new V.ProdutoV();
                    prodv.CodigoProduto = Convert.ToInt32(tbId.Text);
                    prodv.ExcluirProduto();

                    LimparCampos();

                    MessageBox.Show("Produto excluido com sucesso!!", "Sucesso", MessageBoxButtons.OK
                       , MessageBoxIcon.Information);
                    CarregarDados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar produto: " + ex);
                }
            }
            else
            {
                return;
            }
        }
    }
}
