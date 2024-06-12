using BusinessLayer.Abstract.CategoryProductService;
using EntityLayer.CategoryProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.CategoryProductManager
{
	public class CategoryPhotoManager : ICategoryPhotoService
	{
		public CategoryPhoto GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public Task<CategoryPhoto> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public void TAdd(CategoryPhoto t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(CategoryPhoto t)
		{
			throw new NotImplementedException();
		}

		public List<CategoryPhoto> TGetList()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(CategoryPhoto t)
		{
			throw new NotImplementedException();
		}
	}
}
