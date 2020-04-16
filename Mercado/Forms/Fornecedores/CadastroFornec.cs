using Mercado.Conexao;
using Mercado.DAO;
using Mercado.V;
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
    public partial class CadastroFornec : MaterialSkin.Controls.MaterialForm
    {
        private FornecedorV fornV;
        private FornecedorDAO fornDAO;
        private Connection conexao;

        public CadastroFornec()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                fornV = new FornecedorV();
                fornV.Cnpj = tbCnpj.Text;
                fornV.RazaoSocial = tbRazaoSocial.Text;
                fornV.NomeFantasia = tbNomeFantasia.Text;
                fornV.Ddd = Convert.ToInt32(tbDdd.Text);
                fornV.Telefone = Convert.ToInt32(tbTelefone.Text);
                fornV.Ramal = Convert.ToInt32(tbRamal.Text);
                fornV.Pais = tbPais.Text;
                fornV.Estado = tbEstado.Text;
                fornV.Rua = tbRua.Text;
                fornV.Numero = Convert.ToInt32(tbNumero.Text);
                fornV.Bairro = tbBairro.Text;
                fornV.Cep = Convert.ToInt32(tbCep.Text);
                fornV.Cidade = tbCidade.Text;
                fornV.InserirFornecedor();
                LimparCampos();

                MessageBox.Show("Fornecedor cadastrado com sucesso!!", "Sucesso", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar fornecedor: " + ex);
            }
        }
    }
}
