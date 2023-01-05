using Microsoft.AspNetCore.Mvc;
using MvcStartApp.Models.Db.Repositories;

namespace MvcStartApp.Controllers
{
    public class LogsController : Controller
    {
        private readonly IRequestRepository _repo;

        public LogsController(IRequestRepository repo)
        {
            _repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            var logs = await _repo.GetAll();
            return View(logs);
        }
    }
}
