namespace Machine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Photomigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Maches", "Photo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Maches", "Photo");
        }
    }
}
