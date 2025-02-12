namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserRoles2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserAccesses", "OFMISId", c => c.String());
            DropColumn("dbo.UserAccesses", "Username");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserAccesses", "Username", c => c.String());
            AlterColumn("dbo.UserAccesses", "OFMISId", c => c.Long(nullable: false));
        }
    }
}
