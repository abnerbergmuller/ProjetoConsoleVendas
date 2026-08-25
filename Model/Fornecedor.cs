using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConsoleVendas.Model
{
    public class Fornecedor : Cliente
    {
        public String Cnpj { get; set; }

        public Fornecedor(string nome, string rg, string cpf, string email, string telefone, string celular, string cep, string endereco, int numero, string complemento, string bairro, string cidade, string estado, string cnpj) : base(nome, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
        {
            Cnpj = cnpj;
        }

        public Fornecedor(int codigo, string nome, string rg, string cpf, string email, string telefone, string celular, string cep, string endereco, int numero, string complemento, string bairro, string cidade, string estado, string cnpj) : base(codigo, nome, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
        {
            Cnpj = cnpj;
        }


        public Fornecedor(int codigo) : base(codigo)
        {
        }
    }
}
