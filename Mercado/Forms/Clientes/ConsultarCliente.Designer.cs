namespace Mercado.Forms.Clientes
{
    partial class ConsultarCliente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.País = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbCep = new System.Windows.Forms.TextBox();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDataNasc = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbDdd = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCpf = new System.Windows.Forms.TextBox();
            this.tbSobrenome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.btnEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnExcluir = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSalvar = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Sobrenome,
            this.CPF,
            this.Email,
            this.DDD,
            this.Telefone,
            this.DataNasc,
            this.Rua,
            this.Numero,
            this.Bairro,
            this.Cidade,
            this.Estado,
            this.País,
            this.CEP});
            this.dataGridView1.Location = new System.Drawing.Point(12, 406);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(805, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 30;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Sobrenome
            // 
            this.Sobrenome.HeaderText = "Sobrenome";
            this.Sobrenome.Name = "Sobrenome";
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // DDD
            // 
            this.DDD.HeaderText = "DDD";
            this.DDD.Name = "DDD";
            this.DDD.Width = 40;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            // 
            // DataNasc
            // 
            this.DataNasc.HeaderText = "Data de Nascimento";
            this.DataNasc.Name = "DataNasc";
            // 
            // Rua
            // 
            this.Rua.HeaderText = "Rua";
            this.Rua.Name = "Rua";
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Nº";
            this.Numero.Name = "Numero";
            // 
            // Bairro
            // 
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // País
            // 
            this.País.HeaderText = "País";
            this.País.Name = "País";
            // 
            // CEP
            // 
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(203, 311);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(127, 20);
            this.tbPais.TabIndex = 64;
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(480, 261);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(137, 20);
            this.tbCidade.TabIndex = 63;
            // 
            // tbCep
            // 
            this.tbCep.Location = new System.Drawing.Point(354, 311);
            this.tbCep.Name = "tbCep";
            this.tbCep.Size = new System.Drawing.Size(110, 20);
            this.tbCep.TabIndex = 62;
            // 
            // tbEstado
            // 
            this.tbEstado.Location = new System.Drawing.Point(30, 311);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(131, 20);
            this.tbEstado.TabIndex = 61;
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(327, 261);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(127, 20);
            this.tbBairro.TabIndex = 60;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(235, 261);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(53, 20);
            this.tbNumero.TabIndex = 59;
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(30, 261);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(173, 20);
            this.tbRua.TabIndex = 58;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(351, 295);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 57;
            this.label15.Text = "CEP:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(200, 295);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "País:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(32, 295);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 55;
            this.label13.Text = "Estado:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(477, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "Cidade:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(324, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Bairro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(32, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Rua:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Endereço";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(30, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 10);
            this.panel2.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(30, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 10);
            this.panel1.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Dados Pessoais";
            // 
            // tbDataNasc
            // 
            this.tbDataNasc.Location = new System.Drawing.Point(480, 167);
            this.tbDataNasc.Name = "tbDataNasc";
            this.tbDataNasc.Size = new System.Drawing.Size(117, 20);
            this.tbDataNasc.TabIndex = 47;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(350, 168);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(100, 20);
            this.tbTelefone.TabIndex = 46;
            // 
            // tbDdd
            // 
            this.tbDdd.Location = new System.Drawing.Point(263, 168);
            this.tbDdd.Name = "tbDdd";
            this.tbDdd.Size = new System.Drawing.Size(59, 20);
            this.tbDdd.TabIndex = 45;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(40, 167);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(211, 20);
            this.tbEmail.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(232, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Nº:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(477, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Data de Nascimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(347, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(263, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "DDD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(37, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "E-Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(430, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "CPF:";
            // 
            // tbCpf
            // 
            this.tbCpf.Location = new System.Drawing.Point(433, 128);
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(164, 20);
            this.tbCpf.TabIndex = 37;
            // 
            // tbSobrenome
            // 
            this.tbSobrenome.Location = new System.Drawing.Point(299, 127);
            this.tbSobrenome.Name = "tbSobrenome";
            this.tbSobrenome.Size = new System.Drawing.Size(100, 20);
            this.tbSobrenome.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(296, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Sobrenome:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Location = new System.Drawing.Point(174, 109);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 34;
            this.lblNome.Text = "Nome:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(173, 128);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(100, 20);
            this.tbNome.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(35, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 65;
            this.label16.Text = "Id:";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(35, 126);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(110, 20);
            this.tbId.TabIndex = 66;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Depth = 0;
            this.btnEdit.Location = new System.Drawing.Point(30, 351);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Primary = false;
            this.btnEdit.Size = new System.Drawing.Size(132, 36);
            this.btnEdit.TabIndex = 67;
            this.btnEdit.Text = "Habilitar Edição";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcluir.Depth = 0;
            this.btnExcluir.Location = new System.Drawing.Point(337, 351);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Primary = false;
            this.btnExcluir.Size = new System.Drawing.Size(123, 36);
            this.btnExcluir.TabIndex = 68;
            this.btnExcluir.Text = "Excluir Cliente";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Location = new System.Drawing.Point(625, 351);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = false;
            this.btnSalvar.Size = new System.Drawing.Size(152, 36);
            this.btnSalvar.TabIndex = 69;
            this.btnSalvar.Text = "Salvar Alterações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 666);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbPais);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.tbCep);
            this.Controls.Add(this.tbEstado);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.tbRua);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbDataNasc);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.tbDdd);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCpf);
            this.Controls.Add(this.tbSobrenome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultarCliente";
            this.Text = "ConsultarCliente";
            this.Load += new System.EventHandler(this.ConsultarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbCep;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDataNasc;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbDdd;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCpf;
        private System.Windows.Forms.TextBox tbSobrenome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbId;
        private MaterialSkin.Controls.MaterialFlatButton btnEdit;
        private MaterialSkin.Controls.MaterialFlatButton btnExcluir;
        private MaterialSkin.Controls.MaterialFlatButton btnSalvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn País;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
    }
}