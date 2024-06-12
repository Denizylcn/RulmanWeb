using BusinessLayer.Abstract.ProductService;
using DataAccesLayer.Abstract.ProductAbstract;
using EntityLayer.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.ProductManager
{
	public class ProductImageManager : IProductImageService
	{
		private readonly IProductImageDAL _productImageDAL;

		public ProductImageManager(IProductImageDAL productImageDAL)
		{
			_productImageDAL = productImageDAL;
		}

		public ProductImage GetByID(int id)
		{
			return _productImageDAL.GetById(id);
		}

		public async Task<ProductImage> GetByIdAsync(int id)
		{
			return await _productImageDAL.GetByIdAsync(id);	
		}

		public void TAdd(ProductImage t)
		{
			_productImageDAL.Insert(t);	
		}

		public void TDelete(ProductImage t)
		{
			_productImageDAL.Delete(t);	
		}

		public List<ProductImage> TGetList()
		{
			return	_productImageDAL.GetAll();	
		}

		public void TUpdate(ProductImage t)
		{
			_productImageDAL.Update(t);	
		}
	}
}
