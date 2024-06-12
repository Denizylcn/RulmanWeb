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
	public class ProductManager : IProductService
	{
		private readonly IProductDAL _productDal;

		public ProductManager(IProductDAL productDal)
		{
			_productDal = productDal;
		}

		public Product GetByID(int id)
		{
			return _productDal.GetById(id);
		}

		public async Task<Product> GetByIdAsync(int id)
		{
			return await _productDal.GetByIdAsync(id);
			
		}

		public void TAdd(Product t)
		{
			_productDal.Insert(t);	
		}

		public void TDelete(Product t)
		{
			_productDal.Delete(t);
		}

		public List<Product> TGetList()
		{
			return _productDal.GetAll();	
		}

		public void TUpdate(Product t)
		{
			_productDal.Update(t);
		}
	}
}
