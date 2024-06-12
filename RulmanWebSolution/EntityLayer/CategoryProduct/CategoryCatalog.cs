using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.CategoryProduct
{
	public class CategoryCatalog
	{
        public int categoryCatalogID { get; set; }
        public string ?titleCatalog { get; set; }


		public string ?descriptionCatalog { get; set; }
		public string ?catalogCoverImgUrl { get; set; }
        public string catalogPathUrl { get; set; }
        public DateTime Date { get; set; }
        public virtual Category categoryID { get; set; }
		public int? ordering { get; set; }
		public bool isActive { get; set; }

	}
}
