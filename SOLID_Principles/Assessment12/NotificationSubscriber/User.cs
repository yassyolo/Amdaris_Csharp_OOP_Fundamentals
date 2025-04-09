using System.Security.Principal;

namespace Assessment12.NotificationSubscriber
{
    internal class User : INotificationSubscriber
    {
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{Name} received notification: {message}");
        }
    }
}
