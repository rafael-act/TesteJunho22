using RevendaVeiculos.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace RevendaVeiculos.Services.Email
{
    public class Email
    {
        public static void EnviarEmail(Veiculo veiculo)
        {
            string htmlString = "<h3>Sistema de Revenda</h3>";
            htmlString += $"<p>Olá Sr(a) {veiculo.Proprietario.Nome}</p>";
            htmlString += $"<p>Veiculo {veiculo.Modelo} cadastrado com sucesso!</p>";
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("sistema@revenda.com.br");
                message.To.Add(new MailAddress(veiculo.Proprietario.Email));
                message.Subject = "Cadastro de Veículo";
                message.IsBodyHtml = true; 
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; 
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("sistema@revenda.com.br", "password");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception) { }
        }
    }
}
