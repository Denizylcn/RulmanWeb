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
	public class CategoryCatalogManager : ICategoryCatalogService
	{
		private readonly ICategoryCatalogDAL _categoryCatalogDAL;

		public CategoryCatalogManager(ICategoryCatalogDAL categoryCatalogDAL)
		{
			_categoryCatalogDAL = categoryCatalogDAL;
		}

		public CategoryCatalog GetByID(int id)
		{
			return _categoryCatalogDAL.GetById(id);	
		}

		public async Task<CategoryCatalog> GetByIdAsync(int id)
		{
			return await	_categoryCatalogDAL.GetByIdAsync(id);	
		}

		public void TAdd(CategoryCatalog t)
		{
		_categoryCatalogDAL.Insert(t);	
		}

		public void TDelete(CategoryCatalog t)
		{
			_categoryCatalogDAL.Delete(t);	
		}

		public List<CategoryCatalog> TGetList()
		{
			return _categoryCatalogDAL.GetAll();	
		}

		public void TUpdate(CategoryCatalog t)
		{
			_categoryCatalogDAL.Update(t);	
		}
	}
}
