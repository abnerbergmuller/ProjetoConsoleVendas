using MySqlX.XDevAPI;
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
    public partial class FrmCadastroCliente : Form
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        //Método para listar clientes
        private void ListarClientes()
        {
            ClienteDAO clienteDao = new ClienteDAO();
            tabelaCliente.DataSource = clienteDao.ListarClientes();
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        //Método para pesquisa por nome
        private void ExecutarPesquisaPorNome(string nome)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            tabelaCliente.DataSource = clienteDAO.BuscarClientePorNome(nome);
        }

        //Uso do método de pesquisa por nome no btnPesquisar
        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisa.Text))
            {
                ListarClientes();
            }
            else
            {
                ExecutarPesquisaPorNome(txtPesquisa.Text);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(
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
                cbEstado.Text
                );

            ClienteDAO clienteDao = new ClienteDAO();
            clienteDao.CadastrarCliente(cliente);
            tabelaCliente.DataSource = clienteDao.ListarClientes();
            new Helpers().LimparTela(this);
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabelaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(int.Parse(txtCodigo.Text));

            ClienteDAO clienteDao = new ClienteDAO();
            clienteDao.ExcluirCliente(cliente);
            tabelaCliente.DataSource = clienteDao.ListarClientes();
            new Helpers().LimparTela(this);
        }

        private void tabelaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(
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
                cbEstado.Text
            );
            ClienteDAO clienteDao = new ClienteDAO();
            clienteDao.AlterarCliente(cliente);
            tabelaCliente.DataSource = clienteDao.ListarClientes();
            new Helpers().LimparTela(this);
        }

        private void tabelaCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = tabelaCliente.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaCliente.CurrentRow.Cells[1].Value.ToString();
            txtRG.Text = tabelaCliente.CurrentRow.Cells[2].Value.ToString();
            txtCPF.Text = tabelaCliente.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = tabelaCliente.CurrentRow.Cells[4].Value.ToString();
            txtTelefone.Text = tabelaCliente.CurrentRow.Cells[5].Value.ToString();
            txtCelular.Text = tabelaCliente.CurrentRow.Cells[6].Value.ToString();
            txtCEP.Text = tabelaCliente.CurrentRow.Cells[7].Value.ToString();
            txtEndereco.Text = tabelaCliente.CurrentRow.Cells[8].Value.ToString();
            txtNumero.Text = tabelaCliente.CurrentRow.Cells[9].Value.ToString();
            txtComplemento.Text = tabelaCliente.CurrentRow.Cells[10].Value.ToString();
            txtBairro.Text = tabelaCliente.CurrentRow.Cells[11].Value.ToString();
            txtCidade.Text = tabelaCliente.CurrentRow.Cells[12].Value.ToString();
            cbEstado.Text = tabelaCliente.CurrentRow.Cells[13].Value.ToString();

            tabClientes.SelectedTab = tabPage1;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        //Uso do método de pesquisa por nome ao clicar Enter no textBox
        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (string.IsNullOrWhiteSpace(txtPesquisa.Text))
                {
                    ListarClientes();
                }
                else
                {
                    ExecutarPesquisaPorNome(txtPesquisa.Text);
                }
                e.SuppressKeyPress = true;
            }  
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            tabelaCliente.DataSource = clienteDAO.ListarClientePorNome($"%{txtPesquisa.Text}%");
        }

        //Busca de endereço via API de busca de CEP's 
        private void button1_Click(object sender, EventArgs e)
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }
    }
}
