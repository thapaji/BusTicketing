using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using OnlineBusTicketing.Models;
using OnlineBusTicketing.Models.DAL;

namespace OnlineBusTicketing.Controllers
{
    public class AccountController : Controller
    {
        private DataContext context = new DataContext();

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                context.User.Add(user);
                context.SaveChanges();
                return View("Login");
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}