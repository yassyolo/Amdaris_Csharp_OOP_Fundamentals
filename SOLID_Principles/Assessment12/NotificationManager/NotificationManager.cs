using Assessment12.NotificationSubscriber;

namespace Assessment12.NotificationManager
{
    internal class NotificationManager : INotificationManager
    {
        private readonly List<INotificationSubscriber> _subscribers = new List<INotificationSubscriber>();

        public void Subscribe(INotificationSubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(INotificationSubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void Notify(string message)
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(message);
            }
        }
    }
}
