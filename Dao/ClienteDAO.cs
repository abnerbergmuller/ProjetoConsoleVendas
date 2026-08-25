using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI;
using ProjetoConsoleVendas.Connection;
using ProjetoConsoleVendas.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoConsoleVendas.Dao
{
    public class ClienteDAO
    {
        private MySqlConnection Connection { get; set; }
        public ClienteDAO()
        {
            this.Connection = new ConnectionFactory().GetConnection();
        }

        public void CadastrarCliente(Cliente cliente)
        {
            try
            {
                string sqlInsert = @"INSERT INTO tb_clientes (nome,rg,cpf,email,telefone,celular,
                cep,endereco,numero,complemento,bairro,cidade,estado) values(@nome,@rg,@cpf,@email,@telefone,@celular,
                @cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                MySqlCommand executeCmd = new MySqlCommand(sqlInsert, Connection);
                executeCmd.Parameters.AddWithValue("@nome", cliente.Nome);
                executeCmd.Parameters.AddWithValue("@rg", cliente.RG);
                executeCmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
                executeCmd.Parameters.AddWithValue("@email", cliente.Email);
                executeCmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                executeCmd.Parameters.AddWithValue("@celular", cliente.Celular);
                executeCmd.Parameters.AddWithValue("@cep", cliente.Cep);
                executeCmd.Parameters.AddWithValue("@endereco", cliente.Endereco);
                executeCmd.Parameters.AddWithValue("@numero", cliente.Numero);
                executeCmd.Parameters.AddWithValue("@complemento", cliente.Complemento);
                executeCmd.Parameters.AddWithValue("@bairro", cliente.Bairro);
                executeCmd.Parameters.AddWithValue("@cidade", cliente.Cidade);
                executeCmd.Parameters.AddWithValue("@estado", cliente.Estado);

                Connection.Open();
                executeCmd.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado com sucesso!");
                Connection.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show($"Algo deu errado! Erro: {error}");
            }
        }

        public void AlterarCliente(Cliente cliente)
        {
            try
            {
                string sqlUpdate = @"UPDATE tb_clientes SET nome=@nome,rg=@rg,cpf=@cpf,email=@email,telefone=@telefone,
            celular=@celular,cep=@cep,endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,
            cidade=@cidade,estado=@estado WHERE id = @id";

                MySqlCommand executeCmd = new MySqlCommand(sqlUpdate, Connection);
                executeCmd.Parameters.AddWithValue("@nome", cliente.Nome);
                executeCmd.Parameters.AddWithValue("@rg", cliente.RG);
                executeCmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
                executeCmd.Parameters.AddWithValue("@email", cliente.Email);
                executeCmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                executeCmd.Parameters.AddWithValue("@celular", cliente.Celular);
                executeCmd.Parameters.AddWithValue("@cep", cliente.Cep);
                executeCmd.Parameters.AddWithValue("@endereco", cliente.Endereco);
                executeCmd.Parameters.AddWithValue("@numero", cliente.Numero);
                executeCmd.Parameters.AddWithValue("@complemento", cliente.Complemento);
                executeCmd.Parameters.AddWithValue("@bairro", cliente.Bairro);
                executeCmd.Parameters.AddWithValue("@cidade", cliente.Cidade);
                executeCmd.Parameters.AddWithValue("@estado", cliente.Estado);
                executeCmd.Parameters.AddWithValue("@id", cliente.Codigo);

                Connection.Open();
                executeCmd.ExecuteNonQuery();
                MessageBox.Show("Cliente alterado com sucesso!");
                Connection.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show($"Algo deu errado! Erro: {error}");
            }
        }

        public void ExcluirCliente(Cliente cliente)
        {
            try
            {
                string sqlDelete = @"DELETE FROM tb_clientes WHERE id = @id";

                MySqlCommand executeCmd = new MySqlCommand(sqlDelete, Connection);
                
                executeCmd.Parameters.AddWithValue("@id", cliente.Codigo);

                Connection.Open();
                executeCmd.ExecuteNonQuery();
                MessageBox.Show("Cliente excluído com sucesso!");
                Connection.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show($"Algo deu errado! Erro: {error}");
            }
        }

        public DataTable ListarClientes()
        {
            try
            {
                //Criação do DataTable e do comando SQL
                DataTable tabelaCliente = new DataTable();
                string sqlSelect = "SELECT * FROM tb_clientes";

                //Execução do comando e abertura da conexão
                MySqlCommand executeCmd = new MySqlCommand(sqlSelect, Connection);

                //Criação do MySQLDataAdapter para preenchimento de dados no DataTable

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executeCmd);
                dataAdapter.Fill(tabelaCliente);
                return tabelaCliente;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao executar o comando SQL: {error}");
                return null;
            }
        }

        public DataTable BuscarClientePorNome(string nome)
        {
            try
            {
                //Criação do DataTable e do comando SQL
                DataTable tabelaCliente = new DataTable();
                string sqlSelect = @"SELECT * FROM tb_clientes WHERE nome = @nome";

                //Execução do comando e abertura da conexão
                MySqlCommand executeCmd = new MySqlCommand(sqlSelect, Connection);
                executeCmd.Parameters.AddWithValue("@nome", nome);

                //Criação do MySQLDataAdapter para preenchimento de dados no DataTable

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executeCmd);
                dataAdapter.Fill(tabelaCliente);
                return tabelaCliente;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao executar o comando SQL: {error}");
                return null;
            }
        }

        public DataTable ListarClientePorNome(string nome)
        {
            try
            {
                //Criação do DataTable e do comando SQL
                DataTable tabelaCliente = new DataTable();
                string sqlSelect = @"SELECT * FROM tb_clientes WHERE nome LIKE @nome";

                //Execução do comando e abertura da conexão
                MySqlCommand executeCmd = new MySqlCommand(sqlSelect, Connection);
                executeCmd.Parameters.AddWithValue("@nome", nome);

                //Criação do MySQLDataAdapter para preenchimento de dados no DataTable

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executeCmd);
                dataAdapter.Fill(tabelaCliente);
                return tabelaCliente;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao executar o comando SQL: {error}");
                return null;
            }
        }

        public Cliente RetornaClientePorCPF(string cpf)
        {
            try 
            {
                Cliente cliente = new Cliente();
                string sqlSelect = @"SELECT * FROM tb_clientes WHERE cpf=@cpf";
                MySqlCommand executeCmd = new MySqlCommand(sqlSelect, Connection);

                executeCmd.Parameters.AddWithValue("@cpf", cpf);

                Connection.Open();

                using (MySqlDataReader dataReader = executeCmd.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        return new Cliente(dataReader);
                    }
                    return null;
                }
            }

            catch (Exception error)
            {
                MessageBox.Show($"Erro ao executar o comando SQL: {error}");
                return null;
            }
            finally
            {
                Connection.Close(); 
            }
        }
    }
}
