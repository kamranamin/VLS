namespace VLS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ab : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Username", c => c.String());
        }
    }
}
