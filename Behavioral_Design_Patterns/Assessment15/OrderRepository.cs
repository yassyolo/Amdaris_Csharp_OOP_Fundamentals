using Assessment15.Entities;

namespace Assessment15;

public class OrderRepository
{
    private static readonly List<Order> _orders = new();
    private static int _nextId = 1;

    public (int orderId, string orderNumber) Save(Order order)
    {
        var id = _nextId++;
        var number = $"ORD-{id:0000}";
        return (id, number);
    }
}
