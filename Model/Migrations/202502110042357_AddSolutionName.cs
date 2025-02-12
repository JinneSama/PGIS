namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSolutionName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InformationSystems", "SolutionName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.InformationSystems", "SolutionName");
        }
    }
}
