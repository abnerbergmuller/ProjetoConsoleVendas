using Mysqlx;
using ProjetoConsoleVendas.Dao;
using ProjetoConsoleVendas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoConsoleVendas.View
{
    public partial class FrmPagamentos : Form
    {
        Cliente cliente = new Cliente();
        DataTable carrinho = new DataTable();
        DateTime dataDaVenda;
        decimal totalVenda;
        string observacoes;

        public FrmPagamentos(Cliente cliente, DataTable carrinho, DateTime dataDaVenda, decimal totalVenda, string observacoes, Produto produto)
        {
            this.cliente = cliente;
            this.carrinho = carrinho;
            this.dataDaVenda = dataDaVenda;
            this.totalVenda = totalVenda;
            this.observacoes = observacoes;
            InitializeComponent();
        }

        public void CalcularTroco()
        {
            txtTroco.Text = string.Empty;

            if (string.IsNullOrWhiteSpace(txtDinheiro.Text)) return;

            if (!string.IsNullOrWhiteSpace(txtCartao.Text) && !string.IsNullOrWhiteSpace(txtPix.Text)) return;

            bool dinheiroValido = decimal.TryParse(txtDinheiro.Text, out decimal dinheiro);
            bool totalValido = decimal.TryParse(txtTotal.Text, out decimal total);

            if (dinheiroValido && totalValido && dinheiro >= total)
            {
                txtTroco.Text = (dinheiro - total).ToString("F2");
            }
        }

        public void LimparCamposPagamento()
        {
            txtPix.Clear();
            txtDinheiro.Clear();
            txtCartao.Clear();
            txtTroco.Clear();
        }

        public bool VerificaPagamento()
        {
            decimal.TryParse(txtDinheiro.Text, out decimal dinheiro);
            decimal.TryParse(txtCartao.Text, out decimal cartao);
            decimal.TryParse(txtPix.Text, out decimal pix);

            decimal totalPago = cartao + pix + dinheiro;

            if (cartao > totalVenda || pix > totalVenda)
            {
                MessageBox.Show("ATENÇÃO: Pagamento maior que a venda");
                LimparCamposPagamento();
                return false;
            }

            if (totalPago < totalVenda)
            {
                MessageBox.Show("PAGAMENTO INSUFICIENTE!!");
                LimparCamposPagamento();
                return false;
            }

            return true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTroco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDinheiro_Leave(object sender, EventArgs e)
        {
            CalcularTroco();
        }

        private void FrmPagamentos_Load(object sender, EventArgs e)
        {

        }

        private void FrmPagamentos_MouseClick(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void txtCartao_Leave(object sender, EventArgs e)
        {
            CalcularTroco();
        }

        private void txtPix_Leave(object sender, EventArgs e)
        {
            CalcularTroco();
        }

        private void btnFinalizarPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                VerificaPagamento();

                Venda venda = new Venda(
                    cliente,
                    dataDaVenda,
                    totalVenda,
                    observacoes
                    );

                
            }
            catch (Exception error)
            {
                MessageBox.Show($"Algo deu errado! Erro: {error}");
            }
        }
    }
}
