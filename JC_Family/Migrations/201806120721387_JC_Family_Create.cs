namespace JC_Family.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JC_Family_Create : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Photos", "Title", c => c.String(nullable: false, maxLength: 60, storeType: "nvarchar"));
            AlterColumn("dbo.Photos", "CreatTime", c => c.String(nullable: false, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Photos", "CreatTime", c => c.String(unicode: false));
            AlterColumn("dbo.Photos", "Title", c => c.String(unicode: false));
        }
    }
}
