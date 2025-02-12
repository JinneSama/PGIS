namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedData3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppUsages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccessedDate = c.DateTime(),
                        AccessType = c.Int(nullable: false),
                        SecurityStamp = c.String(),
                        InfoSystemId = c.Int(nullable: false),
                        UserAccessId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.InformationSystems", t => t.InfoSystemId, cascadeDelete: true)
                .ForeignKey("dbo.UserAccesses", t => t.UserAccessId, cascadeDelete: true)
                .Index(t => t.InfoSystemId)
                .Index(t => t.UserAccessId);
            
            AddColumn("dbo.UserAccesses", "Username", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AppUsages", "UserAccessId", "dbo.UserAccesses");
            DropForeignKey("dbo.AppUsages", "InfoSystemId", "dbo.InformationSystems");
            DropIndex("dbo.AppUsages", new[] { "UserAccessId" });
            DropIndex("dbo.AppUsages", new[] { "InfoSystemId" });
            DropColumn("dbo.UserAccesses", "Username");
            DropTable("dbo.AppUsages");
        }
    }
}
