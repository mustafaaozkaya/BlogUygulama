using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BlogUygulama.Core.Entities.Abstract;

namespace BlogUygulama.Core.DataAccess
{
    public interface IRepositoryBase<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);

    }
}
