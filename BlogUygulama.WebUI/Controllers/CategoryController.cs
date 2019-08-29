using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogUygulama.Business.Abstract;
using BlogUygulama.Business.Concrete;
using BlogUygulama.Entities.Concrete;

namespace BlogUygulama.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        private ICategoryService _categoryService;
        public CategoryController()
        {

        }
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

       

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KategoriKaydet(Category category)
        {
            var response = _categoryService.Add(category);
            if (response.Tamamlandi)
                return RedirectToAction("Index", "Home", new {mesaj = response.Mesaj});
            return RedirectToAction("Index", "Category", new { mesaj = response.Mesaj });
        }
        public ActionResult KategorileriGetir()
        {
            var response = _categoryService.GetList();
            if  (response.Tamamlandi)
                return PartialView(response.Data);
            return RedirectToAction("Index", "Category", new { mesaj = response.Mesaj });

        }
    }
}