using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogUygulama.WebUI.Controllers
{
    public class BlogUserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
    }
}