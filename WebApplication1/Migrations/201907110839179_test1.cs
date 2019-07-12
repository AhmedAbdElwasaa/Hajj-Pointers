namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Office", "Rate", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Office", "Rate", c => c.Int());
        }
    }
}
