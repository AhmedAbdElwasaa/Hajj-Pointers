namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makeTheTableStatistisOfSectors : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StatisticsOfSectors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Office_Name = c.String(),
                        Sector = c.String(),
                        SectorType = c.String(),
                        TargetNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Type_Of_Sector", "ActualNumber", c => c.Int(nullable: false));
            DropColumn("dbo.Type_Of_Sector", "TargetNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Type_Of_Sector", "TargetNumber", c => c.Int());
            AlterColumn("dbo.Type_Of_Sector", "ActualNumber", c => c.Int());
            DropTable("dbo.StatisticsOfSectors");
        }
    }
}
