using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogUygulama.Core.DataAccess;
using BlogUygulama.Entities.Concrete;

namespace BlogUygulama.DataAccess.Abstract
{
    public interface ICategoryDal:IRepositoryBase<Category>
    {
    }
}
