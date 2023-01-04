using MvcStartApp.Models.Db;
using MvcStartApp.Models.Db.Repositories;

namespace MvcStartApp.Controllers
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IBlogRepository _repo;

        public LoggingMiddleware(RequestDelegate next, IBlogRepository repo)
        {
            _next = next;
            _repo = repo;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var test = context.Request.Headers["User-Agent"][0];

            var userTest = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Иван",
                LastName = "Иванов",
                JoinDate = DateTime.Now,
            };

            await _repo.AddUser(userTest);

            Console.WriteLine($"[{DateTime.Now}]: New request to https://{context.Request.Host.Value + context.Request.Path}");

            await _next.Invoke(context);
        }
    }
}
