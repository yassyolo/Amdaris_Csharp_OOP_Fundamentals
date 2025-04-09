using Assessment12.NotificationSubscriber;

namespace Assessment12.NotificationManager
{
    internal interface INotificationManager
    {
        void Subscribe(INotificationSubscriber subscriber);
        void Unsubscribe(INotificationSubscriber subscriber);
        void Notify(string message);
    }
}
