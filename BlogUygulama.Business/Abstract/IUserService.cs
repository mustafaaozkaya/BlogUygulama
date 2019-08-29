using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogUygulama.Core.Entities.Concrete;
using BlogUygulama.Entities.Concrete;

namespace BlogUygulama.Business.Abstract
{
    public interface IUserService
    {
        DataResponse GetList();
        DataResponse Get(int id);
        DataResponse Add(BlogUser entity);
        DataResponse Update(BlogUser entity);
        DataResponse Delete(BlogUser entity);
    }
}
