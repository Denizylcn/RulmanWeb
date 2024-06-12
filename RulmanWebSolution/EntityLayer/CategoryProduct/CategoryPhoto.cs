using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.CategoryProduct
{
	public class CategoryPhoto
	{
        public int id { get; set; }
		public string name { get; set; }
		public string photoUrl { get; set; }
		public virtual Category categoryId { get; set; }
		public int? ordering { get; set; }
		public bool isActive { get; set; }
	}
}
