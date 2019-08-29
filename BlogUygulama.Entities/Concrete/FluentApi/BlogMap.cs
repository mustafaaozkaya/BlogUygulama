using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulama.Entities.Concrete.FluentApi
{
    public class BlogMap : EntityTypeConfiguration<Blog>
    {
        public BlogMap()
        {
            ToTable("Bloglar", "VerbiTeklifBlog");
            HasKey(i => i.ID);
            Property(i => i.Baslik).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(i => i.Icerik).IsRequired().HasColumnType("nvarchar");
            Property(i => i.Anasayfadami).IsOptional().HasColumnType("bit");
            Property(i => i.Onaylandimi).IsOptional().HasColumnType("bit");
            Property(i => i.BegenilmeSayisi).IsOptional().HasColumnType("int");
            Property(i => i.EklenmeTarihi).IsRequired().HasColumnType("datetime");
            Property(i => i.SonGuncellenmeTarihi).IsRequired().HasColumnType("datetime");


            #region Relations

            HasRequired(i => i.BlogUser)
                .WithMany(i => i.Bloglar)
                .HasForeignKey(i => i.BlogUserID);

            HasRequired(i => i.Category)
                .WithMany(i => i.Bloglar)
                .HasForeignKey(i => i.CategoryID);




            //HasMany(i => i.Etiketler)
            //    .WithMany(i => i.Bloglar)
            //    .Map(i =>
            //    {
            //        i.MapLeftKey("BlogID");
            //        i.MapRightKey("BlogTagID");
            //        i.ToTable("BlogTagBlogRelation");
            //    });

            #endregion

        }
    }
}
