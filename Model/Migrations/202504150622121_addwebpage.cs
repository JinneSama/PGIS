namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addwebpage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InformationSystems", "Webpage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.InformationSystems", "Webpage");
        }
    }
}
