namespace Adminus.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniqueIndex : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Users", "Username", true);
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Users", "Username", true);
        }
    }
}
