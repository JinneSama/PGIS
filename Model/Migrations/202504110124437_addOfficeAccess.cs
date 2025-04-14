namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addOfficeAccess : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OfficeAccesses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OfficeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OfficeAccessInformationSystems",
                c => new
                    {
                        OfficeAccess_Id = c.Int(nullable: false),
                        InformationSystem_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.OfficeAccess_Id, t.InformationSystem_Id })
                .ForeignKey("dbo.OfficeAccesses", t => t.OfficeAccess_Id, cascadeDelete: true)
                .ForeignKey("dbo.InformationSystems", t => t.InformationSystem_Id, cascadeDelete: true)
                .Index(t => t.OfficeAccess_Id)
                .Index(t => t.InformationSystem_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OfficeAccessInformationSystems", "InformationSystem_Id", "dbo.InformationSystems");
            DropForeignKey("dbo.OfficeAccessInformationSystems", "OfficeAccess_Id", "dbo.OfficeAccesses");
            DropIndex("dbo.OfficeAccessInformationSystems", new[] { "InformationSystem_Id" });
            DropIndex("dbo.OfficeAccessInformationSystems", new[] { "OfficeAccess_Id" });
            DropTable("dbo.OfficeAccessInformationSystems");
            DropTable("dbo.OfficeAccesses");
        }
    }
}
