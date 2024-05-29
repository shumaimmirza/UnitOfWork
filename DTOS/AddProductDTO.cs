using System;
namespace UnitOfWorkDemo.DTOS
{
	public class AddProductDTO
	{
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductPrice { get; set; }
        public int ProductStock { get; set; }
    }
}

