using Microsoft.EntityFrameworkCore;

namespace Excersise02
{
    class Northwind : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(
                @"Data Source=(localdb)\mssqllocaldb;" +
                "Initial Catalog=Northwind;" +
                "Integrated Security=true;" +
                "MultipleActiveResultSets=true;");
        }
    }
}
