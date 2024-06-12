using BusinessLayer.Abstract.CategoryProductService;
using EntityLayer.CategoryProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.CategoryProductManager
{
	public class CategoryManager : ICategoryService
	{
		public Category GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public Task<Category> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public void TAdd(Category t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Category t)
		{
			throw new NotImplementedException();
		}

		public List<Category> TGetList()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Category t)
		{
			throw new NotImplementedException();
		}
	}
}
