namespace Assessment9.Entities
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string UniqueCode { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"{Name}/{UniqueCode} - ${Price}";
        }
    }
}
