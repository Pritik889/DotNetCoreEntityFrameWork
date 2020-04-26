using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleDemo.Contract.Model.Repository;

namespace SampleDemo.Repository.Data
{
    public partial class DataContext
    {

        public virtual DbSet<ProductDto> Products { get; set; }

        public void ConfigureProduct(EntityTypeBuilder<ProductDto> entity)
        {
            entity.ToTable("Product", "dbo");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).HasColumnName("Name");
            entity.Property(e => e.ShortDescription).HasColumnName("ShortDescription");
            entity.Property(e => e.FullDescription).HasColumnName("FullDescription");
            entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeId");
            entity.Property(e => e.Price).HasColumnName("Price");
        }


    }
}
