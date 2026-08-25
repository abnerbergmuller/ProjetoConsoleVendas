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
    public partial class FrmCadastroFuncionario : Form
    {
        public FrmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void ListarFuncionarios()
        {
            FuncionarioDAO funcionarioDao = new FuncionarioDAO();
            tabelaFuncionario.DataSource = funcionarioDao.ListarFuncionarios();
        }

        private void ExecutarPesquisaPorNome(string nome)
        {
            FuncionarioDAO funcionarioDao = new FuncionarioDAO();
            tabelaFuncionario.DataSource = funcionarioDao.BuscarFuncionarioPorNome(nome);
        }

        private void FrmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            ListarFuncionarios();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtRG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisa.Text))
            {
                ListarFuncionarios();
            }
            else
            {
                ExecutarPesquisaPorNome(txtPesquisa.Text);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario(
                txtNome.Text,
                txtRG.Text,
                txtCPF.Text,
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
                txtSenha.Text,
                txtCargo.Text,
                cbNivel.Text
            );

            FuncionarioDAO funcionarioDao = new FuncionarioDAO();
            funcionarioDao.CadastrarFuncionario(funcionario);
            tabelaFuncionario.DataSource = funcionarioDao.ListarFuncionarios();
            new Helpers().LimparTela(this);
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisa.Text))
            {
                ListarFuncionarios();
            }
            else
            {
                FuncionarioDAO funcionarioDao = new FuncionarioDAO();
                tabelaFuncionario.DataSource = funcionarioDao.ListarClientePorNome($"%{txtPesquisa.Text}%");
            }
        }

        private void tabelaFuncionario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = tabelaFuncionario.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaFuncionario.CurrentRow.Cells[1].Value.ToString();
            txtRG.Text = tabelaFuncionario.CurrentRow.Cells[2].Value.ToString();
            txtCPF.Text = tabelaFuncionario.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = tabelaFuncionario.CurrentRow.Cells[4].Value.ToString();
            txtSenha.Text = tabelaFuncionario.CurrentRow.Cells[5].Value.ToString();
            txtCargo.Text = tabelaFuncionario.CurrentRow.Cells[6].Value.ToString();
            cbNivel.Text = tabelaFuncionario.CurrentRow.Cells[7].Value.ToString();
            txtTelefone.Text = tabelaFuncionario.CurrentRow.Cells[8].Value.ToString();
            txtCelular.Text = tabelaFuncionario.CurrentRow.Cells[9].Value.ToString();
            txtCEP.Text = tabelaFuncionario.CurrentRow.Cells[10].Value.ToString();
            txtEndereco.Text = tabelaFuncionario.CurrentRow.Cells[11].Value.ToString();
            txtNumero.Text = tabelaFuncionario.CurrentRow.Cells[12].Value.ToString();
            txtComplemento.Text = tabelaFuncionario.CurrentRow.Cells[13].Value.ToString();
            txtBairro.Text = tabelaFuncionario.CurrentRow.Cells[14].Value.ToString();
            txtCidade.Text = tabelaFuncionario.CurrentRow.Cells[15].Value.ToString();
            cbEstado.Text = tabelaFuncionario.CurrentRow.Cells[16].Value.ToString();

            tabFuncionario.SelectedTab = tabPage1;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario(int.Parse(txtCodigo.Text));

            FuncionarioDAO funcionarioDao = new FuncionarioDAO();
            funcionarioDao.ExcluirFuncionario(funcionario);
            tabelaFuncionario.DataSource = funcionarioDao.ListarFuncionarios();
            new Helpers().LimparTela(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario(
                int.Parse(txtCodigo.Text),
                txtNome.Text,
                txtRG.Text,
                txtCPF.Text,
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
                txtSenha.Text,
                txtCargo.Text,
                cbNivel.Text
            );

            FuncionarioDAO funcionarioDao = new FuncionarioDAO();
            funcionarioDao.AlterarFuncionario(funcionario);
            tabelaFuncionario.DataSource = funcionarioDao.ListarFuncionarios();
            new Helpers().LimparTela(this);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '*';  
            }
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (string.IsNullOrWhiteSpace(txtPesquisa.Text))
                {
                    ListarFuncionarios();
                }
                else
                {
                    ExecutarPesquisaPorNome(txtPesquisa.Text);
                }
                e.SuppressKeyPress = true;
            }
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
