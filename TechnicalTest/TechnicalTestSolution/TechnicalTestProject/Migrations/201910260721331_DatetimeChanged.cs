namespace TechnicalTestProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatetimeChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Calls", "Insert_date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CallSteps", "Insert_date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CallSteps", "Insert_date", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.Calls", "Insert_date", c => c.DateTime(storeType: "date"));
        }
    }
}
