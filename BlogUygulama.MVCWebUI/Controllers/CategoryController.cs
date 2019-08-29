using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogUygulama.Business.Abstract;
using BlogUygulama.Entities.Concrete;

namespace BlogUygulama.MVCWebUI.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kaydet(Category category)
        {
            var response = _categoryService.Add(category);
            if (response.Tamamlandi)
                return RedirectToAction("Index", "Home",new{mesaj = response.Mesaj});
            return RedirectToAction("Index", "Category", new { mesaj = response.Mesaj });
        }
    }
}