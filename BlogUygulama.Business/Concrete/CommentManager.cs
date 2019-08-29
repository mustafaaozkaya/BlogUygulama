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
    public class CommentManager:ICommentService
    {
        private ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public DataResponse GetList()
        {
            var comment = _commentDal.GetList();
            if (comment == null)
                return new DataResponse
                {
                    Mesaj = "Aradiginiz Yorum Getirilemedi",
                    Tamamlandi = false
                };
            return new DataResponse
            {
                Data = comment,
                Mesaj = "Yorumlar Getirildi",
                Tamamlandi = true
            };

        }

        public DataResponse Get(int id)
        {
            var comment = _commentDal.Get(i => i.ID == id);
            if (comment == null)
                return new DataResponse
                {
                    Mesaj = "Aradiginiz Yorum Bulunamadi",
                    Tamamlandi = false
                };
            return new DataResponse
            {
                Data = comment,
                Mesaj = "Yorum Getirildi",
                Tamamlandi = true
            };
        }

        public DataResponse Add(Comment entity)
        {
            var comment = _commentDal.Add(entity);
            if (comment == null)
                return new DataResponse
                {
                    Mesaj = "Yorum Eklenemedi",
                    Tamamlandi = false,
                };
            return new DataResponse
            {
                Data = comment,
                Tamamlandi = true,
                Mesaj = comment.YorumBaslik + " Baslikli Yorum Eklendi",
            };
        }

        public DataResponse Update(Comment entity)
        {
            var comment = _commentDal.Update(entity);
            if (comment == null)
                return new DataResponse
                {
                    Mesaj = "Yorum Duzenlenemedi",
                    Tamamlandi = false,
                };
            return new DataResponse
            {
                Data = comment,
                Tamamlandi = true,
                Mesaj = comment.YorumBaslik + " Baslikli Yorum Duzenlendi",
            };

        }

        public DataResponse Delete(Comment entity)
        {
            var comment = _commentDal.Delete(entity);
            if (comment == null)
                return new DataResponse
                {
                    Mesaj = "Aradiginiz Yorum Bulunamadi",
                    Tamamlandi = false
                };
            return new DataResponse
            {
                Data = comment,
                Mesaj = "Yorum Silindi",
                Tamamlandi = true
            };
        }
    }
}
