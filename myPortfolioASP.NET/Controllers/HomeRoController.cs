using Microsoft.AspNetCore.Mvc;

namespace myPortfolioASP.NET.Controllers
{
    public class HomeRoController : Controller
    {
        private readonly ILogger<HomeRoController> _logger;

        public IActionResult IndexRo()
        {
            return View();
        }
        public IActionResult AboutRo()
        {
            return View();
        }
        public IActionResult ContactRo()
        {
            return View();
        }
    }
}
