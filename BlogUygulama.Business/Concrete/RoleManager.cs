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
    public class RoleManager:IRoleService
    {
        private IRoleDal _RoleDal;

        public RoleManager(IRoleDal iRoleDal)
        {
            _RoleDal = iRoleDal;
        }

        public DataResponse GetList()
        {
            var role = _RoleDal.GetList();
            if (role == null)
                return new DataResponse
                {
                    Mesaj = "Aradiginiz Roller Getirilemedi",
                    Tamamlandi = false
                };
            return new DataResponse
            {
                Data = role,
                Mesaj = "Roller Getirildi",
                Tamamlandi = true
            };

        }

        public DataResponse Get(int id)
        {
            var role = _RoleDal.Get(i => i.ID == id);
            if (role == null)
                return new DataResponse
                {
                    Mesaj = "Aradiginiz Rol Bulunamadi",
                    Tamamlandi = false
                };
            return new DataResponse
            {
                Data = role,
                Mesaj = "Rol Getirildi",
                Tamamlandi = true
            };
        }

        public DataResponse Add(Role entity)
        {
            var role = _RoleDal.Add(entity);
            if (role == null)
                return new DataResponse
                {
                    Mesaj = "Rol Eklenemedi",
                    Tamamlandi = false,
                };
            return new DataResponse
            {
                Data = role,
                Tamamlandi = true,
                Mesaj = role.RoleAdi + " Rolu Eklendi",
            };
        }

        public DataResponse Update(Role entity)
        {
            var role = _RoleDal.Update(entity);
            if (role == null)
                return new DataResponse
                {
                    Mesaj = "Rol Duzenlenemedi",
                    Tamamlandi = false,
                };
            return new DataResponse
            {
                Data = role,
                Tamamlandi = true,
                Mesaj = role.RoleAdi + " Rolu Duzenlendi",
            };

        }

        public DataResponse Delete(Role entity)
        {
            var role = _RoleDal.Delete(entity);
            if (role == null)
                return new DataResponse
                {
                    Mesaj = "Aradiginiz Rol Bulunamadi",
                    Tamamlandi = false
                };
            return new DataResponse
            {
                Data = role,
                Mesaj = "Rol Silindi",
                Tamamlandi = true
            };
        }
    }
}
