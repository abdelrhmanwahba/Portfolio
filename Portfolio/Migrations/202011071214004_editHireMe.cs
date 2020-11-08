namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editHireMe : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HireMes", "FroMailAddress", c => c.String(nullable: false));
            AlterColumn("dbo.HireMes", "Subject", c => c.String(nullable: false));
            AlterColumn("dbo.HireMes", "Message", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.HireMes", "Message", c => c.String());
            AlterColumn("dbo.HireMes", "Subject", c => c.String());
            DropColumn("dbo.HireMes", "FroMailAddress");
        }
    }
}
