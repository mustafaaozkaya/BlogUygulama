using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogUygulama.Core.Entities.Concrete;
using BlogUygulama.Entities.Concrete;

namespace BlogUygulama.Business.Abstract
{
    public interface ICategoryService
    {
        DataResponse GetList();
        DataResponse Get(int id);
        DataResponse Add(Category entity);
        DataResponse Update(Category entity);
        DataResponse Delete(Category entity);
    }
}
