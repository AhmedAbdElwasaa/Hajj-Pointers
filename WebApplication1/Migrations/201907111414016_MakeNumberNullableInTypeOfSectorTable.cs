namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeNumberNullableInTypeOfSectorTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Type_Of_Sector", "TargetNumber", c => c.Int());
            AlterColumn("dbo.Type_Of_Sector", "ActualNumber", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Type_Of_Sector", "ActualNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Type_Of_Sector", "TargetNumber", c => c.Int(nullable: false));
        }
    }
}
