using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoConsoleVendas.Dao;
using ProjetoConsoleVendas.Model;

namespace ProjetoConsoleVendas.View
{
    public partial class FrmCadastroFornecedor : Form
    {
        public FrmCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void ListarFornecedores()
        {
            FornecedorDAO fornecedorDao = new FornecedorDAO();
            tabelaFornecedores.DataSource = fornecedorDao.ListarFornecedores();
        }

        public void ExecutarPesquisaPorNome(string nome)
        {
            FornecedorDAO fornecedorDao = new FornecedorDAO();
            tabelaFornecedores.DataSource = fornecedorDao.BuscarFornecedorPorNome(nome);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor(
                txtNome.Text,
                "",
                "",
                txtEmail.Text,
                txtTelefone.Text,
                txtCelular.Text,
                txtCEP.Text,
                txtEndereco.Text,
                int.Parse(txtNumero.Text),
                txtComplemento.Text,
                txtBairro.Text,
                txtCidade.Text,
                cbEstado.Text,
                txtCNPJ.Text
                );
            FornecedorDAO fornecedorDao = new FornecedorDAO();
            fornecedorDao.CadastrarFornecedor(fornecedor);

            tabelaFornecedores.DataSource = fornecedorDao.ListarFornecedores();
            new Helpers().LimparTela(this);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor(int.Parse(txtCodigo.Text));
            FornecedorDAO fornecedorDao = new FornecedorDAO();

            fornecedorDao.ExcluirFornecedor(fornecedor);
            tabelaFornecedores.DataSource = fornecedorDao.ListarFornecedores();
            new Helpers().LimparTela(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        { Fornecedor fornecedor = new Fornecedor(
                int.Parse(txtCodigo.Text),
                txtNome.Text,
                "",
                "",
                txtEmail.Text,
                txtTelefone.Text,
                txtCelular.Text,
                txtCEP.Text,
                txtEndereco.Text,
                int.Parse(txtNumero.Text),
                txtComplemento.Text,
                txtBairro.Text,
                txtCidade.Text,
                cbEstado.Text,
                txtCNPJ.Text
            );

            FornecedorDAO fornecedorDao = new FornecedorDAO();
            fornecedorDao.AlterarFornecedor(fornecedor);

            tabelaFornecedores.DataSource = fornecedorDao.ListarFornecedores();
            new Helpers().LimparTela(this);
        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnPesquisarCEP_Click(object sender, EventArgs e)
        {
            try
            {
                string xmlApi = $"https://viacep.com.br/ws/{txtCEP.Text}/xml/";
                DataSet dataSet = new DataSet();

                dataSet.ReadXml(xmlApi);

                txtEndereco.Text = dataSet.Tables[0].Rows[0]["logradouro"].ToString();
                txtComplemento.Text = dataSet.Tables[0].Rows[0]["complemento"].ToString();
                txtCidade.Text = dataSet.Tables[0].Rows[0]["localidade"].ToString();
                txtBairro.Text = dataSet.Tables[0].Rows[0]["bairro"].ToString();
                cbEstado.Text = dataSet.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("Endereço não encontrado, digite-o manualmente");
            }
        }

        private void FrmCadastroFornecedor_Load(object sender, EventArgs e)
        {
            ListarFornecedores();
        }

        private void tabelaFornecedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = tabelaFornecedores.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaFornecedores.CurrentRow.Cells[1].Value.ToString();
            txtCNPJ.Text = tabelaFornecedores.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = tabelaFornecedores.CurrentRow.Cells[3].Value.ToString();
            txtTelefone.Text = tabelaFornecedores.CurrentRow.Cells[4].Value.ToString();
            txtCelular.Text = tabelaFornecedores.CurrentRow.Cells[5].Value.ToString();
            txtCEP.Text = tabelaFornecedores.CurrentRow.Cells[6].Value.ToString();
            txtEndereco.Text = tabelaFornecedores.CurrentRow.Cells[7].Value.ToString();
            txtNumero.Text = tabelaFornecedores.CurrentRow.Cells[8].Value.ToString();
            txtComplemento.Text = tabelaFornecedores.CurrentRow.Cells[9].Value.ToString();
            txtBairro.Text = tabelaFornecedores.CurrentRow.Cells[10].Value.ToString();
            txtCidade.Text = tabelaFornecedores.CurrentRow.Cells[11].Value.ToString();
            cbEstado.Text = tabelaFornecedores.CurrentRow.Cells[12].Value.ToString();

            tabFornecedor.SelectedTab = tabPage1;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisa.Text))
            {
                ListarFornecedores();
            }
            else
            {
                ExecutarPesquisaPorNome(txtPesquisa.Text);
            }
        }
    }
}
