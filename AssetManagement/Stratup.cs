using AssetManagement.Controllers;
using AssetManagement.Core.DAO.Implement;
using AssetManagement.Core.Facade.Implement;
using AssetManagement.Core.Service.Implement;
using Autofac;
using DB.Context;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using AssetManagement.Core.Facade.Interface;
using AssetManagement.Core.Facade.Implement.Employee;
using AssetManagement.Core.Service.Interface;
using AssetManagement.Core.Service.Implement.Employee;
using AssetManagement.Core.DAO.Interface;
using AssetManagement.Core.DAO.Implement.Employee;

namespace AssetManagement
{
    public class Stratup
    {
        public IConfiguration _configuration { get; }

        public Stratup (IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<AssetManagementContext>(options =>
                    options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));

            services.AddHttpContextAccessor();
            //發佈時有View資料夾
            //services.AddControllersWithViews();
            services.AddMemoryCache();

            services.AddSession(x => {
                x.IdleTimeout = TimeSpan.FromMinutes(30);
            });

            services.AddMvc(x =>
            {

            })
            // 這行才能 propertyInjection
            .AddControllersAsServices();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Index}/{id?}");
            });
        }

        /// <summary>
        /// AutoFac DI Register
        /// </summary>
        /// <param name="builder"></param>
        public void ConfigureContainer(ContainerBuilder builder)
        {
            Assembly mainAssembly = Assembly.GetExecutingAssembly();
            Assembly coreAssembly = Assembly.Load("AssetManagement.Core");
            Assembly libAssembly = Assembly.Load("Lib");

            builder.RegisterAssemblyTypes(mainAssembly)
             .Where(t => t.BaseType == typeof(BaseController))
             .PropertiesAutowired();

            builder.RegisterAssemblyTypes(coreAssembly)
             .Where(t => t.BaseType == typeof(BaseFacade))
             .AsImplementedInterfaces()
             .PropertiesAutowired();

            builder.RegisterAssemblyTypes(coreAssembly)
             .Where(t => t.BaseType == typeof(BaseService))
             .AsImplementedInterfaces()
             .PropertiesAutowired();

            builder.RegisterAssemblyTypes(coreAssembly)
             .Where(t => t.BaseType == typeof(BaseDAO))
             .AsImplementedInterfaces()
             .PropertiesAutowired();
        }
    }
}
