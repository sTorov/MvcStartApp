﻿using Microsoft.AspNetCore.Mvc;
using MvcStartApp.Models;
using MvcStartApp.Models.Db;
using MvcStartApp.Models.Db.Repositories;

namespace MvcStartApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogRepository _repo;
        //private readonly ILogger<HomeController> _logger;

        public HomeController(/*ILogger<HomeController> logger,*/ IBlogRepository repo)
        {
            //_logger = logger;
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