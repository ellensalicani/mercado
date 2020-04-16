using Mercado.Conexao;
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

namespace Mercado.Forms.Fornecedores
{
    public partial class ConsultarFornec : MaterialSkin.Controls.MaterialForm
    {
        private FornecedorV fornv;
        private DAO.FornecedorDAO fornDAO;
        private Connection conexao;
        private Int32 catchRowIndex;

        public ConsultarFornec()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            tbId.Clear();
            tbCnpj.Clear();
            tbRazaoSocial.Clear();
            tbNomeFantasia.Clear();
            tbDdd.Clear();
            tbTelefone.Clear();
            tbRamal.Clear();
            tbRua.Clear();
            tbNumero.Clear();
            tbBairro.Clear();
            tbCidade.Clear();
            tbEstado.Clear();
            tbPais.Clear();
            tbCep.Clear();
        }

        private void CarregarDados()
        {
            conexao = new Connection();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string connectionString = conexao.getConnectionString();
            string query = "SELECT codigo_fornecedor, cnpj, razao_social, nome_fantasia, ddd, telefone, ramal, rua, numero, bairro, cidade, estado, pais, cep FROM fornecedor";

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
                                , dataTable.Rows[i][8], dataTable.Rows[i][9], dataTable.Rows[i][10], dataTable.Rows[i][11], dataTable.Rows[i][12], dataTable.Rows[i][13]);
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
                tbCnpj.Text = row.Cells[1].Value.ToString();
                tbRazaoSocial.Text = row.Cells[2].Value.ToString();
                tbNomeFantasia.Text = row.Cells[3].Value.ToString();
                tbDdd.Text = row.Cells[4].Value.ToString();
                tbTelefone.Text = row.Cells[5].Value.ToString();
                tbRamal.Text = row.Cells[6].Value.ToString();
                tbRua.Text = row.Cells[7].Value.ToString();
                tbNumero.Text = row.Cells[8].Value.ToString();
                tbBairro.Text = row.Cells[9].Value.ToString();
                tbCidade.Text = row.Cells[10].Value.ToString();
                tbEstado.Text = row.Cells[11].Value.ToString();
                tbPais.Text = row.Cells[12].Value.ToString();
                tbCep.Text = row.Cells[13].Value.ToString();
            }
        }

        private void ConsultarFornec_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbId.Text != "")
            {
                tbRazaoSocial.Enabled = true;
                tbNomeFantasia.Enabled = true;
                tbDdd.Enabled = true;
                tbTelefone.Enabled = true;
                tbRamal.Enabled = true;
                tbRua.Enabled = true;
                tbNumero.Enabled = true;
                tbBairro.Enabled = true;
                tbCidade.Enabled = true;
                tbEstado.Enabled = true;
                tbPais.Enabled = true;
                tbCep.Enabled = true;
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
                fornv = new FornecedorV();
                fornv.RazaoSocial = tbRazaoSocial.Text;
                fornv.NomeFantasia = tbNomeFantasia.Text;
                fornv.Ddd = Convert.ToInt32(tbDdd.Text);
                fornv.Telefone = Convert.ToInt32(tbTelefone.Text);
                fornv.Ramal = Convert.ToInt32(tbRamal.Text);
                fornv.Pais = tbPais.Text;
                fornv.Estado = tbEstado.Text;
                fornv.Rua = tbRua.Text;
                fornv.Numero = Convert.ToInt32(tbNumero.Text);
                fornv.Bairro = tbBairro.Text;
                fornv.Cep = Convert.ToInt32(tbCep.Text);
                fornv.Cidade = tbCidade.Text;
                fornv.AlterarFornecedor();
                LimparCampos();
                CarregarDados();

                MessageBox.Show("Fornecedor atualizado com sucesso!!", "Sucesso", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar fornecedor: " + ex);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Deseja realmente excluir " + tbNomeFantasia.Text + "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    fornv = new FornecedorV();
                    fornv.Id = Convert.ToInt32(tbId.Text);
                    fornv.ExcluirFornecedor();

                    LimparCampos();

                    MessageBox.Show("Fornecedor excluido com sucesso!!", "Sucesso", MessageBoxButtons.OK
                       , MessageBoxIcon.Information);
                    CarregarDados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar fornecedor: " + ex);
                }
            }
            else
            {
                return;
            }
        }
    }
}
