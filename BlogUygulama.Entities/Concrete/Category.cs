using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using BlogUygulama.Core.Entities.Concrete;

namespace BlogUygulama.Entities.Concrete
{
    public class Category:Entity
    {
        public string KategoriAdi { get; set; }
        public DateTime EklenmeZamani { get; set; }
        public virtual List<Blog> Bloglar{ get; set; }
    }
}
