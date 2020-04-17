using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mercado.Conexao;
using MySql.Data.MySqlClient;

namespace Mercado.Forms.Clientes
{
    public partial class ConsultarCliente : MaterialSkin.Controls.MaterialForm
    {
        private V.ClienteV clienteV;
        private DAO.ClienteDAO clienteDAO;
        private Connection conexao;
        private Int32 catchRowIndex;

        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private void CarregarDados()
        {
            conexao = new Connection();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string connectionString = conexao.getConnectionString();
            string query = "SELECT id, nome, sobrenome, cpf, email, ddd, telefone, data_nascimento, rua, numero, bairro, cidade, estado, pais, cep FROM cliente";
            //string query = "select * from produto";

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
                            dataGridView1.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2]/*, dataTable.Rows[i][3]*/);
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
                tbSobrenome.Text = row.Cells[2].Value.ToString().Substring(1);
                //tbPreco.Text = row.Cells[2].Value.ToString();
                //tbQuantidade.Text = row.Cells[3].Value.ToString();
            }
        }

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
