using Assessment15.Observer;

namespace Assessment15.Entities
{
    public class Order : IOrderNotifier
    {
        private readonly List<IObserver> _observers = new();
        private readonly List<OrderItem> _items = new();

        public int Id { get; private set; }
        public string OrderNumber { get; private set; } = string.Empty;
        public string Status { get; private set; }

        public void Subscribe(IObserver observer) => _observers.Add(observer);
        public void Unsubscribe(IObserver observer) => _observers.Remove(observer);

        public void Notify(string message)
        {
            foreach (var observer in _observers)
                observer.Update(message);
        }

        public void AddItem(Product product, int quantity)
        {
            _items.Add(new OrderItem(product, quantity));
        }

        public void PlaceOrder(OrderRepository repo)
        {
            (Id, OrderNumber) = repo.Save(this);
            Notify($"Order placed successfully! Order Number: {OrderNumber}");
            UpdateStatus("Created");
        }

        public void UpdateStatus(string newStatus)
        {
            Status = newStatus;
            Notify($"Order {OrderNumber} status changed to: {Status}");
        }

        public decimal TotalAmount()
        {
            decimal total = 0;
            foreach (var item in _items)
                total += item.TotalPrice;
            return total;
        }
    }

}
