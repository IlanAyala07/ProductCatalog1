namespace ProductCatalog.Models
{
    public class Supplier
    {
        public int Id { get; set; }                              // PK int
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;        // max length 13
        public bool IsActive { get; set; } = true;               // Soft delete
    }
}
