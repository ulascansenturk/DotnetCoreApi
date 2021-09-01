using DotnetCoreWebApi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotnetCoreWebApi.Data.Concrete.EntityFramework.Mappings
{
    public class CustomerMap:IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.FirstName).HasMaxLength(200);
            builder.Property(c => c.FirstName).IsRequired();

            builder.Property(c => c.LastName).HasMaxLength(200);
            builder.Property(c => c.LastName).IsRequired();

            builder.Property(c => c.Gender).HasConversion<int>();
            builder.Property(c => c.Gender).IsRequired();

            builder.Property(c => c.Email).IsRequired(false);
            builder.Property(c => c.Email).HasMaxLength(100);
            


            builder.Property(c => c.Age).IsRequired(false);

            builder.Property(c => c.CreatedDate).IsRequired();

            builder.Property(c => c.ModifiedDate).IsRequired();


            builder.ToTable("Customers");

            
            
        }
    }
}