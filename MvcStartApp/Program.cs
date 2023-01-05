namespace MvcStartApp
{
    class Program
    {
        /// <summary>
        /// Основной метод Main
        /// </summary>
        static void Main(string[] args)
        {
            CreateHostBulder(args).Build().Run();
        }

        /// <summary>
        /// Метод для развёртывания приложения
        /// </summary>
        static IHostBuilder CreateHostBulder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    }
}
