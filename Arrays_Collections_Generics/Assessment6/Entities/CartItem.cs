namespace Assessment6.Entities
{
    internal class CartItem
    {
        public required int Id { get; set; }
        public required int ProductId { get; set; }
        public required int Quantity { get; set; }
        public required int CartId { get; set; }
    }
}
