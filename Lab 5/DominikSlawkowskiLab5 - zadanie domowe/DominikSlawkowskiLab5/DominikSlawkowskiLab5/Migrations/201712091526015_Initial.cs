namespace DominikSlawkowskiLab5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Djs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Year = c.Int(nullable: false),
                        BpmAmount = c.String(),
                        DjId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Djs", t => t.DjId, cascadeDelete: true)
                .Index(t => t.DjId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Genres", "DjId", "dbo.Djs");
            DropIndex("dbo.Genres", new[] { "DjId" });
            DropTable("dbo.Genres");
            DropTable("dbo.Djs");
        }
    }
}
