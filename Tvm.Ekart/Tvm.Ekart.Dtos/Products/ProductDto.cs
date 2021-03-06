using System.Collections.Generic;

namespace Tvm.Ekart.Dtos.Products
{
	public class ProductDto
    {

        public string ProductId { get; set; }

        public string ProductName { get; set; }

        public string SupplierName { get; set; }

        public string CategoryName { get; set; }

        public string QuantityPerUnit { get; set; }

        public decimal? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }

    }
}
