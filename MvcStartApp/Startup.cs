using Microsoft.EntityFrameworkCore;
using MvcStartApp.Controllers;
using MvcStartApp.Models.Db;
using MvcStartApp.Models.Db.Repositories;

namespace MvcStartApp
{
    /// <summary>
    /// Класс для настройки приложения и сервисов
    /// </summary>
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Метод для подключения сервисов
        /// </summary>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IBlogRepository, BlogRepository>();
            services.AddSingleton<IRequestRepository, RequestRepository>();

            string connection = _configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<BlogContext>(options => options.UseSqlServer(connection), ServiceLifetime.Singleton);

            services.AddControllersWithViews();
        }

        /// <summary>
        /// Метод для настройки конвеера запросов
        /// </summary>
        public async void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseMiddleware<LoggingMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
