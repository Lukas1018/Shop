
using System.Net;
using System.Net.Mail;

namespace ShopClassLibrary.Services
{
    public class SendEmailService
    {
        public string Email { get; set; }
        public void SendEmail(string emailText, string receiver)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("email@gmail.com", "password"),
                EnableSsl = true
            };
            
            smtpClient.Send("email@gmail.com", receiver, "receipt", emailText);
        }
    }
}
