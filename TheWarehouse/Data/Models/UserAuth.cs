namespace TheWarehouse.Data.Models
{
    public class UserAuth
    {
        public int Id { get; set; }
        public string? AuthToken { get; set; }
        public DateTime Expiry { get; set; }
        public int UserId { get; set; }
    }
}
