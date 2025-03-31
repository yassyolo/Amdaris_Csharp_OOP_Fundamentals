namespace Assessment6.Entities
{
    internal class Product
    {
        public required int Id { get; set; }
        public required string Name { get; set; } = string.Empty;
        public required string UniqueCode { get; set; } = string.Empty;
        public required decimal Price { get; set; }
        public required int Quantity { get; set; }
    }
}
