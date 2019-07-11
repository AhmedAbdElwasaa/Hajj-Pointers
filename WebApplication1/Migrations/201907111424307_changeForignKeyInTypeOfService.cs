namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeForignKeyInTypeOfService : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Type_Of_Sector", "Sector_Id", "dbo.Sector");
            DropIndex("dbo.Type_Of_Sector", new[] { "Sector_Id" });
            AlterColumn("dbo.Type_Of_Sector", "Sector_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Type_Of_Sector", "Sector_Id");
            AddForeignKey("dbo.Type_Of_Sector", "Sector_Id", "dbo.Sector", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Type_Of_Sector", "Sector_Id", "dbo.Sector");
            DropIndex("dbo.Type_Of_Sector", new[] { "Sector_Id" });
            AlterColumn("dbo.Type_Of_Sector", "Sector_Id", c => c.Int());
            CreateIndex("dbo.Type_Of_Sector", "Sector_Id");
            AddForeignKey("dbo.Type_Of_Sector", "Sector_Id", "dbo.Sector", "Id");
        }
    }
}
