using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogUygulama.Core.Entities.Concrete;

namespace BlogUygulama.Entities.Concrete
{
    public class BlogTagBlogRelation : Entity
    {


        public int BlogID { get; set; }

        [ForeignKey("BlogID")]
        public virtual Blog Blog { get; set; }
        public int BlogTagID { get; set; }

        [ForeignKey("BlogTagID")]
        public virtual BlogTag BlogTag { get; set; }
    }
}
