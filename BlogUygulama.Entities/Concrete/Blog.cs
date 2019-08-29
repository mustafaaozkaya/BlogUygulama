using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogUygulama.Core.Entities.Concrete;

namespace BlogUygulama.Entities.Concrete
{
    public class Blog:Entity
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string Resim { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime SonGuncellenmeTarihi { get; set; }
        public bool Onaylandimi { get; set; }
        public bool Anasayfadami { get; set; }
        public int BegenilmeSayisi { get; set; }
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }

        public int BlogUserID { get; set; }
        [ForeignKey("BlogUserID")]
        public virtual BlogUser BlogUser { get; set; }

        public virtual List<Comment> Yorumlar { get; set; }

        public virtual List<BlogTag> Etiketler { get; set; }
    }
}
