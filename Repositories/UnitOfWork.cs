using System;
using DotNetApi;
using UnitOfWorkDemo.Interfaces;

namespace UnitOfWorkDemo.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContextClass _dbContext;
        public IProductRepository Products { get; }

        public UnitOfWork(DbContextClass dbContext,
                            IProductRepository productRepository)
        {
            _dbContext = dbContext;
            Products = productRepository;
        }

        public async Task<int> SaveAsync()
        {
            var x = await _dbContext.SaveChangesAsync();
            return x;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }

    }
}