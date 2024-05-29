using System;
using UnitOfWorkDemo.Interfaces;
using UnitOfWorkDemo.Models;

namespace UnitOfWorkDemo.Interfaces
{
    public interface IProductRepository : IGenericRepository<ProductDetails>
    {
    }
}