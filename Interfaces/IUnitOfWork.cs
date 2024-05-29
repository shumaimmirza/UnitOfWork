using System;
using UnitOfWorkDemo.Interfaces;

namespace UnitOfWorkDemo.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }

        Task<int> SaveAsync();
    }
}