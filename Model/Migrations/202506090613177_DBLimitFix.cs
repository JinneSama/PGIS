namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBLimitFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AppUsages", "SecurityStamp", c => c.String(maxLength: 128));
            AlterColumn("dbo.AppUsages", "OFMISId", c => c.String(maxLength: 128));
            AlterColumn("dbo.InformationSystems", "AbbrevName", c => c.String(maxLength: 128));
            AlterColumn("dbo.InformationSystems", "AcrName", c => c.String(maxLength: 128));
            AlterColumn("dbo.InformationSystems", "Description", c => c.String(maxLength: 128));
            AlterColumn("dbo.InformationSystems", "ProductName", c => c.String(maxLength: 128));
            AlterColumn("dbo.InformationSystems", "DownloadURL", c => c.String(maxLength: 128));
            AlterColumn("dbo.InformationSystems", "PublisherName", c => c.String(maxLength: 128));
            AlterColumn("dbo.InformationSystems", "SolutionName", c => c.String(maxLength: 128));
            AlterColumn("dbo.InformationSystems", "Creator", c => c.String(maxLength: 128));
            AlterColumn("dbo.InformationSystems", "Webpage", c => c.String(maxLength: 128));
            AlterColumn("dbo.InformationSystems", "IconPath", c => c.String(maxLength: 128));
            AlterColumn("dbo.InformationSystems", "IconPathSecurityStamp", c => c.String(maxLength: 128));
            AlterColumn("dbo.ISImages", "FileName", c => c.String(maxLength: 128));
            AlterColumn("dbo.ISImages", "SecurityStamp", c => c.String(maxLength: 128));
            AlterColumn("dbo.UserAccesses", "OFMISId", c => c.String(maxLength: 128));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserAccesses", "OFMISId", c => c.String());
            AlterColumn("dbo.ISImages", "SecurityStamp", c => c.String());
            AlterColumn("dbo.ISImages", "FileName", c => c.String());
            AlterColumn("dbo.InformationSystems", "IconPathSecurityStamp", c => c.String());
            AlterColumn("dbo.InformationSystems", "IconPath", c => c.String());
            AlterColumn("dbo.InformationSystems", "Webpage", c => c.String());
            AlterColumn("dbo.InformationSystems", "Creator", c => c.String());
            AlterColumn("dbo.InformationSystems", "SolutionName", c => c.String());
            AlterColumn("dbo.InformationSystems", "PublisherName", c => c.String());
            AlterColumn("dbo.InformationSystems", "DownloadURL", c => c.String());
            AlterColumn("dbo.InformationSystems", "ProductName", c => c.String());
            AlterColumn("dbo.InformationSystems", "Description", c => c.String());
            AlterColumn("dbo.InformationSystems", "AcrName", c => c.String());
            AlterColumn("dbo.InformationSystems", "AbbrevName", c => c.String());
            AlterColumn("dbo.AppUsages", "OFMISId", c => c.String());
            AlterColumn("dbo.AppUsages", "SecurityStamp", c => c.String());
        }
    }
}
