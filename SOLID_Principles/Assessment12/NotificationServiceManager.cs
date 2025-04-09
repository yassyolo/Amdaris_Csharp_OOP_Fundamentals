
using Assessment12.NotificationManager;
using Assessment12.NotificationService;

namespace Assessment12
{
    internal class NotificationServiceManager
    {
        private readonly INotificationManager _notificationManager;
        private readonly List<INotificationService> _notificationServices = new();

        public NotificationServiceManager(INotificationManager notificationManager)
        {
            _notificationManager = notificationManager;
        }

        public void RegisterService(INotificationService service)
        {
            _notificationServices.Add(service);
        }

        public void SendNotification(string to, string message)
        {

            foreach (var service in _notificationServices)
            {
                service.SendNotification(to, message);
            }

            _notificationManager.Notify(message);
        }
    }
}
