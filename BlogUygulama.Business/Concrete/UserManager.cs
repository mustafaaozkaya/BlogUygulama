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
    public class UserManager:IUserService
    {
        private IBlogUserDal _userDal;

        public UserManager(IBlogUserDal userDal)
        {
            _userDal = userDal;
        }
        public DataResponse GetList()
        {
            var user = _userDal.GetList();
            if (user == null)
                return new DataResponse
                {
                    Mesaj = "Kullanici Bulunamadi",
                    Tamamlandi = false
                };
            return new DataResponse
            {
                Data = user,
                Mesaj = "Kullanicilar Getirildi",
                Tamamlandi = true
            };

        }

        public DataResponse Get(int id)
        {
            var user = _userDal.Get(i => i.ID == id);
            if (user == null)
                return new DataResponse
                {
                    Mesaj = "Aradiginiz Kullanici Bulunamadi",
                    Tamamlandi = false
                };
            return new DataResponse
            {
                Data = user,
                Mesaj = user.KullaniciAdi + " Kullanicisi Getirildi",
                Tamamlandi = true
            };
        }

        public DataResponse Add(BlogUser entity)
        {
            var user = _userDal.Add(entity);
            if (user == null)
                return new DataResponse
                {
                    Mesaj = "Kullanici Eklenemedi",
                    Tamamlandi = false,
                };
            return new DataResponse
            {
                Data = user,
                Tamamlandi = true,
                Mesaj = user.KullaniciAdi + " Kullanicisi Eklendi",
            };
        }

        public DataResponse Update(BlogUser entity)
        {
            var user = _userDal.Update(entity);
            if (user == null)
                return new DataResponse
                {
                    Mesaj = user.KullaniciAdi + " Kullanicisi Duzenlenemedi",
                    Tamamlandi = false,
                };
            return new DataResponse
            {
                Data = user,
                Tamamlandi = true,
                Mesaj = user.KullaniciAdi + " Kullanicisi Duzenlendi",
            };

        }

        public DataResponse Delete(BlogUser entity)
        {
            var user = _userDal.Delete(entity);
            if (user == null)
                return new DataResponse
                {
                    Mesaj = "Aradiginiz Kullanici Bulunamadi",
                    Tamamlandi = false
                };
            return new DataResponse
            {
                Data = user,
                Mesaj = user.KullaniciAdi + " Kullanicisi Silindi",
                Tamamlandi = true
            };
        }
    }
}
