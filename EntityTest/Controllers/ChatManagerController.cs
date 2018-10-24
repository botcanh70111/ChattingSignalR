using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityTest.Controllers
{
    public class ChatManagerController : Controller
    {
        // GET: ChatManager
        [Authorize]
        public ActionResult Index()
        {
            var model = HttpContext.User.Identity;
            return View(model);
        }
    }
}