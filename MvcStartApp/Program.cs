namespace MvcStartApp
{
    class Program
    {
        /// <summary>
        /// �������� ����� Main
        /// </summary>
        static void Main(string[] args)
        {
            CreateHostBulder(args).Build().Run();
        }

        /// <summary>
        /// ����� ��� ������������ ����������
        /// </summary>
        static IHostBuilder CreateHostBulder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    }
}
