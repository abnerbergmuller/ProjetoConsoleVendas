namespace ProjetoConsoleVendas.View
{
    partial class FrmPagamentos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCartao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnFinalizarPagamento = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 92);
            this.panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(164, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pagamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(85, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 32);
            this.label4.TabIndex = 38;
            this.label4.Text = "Dinheiro (R$):";
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtDinheiro.Location = new System.Drawing.Point(281, 124);
            this.txtDinheiro.Multiline = true;
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(184, 36);
            this.txtDinheiro.TabIndex = 39;
            this.txtDinheiro.TextChanged += new System.EventHandler(this.txtCodigoProduto_TextChanged);
            this.txtDinheiro.Leave += new System.EventHandler(this.txtDinheiro_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(168, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 40;
            this.label1.Text = "Cartão:";
            // 
            // txtCartao
            // 
            this.txtCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtCartao.Location = new System.Drawing.Point(281, 182);
            this.txtCartao.Multiline = true;
            this.txtCartao.Name = "txtCartao";
            this.txtCartao.Size = new System.Drawing.Size(184, 36);
            this.txtCartao.TabIndex = 41;
            this.txtCartao.Leave += new System.EventHandler(this.txtCartao_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(208, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 32);
            this.label3.TabIndex = 42;
            this.label3.Text = "PIX:";
            // 
            // txtPix
            // 
            this.txtPix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtPix.Location = new System.Drawing.Point(281, 238);
            this.txtPix.Multiline = true;
            this.txtPix.Name = "txtPix";
            this.txtPix.Size = new System.Drawing.Size(184, 36);
            this.txtPix.TabIndex = 43;
            this.txtPix.Leave += new System.EventHandler(this.txtPix_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(181, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 32);
            this.label5.TabIndex = 44;
            this.label5.Text = "Troco:";
            // 
            // txtTroco
            // 
            this.txtTroco.BackColor = System.Drawing.SystemColors.Window;
            this.txtTroco.Enabled = false;
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtTroco.Location = new System.Drawing.Point(281, 351);
            this.txtTroco.Multiline = true;
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(184, 36);
            this.txtTroco.TabIndex = 45;
            this.txtTroco.TextChanged += new System.EventHandler(this.txtTroco_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(189, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 32);
            this.label6.TabIndex = 46;
            this.label6.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtTotal.Location = new System.Drawing.Point(281, 406);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(184, 36);
            this.txtTotal.TabIndex = 47;
            // 
            // btnFinalizarPagamento
            // 
            this.btnFinalizarPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.btnFinalizarPagamento.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarPagamento.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarPagamento.Location = new System.Drawing.Point(123, 483);
            this.btnFinalizarPagamento.Name = "btnFinalizarPagamento";
            this.btnFinalizarPagamento.Size = new System.Drawing.Size(364, 55);
            this.btnFinalizarPagamento.TabIndex = 48;
            this.btnFinalizarPagamento.Text = "Finalizar Pagamento 💲";
            this.btnFinalizarPagamento.UseVisualStyleBackColor = false;
            this.btnFinalizarPagamento.Click += new System.EventHandler(this.btnFinalizarPagamento_Click);
            // 
            // FrmPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 555);
            this.Controls.Add(this.btnFinalizarPagamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCartao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDinheiro);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPagamentos";
            this.Text = "FrmPagamentos";
            this.Load += new System.EventHandler(this.FrmPagamentos_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FrmPagamentos_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCartao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFinalizarPagamento;
        public System.Windows.Forms.TextBox txtTotal;
    }
}