using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDistributedMemoryCache(); 

        services.AddSession(options => 
        {
            options.IdleTimeout = TimeSpan.FromMinutes(30); 
            options.Cookie.HttpOnly = true; 
            options.Cookie.IsEssential = true; 
        });

        services.AddControllersWithViews(); 
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage(); 
        }
        else
        {
            app.UseExceptionHandler("/Home/Error"); 
            app.UseHsts(); 
        }

        app.UseHttpsRedirection(); 
        app.UseStaticFiles(); 

        app.UseRouting(); 

        app.UseSession();
        app.UseAuthorization(); 

        app.UseEndpoints(endpoints => 
        {
            endpoints.MapControllerRoute( 
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}
