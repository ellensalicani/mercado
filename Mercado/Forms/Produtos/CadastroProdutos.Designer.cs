namespace Mercado.Forms
{
    partial class CadastroProdutos
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
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbDataVenc = new System.Windows.Forms.TextBox();
            this.tbValorCompra = new System.Windows.Forms.TextBox();
            this.tbValorVenda = new System.Windows.Forms.TextBox();
            this.tbCodigoBarra = new System.Windows.Forms.TextBox();
            this.tbQtdEstoque = new System.Windows.Forms.TextBox();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSalvar = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(67, 105);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(225, 20);
            this.tbNome.TabIndex = 0;
            // 
            // tbDataVenc
            // 
            this.tbDataVenc.Location = new System.Drawing.Point(317, 105);
            this.tbDataVenc.Name = "tbDataVenc";
            this.tbDataVenc.Size = new System.Drawing.Size(243, 20);
            this.tbDataVenc.TabIndex = 1;
            // 
            // tbValorCompra
            // 
            this.tbValorCompra.Location = new System.Drawing.Point(68, 172);
            this.tbValorCompra.Name = "tbValorCompra";
            this.tbValorCompra.Size = new System.Drawing.Size(224, 20);
            this.tbValorCompra.TabIndex = 2;
            // 
            // tbValorVenda
            // 
            this.tbValorVenda.Location = new System.Drawing.Point(317, 172);
            this.tbValorVenda.Name = "tbValorVenda";
            this.tbValorVenda.Size = new System.Drawing.Size(243, 20);
            this.tbValorVenda.TabIndex = 3;
            // 
            // tbCodigoBarra
            // 
            this.tbCodigoBarra.Location = new System.Drawing.Point(68, 244);
            this.tbCodigoBarra.Name = "tbCodigoBarra";
            this.tbCodigoBarra.Size = new System.Drawing.Size(224, 20);
            this.tbCodigoBarra.TabIndex = 4;
            // 
            // tbQtdEstoque
            // 
            this.tbQtdEstoque.Location = new System.Drawing.Point(317, 244);
            this.tbQtdEstoque.Name = "tbQtdEstoque";
            this.tbQtdEstoque.Size = new System.Drawing.Size(243, 20);
            this.tbQtdEstoque.TabIndex = 5;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(68, 304);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(224, 21);
            this.cbFornecedor.TabIndex = 6;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(317, 304);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(243, 21);
            this.cbCategoria.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(65, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome do Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(314, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data de Vencimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(65, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Valor de Compra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(314, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Valor de Venda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(65, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Codigo de Barras:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(314, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Quantidade em Estoque:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(65, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fornecedor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(314, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Categoria:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Location = new System.Drawing.Point(388, 364);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = false;
            this.btnSalvar.Size = new System.Drawing.Size(157, 36);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Cadastrar Produto";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // CadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 415);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.tbQtdEstoque);
            this.Controls.Add(this.tbCodigoBarra);
            this.Controls.Add(this.tbValorVenda);
            this.Controls.Add(this.tbValorCompra);
            this.Controls.Add(this.tbDataVenc);
            this.Controls.Add(this.tbNome);
            this.Name = "CadastroProdutos";
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.CadastroProdutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbDataVenc;
        private System.Windows.Forms.TextBox tbValorCompra;
        private System.Windows.Forms.TextBox tbValorVenda;
        private System.Windows.Forms.TextBox tbCodigoBarra;
        private System.Windows.Forms.TextBox tbQtdEstoque;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialFlatButton btnSalvar;
    }
}