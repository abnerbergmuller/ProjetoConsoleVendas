using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConsoleVendas.Model
{
    public class Cliente
    {
        public Int32 Codigo { get; private set; }
        public String Nome { get; private set; }
        public String RG { get; private set; }
        public String Cpf { get; private set; }
        public String Email { get; private set; }
        public String Telefone { get; private set; }
        public String Celular { get; private set; }
        public String Cep { get; private set; }
        public String Endereco { get; private set; }
        public Int32 Numero { get; private set; }
        public String Complemento { get; private set; }
        public String Bairro { get; private set; }
        public String Cidade { get; private set; }
        public String Estado { get; private set; }

        public Cliente(string nome, string rg, string cpf, string email, string telefone, string celular, string cep, string endereco, int numero, string complemento, string bairro, string cidade, string estado)
        {
            Nome = nome;
            RG = rg;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Celular = celular;
            Cep = cep;
            Endereco = endereco;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
        public Cliente(int codigo, string nome, string rg, string cpf, string email, string telefone, string celular, string cep, string endereco, int numero, string complemento, string bairro, string cidade, string estado)
        {
            Codigo = codigo;
            Nome = nome;
            RG = rg;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Celular = celular;
            Cep = cep;
            Endereco = endereco;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        public Cliente(int codigo)
        {
            Codigo = codigo;
        }

        public Cliente(){}

        public Cliente(MySqlDataReader reader)
        {
            Codigo = reader.GetInt32("id");
            Nome = reader.GetString("nome");
        }
    }
}
