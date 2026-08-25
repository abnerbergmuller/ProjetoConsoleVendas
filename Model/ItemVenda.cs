using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConsoleVendas.Model
{
    public class ItemVenda
    {
        public int Id { get; set; }
        public Venda VendaId  { get; set; }
        public Produto ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal SubTotal { get; set; }

        public ItemVenda(Venda vendaId, Produto produtoId, int quantidade, decimal subTotal)
        {
            VendaId = vendaId;
            ProdutoId = produtoId;
            Quantidade = quantidade;
            SubTotal = subTotal;
        }
    }
}
