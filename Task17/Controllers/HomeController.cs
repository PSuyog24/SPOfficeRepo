using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using Task17.Models;

namespace Task17.Controllers
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
            DataClass data = new DataClass();

            data.Operations = new List<OperationList>();

            data.Operations.Add(new OperationList { OperationId="1",Operation="Addition"});
            data.Operations.Add(new OperationList { OperationId="2",Operation="Subtraction"});

            return View(data);
        }
        [HttpPost]
        public string Index(DataClass data)
        {
            long result = 0;

            if(data.SelectedOperation == 1)
            {
                result = data.FirstNumber + data.SecondNumber;
            }
            else if (data.SelectedOperation == 2)
            {
                result = data.FirstNumber - data.SecondNumber;
            }

            return "Result is " + result;
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