using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado.V
{
    public class ClienteV
    {
        private int id;
        private String nome;
        private String sobrenome;
        private String cpf;
        private int ddd;
        private int telefone;
        private String email;
        private DateTime dataNasc;
        private String pais;
        private String estado;
        private String rua;
        private int numero;
        private String bairro;
        private String cidade;
        private int cep;
        private String cargo;
        private String username;
        private int idade;

        private DAO.ClienteDAO cdao;

        public ClienteV()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public int Ddd { get => ddd; set => ddd = value; }
        public int Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DataNasc { get => dataNasc; set => dataNasc = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Rua { get => rua; set => rua = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public int Cep { get => cep; set => cep = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Username { get => username; set => username = value; }
        public int Idade { get => idade; set => idade = value; }

        public void InserirCliente()
        {
            cdao = new DAO.ClienteDAO();
            cdao.InserirCliente(nome, sobrenome, cpf, ddd, telefone, email, dataNasc, pais, estado, rua, numero, bairro, cep, cidade);
        }
    }
}
