namespace Machine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MachineNum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Maches", "MachineNum", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Maches", "MachineNum");
        }
    }
}
