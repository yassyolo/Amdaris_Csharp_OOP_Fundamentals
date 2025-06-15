using Assessment15.Observer;

namespace Assessment15.Entities;

public class Staff : IObserver
{
    public string Name { get; }

    public Staff(string name)
    {
        Name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"[Staff: {Name}] -> {message}");
    }
}
