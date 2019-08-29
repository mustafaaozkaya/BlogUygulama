using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlogUygulama.Entities.Concrete.FluentApi
{
    public class BlogTagMap:EntityTypeConfiguration<BlogTag>
    {
        public BlogTagMap()
        {
            ToTable("BlogEtiketleri", "VerbiTeklifBlog");
            HasKey(i => i.ID);
            Property(i => i.Etiket).IsRequired().HasColumnType("nvarchar").HasMaxLength(20);

            #region Relations


            HasMany(i => i.Bloglar)
                .WithMany(i => i.Etiketler)
                .Map(i =>
                {
                    i.MapLeftKey("BlogTagID");
                    i.MapRightKey("BlogID");
                    i.ToTable("BlogEtiketIliskileri", "VerbiTeklifBlog");
                });


            //HasRequired(i => i.BlogTagBlogRelation)
            //    .WithMany(i => i.BlogEtiketleri)
            //    .HasForeignKey(i => i.BlogTagBlogRelationID);

            #endregion



        }
    }
}
