using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace SimpleNetFrame.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            ViewBag.Secret = ConfigurationManager.AppSettings["SomeSecret"];

            return View();
        }
    }
}
