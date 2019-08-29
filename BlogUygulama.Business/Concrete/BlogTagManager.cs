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
    public class BlogTagManager : IBlogTagService
    {
        private IBlogTagDal _blogTagDal;

        public BlogTagManager(IBlogTagDal blogTagDal)
        {
            _blogTagDal = blogTagDal;
        }

        public DataResponse GetList()
        {
            var blogTag = _blogTagDal.GetList();
            if (blogTag == null)
                return new DataResponse
                {
                    Mesaj = "Aradiginiz Etiketler Getirilemedi",
                    Tamamlandi = false
                };
            return new DataResponse
            {
                Data = blogTag,
                Mesaj = "Etiketler Getirildi",
                Tamamlandi = true
            };

        }

        public DataResponse Get(int id)
        {
            var blogTag = _blogTagDal.Get(i => i.ID == id);
            if (blogTag == null)
                return new DataResponse
                {
                    Mesaj = "Aradiginiz Etiket Bulunamadi",
                    Tamamlandi = false
                };
            return new DataResponse
            {
                Data = blogTag,
                Mesaj = "Etiket Getirildi",
                Tamamlandi = true
            };
        }

        public DataResponse Add(BlogTag entity)
        {
            var blogTag = _blogTagDal.Add(entity);
            if (blogTag == null)
                return new DataResponse
                {
                    Mesaj = "Etiket Eklenemedi",
                    Tamamlandi = false,
                };
            return new DataResponse
            {
                Data = blogTag,
                Tamamlandi = true,
                Mesaj =" Etiket Eklendi",
            };
        }

        public DataResponse Update(BlogTag entity)
        {
            var blogTag = _blogTagDal.Update(entity);
            if (blogTag == null)
                return new DataResponse
                {
                    Mesaj = "Etiket Duzenlenemedi",
                    Tamamlandi = false,
                };
            return new DataResponse
            {
                Data = blogTag,
                Tamamlandi = true,
                Mesaj = " Etiket Duzenlendi",
            };

        }

        public DataResponse Delete(BlogTag entity)
        {
            var blogTag = _blogTagDal.Delete(entity);
            if (blogTag == null)
                return new DataResponse
                {
                    Mesaj = "Aradiginiz Etiket Bulunamadi",
                    Tamamlandi = false
                };
            return new DataResponse
            {
                Data = blogTag,
                Mesaj = "Etiket Silindi",
                Tamamlandi = true
            };
        }
    }
}
