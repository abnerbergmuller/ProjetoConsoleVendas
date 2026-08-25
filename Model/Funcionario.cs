using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConsoleVendas.Model
{
    public class Funcionario : Cliente
    {
        public String Senha { get; set; }
        public String Cargo { get; set; }
        public String NivelAcesso { get; set; }

        public Funcionario(string nome, string rg, string cpf, string email, string telefone, string celular, string cep, string endereco, int numero, string complemento, string bairro, string cidade, string estado, string senha, string cargo, string nivelacesso) : base(nome, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
        {
            Senha = senha;
            Cargo = cargo;
            NivelAcesso = nivelacesso;
        }

        public Funcionario(int codigo, string nome, string rg, string cpf, string email, string telefone, string celular, string cep, string endereco, int numero, string complemento, string bairro, string cidade, string estado, string senha, string cargo, string nivelacesso) : base(codigo, nome, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
        {
            Senha = senha;
            Cargo = cargo;
            NivelAcesso = nivelacesso;
        }

        public Funcionario(int codigo) : base(codigo)
        {
        }

    }
}
