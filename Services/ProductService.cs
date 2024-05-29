using System;
using AutoMapper;
using UnitOfWorkDemo.DTOS;
using UnitOfWorkDemo.Interfaces;
using UnitOfWorkDemo.Models;

namespace UnitOfWorkDemo.Services
{
    public class ProductService : IProductService
    {
        public IUnitOfWork _unitOfWork;
        public IProductRepository _productRepository;

        public ProductService(IUnitOfWork unitOfWork, IProductRepository productRepository)
        {
            _unitOfWork = unitOfWork;
            _productRepository = productRepository;
        }

        public async Task<bool> CreateProduct(ProductDetails productDetails)
        {
            await _productRepository.Add(productDetails);
            var result = await _unitOfWork.SaveAsync();

            if (result > 0)
               return true;
            else
               return false;
        }

        public async Task<bool> UpdateProduct(ProductDetails productDetails)
        {
                var product = await _productRepository.GetById(productDetails.Id);
                if (product != null)
                {
                    product.ProductName = productDetails.ProductName;
                    product.ProductDescription = productDetails.ProductDescription;
                    product.ProductPrice = productDetails.ProductPrice;
                    product.ProductStock = productDetails.ProductStock;

                    _productRepository.Update(product);

                    var result = await _unitOfWork.SaveAsync();

                    if (result > 0)
                        return true;
                    else
                        return false;
                } else {
                    return false;
                }

        }

        public async Task<bool> DeleteProduct(int productId)
        {
            if (productId > 0)
            {
                var productDetails = await _productRepository.GetById(productId);
                if (productDetails != null)
                {
                    _productRepository.Delete(productDetails);
                    var result = await _unitOfWork.SaveAsync();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public async Task<IEnumerable<ProductDetails>> GetAllProducts()
        {
            var productDetailsList = await _productRepository.GetAll();
            return productDetailsList;
        }

        public async Task<ProductDetails> GetProductById(int productId)
        {
            if (productId > 0)
            {
                var productDetails = await _productRepository.GetById(productId);
                if (productDetails != null)
                {
                    return productDetails;
                }
            }
            return null;
        }

        
    }
}