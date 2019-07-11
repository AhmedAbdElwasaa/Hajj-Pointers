namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingSectorsAndTypeOfSectors : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Pointer_Services", newName: "Statistics_Services");
            CreateTable(
                "dbo.Sector",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Type_Of_Sector",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TargetNumber = c.Int(nullable: false),
                        ActualNumber = c.Int(nullable: false),
                        Sector_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sector", t => t.Sector_Id)
                .Index(t => t.Sector_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Type_Of_Sector", "Sector_Id", "dbo.Sector");
            DropIndex("dbo.Type_Of_Sector", new[] { "Sector_Id" });
            DropTable("dbo.Type_Of_Sector");
            DropTable("dbo.Sector");
            RenameTable(name: "dbo.Statistics_Services", newName: "Pointer_Services");
        }
    }
}
