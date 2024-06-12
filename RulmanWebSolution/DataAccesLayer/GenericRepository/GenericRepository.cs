using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.GenericRepository
{
	
		public class GenericRepository<T> : IGenericDal<T> where T : class
		{
			void IGenericDal<T>.Delete(T t)
			{
				using var context = new Context();
				context.Remove(t);
				context.SaveChanges();
			}

			List<T> IGenericDal<T>.GetAll()
			{
				using var context = new Context();
				return context.Set<T>().ToList();
			}

			T IGenericDal<T>.GetById(int id)
			{
				using var context = new Context();
				return context.Set<T>().Find(id);
			}

			void IGenericDal<T>.Insert(T t)
			{
				using var context = new Context();
				context.Add(t);
				context.SaveChanges();
			}

			void IGenericDal<T>.Update(T t)
			{
				using var context = new Context();
				context.Update(t);
				context.SaveChanges();
			}


			async Task<T> IGenericDal<T>.GetByIdAsync(int id)
			{
				using var context = new Context();
				return await context.Set<T>().FindAsync(id);
			}

		
			
		}
		 
}

