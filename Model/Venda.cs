using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConsoleVendas.Model
{
    public class Venda
    {
        public int Codigo { get; set; }
        public Cliente ClienteId { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal TotalVenda { get; set; }
        public string Observacoes { get; set; }

        public Venda(int codigo, Cliente clienteId, DateTime dataVenda, decimal totalVenda, string observacoes)
        {
            Codigo = codigo;
            ClienteId = clienteId;
            DataVenda = dataVenda;
            TotalVenda = totalVenda;
            Observacoes = observacoes;
        }

        public Venda(Cliente clienteId, DateTime dataVenda, decimal totalVenda, string observacoes)
        {
            ClienteId = clienteId;
            DataVenda = dataVenda;
            TotalVenda = totalVenda;
            Observacoes = observacoes;
        }
    }
}
