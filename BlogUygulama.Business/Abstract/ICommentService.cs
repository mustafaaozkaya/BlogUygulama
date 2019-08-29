using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogUygulama.Core.Entities.Concrete;
using BlogUygulama.Entities.Concrete;

namespace BlogUygulama.Business.Abstract
{
    public interface ICommentService
    {
        DataResponse GetList();
        DataResponse Get(int id);
        DataResponse Add(Comment entity);
        DataResponse Update(Comment entity);
        DataResponse Delete(Comment entity);
    }
}
