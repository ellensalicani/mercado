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

namespace Mercado.Forms.Relatorio
{
    public partial class RelatorioProduto : MaterialSkin.Controls.MaterialForm
    {
        private DAO.ClienteDAO clienteDAO;
        private Connection conexao;


        public RelatorioProduto()
        {
            InitializeComponent();
        }

        private void RelatorioProduto_Load(object sender, EventArgs e)
        {
            CarregarDados();

            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                doc.Info.Title = "Relatório dos Clientes Cadastrados";
                var page = doc.AddPage();
                var graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                var textFormatter = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
                var font = new PdfSharp.Drawing.XFont("Arial", 14);
            }
        }

        private void CarregarDados()
        {
            conexao = new Connection();
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();

            string connectionString = conexao.getConnectionString();
            
            string query = "select * from produto where qnt_estoque > 0";

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
                                dataGridView2.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2]/*, dataTable.Rows[i][3]*/);
                            //
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






        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
