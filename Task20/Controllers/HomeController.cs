using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task20.Models;

namespace Task20.Controllers
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
            FormClass form = new FormClass();

            return View();
        }
        [HttpPost]
        public IActionResult Index(FormClass form)
        {
            CookieOptions nameCookie = new CookieOptions();

            nameCookie.Expires = DateTime.Now.AddMinutes(5);

            Response.Cookies.Append("Username", form.Username, nameCookie);

            Console.WriteLine("Cookie Value : " + Request.Cookies["Username"]);

            return RedirectToAction("Index");
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