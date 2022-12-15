using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task18.Models;

namespace Task18.Controllers
{
    public class HomeController : Controller
    {
        public List<SelectListItem> GetAllItems()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem { Text = "Rose", Value = "1" });
            items.Add(new SelectListItem { Text = "Marigold", Value = "2" });
            items.Add(new SelectListItem { Text = "Tulip", Value = "3" });
            return items;
        }

        public ActionResult Index()
        {

            var model = new ItemClass
            {
                //SelectedItemName = new[] {2},
                ItemList = GetAllItems()
            };

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}