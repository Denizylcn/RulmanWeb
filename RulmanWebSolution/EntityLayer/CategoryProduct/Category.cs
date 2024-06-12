using EntityLayer.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.CategoryProduct
{
	public class Category
	{
        public int id { get; set; }
		public string name { get; set; }
		public string ?title { get; set; }
		public string ?subtitle { get; set; }
		public string description { get; set; }
		public string ?description2 { get; set; }
		public string mainPhotoUrl { get; set; }
		public virtual ICollection<Product> Product { get; set; }	
		public virtual ICollection<CategoryCatalog> CategoryCatalog { get; set; }
		public virtual ICollection<CategoryPhoto> categoCategoryPhotoryPhotoId { get; set; }
		public virtual ICollection<CategoryProperty> categCategoryPropertyoryPropertyId { get; set; }
		public int? ordering { get; set; }
		public bool isActive { get; set; }
	}
}
