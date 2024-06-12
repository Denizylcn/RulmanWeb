using DataAccesLayer.Abstract.CategoryProductAbstract;
using DataAccesLayer.GenericRepository;
using EntityLayer.CategoryProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EFDAL.CategoryProductEF
{
	public class CategoryEFDAL:GenericRepository<Category>,ICategoryDAL
	{
	}
}
