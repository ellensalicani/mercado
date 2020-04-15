namespace Mercado.Forms
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.pwd = new System.Windows.Forms.Label();
            this.btnSubmit = new MaterialSkin.Controls.MaterialFlatButton();
            this.toolTipUsername = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPwd = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(311, 244);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(217, 20);
            this.tbUsername.TabIndex = 2;
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(311, 299);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.PasswordChar = '*';
            this.tbPwd.Size = new System.Drawing.Size(217, 20);
            this.tbPwd.TabIndex = 3;
            this.toolTipPwd.SetToolTip(this.tbPwd, "Deve conter até 6 digitos");
            this.toolTipUsername.SetToolTip(this.tbPwd, "Deve conter até 6 digitos");
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.DarkGray;
            this.username.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.Location = new System.Drawing.Point(308, 228);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(54, 13);
            this.username.TabIndex = 4;
            this.username.Text = "Usuário:";
            // 
            // pwd
            // 
            this.pwd.AutoSize = true;
            this.pwd.BackColor = System.Drawing.Color.DarkGray;
            this.pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd.ForeColor = System.Drawing.Color.Black;
            this.pwd.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.pwd.Location = new System.Drawing.Point(308, 283);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(47, 13);
            this.pwd.TabIndex = 5;
            this.pwd.Text = "Senha:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.Depth = 0;
            this.btnSubmit.Location = new System.Drawing.Point(385, 337);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Primary = false;
            this.btnSubmit.Size = new System.Drawing.Size(64, 36);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Entrar";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // toolTipUsername
            // 
            this.toolTipUsername.IsBalloon = true;
            this.toolTipUsername.ToolTipTitle = "Deve conter até 6 digitos";
            this.toolTipUsername.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // toolTipPwd
            // 
            this.toolTipPwd.IsBalloon = true;
            this.toolTipPwd.ToolTipTitle = "Deve conter até 6 digitos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mercado.Properties.Resources.market;
            this.pictureBox1.Location = new System.Drawing.Point(0, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 482);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 515);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.username);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label pwd;
        private MaterialSkin.Controls.MaterialFlatButton btnSubmit;
        private System.Windows.Forms.ToolTip toolTipUsername;
        private System.Windows.Forms.ToolTip toolTipPwd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}