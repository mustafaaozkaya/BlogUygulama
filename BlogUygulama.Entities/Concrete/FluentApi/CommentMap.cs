using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulama.Entities.Concrete.FluentApi
{
    public class CommentMap: EntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            ToTable("Yorumlar", "VerbiTeklifBlog");
            HasKey(i => i.ID);
            Property(i => i.YorumBaslik).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(i => i.YorumIcerik).IsRequired().HasColumnType("nvarchar").HasMaxLength(200);
            Property(i => i.EklenmeTarihi).IsRequired().HasColumnType("datetime");
            Property(i => i.SonGuncellenmeTarihi).IsRequired().HasColumnType("datetime");
           
            #region Relations

            HasRequired(i => i.BlogUser)
                .WithMany(i => i.Yorumlar)
                .HasForeignKey(i => i.BlogUserID).WillCascadeOnDelete(false);

            HasRequired(i => i.Blog)
                .WithMany(i => i.Yorumlar)
                .HasForeignKey(i => i.BlogID).WillCascadeOnDelete(false);
            #endregion


        }
    }
}
