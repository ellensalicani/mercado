namespace Mercado.Forms.Produtos
{
    partial class ConsultarProduto
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.tbQtdEstoque = new System.Windows.Forms.TextBox();
            this.tbCodigoBarra = new System.Windows.Forms.TextBox();
            this.tbValorVenda = new System.Windows.Forms.TextBox();
            this.tbValorCompra = new System.Windows.Forms.TextBox();
            this.tbDataVenc = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.btnSalvar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnExcluir = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(419, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Categoria:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(170, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Fornecedor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(31, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Quantidade em Estoque:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(450, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Codigo de Barras:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(248, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Valor de Venda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(29, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Valor de Compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(364, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Data de Vencimento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(115, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nome do Produto:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(422, 178);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(243, 21);
            this.cbCategoria.TabIndex = 23;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(173, 178);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(224, 21);
            this.cbFornecedor.TabIndex = 22;
            // 
            // tbQtdEstoque
            // 
            this.tbQtdEstoque.Location = new System.Drawing.Point(34, 178);
            this.tbQtdEstoque.Name = "tbQtdEstoque";
            this.tbQtdEstoque.Size = new System.Drawing.Size(121, 20);
            this.tbQtdEstoque.TabIndex = 21;
            // 
            // tbCodigoBarra
            // 
            this.tbCodigoBarra.Location = new System.Drawing.Point(453, 134);
            this.tbCodigoBarra.Name = "tbCodigoBarra";
            this.tbCodigoBarra.Size = new System.Drawing.Size(197, 20);
            this.tbCodigoBarra.TabIndex = 20;
            // 
            // tbValorVenda
            // 
            this.tbValorVenda.Location = new System.Drawing.Point(251, 134);
            this.tbValorVenda.Name = "tbValorVenda";
            this.tbValorVenda.Size = new System.Drawing.Size(176, 20);
            this.tbValorVenda.TabIndex = 19;
            // 
            // tbValorCompra
            // 
            this.tbValorCompra.Location = new System.Drawing.Point(32, 134);
            this.tbValorCompra.Name = "tbValorCompra";
            this.tbValorCompra.Size = new System.Drawing.Size(191, 20);
            this.tbValorCompra.TabIndex = 18;
            // 
            // tbDataVenc
            // 
            this.tbDataVenc.Location = new System.Drawing.Point(367, 90);
            this.tbDataVenc.Name = "tbDataVenc";
            this.tbDataVenc.Size = new System.Drawing.Size(243, 20);
            this.tbDataVenc.TabIndex = 17;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(117, 90);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(225, 20);
            this.tbNome.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(32, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Id:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(36, 90);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(67, 20);
            this.tbId.TabIndex = 33;
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Location = new System.Drawing.Point(595, 243);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = false;
            this.btnSalvar.Size = new System.Drawing.Size(152, 36);
            this.btnSalvar.TabIndex = 111;
            this.btnSalvar.Text = "Salvar Alterações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcluir.Depth = 0;
            this.btnExcluir.Location = new System.Drawing.Point(301, 243);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Primary = false;
            this.btnExcluir.Size = new System.Drawing.Size(159, 36);
            this.btnExcluir.TabIndex = 110;
            this.btnExcluir.Text = "Excluir Funcionário";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Depth = 0;
            this.btnEdit.Location = new System.Drawing.Point(34, 243);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Primary = false;
            this.btnEdit.Size = new System.Drawing.Size(132, 36);
            this.btnEdit.TabIndex = 109;
            this.btnEdit.Text = "Habilitar Edição";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NomeProduto,
            this.DataVenc,
            this.ValorCompra,
            this.ValorVenda,
            this.CodigoBarras,
            this.qtdEstoque,
            this.Fornecedor,
            this.Categoria});
            this.dataGridView1.Location = new System.Drawing.Point(12, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(814, 248);
            this.dataGridView1.TabIndex = 108;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 30;
            // 
            // NomeProduto
            // 
            this.NomeProduto.HeaderText = "Nome Produto";
            this.NomeProduto.Name = "NomeProduto";
            // 
            // DataVenc
            // 
            this.DataVenc.HeaderText = "Data Vencimento";
            this.DataVenc.Name = "DataVenc";
            // 
            // ValorCompra
            // 
            this.ValorCompra.HeaderText = "Valor Compra";
            this.ValorCompra.Name = "ValorCompra";
            this.ValorCompra.Width = 90;
            // 
            // ValorVenda
            // 
            this.ValorVenda.HeaderText = "Valor Venda";
            this.ValorVenda.Name = "ValorVenda";
            this.ValorVenda.Width = 90;
            // 
            // CodigoBarras
            // 
            this.CodigoBarras.HeaderText = "Codigo de Barras";
            this.CodigoBarras.Name = "CodigoBarras";
            // 
            // qtdEstoque
            // 
            this.qtdEstoque.HeaderText = "Qtd Estoque";
            this.qtdEstoque.Name = "qtdEstoque";
            this.qtdEstoque.Width = 50;
            // 
            // Fornecedor
            // 
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // ConsultarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 566);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label9);
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
            this.Name = "ConsultarProduto";
            this.Text = "Consultar Produto";
            this.Load += new System.EventHandler(this.ConsultarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.TextBox tbQtdEstoque;
        private System.Windows.Forms.TextBox tbCodigoBarra;
        private System.Windows.Forms.TextBox tbValorVenda;
        private System.Windows.Forms.TextBox tbValorCompra;
        private System.Windows.Forms.TextBox tbDataVenc;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbId;
        private MaterialSkin.Controls.MaterialFlatButton btnSalvar;
        private MaterialSkin.Controls.MaterialFlatButton btnExcluir;
        private MaterialSkin.Controls.MaterialFlatButton btnEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataVenc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    }
}