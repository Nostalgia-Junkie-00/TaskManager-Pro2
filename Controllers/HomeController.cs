using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskManager_Pro2.Models;

namespace TaskManager_Pro2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}