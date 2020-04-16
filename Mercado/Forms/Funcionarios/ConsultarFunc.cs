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

namespace Mercado.Forms.Funcionarios
{
    public partial class ConsultarFunc : MaterialSkin.Controls.MaterialForm
    {
        private V.FuncionarioV funcv;
        private DAO.FuncionarioDAO funcDAO;
        private Connection conexao;
        private Int32 catchRowIndex;

        public ConsultarFunc()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
            tbId.Clear();
            tbNome.Clear();
            tbSobrenome.Clear();
            tbCpf.Clear();
            tbDdd.Clear();
            tbTelefone.Clear();
            tbEmail.Clear();
            tbIdade.Clear();
            tbPais.Clear();
            tbEstado.Clear();
            tbNumero.Clear();
            tbBairro.Clear();
            tbCep.Clear();
            tbCidade.Clear();
            tbUsername.Clear();
            cbCargo.Items.Clear();
        }

        private void CarregarDados()
        {
            conexao = new Connection();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string connectionString = conexao.getConnectionString();
            string query = "SELECT id, nome, sobrenome, cpf, cargo, username, email, ddd, telefone, idade, rua, numero, bairro, cidade, estado, pais, cep FROM funcionarios";

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
                                , dataTable.Rows[i][8], dataTable.Rows[i][9], dataTable.Rows[i][10], dataTable.Rows[i][11], dataTable.Rows[i][12], dataTable.Rows[i][13], dataTable.Rows[i][14], dataTable.Rows[i][15], dataTable.Rows[i][16]);
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
                tbSobrenome.Text = row.Cells[2].Value.ToString();
                tbCpf.Text = row.Cells[3].Value.ToString();
                cbCargo.Text = row.Cells[4].Value.ToString();
                tbUsername.Text = row.Cells[5].Value.ToString();
                tbEmail.Text = row.Cells[6].Value.ToString();
                tbDdd.Text = row.Cells[7].Value.ToString();
                tbTelefone.Text = row.Cells[8].Value.ToString();
                tbIdade.Text = row.Cells[9].Value.ToString();
                tbRua.Text = row.Cells[10].Value.ToString();
                tbNumero.Text = row.Cells[11].Value.ToString();
                tbBairro.Text = row.Cells[12].Value.ToString();
                tbCidade.Text = row.Cells[13].Value.ToString();
                tbEstado.Text = row.Cells[14].Value.ToString();
                tbPais.Text = row.Cells[15].Value.ToString();
                tbCep.Text = row.Cells[16].Value.ToString();
            }
        }

        private void ConsultarFunc_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(tbId.Text != "")
            {
                tbNome.Enabled = true;
                tbSobrenome.Enabled = true;
                tbCpf.Enabled = true;
                tbEmail.Enabled = true;
                tbDdd.Enabled = true;
                tbTelefone.Enabled = true;
                tbIdade.Enabled = true;
                tbRua.Enabled = true;
                tbNumero.Enabled = true;
                tbBairro.Enabled = true;
                tbCidade.Enabled = true;
                tbEstado.Enabled = true;
                tbPais.Enabled = true;
                tbCep.Enabled = true;
                cbCargo.Enabled = true;
            } else
            {
                MessageBox.Show("Selecione um funcionário para habilitar os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                funcv = new V.FuncionarioV();
                funcv.Nome = tbNome.Text;
                funcv.Sobrenome = tbSobrenome.Text;
                funcv.Cpf = tbCpf.Text;
                funcv.Ddd = Convert.ToInt32(tbDdd.Text);
                funcv.Telefone = Convert.ToInt32(tbTelefone.Text);
                funcv.Email = tbEmail.Text;
                funcv.Idade = Convert.ToInt32(tbIdade.Text);
                funcv.Pais = tbPais.Text;
                funcv.Estado = tbEstado.Text;
                funcv.Rua = tbRua.Text;
                funcv.Numero = Convert.ToInt32(tbNumero.Text);
                funcv.Bairro = tbBairro.Text;
                funcv.Cep = Convert.ToInt32(tbCep.Text);
                funcv.Cidade = tbCidade.Text;
                funcv.Cargo = cbCargo.SelectedText;
                funcv.AlterarFuncionario();
                limparCampos();
                CarregarDados();

                MessageBox.Show("Dados atualizados com sucesso!!", "Sucesso", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente: " + ex);
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
                    funcv = new V.FuncionarioV();
                    funcv.Id = Convert.ToInt32(tbId.Text);
                    funcv.ExcluirFuncionario();

                    limparCampos();

                    MessageBox.Show("Funcionário excluido com sucesso!!", "Sucesso", MessageBoxButtons.OK
                       , MessageBoxIcon.Information);
                    CarregarDados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar funcionário: " + ex);
                }
            }
            else
            {
                return;
            }
        }
    }
}
