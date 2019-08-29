using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulama.Entities.Concrete.FluentApi
{
    public class CategoryMap: EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {

            ToTable("Kategoriler", "VerbiTeklifBlog");
            HasKey(i => i.ID);
            Property(i => i.KategoriAdi).IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(i => i.EklenmeZamani).IsRequired().HasColumnType("datetime");

        }
    }
}
