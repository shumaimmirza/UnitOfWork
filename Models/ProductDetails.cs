using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnitOfWorkDemo.Models
{
    public class ProductDetails
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}