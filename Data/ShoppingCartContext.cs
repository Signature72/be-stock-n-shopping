using stock_n_shopping.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace stock_n_shopping.Data
{
    public class ShoppingCartContext : DbContext
    {
        public ShoppingCartContext(DbContextOptions<ShoppingCartContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
