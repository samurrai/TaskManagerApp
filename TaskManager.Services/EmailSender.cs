using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Services
{
    public class EmailSender
    {

        public void SendMail(string fromMail, string password, string fromName, string toMail, string theme, string text)
        {
            try
            {
                MailAddress from = new MailAddress(fromMail, fromName);
                MailAddress to = new MailAddress(toMail);

                MailMessage mail = new MailMessage(from, to);
                mail.Subject = theme;
                mail.Body = text;

                string smtpHost;
                if (fromMail.Contains("gmail.com"))
                {
                    smtpHost = "smtp.gmail.com";
                }
                else if (fromMail.Contains("mail.ru")) 
                {
                    smtpHost = "smtp.mail.ru";
                }
                else
                {
                    throw new Exception();
                }
                SmtpClient smtp = new SmtpClient(smtpHost, 587);
                smtp.Credentials = new NetworkCredential(fromMail, password);
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
