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
            context.Machines.AddOrUpdate(
                m => m.MachineId,
                new Mach { MachineId = 1, MachineMake = "CAT", MachineModel = "D3", Hours = 500 },
                new Mach { MachineId = 2, MachineMake = "CAT", MachineModel = "D4", Hours = 1500 },
                new Mach { MachineId = 3, MachineMake = "CAT", MachineModel = "D5", Hours = 2500 },
                new Mach { MachineId = 4, MachineMake = "CAT", MachineModel = "D6", Hours = 3500 },
                new Mach { MachineId = 5, MachineMake = "CAT", MachineModel = "D8", Hours = 4500 },
                new Mach { MachineId = 6, MachineMake = "CAT", MachineModel = "D9", Hours = 6500 }


                );
        }
    }
}
