using Microsoft.EntityFrameworkCore;

namespace CSGenerics.Data
{
    public class StorageAppDbContext : DbContext
    {
        // public DbSet<>

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageAppDb");
        }
    }
}