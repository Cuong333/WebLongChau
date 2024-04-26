using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebLongChau.Data;
using WebLongChau.Models;

var builder = WebApplication.CreateBuilder(args);
//var ConnectionString = builder.Configuration.GetConnectionString("LongChauWebContextConnection");
// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<LongChauWebContext>(
//    options => options.UseSqlServer(ConnectionString));

//builder.Services.AddIdentity<Customer, IdentityRole>(
//    options =>
//    {
//        options.Password.RequiredUniqueChars = 0;
//        options.Password.RequireUppercase = false;
//        options.Password.RequiredLength = 8;
//        options.Password.RequireLowercase = false;
//        options.Password.RequireNonAlphanumeric = false;

//    }).AddDefaultTokenProviders();

//builder.Services.AddSession();
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

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
app.UseSession();

app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
