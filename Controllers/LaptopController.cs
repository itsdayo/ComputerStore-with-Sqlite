using Microsoft.AspNetCore.Mvc;

namespace ComputerStore.Controllers
{
    public class LaptopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult navtoHomepage()
        {
            return View("index");
        }
        public IActionResult navtoAccessories()
        {
            return View("accessories");
        }
        public IActionResult navtoTablets()
        {
            return View("tablets");
        }
    }
}
