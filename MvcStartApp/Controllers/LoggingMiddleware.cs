namespace MvcStartApp.Controllers
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            LogConsole(context);
            await LogFile(context);

            await _next.Invoke(context);
        }

        private void LogConsole(HttpContext context) =>
            Console.WriteLine($"[{DateTime.Now}]: New request to https://{context.Request.Host.Value + context.Request.Path}");

        private async Task LogFile(HttpContext context)
        {
            string logMessage = $"[{DateTime.Now}]: New request to https://{context.Request.Host.Value + context.Request.Path}\n";
            string fileLogPath = Path.Combine(Directory.GetCurrentDirectory(), "Log", "RequestLog.txt");

            await File.AppendAllTextAsync(fileLogPath, logMessage);
        }
    }
}
