using Mercado.Conexao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mercado.V;
using Mercado.DAO;

namespace Firma.Forms.Clientes
{
    public partial class CadastroCliente : MaterialSkin.Controls.MaterialForm
    {
        private ClienteV clienteV;
        private CadastroDAO crudDAO;
        private Connection conexao;

        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void limparCampos()
        {
            tbNome.Clear();
            tbSobrenome.Clear();
            tbCpf.Clear();
            tbDdd.Clear();
            tbTelefone.Clear();
            tbEmail.Clear();
            tbDataNasc.Clear();
            tbPais.Clear();
            tbEstado.Clear();
            tbNumero.Clear();
            tbBairro.Clear();
            tbCep.Clear();
            tbCidade.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                clienteV = new ClienteV();
                clienteV.Nome = tbNome.Text;
                clienteV.Sobrenome = tbSobrenome.Text;
                clienteV.Cpf = tbCpf.Text;
                clienteV.Ddd = Convert.ToInt32(tbDdd.Text);
                clienteV.Telefone = Convert.ToInt32(tbTelefone.Text);
                clienteV.Email = tbEmail.Text;
                clienteV.DataNasc = Convert.ToDateTime(tbDataNasc.Text);
                clienteV.Pais = tbPais.Text;
                clienteV.Estado = tbEstado.Text;
                clienteV.Rua = tbRua.Text;
                clienteV.Numero = Convert.ToInt32(tbNumero.Text);
                clienteV.Bairro = tbBairro.Text;
                clienteV.Cep = Convert.ToInt32(tbCep.Text);
                clienteV.Cidade = tbCidade.Text;
                clienteV.InserirCliente();
                limparCampos();

                MessageBox.Show("Cliente cadastrado com sucesso!!", "Sucesso", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente: " + ex);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
