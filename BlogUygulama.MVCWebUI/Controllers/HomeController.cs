using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogUygulama.Business.Abstract;
using BlogUygulama.Business.Concrete;
using BlogUygulama.Business.DepandencyResolvers.Ninject;

namespace BlogUygulama.MVCWebUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private IBlogService _blogService;

        public HomeController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public ActionResult Index()
        {
            var response = _blogService.GetList();
            if(response.Tamamlandi)
            return View(response.Data);
            return RedirectToAction("Index", "Blog", new {mesajım = response.Mesaj});
        }
    }
}