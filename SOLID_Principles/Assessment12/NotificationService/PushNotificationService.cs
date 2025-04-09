namespace Assessment12.NotificationService
{
    internal class PushNotificationService : INotificationService
    { 
        public void SendNotification(string to, string message)
        {
            Console.WriteLine($"{to} received push notification: {message}");
        }
    }
}
