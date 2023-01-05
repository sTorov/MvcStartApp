using Microsoft.AspNetCore.Mvc;
using MvcStartApp.Models;
using MvcStartApp.Models.Db;
using MvcStartApp.Models.Db.Repositories;

namespace MvcStartApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogRepository _repo;

        public HomeController(IBlogRepository repo)
        {
            _repo = repo;
        }        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}