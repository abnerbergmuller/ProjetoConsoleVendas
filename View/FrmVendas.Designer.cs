namespace ProjetoConsoleVendas.View
{
    partial class FrmVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.Preco = new System.Windows.Forms.Label();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.tabCarrinho = new System.Windows.Forms.DataGridView();
            this.totalVenda = new System.Windows.Forms.GroupBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabCarrinho)).BeginInit();
            this.totalVenda.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 92);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(469, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tela de Vendas";
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.txtNomeCliente);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Controls.Add(this.txtCPF);
            this.gbCliente.Controls.Add(this.label6);
            this.gbCliente.Location = new System.Drawing.Point(11, 110);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(556, 173);
            this.gbCliente.TabIndex = 24;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(84, 54);
            this.txtNomeCliente.Multiline = true;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(334, 26);
            this.txtNomeCliente.TabIndex = 13;
            this.txtNomeCliente.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(16, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(73, 105);
            this.txtCPF.Mask = "###\\.###\\.###-##";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(133, 26);
            this.txtCPF.TabIndex = 10;
            this.txtCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCPF_MaskInputRejected);
            this.txtCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCPF_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(16, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "CPF:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoverItem);
            this.groupBox1.Controls.Add(this.btnAdicionarItem);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.txtDescricaoProduto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCodigoProduto);
            this.groupBox1.Location = new System.Drawing.Point(11, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 303);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.btnRemoverItem.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoverItem.Location = new System.Drawing.Point(277, 233);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(231, 55);
            this.btnRemoverItem.TabIndex = 42;
            this.btnRemoverItem.Text = "Remover Item ❌";
            this.btnRemoverItem.UseVisualStyleBackColor = false;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.btnAdicionarItem.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarItem.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarItem.Location = new System.Drawing.Point(20, 233);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(231, 55);
            this.btnAdicionarItem.TabIndex = 41;
            this.btnAdicionarItem.Text = "Adicionar Item ✔";
            this.btnAdicionarItem.UseVisualStyleBackColor = false;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Controls.Add(this.txtQtd);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.txtPreco);
            this.panel2.Controls.Add(this.Preco);
            this.panel2.Location = new System.Drawing.Point(20, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 54);
            this.panel2.TabIndex = 40;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(367, 14);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(57, 26);
            this.txtQtd.TabIndex = 34;
            this.txtQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(255, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 20);
            this.label19.TabIndex = 33;
            this.label19.Text = "Quantidade:";
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.SystemColors.Window;
            this.txtPreco.Location = new System.Drawing.Point(120, 14);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.Size = new System.Drawing.Size(74, 26);
            this.txtPreco.TabIndex = 32;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Preco
            // 
            this.Preco.AutoSize = true;
            this.Preco.BackColor = System.Drawing.Color.Transparent;
            this.Preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Preco.ForeColor = System.Drawing.Color.White;
            this.Preco.Location = new System.Drawing.Point(16, 18);
            this.Preco.Name = "Preco";
            this.Preco.Size = new System.Drawing.Size(93, 20);
            this.Preco.TabIndex = 31;
            this.Preco.Text = "Preço:  R$";
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescricaoProduto.Location = new System.Drawing.Point(117, 104);
            this.txtDescricaoProduto.Multiline = true;
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.ReadOnly = true;
            this.txtDescricaoProduto.Size = new System.Drawing.Size(334, 26);
            this.txtDescricaoProduto.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(16, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 36;
            this.label4.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(16, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "Descrição:";
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(94, 50);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(98, 26);
            this.txtCodigoProduto.TabIndex = 37;
            this.txtCodigoProduto.TextChanged += new System.EventHandler(this.txtCodigoProduto_TextChanged);
            this.txtCodigoProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoProduto_KeyDown);
            // 
            // tabCarrinho
            // 
            this.tabCarrinho.AllowUserToResizeColumns = false;
            this.tabCarrinho.AllowUserToResizeRows = false;
            this.tabCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabCarrinho.DefaultCellStyle = dataGridViewCellStyle4;
            this.tabCarrinho.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tabCarrinho.Location = new System.Drawing.Point(596, 111);
            this.tabCarrinho.Name = "tabCarrinho";
            this.tabCarrinho.ReadOnly = true;
            this.tabCarrinho.RowHeadersVisible = false;
            this.tabCarrinho.RowHeadersWidth = 62;
            this.tabCarrinho.RowTemplate.Height = 28;
            this.tabCarrinho.Size = new System.Drawing.Size(724, 502);
            this.tabCarrinho.TabIndex = 26;
            // 
            // totalVenda
            // 
            this.totalVenda.Controls.Add(this.txtData);
            this.totalVenda.Controls.Add(this.label7);
            this.totalVenda.Controls.Add(this.btnCancelar);
            this.totalVenda.Controls.Add(this.txtTotalVenda);
            this.totalVenda.Controls.Add(this.btnPagamento);
            this.totalVenda.Controls.Add(this.label5);
            this.totalVenda.Location = new System.Drawing.Point(749, 619);
            this.totalVenda.Name = "totalVenda";
            this.totalVenda.Size = new System.Drawing.Size(571, 167);
            this.totalVenda.TabIndex = 27;
            this.totalVenda.TabStop = false;
            this.totalVenda.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.SystemColors.Window;
            this.txtData.Location = new System.Drawing.Point(406, 39);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(111, 26);
            this.txtData.TabIndex = 46;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(339, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 26);
            this.label7.TabIndex = 45;
            this.label7.Text = "Data:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(310, 88);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(207, 50);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalVenda.Location = new System.Drawing.Point(146, 39);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.ReadOnly = true;
            this.txtTotalVenda.Size = new System.Drawing.Size(131, 26);
            this.txtTotalVenda.TabIndex = 13;
            this.txtTotalVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPagamento
            // 
            this.btnPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.btnPagamento.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamento.ForeColor = System.Drawing.Color.White;
            this.btnPagamento.Location = new System.Drawing.Point(53, 88);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(207, 50);
            this.btnPagamento.TabIndex = 43;
            this.btnPagamento.Text = "Pagamento";
            this.btnPagamento.UseVisualStyleBackColor = false;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(33, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total (R$)";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes.Location = new System.Drawing.Point(15, 28);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(520, 101);
            this.txtObservacoes.TabIndex = 0;
            this.txtObservacoes.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtObservacoes.Leave += new System.EventHandler(this.txtObservacoes_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(27, 629);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(145, 32);
            this.panel3.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 23);
            this.label8.TabIndex = 42;
            this.label8.Text = "Observação";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtObservacoes);
            this.panel4.Location = new System.Drawing.Point(11, 644);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(556, 142);
            this.panel4.TabIndex = 42;
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1332, 798);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.totalVenda);
            this.Controls.Add(this.tabCarrinho);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.KeyPreview = true;
            this.Name = "FrmVendas";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Text = "Tela de Vendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabCarrinho)).EndInit();
            this.totalVenda.ResumeLayout(false);
            this.totalVenda.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label Preco;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.DataGridView tabCarrinho;
        private System.Windows.Forms.GroupBox totalVenda;
        private System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
    }
}