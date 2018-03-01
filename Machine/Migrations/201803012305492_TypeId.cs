namespace Machine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TypeId : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Maches", name: "MachineType_TypeId", newName: "TypeId");
            RenameIndex(table: "dbo.Maches", name: "IX_MachineType_TypeId", newName: "IX_TypeId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Maches", name: "IX_TypeId", newName: "IX_MachineType_TypeId");
            RenameColumn(table: "dbo.Maches", name: "TypeId", newName: "MachineType_TypeId");
        }
    }
}
