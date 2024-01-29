using BookStore.Models.Enitity;
using BookStore.Models.EnitityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Context
{
    public class BookStoreDBContext : DbContext
    {
        public BookStoreDBContext(DbContextOptions<BookStoreDBContext> dbOptions) : base(dbOptions)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.ApplyConfiguration(new PersonEnitityConfiguration());
            modelBuilder.ApplyConfiguration(new ContentEnitityConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentEnitityConfiguration());
            modelBuilder.ApplyConfiguration(new SubscriptionEnitityConfiguration());
        }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Content> Contents { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
    }
}
