using System.Data.Entity;

namespace WebStoreTraining.Models
{
    public class ShoppingStoreEntities:DbContext
    {
        public DbSet<Items> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}