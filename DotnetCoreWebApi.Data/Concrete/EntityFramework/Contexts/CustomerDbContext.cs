using System.Threading.Tasks;
using DotnetCoreWebApi.Data.Concrete.EntityFramework.Mappings;
using DotnetCoreWebApi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;

namespace DotnetCoreWebApi.Data.Concrete.EntityFramework.Contexts
{
    public class CustomerDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        { 
            optionsBuilder.UseSqlServer(connectionString: "Server=localhost;Database=CustomersApp;User Id=sa;Password=Strong??Password123;");
            
        }


        public DbSet<Customer> Customers{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMap());
        }
    }
}