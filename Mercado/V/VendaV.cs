using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado.V
{
    class VendaV
    {
        private int id;
        private Double valor_unitario;
        private Double valor_total;
        private int qnt_produto;
        private DateTime datahora_venda;
        private int id_produto;
        private int id_cliente;

        public int Id { get => id; set => id = value; }
        public Double Valor_unitario { get => valor_unitario; set => valor_unitario = value; }
        public Double Valor_total { get => valor_total; set => valor_total = value; }
        public int Qnt_produto { get => qnt_produto; set => qnt_produto = value; }
        public DateTime Datahora_venda { get => datahora_venda; set => datahora_venda = value; }
        public int Id_produto { get => id_produto; set => id_produto = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
    }
}
