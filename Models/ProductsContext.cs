using Microsoft.EntityFrameworkCore;

namespace Finals.Models
{
    public class ProductsContext : DbContext
	{
		public ProductsContext (DbContextOptions<ProductsContext> options)
			: base(options)
		{
		}
		public DbSet<Product> Product {get; set;}
        public DbSet<Review> Review {get; set;}
	}
}