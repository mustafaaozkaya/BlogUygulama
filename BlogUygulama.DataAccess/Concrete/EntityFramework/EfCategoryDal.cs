using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogUygulama.Core.DataAccess.EntityFramework;
using BlogUygulama.DataAccess.Abstract;
using BlogUygulama.Entities.Concrete;

namespace BlogUygulama.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfRepositoryBase<Category,BlogContext>,ICategoryDal
    {
    }
}
