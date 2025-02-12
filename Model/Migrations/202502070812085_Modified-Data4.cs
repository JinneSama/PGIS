namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedData4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ISImages", "SecurityStamp", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ISImages", "SecurityStamp");
        }
    }
}
