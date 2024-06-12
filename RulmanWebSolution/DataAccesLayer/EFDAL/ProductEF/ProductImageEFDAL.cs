using DataAccesLayer.Abstract;
using DataAccesLayer.Abstract.ProductAbstract;
using DataAccesLayer.GenericRepository;
using EntityLayer.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EFDAL.ProductEF
{
	public class ProductImageEFDAL:GenericRepository<ProductImage>,IProductImageDAL
	{
	}
}
