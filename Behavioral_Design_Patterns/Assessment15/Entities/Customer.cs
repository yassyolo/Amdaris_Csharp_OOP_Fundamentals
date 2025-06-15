using Assessment15.Observer;

namespace Assessment15.Entities;

public class Customer : IObserver
{
    public string UserName { get; }
    public string ContactMethod { get; }

    public Customer(string userName, string contactMethod)
    {
        UserName = userName;
        ContactMethod = contactMethod;
    }

    public void Update(string message)
    {
        Console.WriteLine($"[Customer: {UserName} received notification via {ContactMethod}] -> {message}");
    }
}
