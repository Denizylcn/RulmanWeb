using BusinessLayer.Abstract.CategoryProductService;
using DataAccesLayer.Abstract.CategoryProductAbstract;
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
		private readonly ICategoryDAL _categoryDAL;

		public CategoryManager(ICategoryDAL categoryDAL)
		{
			_categoryDAL = categoryDAL;
		}

		public Category GetByID(int id)
		{
			return _categoryDAL.GetById(id);	
		}

		public async Task<Category> GetByIdAsync(int id)
		{
			return await _categoryDAL.GetByIdAsync(id);
		}

		public void TAdd(Category t)
		{
			_categoryDAL.Insert(t);	
		}

		public void TDelete(Category t)
		{
			_categoryDAL?.Delete(t);	
		}

		public List<Category> TGetList()
		{
			return _categoryDAL.GetAll();	
		}

		public void TUpdate(Category t)
		{
			_categoryDAL.Update(t);	
		}
	}
}
