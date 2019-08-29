using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogUygulama.Core.Entities.Concrete;

namespace BlogUygulama.Entities.Concrete
{
    public class BlogTag : Entity
    {
        public string Etiket { get; set; }
        public virtual List<Blog> Bloglar { get; set; }




    }
}
