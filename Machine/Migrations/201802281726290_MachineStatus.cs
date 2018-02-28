namespace Machine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MachineStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Maches", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Maches", "Status");
        }
    }
}
