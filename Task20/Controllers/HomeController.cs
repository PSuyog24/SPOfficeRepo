using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Globalization;
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

            List<string> lsCountry = new List<string>();
            CultureInfo[] CInfoList = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach(CultureInfo cinfo in CInfoList)
            {
                RegionInfo R = new RegionInfo(cinfo.LCID);
                if (!(lsCountry.Contains(R.EnglishName)))
                {
                    lsCountry.Add(R.EnglishName);
                }
            }

            lsCountry.Sort();
            ViewBag.CountryList = lsCountry;

            return View();
        }
        [HttpPost]
        public IActionResult Index(FormClass form)
        {
            if (ModelState.IsValid)
            {

                CookieOptions nameCookie = new CookieOptions();

                nameCookie.Expires = DateTime.Now.AddMinutes(5);

                Response.Cookies.Append("Username", form.Username, nameCookie);

                Console.WriteLine("Cookie Value : " + Request.Cookies["Username"]);

                return View();
            }
            else
            {
                return View();
            }
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