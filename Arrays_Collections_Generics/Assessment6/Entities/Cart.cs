namespace Assessment6.Entities
{
    internal class Cart
    {
        public required int Id { get; set; }
        public required int CustomerId { get; set; }
        public List<CartItem> CartItems { get; set; } = new();
    }
}
