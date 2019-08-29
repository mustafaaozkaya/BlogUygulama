using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogUygulama.Core.Entities.Concrete;
using BlogUygulama.Entities.Concrete;

namespace BlogUygulama.Business.Abstract
{
    public interface IRoleService
    {
        DataResponse GetList();
        DataResponse Get(int id);
        DataResponse Add(Role entity);
        DataResponse Update(Role entity);
        DataResponse Delete(Role entity);
    }
}
