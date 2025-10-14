namespace ProductCatalog.Models
{
    public class Brand
    {
        public int Id { get; set; }                              // PK int
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;               // Soft delete
    }
}
