namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserRoles : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InformationSystems", "IsDefaultApp", c => c.Boolean());
            AddColumn("dbo.UserAccesses", "UserRole", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserAccesses", "UserRole");
            DropColumn("dbo.InformationSystems", "IsDefaultApp");
        }
    }
}
