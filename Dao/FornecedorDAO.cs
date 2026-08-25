using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProjetoConsoleVendas.Connection;
using ProjetoConsoleVendas.Model;

namespace ProjetoConsoleVendas.Dao
{
    public class FornecedorDAO
    {
        private MySqlConnection Connection { get; set; }

        public FornecedorDAO()
        {
            this.Connection = new ConnectionFactory().GetConnection();
        }

        public void CadastrarFornecedor(Fornecedor fornecedor)
        {
            try
            {
                string sqlInsert = @"INSERT INTO tb_fornecedores(nome,cnpj,email,telefone,celular,cep,endereco,numero,
            complemento,bairro,cidade,estado) VALUES(@nome,@cnpj,@email,@telefone,@celular,@cep,@endereco,@numero,
            @complemento,@bairro,@cidade,@estado)";

                MySqlCommand executeCmd = new MySqlCommand(sqlInsert, Connection);
                executeCmd.Parameters.AddWithValue("@nome", fornecedor.Nome);
                executeCmd.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
                executeCmd.Parameters.AddWithValue("@email", fornecedor.Email);
                executeCmd.Parameters.AddWithValue("@telefone", fornecedor.Telefone);
                executeCmd.Parameters.AddWithValue("@celular", fornecedor.Celular);
                executeCmd.Parameters.AddWithValue("@cep", fornecedor.Cep);
                executeCmd.Parameters.AddWithValue("@endereco", fornecedor.Endereco);
                executeCmd.Parameters.AddWithValue("@numero", fornecedor.Numero);
                executeCmd.Parameters.AddWithValue("@complemento", fornecedor.Complemento);
                executeCmd.Parameters.AddWithValue("@bairro", fornecedor.Bairro);
                executeCmd.Parameters.AddWithValue("@cidade", fornecedor.Cidade);
                executeCmd.Parameters.AddWithValue("@estado", fornecedor.Estado);

                Connection.Open();
                executeCmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor cadastrado com sucesso!");
                Connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Algo deu errado! Erro: {error}");
            }
        }

        public void AlterarFornecedor(Fornecedor fornecedor)
        {
            try
            {
                string sqlUpdate = @"UPDATE tb_fornecedores SET nome=@nome,cnpj=@cnpj,email=@email,telefone=@telefone,
            celular=@celular,cep=@cep,endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,
            cidade=@cidade,estado=@estado WHERE id=@id";

                MySqlCommand executeCmd = new MySqlCommand(sqlUpdate, Connection);
                executeCmd.Parameters.AddWithValue("@nome", fornecedor.Nome);
                executeCmd.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
                executeCmd.Parameters.AddWithValue("@email", fornecedor.Email);
                executeCmd.Parameters.AddWithValue("@telefone", fornecedor.Telefone);
                executeCmd.Parameters.AddWithValue("@celular", fornecedor.Celular);
                executeCmd.Parameters.AddWithValue("@cep", fornecedor.Cep);
                executeCmd.Parameters.AddWithValue("@endereco", fornecedor.Endereco);
                executeCmd.Parameters.AddWithValue("@numero", fornecedor.Numero);
                executeCmd.Parameters.AddWithValue("@complemento", fornecedor.Complemento);
                executeCmd.Parameters.AddWithValue("@bairro", fornecedor.Bairro);
                executeCmd.Parameters.AddWithValue("@cidade", fornecedor.Cidade);
                executeCmd.Parameters.AddWithValue("@estado", fornecedor.Estado);
                executeCmd.Parameters.AddWithValue("@id", fornecedor.Codigo);

                Connection.Open();
                executeCmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor alterado com sucesso!");
                Connection.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show($"Algo deu errado! Erro: {error}");
            }
        }

        public void ExcluirFornecedor(Fornecedor fornecedor)
        {
            try
            {
                string sqlDelete = @"DELETE FROM tb_fornecedores WHERE id=@id";
                MySqlCommand executeCmd = new MySqlCommand(sqlDelete, Connection);

                executeCmd.Parameters.AddWithValue("@id", fornecedor.Codigo);

                Connection.Open();
                executeCmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor excluído com sucesso!");
                Connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Algo deu errado! Erro: {error}");
            }
        }

        public DataTable ListarFornecedores()
        {
            try
            {
                DataTable tabelaFornecedores = new DataTable();
                string sqlSelect = "SELECT * FROM tb_fornecedores";

                MySqlCommand executeCmd = new MySqlCommand(sqlSelect, Connection);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executeCmd);
                dataAdapter.Fill(tabelaFornecedores);

                return tabelaFornecedores;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Algo deu errado! Erro: {error}");
                return null;
            }
        }

        public DataTable BuscarFornecedorPorNome(string nome)
        {
            try
            {
                DataTable tabelaFornecedores = new DataTable();
                string sqlSelect = @"SELECT * FROM tb_fornecedores WHERE nome LIKE @nome";

                MySqlCommand executeCmd = new MySqlCommand(sqlSelect, Connection);
                executeCmd.Parameters.AddWithValue("@nome", nome);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executeCmd);
                dataAdapter.Fill(tabelaFornecedores);

                return tabelaFornecedores;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Algo deu errado! Erro: {error}");
                return null;
            }
        }
    }
}
