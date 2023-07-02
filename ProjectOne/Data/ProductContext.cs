using Microsoft.EntityFrameworkCore;
using ProjectOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Data
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options):base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Product> products { get; set; }
    }
}
