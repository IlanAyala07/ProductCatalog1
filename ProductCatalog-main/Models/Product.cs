using System;

namespace ProductCatalog.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // PK GUID
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }                 // *
        public decimal Price { get; set; }                       // 2 decimales (SQLite lo almacena como NUMERIC)
        public byte[]? Image { get; set; }                       // Solo BD/modelo; no UI
        public bool IsActive { get; set; } = true;               // Soft delete
    }
}
