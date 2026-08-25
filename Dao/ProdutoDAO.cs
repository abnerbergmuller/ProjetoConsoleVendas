using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProjetoConsoleVendas.Connection;
using ProjetoConsoleVendas.Model;

namespace ProjetoConsoleVendas.Dao
{
    public class ProdutoDAO
    {
        private MySqlConnection Connection { get; set; }

        public ProdutoDAO()
        {
            this.Connection = new ConnectionFactory().GetConnection();
        }

        public void CadastrarProduto(Produto produto)
        {
            try
            {
                string sqlInsert = @"INSERT INTO tb_produtos (descricao,preco,qtd_estoque,for_id)
            VALUES(@descricao,@preco,@qtd_estoque,@for_id)";
                MySqlCommand executeCmd = new MySqlCommand(sqlInsert, Connection);

                executeCmd.Parameters.AddWithValue("@descricao", produto.Descricao);
                executeCmd.Parameters.AddWithValue("@preco", produto.Preco);
                executeCmd.Parameters.AddWithValue("@qtd_estoque", produto.QtdEstoque);
                executeCmd.Parameters.AddWithValue("@for_id", produto.CodigoFornecedor);

                Connection.Open();
                executeCmd.ExecuteNonQuery();
                MessageBox.Show("Produto cadastrado com sucesso!");
                Connection.Clone();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Algo deu errado! Erro: {error}");
            }
        }

        public void AlterarProduto(Produto produto)
        {
            try
            {
                string sqlUpdate = @"UPDATE tb_produtos SET descricao=@descricao, preco=@preco,
            qtd_estoque=@qtd_estoque, for_id=@for_id WHERE id=@id";

                MySqlCommand executeCmd = new MySqlCommand(sqlUpdate, Connection);

                executeCmd.Parameters.AddWithValue("@descricao", produto.Descricao);
                executeCmd.Parameters.AddWithValue("@preco", produto.Preco);
                executeCmd.Parameters.AddWithValue("@qtd_estoque", produto.QtdEstoque);
                executeCmd.Parameters.AddWithValue("@for_id", produto.CodigoFornecedor);
                executeCmd.Parameters.AddWithValue("@id", produto.Codigo);
                
                Connection.Open();
                executeCmd.ExecuteNonQuery();
                MessageBox.Show("Produto alterado com sucesso!");
                Connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Algo deu errado! Erro: {error}");
            }
        }

        public void ExcluirProduto(Produto produto)
        {
            try
            {
                string sqlDelete = @"DELETE FROM tb_produtos WHERE id=@id";
                MySqlCommand executeCmd = new MySqlCommand(sqlDelete, Connection);

                executeCmd.Parameters.AddWithValue("@id", produto.Codigo);

                Connection.Open();
                executeCmd.ExecuteNonQuery();
                MessageBox.Show("Produto excluído com sucesso!");
                Connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Algo deu errado! Erro: {error}");
            }
        }

        public DataTable ListarProdutos()
        {
            try
            {
                DataTable tabelaProdutos = new DataTable();
                string sqlSelect = @"SELECT tb_produtos.id as 'Codigo', tb_produtos.descricao as 'Descrição',
            tb_produtos.preco as 'Preço', tb_produtos.qtd_estoque as 'Estoque' ,tb_fornecedores.nome as 'Fornecedor'
            FROM bdvendas.tb_produtos JOIN bdvendas.tb_fornecedores ON (tb_produtos.for_id = tb_fornecedores.id)";

                MySqlCommand executeCmd = new MySqlCommand(sqlSelect, Connection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executeCmd);
                dataAdapter.Fill(tabelaProdutos);

                return tabelaProdutos;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Algo deu errado! Erro: {error}");
                return null;
            }
        }

        public DataTable BuscarProdutoPorNome(string nome)
        {
            try
            {
                DataTable tabelaProdutos = new DataTable(); 
                string sqlSelect = @"SELECT tb_produtos.id as 'Codigo', tb_produtos.descricao as 'Descrição',
            tb_produtos.preco as 'Preço', tb_produtos.qtd_estoque as 'Estoque' ,tb_fornecedores.nome as 'Fornecedor'
            FROM bdvendas.tb_produtos JOIN bdvendas.tb_fornecedores ON (tb_produtos.for_id = tb_fornecedores.id)
            WHERE tb_produtos.descricao LIKE @nome";

                MySqlCommand executeCmd = new MySqlCommand(sqlSelect, Connection);
                executeCmd.Parameters.AddWithValue("@nome", nome);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executeCmd);
                dataAdapter.Fill(tabelaProdutos);
                return tabelaProdutos;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Algo deu errado! Erro: {error}");
                return null;
            }
        }

        public Produto RetornaProdutoPorCodigo(int codigo)
        {
            try
            {
                Produto produto = new Produto();
                string sqlSelect = @"SELECT * FROM tb_produtos WHERE id=@id";

                MySqlCommand executeCmd = new MySqlCommand(sqlSelect, Connection);

                executeCmd.Parameters.AddWithValue("@id", codigo);
                Connection.Open();

                using (MySqlDataReader dataReader = executeCmd.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        produto.Codigo = dataReader.GetInt32("id");
                        produto.Descricao = dataReader.GetString("descricao");
                        produto.Preco = Convert.ToDecimal(dataReader.GetDecimal("preco"), CultureInfo.InvariantCulture); ;
                        produto.QtdEstoque = dataReader.GetInt32("qtd_estoque");
                        return produto;
                    }
                    return null;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show($"Algo deu errado! Erro: {error}");
                return null;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
