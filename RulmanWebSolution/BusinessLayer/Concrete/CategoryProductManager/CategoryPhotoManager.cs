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
	public class CategoryPhotoManager : ICategoryPhotoService
	{
		private readonly ICategoryPhotoDAL _categoryPhotoDAL;

		public CategoryPhotoManager(ICategoryPhotoDAL categoryPhotoDAL)
		{
			_categoryPhotoDAL = categoryPhotoDAL;
		}

		public CategoryPhoto GetByID(int id)
		{
			return _categoryPhotoDAL.GetById(id);	
		}

		public async Task<CategoryPhoto> GetByIdAsync(int id)
		{
			return await _categoryPhotoDAL.GetByIdAsync(id);	
		}

		public void TAdd(CategoryPhoto t)
		{
			_categoryPhotoDAL.Insert(t);	
		}

		public void TDelete(CategoryPhoto t)
		{
			_categoryPhotoDAL.Delete(t);	
		}

		public List<CategoryPhoto> TGetList()
		{
			return _categoryPhotoDAL.GetAll();
		}

		public void TUpdate(CategoryPhoto t)
		{
			_categoryPhotoDAL.Update(t);
		}
	}
}
