
namespace Shop.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using Shop.Web.Data.Entities;

    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    public class DataContext : DbContext
    {
        public DbSet <Product> Products { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { 

        }
        
    }
}
