using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogUygulama.Core.Entities.Concrete;

namespace BlogUygulama.Entities.Concrete
{
    public class Comment:Entity
    {
        public string YorumBaslik { get; set; }
        public string YorumIcerik { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime SonGuncellenmeTarihi { get; set; }
        public int BegeniSayisi { get; set; }
        public int BlogID { get; set; }
        [ForeignKey("BlogID")]
        public virtual Blog Blog { get; set; }

        public int BlogUserID { get; set; }
        [ForeignKey("BlogUserID")]
        public virtual BlogUser BlogUser { get; set; }
    }
}
