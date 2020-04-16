using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado.V
{
    public class ProdutoV
    {
        private int codigoProduto;
        private string nomeProduto;
        private decimal precoCompra;
        private DateTime dataVenc;
        private int idFornecedor;
        private int idCategoria;
        private int qtdEstoque;
        private string codigoBarra;
        private decimal precoVenda;

        private DAO.ProdutoDAO pdao;

        public ProdutoV()
        {

        }

        public int CodigoProduto { get => codigoProduto; set => codigoProduto = value; }
        public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
        public decimal PrecoCompra { get => precoCompra; set => precoCompra = value; }
        public DateTime DataVenc { get => dataVenc; set => dataVenc = value; }
        public int IdFornecedor { get => idFornecedor; set => idFornecedor = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public int QtdEstoque { get => qtdEstoque; set => qtdEstoque = value; }
        public string CodigoBarra { get => codigoBarra; set => codigoBarra = value; }
        public decimal PrecoVenda { get => precoVenda; set => precoVenda = value; }

        public void InserirProduto()
        {
            pdao = new DAO.ProdutoDAO();
            pdao.InserirProduto(nomeProduto, precoCompra, dataVenc, idFornecedor, idCategoria, qtdEstoque, codigoBarra, PrecoVenda);
        }

        public void AlterarProduto()
        {
            pdao = new DAO.ProdutoDAO();
            pdao.AlterarProduto(codigoProduto, nomeProduto, precoCompra, dataVenc, idFornecedor, idCategoria, qtdEstoque, codigoBarra, PrecoVenda);
        }

        public void ExcluirProduto()
        {
            pdao = new DAO.ProdutoDAO();
            pdao.ExcluirProduto(CodigoProduto);
        }

    }
}
