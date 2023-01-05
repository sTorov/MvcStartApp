using Microsoft.AspNetCore.Mvc;
using MvcStartApp.Models.Db;
using MvcStartApp.Models.Db.Repositories;

namespace MvcStartApp.Controllers
{
    /// <summary>
    /// Контроллер для обработки объектов пользователя
    /// </summary>
    public class UsersController : Controller
    {
        private readonly IBlogRepository _repo;

        public UsersController(IBlogRepository repo) 
        { 
            _repo = repo;
        }

        /// <summary>
        /// Метод, возвращающий страницу со списком зарегистрированных пользователей
        /// </summary>
        public async Task<IActionResult> Index()
        {
            var authors = await _repo.GetUsers();
            return View(authors);
        }

        /// <summary>
        /// Метод, возвращающий страницу регистрации
        /// </summary>
        [HttpGet]
        public IActionResult Register()
        {            
            return View();
        }

        /// <summary>
        /// Метод, принимающий POST-запросы со страницы регистрации. Добавляет новых пользователей в БД при регистрации
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Register(User newUser)
        {
            await _repo.AddUser(newUser);
            return View(newUser);
        }
    }
}
