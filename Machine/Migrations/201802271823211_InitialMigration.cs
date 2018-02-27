namespace Machine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Maches",
                c => new
                    {
                        MachineId = c.Int(nullable: false, identity: true),
                        MachineMake = c.String(),
                        MachineModel = c.String(),
                        Hours = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MachineId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Maches");
        }
    }
}
