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
    public partial class FrmCadastroProdutos : Form
    {
        public FrmCadastroProdutos()
        {
            InitializeComponent();
        }

        public void ListarProdutos()
        {
            ProdutoDAO produtoDao = new ProdutoDAO();
            tabelaProdutos.DataSource = produtoDao.ListarProdutos();
        }

        public void ExecutarPesquisaPorNome(string nome)
        {
            ProdutoDAO produtoDao = new ProdutoDAO();
            tabelaProdutos.DataSource = produtoDao.BuscarProdutoPorNome(nome);
        }

        public void LimpartxtPrecoEtxtEstoque()
        {
            txtPreco.Clear();
            txtQtdEstoque.Clear();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCadastroProdutos_Load(object sender, EventArgs e)
        {
            FornecedorDAO fornecedorDao = new FornecedorDAO();
            cbFornecedor.DataSource = fornecedorDao.ListarFornecedores();
            cbFornecedor.DisplayMember = "nome";
            cbFornecedor.ValueMember = "id";

            ListarProdutos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
            LimpartxtPrecoEtxtEstoque();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(
                txtDescricao.Text,
                decimal.Parse(txtPreco.Text, CultureInfo.InvariantCulture),
                int.Parse(txtQtdEstoque.Text),
                int.Parse(cbFornecedor.SelectedValue.ToString())
                );
            ProdutoDAO produtoDao = new ProdutoDAO();
            produtoDao.CadastrarProduto(produto);

            ListarProdutos();
            new Helpers().LimparTela(this);
            LimpartxtPrecoEtxtEstoque();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(
                int.Parse(txtCodigo.Text)
            );

            ProdutoDAO produtoDao = new ProdutoDAO();
            produtoDao.ExcluirProduto(produto);
            ListarProdutos();
            new Helpers().LimparTela(this);
            LimpartxtPrecoEtxtEstoque();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(
                int.Parse(txtCodigo.Text),
                txtDescricao.Text,
                decimal.Parse(txtPreco.Text, CultureInfo.InvariantCulture),
                int.Parse(txtQtdEstoque.Text),
                int.Parse(cbFornecedor.SelectedValue.ToString())
            );
            ProdutoDAO produtoDao = new ProdutoDAO();
            produtoDao.AlterarProduto(produto);
            ListarProdutos();
            new Helpers().LimparTela(this);
            LimpartxtPrecoEtxtEstoque();
        }

        private void tabelaProdutos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FornecedorDAO fornecedorDao = new FornecedorDAO();
            txtCodigo.Text = tabelaProdutos.CurrentRow.Cells[0].Value.ToString();
            txtDescricao.Text = tabelaProdutos.CurrentRow.Cells[1].Value.ToString();
            txtPreco.Text = tabelaProdutos.CurrentRow.Cells[2].Value.ToString();
            txtQtdEstoque.Text = tabelaProdutos.CurrentRow.Cells[3].Value.ToString();
            cbFornecedor.Text = tabelaProdutos.CurrentRow.Cells[4].Value.ToString();

            tabProdutos.SelectedTab = tabPage1;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisa.Text))
            {
                ListarProdutos();
            }
            else
            {
                ExecutarPesquisaPorNome($"%{txtPesquisa.Text}%");
            }
        }

        private void btnPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (string.IsNullOrWhiteSpace(txtPesquisa.Text))
                {
                    ListarProdutos();
                }
                else
                {
                    ExecutarPesquisaPorNome($"%{txtPesquisa.Text}%");
                }
                e.SuppressKeyPress = true;
            }
        }
    }
}
