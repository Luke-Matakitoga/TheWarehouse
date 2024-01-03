namespace TheWarehouse.Data.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? City { get; set; }
        public string? Postcode { get; set; }

        public List<Product>? Products { get; set; } = new();
    }
}
