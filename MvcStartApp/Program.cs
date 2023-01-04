namespace MvcStartApp
{
    class Program
    {
        public static WebApplicationBuilder builder;

        static void Main(string[] args)
        {
            CreateHostBulder(args).Build().Run();
        }

        static IHostBuilder CreateHostBulder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    }
}
