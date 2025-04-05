using System.Net.Mail;

namespace Assessment10.Email
{
    internal class EmailService : IEmailService
    {
        string smtpServer = "smtp.office365.com";
        int smtpPort = 25;
        string from = "yoana.kalinova.intern@amdaris.com";
        string emailPassword = "";

        public void SendEmail(string to, string subject = "Thank you for subscribing!")
        {
            string body = string.Format("<html><body><h3>Hello {0},</h3><p>Thank you for subscribing to our newsletter! </p><p>Best regards,<br>Amdaris</p></body></html>", to);

            try
            {
                using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
                {
                    smtpClient.EnableSsl = true;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new System.Net.NetworkCredential(from, emailPassword);

                    using (MailMessage mailMessage = new MailMessage(from, to, subject, body.ToString()))
                    {
                        mailMessage.IsBodyHtml = true;
                        smtpClient.Send(mailMessage);
                    }
                }
            }
            catch (SmtpException ex)
            {
                Console.WriteLine($"SMTP Error: {ex.Message}");
            }
        }
    }
}
