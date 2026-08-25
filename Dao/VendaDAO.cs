using MySql.Data.MySqlClient;
using ProjetoConsoleVendas.Connection;
using ProjetoConsoleVendas.Model;
using ProjetoConsoleVendas.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoConsoleVendas.Dao
{
    public class VendaDAO
    {
        private MySqlConnection Connection { get; set; }

        public VendaDAO()
        {
            this.Connection = new ConnectionFactory().GetConnection();
        }

        public void CadastrarVenda(Venda venda)
        {
            try
            {
                string sqlInsert = @"INSERT INTO tb_vendas(cliente_id,data_venda,total_venda,observacoes) 
            VALUES(@cliente_id,@data_venda,@total_venda,@observacoes)";

                MySqlCommand executeCmd = new MySqlCommand(sqlInsert, Connection);
                executeCmd.Parameters.AddWithValue("@cliente_id", venda.ClienteId.Codigo);
                executeCmd.Parameters.AddWithValue("@data_venda", venda.DataVenda);
                executeCmd.Parameters.AddWithValue("@total_venda", venda.TotalVenda);
                executeCmd.Parameters.AddWithValue("@observacoes", venda.Observacoes);

                Connection.Open();
                executeCmd.ExecuteNonQuery();
                MessageBox.Show("Venda finalizada, tenha um bom dia! 😊");
                Connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Algo deu errado! Erro: {error}");
            }
        }
        public int RetornaIdUltimaVenda(Venda venda)
        {
            try
            {
                int idUltimaVenda;
                string sqlSelect = "SELECT MAX(id) id FROM tb_vendas";

                MySqlCommand executeCmd = new MySqlCommand(sqlSelect, Connection);

                Connection.Open();
                using (MySqlDataReader dataReader = executeCmd.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        return idUltimaVenda = dataReader.GetInt32("id");
                    }
                    return 0;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Algo deu errado! Erro: {error}");
                return 0;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
