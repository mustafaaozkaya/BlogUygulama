using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogUygulama.Business.Abstract;
using BlogUygulama.Business.Concrete;
using BlogUygulama.DataAccess.Abstract;
using BlogUygulama.DataAccess.Concrete;
using BlogUygulama.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace BlogUygulama.Business.DepandencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            #region DataAccessBindings
            Bind<IBlogDal>().To<EfBlogDal>();
            Bind<ICategoryDal>().To<EfCategoryDal>();
            Bind<IBlogUserDal>().To<EfBlogUserDal>();
            Bind<ICommentDal>().To<EfCommentDal>();
            Bind<IRoleDal>().To<EfRoleDal>();
            Bind<IBlogTagDal>().To<EfBlogTagDal>();

            #endregion

            #region ServiceBindings
            Bind<IBlogService>().To<BlogManager>();
            Bind<ICategoryService>().To<CategoryManager>();
            Bind<IUserService>().To<UserManager>();
            Bind<ICommentService>().To<CommentManager>();
            Bind<IRoleService>().To<RoleManager>();
            Bind<IBlogService>().To<BlogManager>();

            #endregion

            #region DatabaseBindings
            Bind<DbContext>().To<BlogContext>();
           
            #endregion

        }
    }
}
