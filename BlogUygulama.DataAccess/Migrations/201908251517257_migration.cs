namespace BlogUygulama.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "VerbiTeklifBlog.Bloglar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Baslik = c.String(nullable: false, maxLength: 50),
                        Icerik = c.String(nullable: false, maxLength: 4000),
                        Resim = c.String(),
                        EklenmeTarihi = c.DateTime(nullable: false),
                        SonGuncellenmeTarihi = c.DateTime(nullable: false),
                        Onaylandimi = c.Boolean(),
                        Anasayfadami = c.Boolean(),
                        BegenilmeSayisi = c.Int(),
                        CategoryID = c.Int(nullable: false),
                        BlogUserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("VerbiTeklifBlog.Kullanicilar", t => t.BlogUserID, cascadeDelete: true)
                .ForeignKey("VerbiTeklifBlog.Kategoriler", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID)
                .Index(t => t.BlogUserID);
            
            CreateTable(
                "VerbiTeklifBlog.Kullanicilar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(nullable: false, maxLength: 20),
                        Sifre = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 4000),
                        Ad = c.String(maxLength: 20),
                        Soyad = c.String(maxLength: 20),
                        Fotograf = c.String(maxLength: 4000),
                        AktifMi = c.Boolean(),
                        AktiflikGuid = c.Guid(),
                        GirisDurumu = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "VerbiTeklifBlog.BlogRolleri",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleAdi = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "VerbiTeklifBlog.Yorumlar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        YorumBaslik = c.String(nullable: false, maxLength: 50),
                        YorumIcerik = c.String(nullable: false, maxLength: 200),
                        EklenmeTarihi = c.DateTime(nullable: false),
                        SonGuncellenmeTarihi = c.DateTime(nullable: false),
                        BegeniSayisi = c.Int(nullable: false),
                        BlogID = c.Int(nullable: false),
                        BlogUserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("VerbiTeklifBlog.Bloglar", t => t.BlogID)
                .ForeignKey("VerbiTeklifBlog.Kullanicilar", t => t.BlogUserID)
                .Index(t => t.BlogID)
                .Index(t => t.BlogUserID);
            
            CreateTable(
                "VerbiTeklifBlog.Kategoriler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(nullable: false, maxLength: 20),
                        EklenmeZamani = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "VerbiTeklifBlog.BlogEtiketleri",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Etiket = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "VerbiTeklifBlog.KullaniciRolIliskileri",
                c => new
                    {
                        RoleID = c.Int(nullable: false),
                        BlogUserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoleID, t.BlogUserID })
                .ForeignKey("VerbiTeklifBlog.BlogRolleri", t => t.RoleID, cascadeDelete: true)
                .ForeignKey("VerbiTeklifBlog.Kullanicilar", t => t.BlogUserID, cascadeDelete: true)
                .Index(t => t.RoleID)
                .Index(t => t.BlogUserID);
            
            CreateTable(
                "VerbiTeklifBlog.BlogEtiketIliskileri",
                c => new
                    {
                        BlogTagID = c.Int(nullable: false),
                        BlogID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.BlogTagID, t.BlogID })
                .ForeignKey("VerbiTeklifBlog.BlogEtiketleri", t => t.BlogTagID, cascadeDelete: true)
                .ForeignKey("VerbiTeklifBlog.Bloglar", t => t.BlogID, cascadeDelete: true)
                .Index(t => t.BlogTagID)
                .Index(t => t.BlogID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("VerbiTeklifBlog.BlogEtiketIliskileri", "BlogID", "VerbiTeklifBlog.Bloglar");
            DropForeignKey("VerbiTeklifBlog.BlogEtiketIliskileri", "BlogTagID", "VerbiTeklifBlog.BlogEtiketleri");
            DropForeignKey("VerbiTeklifBlog.Bloglar", "CategoryID", "VerbiTeklifBlog.Kategoriler");
            DropForeignKey("VerbiTeklifBlog.Bloglar", "BlogUserID", "VerbiTeklifBlog.Kullanicilar");
            DropForeignKey("VerbiTeklifBlog.Yorumlar", "BlogUserID", "VerbiTeklifBlog.Kullanicilar");
            DropForeignKey("VerbiTeklifBlog.Yorumlar", "BlogID", "VerbiTeklifBlog.Bloglar");
            DropForeignKey("VerbiTeklifBlog.KullaniciRolIliskileri", "BlogUserID", "VerbiTeklifBlog.Kullanicilar");
            DropForeignKey("VerbiTeklifBlog.KullaniciRolIliskileri", "RoleID", "VerbiTeklifBlog.BlogRolleri");
            DropIndex("VerbiTeklifBlog.BlogEtiketIliskileri", new[] { "BlogID" });
            DropIndex("VerbiTeklifBlog.BlogEtiketIliskileri", new[] { "BlogTagID" });
            DropIndex("VerbiTeklifBlog.KullaniciRolIliskileri", new[] { "BlogUserID" });
            DropIndex("VerbiTeklifBlog.KullaniciRolIliskileri", new[] { "RoleID" });
            DropIndex("VerbiTeklifBlog.Yorumlar", new[] { "BlogUserID" });
            DropIndex("VerbiTeklifBlog.Yorumlar", new[] { "BlogID" });
            DropIndex("VerbiTeklifBlog.Bloglar", new[] { "BlogUserID" });
            DropIndex("VerbiTeklifBlog.Bloglar", new[] { "CategoryID" });
            DropTable("VerbiTeklifBlog.BlogEtiketIliskileri");
            DropTable("VerbiTeklifBlog.KullaniciRolIliskileri");
            DropTable("VerbiTeklifBlog.BlogEtiketleri");
            DropTable("VerbiTeklifBlog.Kategoriler");
            DropTable("VerbiTeklifBlog.Yorumlar");
            DropTable("VerbiTeklifBlog.BlogRolleri");
            DropTable("VerbiTeklifBlog.Kullanicilar");
            DropTable("VerbiTeklifBlog.Bloglar");
        }
    }
}
