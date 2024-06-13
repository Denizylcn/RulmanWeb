using BusinessLayer.Abstract.CategoryProductService;
using BusinessLayer.Abstract.ProductService;
using BusinessLayer.Concrete.CategoryProductManager;
using BusinessLayer.Concrete.ProductManager;
using DataAccesLayer.Abstract.CategoryProductAbstract;
using DataAccesLayer.Abstract.ProductAbstract;
using DataAccesLayer.Concrete;
using DataAccesLayer.EFDAL.CategoryProductEF;
using DataAccesLayer.EFDAL.ProductEF;
using EntityLayer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
builder.Services.AddScoped<IProductDAL, ProductEFDALcs>();
builder.Services.AddScoped<IProductImageDAL, ProductImageEFDAL>();
builder.Services.AddScoped<ICategoryDAL, CategoryEFDAL>();
builder.Services.AddScoped<ICategoryPhotoDAL, CategoryPhotoEFDAL>();
builder.Services.AddScoped<ICategoryPropertyDAL, CategoryPropertyEFDAL>();
builder.Services.AddScoped<ICategoryCatalogDAL, CategoryCatalogEFDAL>();
builder.Services.AddTransient<IProductService, ProductManager>();
builder.Services.AddTransient<IProductImageService, ProductImageManager>();
builder.Services.AddTransient<ICategoryService, CategoryManager>();
builder.Services.AddTransient<ICategoryPhotoService, CategoryPhotoManager>();
builder.Services.AddTransient<ICategoryPropertyService, CategoryPropertyManager>();
builder.Services.AddTransient<ICategoryCatalogService, CategoryCatalogManager>();






var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
