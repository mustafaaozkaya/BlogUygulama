using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogUygulama.Core.Entities.Concrete;

namespace BlogUygulama.Entities.Concrete
{
    public class BlogUserRoleRelation:Entity
    {


        public int BlogUserID { get; set; }

        [ForeignKey("BlogUserID")]
        public virtual BlogUser BlogUser { get; set; }
        public int RoleID { get; set; }

        [ForeignKey("RoleID")]
        public virtual Role Role { get; set; }
    }
}
