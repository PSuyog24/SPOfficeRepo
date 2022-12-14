using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task21.Models;

namespace Task21.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //FlowerClass flower = new FlowerClass();

            return View();
        }

        [HttpPost]
        public IActionResult Index(FlowerClass flower)
        {
            //if (!string.IsNullOrEmpty(flower.FlowerName))
            //{
            //    if(flower.FlowerName == "1")
            //    {
            //        return RedirectToAction("Index");
            //    }
            //    else if(flower.FlowerName == "2")
            //    {
            //        return RedirectToAction("Index");
            //    }
            //    else if (flower.FlowerName == "3")
            //    {
            //        return RedirectToAction("Index");
            //    }
            //}

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