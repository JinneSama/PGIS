namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InformationSystems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DatePublished = c.DateTime(),
                        Description = c.String(),
                        ProductName = c.String(),
                        DownloadURL = c.String(),
                        PublisherName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ISImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileName = c.String(),
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
                        OFMISId = c.Long(nullable: false),
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
            DropForeignKey("dbo.ISImages", "InformationSystemId", "dbo.InformationSystems");
            DropIndex("dbo.UserAccessInformationSystems", new[] { "InformationSystem_Id" });
            DropIndex("dbo.UserAccessInformationSystems", new[] { "UserAccess_Id" });
            DropIndex("dbo.ISImages", new[] { "InformationSystemId" });
            DropTable("dbo.UserAccessInformationSystems");
            DropTable("dbo.UserAccesses");
            DropTable("dbo.ISImages");
            DropTable("dbo.InformationSystems");
        }
    }
}
