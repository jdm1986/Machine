namespace Machine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rebuild_initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Maches", "MachineMake", c => c.String());
            AlterColumn("dbo.Maches", "MachineModel", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Maches", "MachineModel", c => c.String(nullable: false, maxLength: 16));
            AlterColumn("dbo.Maches", "MachineMake", c => c.String(nullable: false, maxLength: 16));
        }
    }
}
