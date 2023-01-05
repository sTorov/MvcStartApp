using Microsoft.AspNetCore.Mvc;
using MvcStartApp.Models.Db.Repositories;

namespace MvcStartApp.Controllers
{
    /// <summary>
    /// Контроллер для обработки истории запросов
    /// </summary>
    public class LogsController : Controller
    {
        private readonly IRequestRepository _repo;

        public LogsController(IRequestRepository repo)
        {
            _repo = repo;
        }

        /// <summary>
        /// Метод, возвращающий страницу с историей запросов
        /// </summary>
        public async Task<IActionResult> Index()
        {
            var logs = await _repo.GetAll();
            return View(logs);
        }
    }
}
