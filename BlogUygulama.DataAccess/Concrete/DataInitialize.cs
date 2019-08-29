using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogUygulama.Entities.Concrete;

namespace BlogUygulama.DataAccess.Concrete
{
    public class DataInitialize:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            context.Categories.Add(new Category
            {
                KategoriAdi = "Genel"
            });
            context.SaveChanges();

            context.Blogs.Add(new Blog
            {
                Baslik = "Aciklama",
                Anasayfadami = true,
                EklenmeTarihi = DateTime.Now,
                Icerik = "Icerikler olusturuldu",
                Onaylandimi = true,
                CategoryID = 1,
                Resim = "ornek.jpg"

            });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
