using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using Task19.Models;

namespace Task19.Controllers
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
            List<SelectListItem> paymentMode = new()
            {
                new SelectListItem { Value = "0", Text = "--Select--" },
                new SelectListItem { Value = "1", Text = "Credit Card" },
                new SelectListItem { Value = "2", Text = "UPI"}
            };

            ViewBag.payMode = paymentMode;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}