using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado.Forms
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {

        private V.LoginV loginV;
        private DAO.LoginDAO loginDAO;
        private Conexao.Connection conexao;

        public Login()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
            tbUsername.Clear();
            tbPwd.Clear();
        }

        public bool ValidarLogin(String username, String senha)
        {
            MySqlConnection con = new MySqlConnection();
            loginV = new V.LoginV();
            conexao = new Conexao.Connection();
            con.ConnectionString = conexao.getConnectionString();
            con.Open();

            string query = "SELECT * from funcionarios WHERE username = ?username and senha = ?senha";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("?username", username);
                cmd.Parameters.AddWithValue("?senha", senha);

                MySqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao tentar logar. Verifique suas informações e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparCampos();
                return false;
            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            V.LoginV loginv = new V.LoginV();

            loginv.Username = tbUsername.Text;
            loginv.Senha = tbPwd.Text;

            if (loginv.ValidarLogin())
            {
                this.Hide();
                Menu menu = new Menu();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos. Tente novamente.", "Falha ao logar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
