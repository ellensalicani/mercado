using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado.V
{
    public class FornecedorV
    {
        private int id;
        private string cnpj;
        private string razaoSocial;
        private string nomeFantasia;
        private int ddd;
        private int telefone;
        private int ramal;
        private string rua;
        private int numero;
        private string bairro;
        private string cidade;
        private string estado;
        private string pais;
        private int cep;

        private DAO.FornecedorDAO fdao;

        public FornecedorV()
        {

        }


        public int Id { get => id; set => id = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public string NomeFantasia { get => nomeFantasia; set => nomeFantasia = value; }
        public int Ddd { get => ddd; set => ddd = value; }
        public int Telefone { get => telefone; set => telefone = value; }
        public int Ramal { get => ramal; set => ramal = value; }
        public string Rua { get => rua; set => rua = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Pais { get => pais; set => pais = value; }
        public int Cep { get => cep; set => cep = value; }

        public void InserirFornecedor()
        {
            fdao = new DAO.FornecedorDAO();
            fdao.InserirFornecedor(cnpj, razaoSocial, nomeFantasia, ddd, telefone, ramal,pais, estado, rua, numero, bairro, cep, cidade);
        }

        public void AlterarFornecedor()
        {
            fdao = new DAO.FornecedorDAO();
            fdao.AlterarFornecedor(id, razaoSocial, nomeFantasia, ddd, telefone, ramal, pais, estado, rua, numero, bairro, cep, cidade);
        }

        public void ExcluirFornecedor()
        {
            fdao = new DAO.FornecedorDAO();
            fdao.ExcluirFornecedor(id);
        }

    }
}
