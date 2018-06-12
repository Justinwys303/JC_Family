namespace JC_Family.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Creaters",
                c => new
                    {
                        CreaterId = c.Int(nullable: false, identity: true),
                        CreaterName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.CreaterId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Decription = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        PhotoId = c.Int(nullable: false, identity: true),
                        GenreId = c.Int(nullable: false),
                        CreaterId = c.Int(nullable: false),
                        Title = c.String(unicode: false),
                        CreatTime = c.String(unicode: false),
                        PhotoUrl = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.PhotoId)
                .ForeignKey("dbo.Creaters", t => t.CreaterId, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId)
                .Index(t => t.CreaterId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Photos", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.Photos", "CreaterId", "dbo.Creaters");
            DropIndex("dbo.Photos", new[] { "CreaterId" });
            DropIndex("dbo.Photos", new[] { "GenreId" });
            DropTable("dbo.Photos");
            DropTable("dbo.Genres");
            DropTable("dbo.Creaters");
        }
    }
}
