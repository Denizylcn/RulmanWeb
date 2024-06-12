using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.CategoryProduct
{
	public class CategoryProperty
	{
        public int id { get; set; }
        public string propertyDescription { get; set; }
		public virtual Category categoryID { get; set; }
		public bool isActive { get; set; }
		public int ?ordering {  get; set; }	
	}
}
