using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoConsoleVendas.Dao;
using ProjetoConsoleVendas.Model;

namespace ProjetoConsoleVendas.View
{
    public partial class FrmVendas : Form
    {
        //Instâncias de objetos Cliente e ClienteDAO
        Cliente cliente = new Cliente();
        ClienteDAO clienteDao = new ClienteDAO();

        //Instâncias de objetos Produto e ProdutoDAO
        Produto produto = new Produto();
        ProdutoDAO produtoDao = new ProdutoDAO();

        int qtd;
        decimal preco;
        decimal subtotal, total;
        DateTime dataDaVenda;
        string observacoes;

        DataTable carrinho = new DataTable();


        public FrmVendas()
        {
            InitializeComponent();

            carrinho.Columns.Add("Codigo", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Quantidade", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            tabCarrinho.DataSource = carrinho;
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            dataDaVenda = DateTime.Today;
            txtData.Text = dataDaVenda.ToShortDateString();
            tabCarrinho.Columns["Codigo"].Width = 50;
            tabCarrinho.Columns["Produto"].Width = 200;
            tabCarrinho.Columns["Quantidade"].Width = 70;
            tabCarrinho.Columns["Quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabCarrinho.Columns["Preço"].Width = 80;
            tabCarrinho.Columns["Subtotal"].Width = 100;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                cliente = clienteDao.RetornaClientePorCPF(txtCPF.Text);
                if (cliente != null)
                {
                    txtNomeCliente.Text = cliente.Nome;
                    e.SuppressKeyPress = true;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!");
                }
            }
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (produto.Codigo == int.Parse(txtCodigoProduto.Text))
                {
                    qtd = int.Parse(txtQtd.Text);
                    preco = decimal.Parse(txtPreco.Text);
                    subtotal = qtd * preco;

                    carrinho.Rows.Add(int.Parse(txtCodigoProduto.Text), txtDescricaoProduto.Text,
                        qtd, preco, subtotal);

                    total += subtotal;
                    txtTotalVenda.Text = total.ToString();

                    txtCodigoProduto.Clear();
                    txtDescricaoProduto.Clear();
                    txtPreco.Clear();
                    txtQtd.Clear();

                    txtCodigoProduto.Focus();
                }
                else
                {
                    MessageBox.Show("As informações do produto não correspondem!!!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Digite o código do produto!!");
            }
        }

        private void txtCodigoProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            try
            {
                var subtotalProduto = tabCarrinho.CurrentRow.Cells["Subtotal"].Value.ToString();
                int rowIndex = tabCarrinho.CurrentCell.RowIndex;

                if (!tabCarrinho.Rows[rowIndex].IsNewRow)
                {
                    carrinho.Rows.RemoveAt(rowIndex);

                    if (string.IsNullOrWhiteSpace(subtotalProduto))
                    {
                        total -= decimal.Parse(subtotalProduto);
                        txtTotalVenda.Text = total.ToString();
                    }

                    carrinho.AcceptChanges();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao remover item!!");
            }
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            FrmPagamentos telaPagamentos = new FrmPagamentos(cliente, carrinho, dataDaVenda, total, observacoes, produto);

            telaPagamentos.txtTotal.Text = total.ToString();

            telaPagamentos.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtObservacoes_Leave(object sender, EventArgs e)
        {
            observacoes = txtObservacoes.Text;
        }

        private void txtCodigoProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                produto = produtoDao.RetornaProdutoPorCodigo(int.Parse(txtCodigoProduto.Text));
                if (produto != null)
                {
                    txtDescricaoProduto.Text = produto.Descricao;
                    txtPreco.Text = produto.Preco.ToString();
                    e.SuppressKeyPress = true;
                }
                else
                {
                    MessageBox.Show("Produto não encontrado!");
                }
            }
        }
    }
}
