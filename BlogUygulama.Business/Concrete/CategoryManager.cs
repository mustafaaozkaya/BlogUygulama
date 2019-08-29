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
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public DataResponse GetList()
        {
            var category = _categoryDal.GetList();
            if (category == null)
                return new DataResponse
                {
                    Mesaj = "Aradiginiz Kategoriler Getirilemedi",
                    Tamamlandi = false
                };
            return new DataResponse
            {
                Data = category,
                Mesaj = "Kategoriler Getirildi",
                Tamamlandi = true
            };

        }

        public DataResponse Get(int id)
        {
            var category = _categoryDal.Get(i => i.ID == id);
            if (category == null)
                return new DataResponse
                {
                    Mesaj = "Aradiginiz Kategori Bulunamadi",
                    Tamamlandi = false
                };
            return new DataResponse
            {
                Data = category,
                Mesaj = category.KategoriAdi + " Kategorisi Getirildi",
                Tamamlandi = true
            };
        }

        public DataResponse Add(Category entity)
        {
            var category = _categoryDal.Add(entity);
            if (category == null)
                return new DataResponse
                {
                    Mesaj = "Kategori Eklenemedi",
                    Tamamlandi = false,
                };
            return new DataResponse
            {
                Data = category,
                Tamamlandi = true,
                Mesaj = category.KategoriAdi + " Kategorisi Eklendi",
            };
        }

        public DataResponse Update(Category entity)
        {
            var category = _categoryDal.Update(entity);
            if (category == null)
                return new DataResponse
                {
                    Mesaj =category.KategoriAdi+ " Kategorisi Duzenlenemedi",
                    Tamamlandi = false,
                };
            return new DataResponse
            {
                Data = category,
                Tamamlandi = true,
                Mesaj = category.KategoriAdi + " Kategorisi Duzenlendi",
            };

        }

        public DataResponse Delete(Category entity)
        {
            var category = _categoryDal.Delete(entity);
            if (category == null)
                return new DataResponse
                {
                    Mesaj = "Aradiginiz Kategori Bulunamadi",
                    Tamamlandi = false
                };
            return new DataResponse
            {
                Data = category,
                Mesaj =category.KategoriAdi+ " Kategorisi Silindi",
                Tamamlandi = true
            };
        }
    }
}
