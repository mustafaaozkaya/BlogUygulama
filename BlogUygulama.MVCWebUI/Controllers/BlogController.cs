using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogUygulama.MVCWebUI.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }
    }
}