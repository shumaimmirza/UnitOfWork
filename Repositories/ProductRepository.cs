using System;
using DotNetApi;
using UnitOfWorkDemo.Interfaces;
using UnitOfWorkDemo.Models;

namespace UnitOfWorkDemo.Repositories
{
    public class ProductRepository : GenericRepository<ProductDetails>, IProductRepository
    {
        public ProductRepository(DbContextClass dbContext) : base(dbContext)
        {

        }
    }
}