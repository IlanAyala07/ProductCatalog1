using Microsoft.EntityFrameworkCore;

namespace ProductCatalog.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Supplier> Suppliers => Set<Supplier>();
        public DbSet<Brand> Brands => Set<Brand>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // PRODUCT
            modelBuilder.Entity<Product>(e =>
            {
                e.HasKey(x => x.Id);
                e.Property(x => x.Name).IsRequired().HasMaxLength(200);
                e.Property(x => x.Description).HasMaxLength(2000);
                // Nota: SQLite ignora precisión decimal; EF valida en memoria
                e.Property(x => x.Price);
                e.Property(x => x.Image);
                e.Property(x => x.IsActive).HasDefaultValue(true);
                e.HasQueryFilter(x => x.IsActive); // Solo activos por defecto
            });

            // CATEGORY
            modelBuilder.Entity<Category>(e =>
            {
                e.HasKey(x => x.Id);
                e.Property(x => x.Name).IsRequired().HasMaxLength(200);
                e.Property(x => x.IsActive).HasDefaultValue(true);
                e.HasQueryFilter(x => x.IsActive);
            });

            // SUPPLIER
            modelBuilder.Entity<Supplier>(e =>
            {
                e.HasKey(x => x.Id);
                e.Property(x => x.Name).IsRequired().HasMaxLength(200);
                e.Property(x => x.Email).HasMaxLength(200);
                e.Property(x => x.Phone).HasMaxLength(13);
                e.Property(x => x.IsActive).HasDefaultValue(true);
                e.HasQueryFilter(x => x.IsActive);
            });

            // BRAND
            modelBuilder.Entity<Brand>(e =>
            {
                e.HasKey(x => x.Id);
                e.Property(x => x.Name).IsRequired().HasMaxLength(200);
                e.Property(x => x.IsActive).HasDefaultValue(true);
                e.HasQueryFilter(x => x.IsActive);
            });
        }
    }
}
