namespace Machine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DisabledOneToMany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MachineTypes",
                c => new
                    {
                        TypeId = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.TypeId);
            
            AddColumn("dbo.Maches", "MachineType_TypeId", c => c.Int());
            CreateIndex("dbo.Maches", "MachineType_TypeId");
            AddForeignKey("dbo.Maches", "MachineType_TypeId", "dbo.MachineTypes", "TypeId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Maches", "MachineType_TypeId", "dbo.MachineTypes");
            DropIndex("dbo.Maches", new[] { "MachineType_TypeId" });
            DropColumn("dbo.Maches", "MachineType_TypeId");
            DropTable("dbo.MachineTypes");
        }
    }
}
