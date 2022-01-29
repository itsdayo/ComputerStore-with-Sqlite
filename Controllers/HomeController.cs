using ComputerStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ComputerStore.Controllers
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

        /*public IActionResult Privacy()
        {
            return View();
        }*/

        public IActionResult Laptops()
        {
            return View("laptops");
        }
        public IActionResult Accessories()
        {
            return View("accessories");
        }
        public IActionResult Tablets()
        {
            return View("tablets");
        }
        public IActionResult Home()
        {
            return View("index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}