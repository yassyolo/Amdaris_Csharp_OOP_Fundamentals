namespace Assessment15.Entities;

public class OrderItem
{
    public OrderItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }
    public Product Product { get; }
    public int Quantity { get; }
    public decimal TotalPrice => Product.Price * Quantity;
}
