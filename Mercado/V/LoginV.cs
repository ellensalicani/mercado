using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado.V
{
    class LoginV
    {
        private String username;
        private String senha;

        private DAO.LoginDAO ldao;

        public String Username { get => username; set => username = value; }
        public String Senha { get => senha; set => senha = value; }

        public bool ValidarLogin()
        {
            ldao = new DAO.LoginDAO();
            return ldao.ValidarLogin(username, senha);
        }
    }
}
