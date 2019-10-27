namespace TechnicalTestProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Calls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Insert_date = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CallSteps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParentId = c.Int(nullable: false),
                        Insert_date = c.DateTime(storeType: "date"),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Calls", t => t.ParentId, cascadeDelete: true)
                .Index(t => t.ParentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CallSteps", "ParentId", "dbo.Calls");
            DropIndex("dbo.CallSteps", new[] { "ParentId" });
            DropTable("dbo.CallSteps");
            DropTable("dbo.Calls");
        }
    }
}
