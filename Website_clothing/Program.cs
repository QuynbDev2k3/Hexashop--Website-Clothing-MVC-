using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Website_clothing.IRepositories;
using Website_clothing.IServices;
using Website_clothing.Models;
using Website_clothing.Repositories;
using Website_clothing.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// Add Cookies
builder.Services.AddAuthentication(
	CookieAuthenticationDefaults.AuthenticationScheme)
	.AddCookie(option =>
	{
		option.LoginPath = "/Access/Login";
		option.ExpireTimeSpan = TimeSpan.FromMinutes(20);
	});
// Đăng ký DbContext
builder.Services.AddDbContext<Website_clothing_DbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Đăng ký DI
builder.Services.AddScoped<ICRUDRepository<SanPham>, CRUDRepository<SanPham>>();
builder.Services.AddScoped<ISanPhamService, SanPhamService>();
builder.Services.AddScoped<ICRUDRepository<CTSanPham>, CRUDRepository<CTSanPham>>();
builder.Services.AddScoped<ICTSanPhamService, CTSanPhamService>();
builder.Services.AddScoped<ICRUDRepository<Hang>, CRUDRepository<Hang>>();
builder.Services.AddScoped<IHangService, HangService>();
builder.Services.AddScoped<CTSanPhamService>();

builder.Services.AddSession();

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

app.UseAuthentication();

app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Access}/{action=Login}/{id?}");

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapGet("/", context =>
//    {
//        context.Response.Redirect("/Home/Index");
//        return Task.CompletedTask;
//    });

//    endpoints.MapControllerRoute(
//        name: "default",
//        pattern: "{controller=Home}/{action=Index}/{id?}");
//});

app.Run();
