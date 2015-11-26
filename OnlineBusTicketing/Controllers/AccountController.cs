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
using System.Net.Mail;
using System.Security.Cryptography;
using OnlineBusTicketing.Utilities;

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
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.live.com");

                    mail.From = new MailAddress("bus_project@outlook.com");
                    mail.To.Add(user.Email);
                    mail.Subject = "Verification Code";
                    mail.Body = "Your Verification code is : " + user.VerificationCode;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("bus_project@outlook.com", "onlineBusTicketing");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                }
                catch (Exception ex)
                {
                }
                user.VerificationCode = 0;
                Verify(user);
            }
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View(new User());
        }

        [HttpPost]
        public ActionResult Login(User model)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                string pass = Utility.GetMd5Hash(md5Hash, model.Password);
                var user = (from s in context.User
                            where s.Username == model.Username
                            where s.Password == pass
                            select s).FirstOrDefault();

                if (user != null)
                {
                    Session["user"] = user;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    model.Password = "";
                    return View(model);
                }
            }
        }

        public ActionResult Verify(User user)
        {
            return View(user);
        }
    }
}