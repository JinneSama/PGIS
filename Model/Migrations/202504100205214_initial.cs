namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
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
            
            CreateTable(
                "dbo.InformationSystems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AbbrevName = c.String(),
                        AcrName = c.String(),
                        DatePublished = c.DateTime(),
                        Description = c.String(),
                        ProductName = c.String(),
                        DownloadURL = c.String(),
                        PublisherName = c.String(),
                        SolutionName = c.String(),
                        Creator = c.String(),
                        IconPath = c.String(),
                        IconPathSecurityStamp = c.String(),
                        IsDefaultApp = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ISImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileName = c.String(),
                        SecurityStamp = c.String(),
                        FileOrder = c.Int(nullable: false),
                        InformationSystemId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.InformationSystems", t => t.InformationSystemId)
                .Index(t => t.InformationSystemId);
            
            CreateTable(
                "dbo.UserAccesses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OFMISId = c.String(),
                        UserRole = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserAccessInformationSystems",
                c => new
                    {
                        UserAccess_Id = c.Int(nullable: false),
                        InformationSystem_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserAccess_Id, t.InformationSystem_Id })
                .ForeignKey("dbo.UserAccesses", t => t.UserAccess_Id, cascadeDelete: true)
                .ForeignKey("dbo.InformationSystems", t => t.InformationSystem_Id, cascadeDelete: true)
                .Index(t => t.UserAccess_Id)
                .Index(t => t.InformationSystem_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserAccessInformationSystems", "InformationSystem_Id", "dbo.InformationSystems");
            DropForeignKey("dbo.UserAccessInformationSystems", "UserAccess_Id", "dbo.UserAccesses");
            DropForeignKey("dbo.AppUsages", "UserAccessId", "dbo.UserAccesses");
            DropForeignKey("dbo.ISImages", "InformationSystemId", "dbo.InformationSystems");
            DropForeignKey("dbo.AppUsages", "InfoSystemId", "dbo.InformationSystems");
            DropIndex("dbo.UserAccessInformationSystems", new[] { "InformationSystem_Id" });
            DropIndex("dbo.UserAccessInformationSystems", new[] { "UserAccess_Id" });
            DropIndex("dbo.ISImages", new[] { "InformationSystemId" });
            DropIndex("dbo.AppUsages", new[] { "UserAccessId" });
            DropIndex("dbo.AppUsages", new[] { "InfoSystemId" });
            DropTable("dbo.UserAccessInformationSystems");
            DropTable("dbo.UserAccesses");
            DropTable("dbo.ISImages");
            DropTable("dbo.InformationSystems");
            DropTable("dbo.AppUsages");
        }
    }
}
