using Assessment15;
using Assessment15.Entities;

class Program
{
    static void Main()
    {
        var customer = new Customer("Mariela", "Email");
        var staff = new Staff("Shein worker");

        var item1 = new Product("Pink dress", 19.99m);
        var item2 = new Product("Orange dress", 29.99m);

        var order = new Order();
        order.Subscribe(customer);
        order.Subscribe(staff);

        order.AddItem(item1, 1);
        order.AddItem(item2, 2);

        var repo = new OrderRepository();
        order.PlaceOrder(repo);

        Console.WriteLine($"Total: ${order.TotalAmount():F2}");

        order.UpdateStatus("Packed");
        order.UpdateStatus("Shipped from China");
    }
}
