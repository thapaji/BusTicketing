using OnlineBusTicketing.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBusTicketing.Controllers
{
    public class HomeController : Controller
    {
        private DataContext dataContext = new DataContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Our Company";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us At";

            return View();
        }
    }
}