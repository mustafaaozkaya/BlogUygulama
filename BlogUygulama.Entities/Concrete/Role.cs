using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogUygulama.Core.Entities.Concrete;

namespace BlogUygulama.Entities.Concrete
{
    public class Role:Entity
    {
        public string RoleAdi { get; set; }
        public virtual List<BlogUser> Kullanicilar { get; set; }


    }
}
