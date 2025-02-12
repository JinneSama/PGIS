namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedData5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InformationSystems", "IconPath", c => c.String());
            AddColumn("dbo.InformationSystems", "IconPathSecurityStamp", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.InformationSystems", "IconPathSecurityStamp");
            DropColumn("dbo.InformationSystems", "IconPath");
        }
    }
}
