using Microsoft.AspNetCore.Mvc;
using MvcStartApp.Models;
using MvcStartApp.Models.Db;
using MvcStartApp.Models.Db.Repositories;

namespace MvcStartApp.Controllers
{
    /// <summary>
    /// Базовый контроллер
    /// </summary>
    public class HomeController : Controller
    {
        private readonly IBlogRepository _repo;

        public HomeController(IBlogRepository repo)
        {
            _repo = repo;
        }        

        /// <summary>
        /// Метод, возвращающий главную страницу
        /// </summary>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Метод, возвращающий страницу политики конфиденциальности
        /// </summary>
        public IActionResult Privacy()
        {
            return View();
        }
    }
}