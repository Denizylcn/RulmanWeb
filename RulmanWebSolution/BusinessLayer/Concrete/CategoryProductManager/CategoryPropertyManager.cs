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
	public class CategoryPropertyManager : ICategoryPropertyService
	{
		private readonly ICategoryPropertyDAL _categoryPropertyDAL;

		public CategoryPropertyManager(ICategoryPropertyDAL categoryPropertyDAL)
		{
			_categoryPropertyDAL = categoryPropertyDAL;
		}

		public CategoryProperty GetByID(int id)
		{
			return _categoryPropertyDAL.GetById(id);
		}

		public async Task<CategoryProperty> GetByIdAsync(int id)
		{
			return await _categoryPropertyDAL.GetByIdAsync(id);
		}

		public void TAdd(CategoryProperty t)
		{
			_categoryPropertyDAL.Insert(t);	
		}

		public void TDelete(CategoryProperty t)
		{
			_categoryPropertyDAL.Delete(t);	
		}

		public List<CategoryProperty> TGetList()
		{
			return _categoryPropertyDAL.GetAll();	
		}

		public void TUpdate(CategoryProperty t)
		{
			 _categoryPropertyDAL.Update(t);	
		}
	}
}
