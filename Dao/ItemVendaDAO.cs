using MySql.Data.MySqlClient;
using Mysqlx;
using ProjetoConsoleVendas.Connection;
using ProjetoConsoleVendas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoConsoleVendas.Dao
{
    public class ItemVendaDAO
    {
        private MySqlConnection Connection;

        public ItemVendaDAO()
        {
            this.Connection = new ConnectionFactory().GetConnection();
        }

        public void CadastrarItem(ItemVenda itemVenda)
        {
            try
            {
                string sqlInsert = @"INSERT INTO tb_itensvendas(venda_id,produto_id,qtd,subtotal) 
        VALUES(@venda_id,@produto_id,@qtd,@subtotal)";

                MySqlCommand executeCmd = new MySqlCommand(sqlInsert, Connection);

                executeCmd.Parameters.AddWithValue("@venda_id", itemVenda.VendaId);
                executeCmd.Parameters.AddWithValue("@produto_id", itemVenda.ProdutoId);
                executeCmd.Parameters.AddWithValue("@qtd", itemVenda.Quantidade);
                executeCmd.Parameters.AddWithValue("@subtotal", itemVenda.SubTotal);

                Connection.Open();
                executeCmd.ExecuteNonQuery();
                MessageBox.Show("Item cadastrado com sucesso!");
                Connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Algo deu errado! Erro: {error}");
            }
        }
    }
}
