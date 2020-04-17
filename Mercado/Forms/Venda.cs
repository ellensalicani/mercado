using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mercado.DAO;
using Mercado.V;
using Mercado.Conexao;


namespace Mercado.Forms
{
    public partial class Venda : MaterialSkin.Controls.MaterialForm
    {
        private VendaV vendaV;
        private VendaDAO vendaDAO;
        private Connection conexao;
        public Venda()
        {
            InitializeComponent();
        }

        private void CarregarDados()
        {
            conexao = new Connection();
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();

            string connectionString = conexao.getConnectionString();
            string query = "SELECT codigo_produto, nome_produto, preco_compra, data_vencimento, id_fornecedor, categoria, qnt_estoque, codigo_barra, preco_venda FROM produto";

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
                            dataGridView2.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1]);
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

        private void Venda_Load_1(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}
