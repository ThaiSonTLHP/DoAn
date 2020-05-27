using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace BatDongSanService.Methods
{
    public static class Mail
    {
        public static void SendMail(string toMail, string subject, string body)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.UseDefaultCredentials = true;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("thaison88981@gmail.com", "Son8898a@B");

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("thaison88981@gmail.com");
            mailMessage.To.Add(toMail);
            mailMessage.Body = body;
            mailMessage.Subject = subject;

            client.Send(mailMessage);
        }
    }
}
