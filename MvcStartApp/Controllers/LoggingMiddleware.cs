using MvcStartApp.Models.Db;
using MvcStartApp.Models.Db.Repositories;

namespace MvcStartApp.Controllers
{
    /// <summary>
    /// Промежуточное ПО для логирования и сохраниения истории запросов в БД
    /// </summary>
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IRequestRepository _repo;

        public LoggingMiddleware(RequestDelegate next, IRequestRepository repo)
        {
            _next = next;
            _repo = repo;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var newRequest = new Request
            {
                Id = Guid.NewGuid(),
                Date = DateTime.Now,
                Url = $"https://{context.Request.Host.Value + context.Request.Path}",
            };

            await _repo.Add(newRequest);

            Console.WriteLine($"[{newRequest.Date}]: New request to {newRequest.Url}");

            await _next.Invoke(context);
        }
    }
}
