namespace Assessment12.NotificationService
{
    internal class EmailNotificationService : INotificationService
    {
        public void SendNotification(string to, string message)
        {
            Console.WriteLine($"{to} received email: {message}");
        }
    }
}
