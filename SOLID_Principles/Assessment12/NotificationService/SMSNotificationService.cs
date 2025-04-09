namespace Assessment12.NotificationService
{
    internal class SMSNotificationService : INotificationService
    {
        public void SendNotification(string to, string message)
        {
            Console.WriteLine($"{to} received SMS: {message}");
        }
    }
}
