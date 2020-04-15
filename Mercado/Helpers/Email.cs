using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Firma.Helpers
{
    public class Email
    {
        public static void EnviarEmail(string user, string senha, string email)
        {
            MailMessage mail = new MailMessage("ec.salicani8@gmail.com", email);
            mail.From = new MailAddress("ec.salicani8@gmail.com");
            mail.To.Add(email);
            mail.Subject = "Cadastro realizado com sucesso!";
            mail.Body = "Seu cadastro no mercado Caelia foi criado com sucesso. Seu usuario e senha para login são: \n\n" +
                " user: " + user +
                "\n" +
                "senha: " + senha + "\n\n" +
                "Aproveite nossas promoções. Só passar o CPF na próxima compra para usufrui-las. Seja bem-vindo!!";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Send(mail);
        }
    }
}
