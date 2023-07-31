using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace RefrigeratorApp.Model
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<ProductType> productTypes { get; set; }
        public DbSet<Products_log> products_log { get; set; }
    }
}
