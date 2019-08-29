using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogUygulama.Core.Entities.Concrete;

namespace BlogUygulama.Entities.Concrete
{
   public class BlogUser:Entity
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Email { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Fotograf { get; set; }
        public bool AktifMi { get; set; }
        public Guid AktiflikGuid { get; set; }
        public bool GirisDurumu { get; set; }
        public virtual List<Comment> Yorumlar { get; set; }
        public virtual List<Blog> Bloglar { get; set; }
        public virtual List<Role> Roller { get; set; }
    }
}
