using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Products
{
	public class ProductImage
	{
		[Key]
		public int Id { get; set; }	
		public string ?Name { get; set; }
		
		public Product Product { get; set; }
		public int? ordering { get; set; }
		public bool isActive { get; set; }
	}
}
