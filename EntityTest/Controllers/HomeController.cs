using Core.IRepositories;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityTest.Controllers
{
    public class HomeController : Controller
    {
        private IUserRepository i;
        public HomeController(UserRepository u)
        {
            i = u;
        }
        public ActionResult Index()
        {
            i.GetCurrentUser();
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
    }
}