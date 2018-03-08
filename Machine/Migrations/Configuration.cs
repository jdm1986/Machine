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
                t => t.TypeName,
                new MachineType { TypeId = 10, TypeName = "Excavator" },
                new MachineType { TypeId = 1, TypeName = "Dozer" },
                new MachineType { TypeId = 11, TypeName = "Tractor" }
                );

            context.SaveChanges();

            context.Machines.AddOrUpdate(
                m => m.MachineId,
                new Mach { MachineId = 1, MachineNum = 345, MachineMake = "CAT", MachineModel = "D3", Hours = 500, Status = false, TypeId = 10, Photo = "https://lh3.googleusercontent.com/VGy24V2LYBdMv6lG7Vhx30OSV3JpIQM3SaaPpXjv6ygnqtmLeUo4JUfhVpvEMhaqOjuyzJTVMt5t-iFhjqZR25SQLDLFeHqNjUZP9Ec_Cw1Lm28gYF8R6MazklGZ2qKWydV5JS9X6jFSLRG5Vk-vehl0Y9cMq80jKhjQc_nwy6BQXFKO5HiNJkMLqPA0NKA2nqnAjbBoNo4gtPmVPVWwH0Rn1-0mZ1MK1LWlLSRIR1eYBNabvgSwDUHf-o22_-OUXGl4j1d_FGCiJ3vj7izZAkeaDgL03NatJGURSy9r2krGpnnvQyyg8dBUfk0AnkJIYQ3A2GJGmIxwSO-NpGW69Au2IIK5G6BScHmfIo26R-DtA4ZnsheTvDutsdK26ld9GouWOT9sRpTT2lYZWM06RaRsheFIoog236CcRjE2RRcDA2YU3yyLADvyPKWUS-hUu2TnS8QfpT4iw7DeHn-ECImBRbBOS2utpk2aQ3dBlUGFTZiB8p_owPt0Ln3UA_1jp6_HkATRjMkdHCT9xaaDHulXYvcCPT0DzwTFpCSH_9Vzu0Kl1jq6dRuENRnQfQlkoOr0GibyrTCU7jE1h3DC80chBhUPY5flx5aFZss=w850-h637-no" },
                new Mach { MachineId = 2, MachineNum = 346, MachineMake = "CAT", MachineModel = "D4", Hours = 1500, Status = false, TypeId = 10, Photo = "https://lh3.googleusercontent.com/VGy24V2LYBdMv6lG7Vhx30OSV3JpIQM3SaaPpXjv6ygnqtmLeUo4JUfhVpvEMhaqOjuyzJTVMt5t-iFhjqZR25SQLDLFeHqNjUZP9Ec_Cw1Lm28gYF8R6MazklGZ2qKWydV5JS9X6jFSLRG5Vk-vehl0Y9cMq80jKhjQc_nwy6BQXFKO5HiNJkMLqPA0NKA2nqnAjbBoNo4gtPmVPVWwH0Rn1-0mZ1MK1LWlLSRIR1eYBNabvgSwDUHf-o22_-OUXGl4j1d_FGCiJ3vj7izZAkeaDgL03NatJGURSy9r2krGpnnvQyyg8dBUfk0AnkJIYQ3A2GJGmIxwSO-NpGW69Au2IIK5G6BScHmfIo26R-DtA4ZnsheTvDutsdK26ld9GouWOT9sRpTT2lYZWM06RaRsheFIoog236CcRjE2RRcDA2YU3yyLADvyPKWUS-hUu2TnS8QfpT4iw7DeHn-ECImBRbBOS2utpk2aQ3dBlUGFTZiB8p_owPt0Ln3UA_1jp6_HkATRjMkdHCT9xaaDHulXYvcCPT0DzwTFpCSH_9Vzu0Kl1jq6dRuENRnQfQlkoOr0GibyrTCU7jE1h3DC80chBhUPY5flx5aFZss=w850-h637-no" },
                new Mach { MachineId = 3, MachineNum = 347, MachineMake = "CAT", MachineModel = "D5", Hours = 2500, Status = false, TypeId = 10, Photo = "https://lh3.googleusercontent.com/VGy24V2LYBdMv6lG7Vhx30OSV3JpIQM3SaaPpXjv6ygnqtmLeUo4JUfhVpvEMhaqOjuyzJTVMt5t-iFhjqZR25SQLDLFeHqNjUZP9Ec_Cw1Lm28gYF8R6MazklGZ2qKWydV5JS9X6jFSLRG5Vk-vehl0Y9cMq80jKhjQc_nwy6BQXFKO5HiNJkMLqPA0NKA2nqnAjbBoNo4gtPmVPVWwH0Rn1-0mZ1MK1LWlLSRIR1eYBNabvgSwDUHf-o22_-OUXGl4j1d_FGCiJ3vj7izZAkeaDgL03NatJGURSy9r2krGpnnvQyyg8dBUfk0AnkJIYQ3A2GJGmIxwSO-NpGW69Au2IIK5G6BScHmfIo26R-DtA4ZnsheTvDutsdK26ld9GouWOT9sRpTT2lYZWM06RaRsheFIoog236CcRjE2RRcDA2YU3yyLADvyPKWUS-hUu2TnS8QfpT4iw7DeHn-ECImBRbBOS2utpk2aQ3dBlUGFTZiB8p_owPt0Ln3UA_1jp6_HkATRjMkdHCT9xaaDHulXYvcCPT0DzwTFpCSH_9Vzu0Kl1jq6dRuENRnQfQlkoOr0GibyrTCU7jE1h3DC80chBhUPY5flx5aFZss=w850-h637-no" },
                new Mach { MachineId = 4, MachineNum = 454, MachineMake = "CAT", MachineModel = "D6", Hours = 3500, Status = false, TypeId = 10, Photo = "https://lh3.googleusercontent.com/VGy24V2LYBdMv6lG7Vhx30OSV3JpIQM3SaaPpXjv6ygnqtmLeUo4JUfhVpvEMhaqOjuyzJTVMt5t-iFhjqZR25SQLDLFeHqNjUZP9Ec_Cw1Lm28gYF8R6MazklGZ2qKWydV5JS9X6jFSLRG5Vk-vehl0Y9cMq80jKhjQc_nwy6BQXFKO5HiNJkMLqPA0NKA2nqnAjbBoNo4gtPmVPVWwH0Rn1-0mZ1MK1LWlLSRIR1eYBNabvgSwDUHf-o22_-OUXGl4j1d_FGCiJ3vj7izZAkeaDgL03NatJGURSy9r2krGpnnvQyyg8dBUfk0AnkJIYQ3A2GJGmIxwSO-NpGW69Au2IIK5G6BScHmfIo26R-DtA4ZnsheTvDutsdK26ld9GouWOT9sRpTT2lYZWM06RaRsheFIoog236CcRjE2RRcDA2YU3yyLADvyPKWUS-hUu2TnS8QfpT4iw7DeHn-ECImBRbBOS2utpk2aQ3dBlUGFTZiB8p_owPt0Ln3UA_1jp6_HkATRjMkdHCT9xaaDHulXYvcCPT0DzwTFpCSH_9Vzu0Kl1jq6dRuENRnQfQlkoOr0GibyrTCU7jE1h3DC80chBhUPY5flx5aFZss=w850-h637-no" },
                new Mach { MachineId = 5, MachineNum = 734, MachineMake = "CAT", MachineModel = "D8", Hours = 4500, Status = false, TypeId = 10, Photo = "https://lh3.googleusercontent.com/VGy24V2LYBdMv6lG7Vhx30OSV3JpIQM3SaaPpXjv6ygnqtmLeUo4JUfhVpvEMhaqOjuyzJTVMt5t-iFhjqZR25SQLDLFeHqNjUZP9Ec_Cw1Lm28gYF8R6MazklGZ2qKWydV5JS9X6jFSLRG5Vk-vehl0Y9cMq80jKhjQc_nwy6BQXFKO5HiNJkMLqPA0NKA2nqnAjbBoNo4gtPmVPVWwH0Rn1-0mZ1MK1LWlLSRIR1eYBNabvgSwDUHf-o22_-OUXGl4j1d_FGCiJ3vj7izZAkeaDgL03NatJGURSy9r2krGpnnvQyyg8dBUfk0AnkJIYQ3A2GJGmIxwSO-NpGW69Au2IIK5G6BScHmfIo26R-DtA4ZnsheTvDutsdK26ld9GouWOT9sRpTT2lYZWM06RaRsheFIoog236CcRjE2RRcDA2YU3yyLADvyPKWUS-hUu2TnS8QfpT4iw7DeHn-ECImBRbBOS2utpk2aQ3dBlUGFTZiB8p_owPt0Ln3UA_1jp6_HkATRjMkdHCT9xaaDHulXYvcCPT0DzwTFpCSH_9Vzu0Kl1jq6dRuENRnQfQlkoOr0GibyrTCU7jE1h3DC80chBhUPY5flx5aFZss=w850-h637-no" },
                new Mach { MachineId = 6, MachineNum = 823, MachineMake = "CAT", MachineModel = "D9", Hours = 6500, Status = false, TypeId = 10, Photo = "https://lh3.googleusercontent.com/VGy24V2LYBdMv6lG7Vhx30OSV3JpIQM3SaaPpXjv6ygnqtmLeUo4JUfhVpvEMhaqOjuyzJTVMt5t-iFhjqZR25SQLDLFeHqNjUZP9Ec_Cw1Lm28gYF8R6MazklGZ2qKWydV5JS9X6jFSLRG5Vk-vehl0Y9cMq80jKhjQc_nwy6BQXFKO5HiNJkMLqPA0NKA2nqnAjbBoNo4gtPmVPVWwH0Rn1-0mZ1MK1LWlLSRIR1eYBNabvgSwDUHf-o22_-OUXGl4j1d_FGCiJ3vj7izZAkeaDgL03NatJGURSy9r2krGpnnvQyyg8dBUfk0AnkJIYQ3A2GJGmIxwSO-NpGW69Au2IIK5G6BScHmfIo26R-DtA4ZnsheTvDutsdK26ld9GouWOT9sRpTT2lYZWM06RaRsheFIoog236CcRjE2RRcDA2YU3yyLADvyPKWUS-hUu2TnS8QfpT4iw7DeHn-ECImBRbBOS2utpk2aQ3dBlUGFTZiB8p_owPt0Ln3UA_1jp6_HkATRjMkdHCT9xaaDHulXYvcCPT0DzwTFpCSH_9Vzu0Kl1jq6dRuENRnQfQlkoOr0GibyrTCU7jE1h3DC80chBhUPY5flx5aFZss=w850-h637-no" }


                );
            context.SaveChanges();

            
        }
    }
}
