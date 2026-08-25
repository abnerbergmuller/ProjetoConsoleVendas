using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConsoleVendas.Model
{
    public class Produto
    {
        public int Codigo { get; set; }
        public String Descricao { get; set; }
        public decimal Preco { get; set; }
        public int QtdEstoque { get; set; }
        public int CodigoFornecedor { get; set; }

        public Produto(int codigo, string descricao, decimal preco, int qtdEstoque, int codigoFornecedor)
        {
            Codigo = codigo;
            Descricao = descricao;
            Preco = preco;
            QtdEstoque = qtdEstoque;
            CodigoFornecedor = codigoFornecedor;
        }

        public Produto(string descricao, decimal preco, int qtdEstoque, int codigoFornecedor)
        {
            Descricao = descricao;
            Preco = preco;
            QtdEstoque = qtdEstoque;
            CodigoFornecedor = codigoFornecedor;
        }

        public Produto(int codigo)
        {
            Codigo = codigo;
        }

        public Produto()
        {
        }

        //public Produto(MySqlDataReader reader)
        //{
        //    Codigo = reader.GetInt32("id");
        //    Nome = reader.GetString("nome");
        //}
    }
}
