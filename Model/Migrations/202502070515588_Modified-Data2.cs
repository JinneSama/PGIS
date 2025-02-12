namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedData2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InformationSystems", "Creator", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.InformationSystems", "Creator");
        }
    }
}
