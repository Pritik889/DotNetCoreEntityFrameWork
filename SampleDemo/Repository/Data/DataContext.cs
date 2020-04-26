using Microsoft.EntityFrameworkCore;
using SampleDemo.Contract.Model.Repository;

namespace SampleDemo.Repository.Data
{
    public partial class DataContext: DbContext
    {
        public DataContext()
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=CBLLAP0061\SQLEXPRESS;database=dbfortesting;trusted_connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductDto>(ConfigureProduct);
        }
    }
}
