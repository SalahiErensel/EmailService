using System.Net.Mail;

namespace EmailService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            //From email will be entered here
            mail.From = new MailAddress("example@gmail.com");
            //To email will be entered here
            mail.To.Add("example@gmail.com");
            //Email subject
            mail.Subject = "Test";
            //Email body
            mail.Body = "Test";
            smtp.Port = 587;
            //Email from and password next to it will be entered here
            smtp.Credentials = new System.Net.NetworkCredential("example@gmail.com", "password");
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }
    }
}