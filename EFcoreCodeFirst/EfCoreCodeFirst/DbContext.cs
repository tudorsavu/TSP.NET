using EfCoreCodeFirst.POCO;
using Microsoft.EntityFrameworkCore;
namespace EfCoreCodeFirst
{
    internal class ModelContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-SQL3P8T\SQLEXPRESS\\sql2012new; Database = EFCore2020; Trusted_Connection = True");
            //ChangeTracker.LazyLoadingEnabled = false;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany(o => o.Orders)
                .WithOne(c => c.Client);

        }
    }
}