using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using ProjetoConsoleVendas.Connection;
using ProjetoConsoleVendas.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoConsoleVendas.Dao
{
    public class FuncionarioDAO
    {
        private MySqlConnection Connection { get; set; }
        public FuncionarioDAO()
        {
            this.Connection = new ConnectionFactory().GetConnection();
        }

        public void CadastrarFuncionario(Funcionario funcionario)
        {
            try
            {
                string sqlInsert = @"INSERT into tb_funcionarios (nome,rg,cpf,email,senha,cargo,nivel_acesso,telefone, 
                celular,cep,endereco,numero,complemento,bairro,cidade,estado) values(@nome,@rg,@cpf,@email,@senha,
                @cargo,@nivelacesso,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                MySqlCommand executeCmd = new MySqlCommand(sqlInsert, Connection);
                executeCmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                executeCmd.Parameters.AddWithValue("@rg", funcionario.RG);
                executeCmd.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                executeCmd.Parameters.AddWithValue("@email", funcionario.Email);
                executeCmd.Parameters.AddWithValue("@senha", funcionario.Senha);
                executeCmd.Parameters.AddWithValue("@cargo", funcionario.Cargo);
                executeCmd.Parameters.AddWithValue("@nivelacesso", funcionario.NivelAcesso);
                executeCmd.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                executeCmd.Parameters.AddWithValue("@celular", funcionario.Celular);
                executeCmd.Parameters.AddWithValue("@cep", funcionario.Cep);
                executeCmd.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                executeCmd.Parameters.AddWithValue("@numero", funcionario.Numero);
                executeCmd.Parameters.AddWithValue("@complemento", funcionario.Complemento);
                executeCmd.Parameters.AddWithValue("@bairro", funcionario.Bairro);
                executeCmd.Parameters.AddWithValue("@cidade", funcionario.Cidade);
                executeCmd.Parameters.AddWithValue("@estado", funcionario.Estado);

                Connection.Open();
                executeCmd.ExecuteNonQuery();
                MessageBox.Show("Funcionário cadastrado com sucesso!");
                Connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Algo deu errado! Erro: {error}");
            }
        }

        public void AlterarFuncionario(Funcionario funcionario)
        {
            try
            {
                string sqlUpdate = @"UPDATE tb_funcionarios SET nome=@nome,rg=@rg,cpf=@cpf,email=@email, 
            senha=@senha, cargo=@cargo, nivel_acesso=@nivel_acesso, telefone=@telefone, celular=@celular, cep=@cep, 
            endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado
            WHERE id=@id";

                MySqlCommand executeCmd = new MySqlCommand(sqlUpdate, Connection);

                executeCmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                executeCmd.Parameters.AddWithValue("@rg", funcionario.RG);
                executeCmd.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                executeCmd.Parameters.AddWithValue("@email", funcionario.Email);
                executeCmd.Parameters.AddWithValue("@senha", funcionario.Senha);
                executeCmd.Parameters.AddWithValue("@cargo", funcionario.Cargo);
                executeCmd.Parameters.AddWithValue("@nivel_acesso", funcionario.NivelAcesso);
                executeCmd.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                executeCmd.Parameters.AddWithValue("@celular", funcionario.Celular);
                executeCmd.Parameters.AddWithValue("@cep", funcionario.Cep);
                executeCmd.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                executeCmd.Parameters.AddWithValue("@numero", funcionario.Numero);
                executeCmd.Parameters.AddWithValue("@complemento", funcionario.Complemento);
                executeCmd.Parameters.AddWithValue("@bairro", funcionario.Bairro);
                executeCmd.Parameters.AddWithValue("@cidade", funcionario.Cidade);
                executeCmd.Parameters.AddWithValue("@estado", funcionario.Estado);
                executeCmd.Parameters.AddWithValue("@id", funcionario.Codigo);

                Connection.Open();
                executeCmd.ExecuteNonQuery();
                MessageBox.Show("Funcionário alterado com sucesso!");
                Connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Algo deu errado! Erro: {error}");
            }
        }

        public void ExcluirFuncionario(Funcionario funcionario)
        {
            try
            {
                string sqlDelete = @"DELETE FROM tb_funcionarios WHERE id=@id";
                MySqlCommand executeCmd = new MySqlCommand(sqlDelete, Connection);

                executeCmd.Parameters.AddWithValue("@id", funcionario.Codigo);

                Connection.Open();
                executeCmd.ExecuteNonQuery();
                MessageBox.Show("Funcionário excluído com sucesso!");
            }
            catch (Exception error)
            {
                MessageBox.Show($"Algo deu errado! Erro: {error}");
            }
        }
        public DataTable ListarFuncionarios()
        {
            try
            {
                DataTable tabelaFuncionarios = new DataTable();
                string sqlSelect = "SELECT * FROM tb_funcionarios";

                MySqlCommand executeCmd = new MySqlCommand(sqlSelect, Connection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executeCmd);

                dataAdapter.Fill(tabelaFuncionarios);
                return tabelaFuncionarios;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Algo deu errado! Erro: {error}");
                return null;
            }
        }

        public DataTable BuscarFuncionarioPorNome(string nome)
        {
            try
            {
                DataTable tabelaFuncionarios = new DataTable();
                string sqlSelect = "SELECT * FROM tb_funcionarios WHERE nome = @nome";

                MySqlCommand executeCmd = new MySqlCommand(sqlSelect, Connection);
                executeCmd.Parameters.AddWithValue("@nome", nome);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executeCmd);

                dataAdapter.Fill(tabelaFuncionarios);
                return tabelaFuncionarios;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Algo deu errado! Erro: {error}");
                return null;
            }
        }

        public DataTable ListarClientePorNome(string nome)
        {
            try
            {
                DataTable tabelaFuncionarios = new DataTable();
                string sqlSelect = @"SELECT * FROM tb_funcionarios WHERE nome LIKE @nome";

                MySqlCommand executeCmd = new MySqlCommand(sqlSelect, Connection);
                executeCmd.Parameters.AddWithValue("@nome", nome);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executeCmd);

                dataAdapter.Fill(tabelaFuncionarios);
                return tabelaFuncionarios;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Algo deu errado! Erro: {error}");
                return null;
            }
        }
    }
}
