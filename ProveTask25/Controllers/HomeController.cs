using ProveTask25.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProveTask25.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterUser(UserData data)
        {
            if (ModelState.IsValid)
            {
                DemoDBEntities demoDBEntities = new DemoDBEntities();

                demoDBEntities.UserDatas.Add(data);
                demoDBEntities.SaveChanges();
            }

            return View(data);
        }
    }
}