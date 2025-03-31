namespace Assessment6.Entities
{
    internal class Customer
    {
        public required int Id { get; set; }
        public required string Name { get; set; } = string.Empty;
        public string? Address { get; set; }
        public string? Country { get; set; } 
        public string? Phone { get; set; }
        public required string Email { get; set; } = string.Empty;
    }
}
