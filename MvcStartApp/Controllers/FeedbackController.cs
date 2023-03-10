using Microsoft.AspNetCore.Mvc;
using MvcStartApp.Models;
using System.Diagnostics;

namespace MvcStartApp.Controllers
{
    /// <summary>
    /// Контроллер для обработкм отзывов
    /// </summary>
    public class FeedbackController : Controller
    {
        /// <summary>
        /// Метод, возвращающий страницу с отзывами
        /// </summary>
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        /// <summary>
        /// Метод для AJAX-запросов
        /// </summary>
        [HttpPost]
        public IActionResult Add(Feedback feedback)
        {
            return StatusCode(200, $"{feedback.From}, спасибо за отзыв!");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { 
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
                });
        }
    }
}
