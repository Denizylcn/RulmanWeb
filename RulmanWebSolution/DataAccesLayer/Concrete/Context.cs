using EntityLayer;
using EntityLayer.CategoryProduct;
using EntityLayer.Products;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
	public class Context:IdentityDbContext<AppUser,AppRole,int>

	{
		public DbSet<Category> Categories { get; set; }
		public DbSet<CategoryCatalog> CategoryCatalogs { get; set; }
		public DbSet<CategoryPhoto> CategoryPhotos { get; set; } 
       
		public DbSet<CategoryProperty>CategoryProperties { get; set; }
		public DbSet<Product> Products { get; set; }	
		public DbSet<ProductImage> ProductImages { get; set; }



		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{

			optionsBuilder.UseSqlServer("server=DESKTOP-KP9S695;initial catalog=RulmanWebDb;integrated Security=true;");

		}
	}
}
