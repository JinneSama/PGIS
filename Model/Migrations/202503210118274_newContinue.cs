namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newContinue : DbMigration
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
                        OFMISId = c.String(),
                        InfoSystemId = c.Int(),
                        UserAccessId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.InformationSystems", t => t.InfoSystemId)
                .ForeignKey("dbo.UserAccesses", t => t.UserAccessId)
                .Index(t => t.InfoSystemId)
                .Index(t => t.UserAccessId);
            
            AddColumn("dbo.InformationSystems", "AbbrevName", c => c.String());
            AddColumn("dbo.InformationSystems", "AcrName", c => c.String());
            AddColumn("dbo.InformationSystems", "SolutionName", c => c.String());
            AddColumn("dbo.InformationSystems", "Creator", c => c.String());
            AddColumn("dbo.InformationSystems", "IconPath", c => c.String());
            AddColumn("dbo.InformationSystems", "IconPathSecurityStamp", c => c.String());
            AddColumn("dbo.InformationSystems", "IsDefaultApp", c => c.Boolean());
            AddColumn("dbo.ISImages", "SecurityStamp", c => c.String());
            AddColumn("dbo.UserAccesses", "UserRole", c => c.Int(nullable: false));
            AlterColumn("dbo.UserAccesses", "OFMISId", c => c.String());
            DropColumn("dbo.InformationSystems", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.InformationSystems", "Name", c => c.String());
            DropForeignKey("dbo.AppUsages", "UserAccessId", "dbo.UserAccesses");
            DropForeignKey("dbo.AppUsages", "InfoSystemId", "dbo.InformationSystems");
            DropIndex("dbo.AppUsages", new[] { "UserAccessId" });
            DropIndex("dbo.AppUsages", new[] { "InfoSystemId" });
            AlterColumn("dbo.UserAccesses", "OFMISId", c => c.Long(nullable: false));
            DropColumn("dbo.UserAccesses", "UserRole");
            DropColumn("dbo.ISImages", "SecurityStamp");
            DropColumn("dbo.InformationSystems", "IsDefaultApp");
            DropColumn("dbo.InformationSystems", "IconPathSecurityStamp");
            DropColumn("dbo.InformationSystems", "IconPath");
            DropColumn("dbo.InformationSystems", "Creator");
            DropColumn("dbo.InformationSystems", "SolutionName");
            DropColumn("dbo.InformationSystems", "AcrName");
            DropColumn("dbo.InformationSystems", "AbbrevName");
            DropTable("dbo.AppUsages");
        }
    }
}
