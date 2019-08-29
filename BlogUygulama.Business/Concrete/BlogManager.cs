using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogUygulama.Business.Abstract;
using BlogUygulama.Core.Entities.Concrete;
using BlogUygulama.DataAccess.Abstract;
using BlogUygulama.Entities.Concrete;

namespace BlogUygulama.Business.Concrete
{
    public class BlogManager:IBlogService
    {
        private IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;

        }
        public DataResponse GetList()
        {
            var blog = _blogDal.GetList();
            if (blog == null)
                return new DataResponse
                {
                    Mesaj = "Aradiginiz Bloglar Getirilemedi",
                    Tamamlandi = false
                };
            return new DataResponse
            {
                Data = blog,
                Mesaj = "Bloglar Getirildi",
                Tamamlandi = true
            };
           
        }

        public DataResponse Get(int id)
        {
            var blog=_blogDal.Get(i => i.ID == id);
            if(blog==null)
                return new DataResponse
                {
                    Mesaj = "Aradiginiz Blog Bulunamadi",
                    Tamamlandi = false
                };
            return new DataResponse
            {
                Data = blog,
                Mesaj = "Blog Getirildi",
                Tamamlandi = true
            };
        }

        public DataResponse Add(Blog entity)
        {
            var blog = _blogDal.Add(entity);
            if (blog == null)
                return new DataResponse
                {
                    Mesaj = "Blog Eklenemedi",
                    Tamamlandi = false,
                };
            return new DataResponse
            {
                Data = blog,
                Tamamlandi = true,
                Mesaj = blog.Baslik + " Baslikli Blog Eklendi",
            };
        }

        public DataResponse Update(Blog entity)
        {
            var blog = _blogDal.Update(entity);
            if (blog == null)
                return new DataResponse
                {
                    Mesaj = "Blog Duzenlenemedi",
                    Tamamlandi = false,
                };
            return new DataResponse
            {
                Data = blog,
                Tamamlandi = true,
                Mesaj = blog.Baslik + " Baslikli Blog Duzenlendi",
            };

        }

        public DataResponse Delete(Blog entity)
        {
            var blog = _blogDal.Delete(entity);
            if (blog == null)
                return new DataResponse
                {
                    Mesaj = "Aradiginiz Blog Bulunamadi",
                    Tamamlandi = false
                };
            return new DataResponse
            {
                Data = blog,
                Mesaj = "Blog Silindi",
                Tamamlandi = true
            };
        }
    }
}
