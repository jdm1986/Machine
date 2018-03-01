namespace Machine.Migrations
{
    using Machine.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Machine.MachineContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Machine.MachineContext context)
        {
            context.MachineTypes.AddOrUpdate(
                t => t.TypeId,
                new MachineType { TypeId = 0, TypeName = "Excavator" },
                new MachineType { TypeId = 1, TypeName = "Dozer" },
                new MachineType { TypeId = 2, TypeName = "Tractor" }
                );

            context.SaveChanges();

            context.Machines.AddOrUpdate(
                m => m.MachineId,
                new Mach { MachineId = 1, MachineNum = 345, MachineMake = "CAT", MachineModel = "D3", Hours = 500, Status = false, TypeId = 1},
                new Mach { MachineId = 2, MachineNum = 346, MachineMake = "CAT", MachineModel = "D4", Hours = 1500, Status = false, TypeId = 1},
                new Mach { MachineId = 3, MachineNum = 347, MachineMake = "CAT", MachineModel = "D5", Hours = 2500, Status = false, TypeId = 1},
                new Mach { MachineId = 4, MachineNum = 454, MachineMake = "CAT", MachineModel = "D6", Hours = 3500, Status = false, TypeId = 1},
                new Mach { MachineId = 5, MachineNum = 734, MachineMake = "CAT", MachineModel = "D8", Hours = 4500, Status = false, TypeId = 1},
                new Mach { MachineId = 6, MachineNum = 823, MachineMake = "CAT", MachineModel = "D9", Hours = 6500, Status = false, TypeId = 1}


                );

            
        }
    }
}
