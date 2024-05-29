using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using UnitOfWorkDemo.Models;

namespace DotNetApi
{
    public class DbContextClass : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<ProductDetails> product { get; set; }

    }
}