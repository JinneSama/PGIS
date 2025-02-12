namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSolutionName2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AppUsages", "InfoSystemId", "dbo.InformationSystems");
            DropForeignKey("dbo.AppUsages", "UserAccessId", "dbo.UserAccesses");
            DropIndex("dbo.AppUsages", new[] { "InfoSystemId" });
            DropIndex("dbo.AppUsages", new[] { "UserAccessId" });
            AddColumn("dbo.AppUsages", "OFMISId", c => c.String());
            AlterColumn("dbo.AppUsages", "InfoSystemId", c => c.Int());
            AlterColumn("dbo.AppUsages", "UserAccessId", c => c.Int());
            CreateIndex("dbo.AppUsages", "InfoSystemId");
            CreateIndex("dbo.AppUsages", "UserAccessId");
            AddForeignKey("dbo.AppUsages", "InfoSystemId", "dbo.InformationSystems", "Id");
            AddForeignKey("dbo.AppUsages", "UserAccessId", "dbo.UserAccesses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AppUsages", "UserAccessId", "dbo.UserAccesses");
            DropForeignKey("dbo.AppUsages", "InfoSystemId", "dbo.InformationSystems");
            DropIndex("dbo.AppUsages", new[] { "UserAccessId" });
            DropIndex("dbo.AppUsages", new[] { "InfoSystemId" });
            AlterColumn("dbo.AppUsages", "UserAccessId", c => c.Int(nullable: false));
            AlterColumn("dbo.AppUsages", "InfoSystemId", c => c.Int(nullable: false));
            DropColumn("dbo.AppUsages", "OFMISId");
            CreateIndex("dbo.AppUsages", "UserAccessId");
            CreateIndex("dbo.AppUsages", "InfoSystemId");
            AddForeignKey("dbo.AppUsages", "UserAccessId", "dbo.UserAccesses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AppUsages", "InfoSystemId", "dbo.InformationSystems", "Id", cascadeDelete: true);
        }
    }
}
