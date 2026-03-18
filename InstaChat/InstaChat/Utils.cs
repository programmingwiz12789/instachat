using System.Text;
using System.Net;
using System.Net.Mail;

namespace InstaChat
{
    internal class Utils
    {
        public static string hashPassword(string password)
        {
            byte[] bytes = Encoding.UTF32.GetBytes(password);
            string hashedPassword = Convert.ToBase64String(bytes);
            return hashedPassword;
        }

        public static void sendMessage(string email, string subject, string body)
        {
            var fromAddress = new MailAddress("allisprogramming12789@gmail.com", "InstaChat");
            var toAddress = new MailAddress(email, email);
            const string fromPassword = "rzhn laap wxau besc";
            var smtp = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
