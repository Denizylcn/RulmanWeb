using BusinessLayer.Abstract.CategoryProductService;
using EntityLayer.CategoryProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.CategoryProductManager
{
	public class CategoryCatalogManager : ICategoryCatalogService
	{
		public CategoryCatalog GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public Task<CategoryCatalog> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public void TAdd(CategoryCatalog t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(CategoryCatalog t)
		{
			throw new NotImplementedException();
		}

		public List<CategoryCatalog> TGetList()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(CategoryCatalog t)
		{
			throw new NotImplementedException();
		}
	}
}
