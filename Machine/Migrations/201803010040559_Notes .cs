namespace Machine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Notes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Maches", "Notes", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Maches", "Notes");
        }
    }
}
