using AspMvcCoreWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace AspMvcCoreWebApp
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }        
        

    }
}
