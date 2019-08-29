using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulama.Entities.Concrete.FluentApi
{
   public class BlogUserMap: EntityTypeConfiguration<BlogUser>
    {
        public BlogUserMap()
        {
            ToTable("Kullanicilar", "VerbiTeklifBlog");
            HasKey(i => i.ID);
            Property(i => i.KullaniciAdi).IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(i => i.Sifre).IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(i => i.Email).IsRequired().HasColumnType("nvarchar");
            Property(i => i.Ad).IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(i => i.Soyad).IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(i => i.Fotograf).IsOptional().HasColumnType("nvarchar");
            Property(i => i.AktifMi).IsOptional().HasColumnType("bit");
            Property(i => i.AktiflikGuid).IsOptional().HasColumnType("uniqueidentifier");
            Property(i => i.GirisDurumu).IsOptional().HasColumnType("bit");

            #region Relations

            //HasRequired(i => i.BlogUserRoleRelation)
            //    .WithMany(i => i.BlogUsers)
            //    .HasForeignKey(i => i.BlogUserRoleRelationID);

            #endregion
        }
    }
}
