using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Products
{
	public class Product
	{
		public int Id { get; set; }
		public string productName { get; set; }
		public string productDescription { get; set; }
		public string ?productDescription2 { get; set; }

		public string ?productMainImgUrl { get; set; }

		public virtual CategoryProduct.Category Category { get; set; }
		public virtual ICollection<ProductImage> ProductImage { get; set; }
		public double ?productPrice { get; set; }
		public DateTime priceDate { get; set; }
    
        public int? ordering { get; set; }
		public bool isActive { get; set; }

	}
}
