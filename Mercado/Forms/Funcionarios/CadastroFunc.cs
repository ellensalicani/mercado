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
using Mercado.DAO;
using Mercado.V;

namespace Firma.Forms.Funcionarios
{
    public partial class CadastroFunc : MaterialSkin.Controls.MaterialForm
    {
        private FuncionarioV funcV;
        private FuncionarioDAO funcDAO;
        private Connection conexao;

        public CadastroFunc()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
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
            cbCargo.Items.Remove(cbCargo.SelectedItem);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                funcV = new FuncionarioV();
                funcV.Nome = tbNome.Text;
                funcV.Sobrenome = tbSobrenome.Text;
                funcV.Cpf = tbCpf.Text;
                funcV.Ddd = Convert.ToInt32(tbDdd.Text);
                funcV.Telefone = Convert.ToInt32(tbTelefone.Text);
                funcV.Email = tbEmail.Text;
                funcV.Idade = Convert.ToInt32(tbIdade.Text);
                funcV.Pais = tbPais.Text;
                funcV.Estado = tbEstado.Text;
                funcV.Rua = tbRua.Text;
                funcV.Numero = Convert.ToInt32(tbNumero.Text);
                funcV.Bairro = tbBairro.Text;
                funcV.Cep = Convert.ToInt32(tbCep.Text);
                funcV.Cidade = tbCidade.Text;
                funcV.Cargo = cbCargo.SelectedText;
                funcV.InserirFuncionario();
                limparCampos();

                MessageBox.Show("Funcionário cadastrado com sucesso!! Email enviado com usuario e senha para login.", "Sucesso", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar funcionário: " + ex);
            }
        }
    }
}
