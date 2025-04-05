using Assessment10.Email;
using Assessment10.Facade;
using Assessment10.Loggers;

Console.WriteLine("Welcome to the application. If you want to subscribe to our newsletter...");
Console.Write("Enter your email: ");
string toEmail = Console.ReadLine();
var emailService = new EmailService();
var loggers = new List<ILogger> { new ConsoleLogger(), new FileLogger() };
var loggerFacade = new LogAndSendEmailFacade(loggers, emailService );

if (IsValid(toEmail))
{
    loggerFacade.LogAndSendEmail("User subscribed", toEmail, "Welcome to our newsletter!");
    Console.WriteLine($"Email sent to {toEmail} successfully!");
}
else
{
    Console.WriteLine("Invalid email");
}

bool IsValid(string? email)
{
    if (string.IsNullOrEmpty(email))
    {
        return false;
    }

    try
    {
        var address = new System.Net.Mail.MailAddress(email);
        return address.Address == email;
    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex.Message);
        return false;
    }
}
