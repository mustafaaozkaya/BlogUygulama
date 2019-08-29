using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogUygulama.Entities.Concrete;
using BlogUygulama.Entities.Concrete.FluentApi;

namespace BlogUygulama.DataAccess.Concrete
{
    public class BlogContext:DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BlogUser> BlogUsers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<Role> Roles { get; set; }
        //public DbSet<BlogTagBlogRelation> BlogTagBlogRelations { get; set; }
        //public DbSet<BlogUserRoleRelation> BlogUserRoleRelations { get; set; }

        public BlogContext() : base("BlogDb")
        {
            Database.SetInitializer(new DataInitialize());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BlogMap());
            modelBuilder.Configurations.Add(new BlogUserMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new CommentMap());
            modelBuilder.Configurations.Add(new BlogTagMap());
            modelBuilder.Configurations.Add(new RoleMap());
           

        }
    }
}
