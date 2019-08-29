using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulama.Entities.Concrete.FluentApi
{
    public class RoleMap : EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            ToTable("BlogRolleri", "VerbiTeklifBlog");
            HasKey(i => i.ID);
            Property(i => i.RoleAdi).IsRequired().HasColumnType("nvarchar").HasMaxLength(10);

            #region Relations



            HasMany(i => i.Kullanicilar)
                .WithMany(i => i.Roller)
                .Map(i =>
                {
                    i.MapLeftKey("RoleID");
                    i.MapRightKey("BlogUserID");
                    i.ToTable("KullaniciRolIliskileri", "VerbiTeklifBlog");
                });



            #endregion
        }
    }
}
