namespace Assessment10.Email
{
    internal interface IEmailService
    {
        void SendEmail(string to, string subject = "Thank you for subscribing!");
    }
}
