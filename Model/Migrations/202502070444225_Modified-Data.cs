namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InformationSystems", "AbbrevName", c => c.String());
            AddColumn("dbo.InformationSystems", "AcrName", c => c.String());
            DropColumn("dbo.InformationSystems", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.InformationSystems", "Name", c => c.String());
            DropColumn("dbo.InformationSystems", "AcrName");
            DropColumn("dbo.InformationSystems", "AbbrevName");
        }
    }
}
