using System;

namespace UnitOfWorkDemo.Models
{
	public class Category
	{
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<ProductDetails> Products { get; }
    }
}

