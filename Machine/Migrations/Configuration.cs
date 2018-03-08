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
                new Mach { MachineId = 1, MachineNum = 345, MachineMake = "CAT", MachineModel = "D8", Hours = 500, Status = false, TypeId = 1, Photo = "https://lh3.googleusercontent.com/VGy24V2LYBdMv6lG7Vhx30OSV3JpIQM3SaaPpXjv6ygnqtmLeUo4JUfhVpvEMhaqOjuyzJTVMt5t-iFhjqZR25SQLDLFeHqNjUZP9Ec_Cw1Lm28gYF8R6MazklGZ2qKWydV5JS9X6jFSLRG5Vk-vehl0Y9cMq80jKhjQc_nwy6BQXFKO5HiNJkMLqPA0NKA2nqnAjbBoNo4gtPmVPVWwH0Rn1-0mZ1MK1LWlLSRIR1eYBNabvgSwDUHf-o22_-OUXGl4j1d_FGCiJ3vj7izZAkeaDgL03NatJGURSy9r2krGpnnvQyyg8dBUfk0AnkJIYQ3A2GJGmIxwSO-NpGW69Au2IIK5G6BScHmfIo26R-DtA4ZnsheTvDutsdK26ld9GouWOT9sRpTT2lYZWM06RaRsheFIoog236CcRjE2RRcDA2YU3yyLADvyPKWUS-hUu2TnS8QfpT4iw7DeHn-ECImBRbBOS2utpk2aQ3dBlUGFTZiB8p_owPt0Ln3UA_1jp6_HkATRjMkdHCT9xaaDHulXYvcCPT0DzwTFpCSH_9Vzu0Kl1jq6dRuENRnQfQlkoOr0GibyrTCU7jE1h3DC80chBhUPY5flx5aFZss=w850-h637-no" },
                new Mach { MachineId = 2, MachineNum = 346, MachineMake = "Komatsu", MachineModel = "PC450", Hours = 1500, Status = false, TypeId = 10, Photo = "https://lh3.googleusercontent.com/fgiCSjYXjs8CApZlzK830rv9TEijCBKNRQ4Ao57nvjfFnzFmcOwdffTNDbs8GCsOrFanCHtazqveCuetJDY4EC8bGOKB3FU6vts3TGBcnfLa45bEaCU-cYfxD92CgKhOoBVxNRpyx26hVFgbhO8j5bEhwpX6Fy6fyVi1JbJSbyaBgk-4EVmpXd2KfO7U4HLluU4n0nxpaWEhrFQNAsBq9QdPzfGkgvvz4h1ql1CVGKncXAg21XqXeJ1egCNECZNrqxVmS1Oi4QSh2KPQUSZm1iOYzATC0Vr5cBtVbKvWg-EdbOoYq1RovvgmpKHvhEqKO2IYBm6k9bKmYgQeepIq_jrBk3u-6u9Cq2MjIY0bz-8geU8DZhkVo-IhzmP7SgjKI93rTJVtjmricXWoEsaXJLJvHigZwldimSpg5Xcig9TE0ar_IxEJw0RldE3pgzTXNJ1b440nB92hECaM3Cqc2Zqd72arHsbXjhYHwM8m-J28noAee7A__ksf52QRGaE6sUoqEFNNmHKx39Dbz7_diAhOhVUn6k8wkM7srXCObIOTx_KhjCe2foH47kVVk0CQmpUJ009FITImZcJlubX1WJ_63G0UGksD3eWjFwI=w1200-h900-no" },
                new Mach { MachineId = 3, MachineNum = 347, MachineMake = "Deere", MachineModel = "9520", Hours = 2500, Status = false, TypeId = 11, Photo = "https://lh3.googleusercontent.com/i9wEEZ4mEEBt4gfCiD4bapKD1mMmk5iTA7CL4IBy7fbAxRRU-l-sQYwUVgILtabIienChZNaDIKqR3rtOrm2A9oNZKMUBsxr55BWPH4aF1Y6xR4UNhleCH8mlQ9N_rCjnohS9ZK_qKJUo5U_oFU7MIywaPkEolc4VbkXb-N-XEiNLaffTRAlLYl3scP34ozLkpBWu89vS7Z4xj6Rjdq2oRS6EcUADnsMXvIedh2qr_7hTN-X_MNzpE_vFYxa2yfHkUjvJKkSVN3WdH23WmSW0AMMk1hB4QwihcsOkdCv7jjp53jsoqZPAPRM_hebhN8ZpN2o9WL4ROKrQOfDwDR0pPeHMMWNAC-X2ij9xgRtscwoc6jmQnPA7788OpdUXfgsM6lXXkM5g1AB72Tya7GWFWkWqh9JLFXUoJHWT-066MW6EShRlISQxkfVMNLRts3pGvR25I1Zi5uKGE_0vQk-mRdmj2IVFauxVnL_EH2UvFCDfQCLfskrPtlay4IHsGXj6Gxr9gjbdzZqjBYT8RgWya0o3c3qJ_H3vMyxLBoWRH6fmGAh0u--vSKUAMv2AwHrFueIHj4qZMcq6RVHn_c2J48inv57JhM4oa6ce7c=w1200-h901-no" },
                new Mach { MachineId = 4, MachineNum = 454, MachineMake = "Takeuchi", MachineModel = "TB290", Hours = 3500, Status = false, TypeId = 10, Photo = "https://lh3.googleusercontent.com/k3ak9zPqDxBhy3aHbpPoBNBUOqmniDNka7TRbe9z1RFi_f75Q4eWWgGplgzpE-tO4cYq8o1wIAgy05QM-4eW471esmgiUzsrcnKeV9CYV5PksA9ViuKVvjKgQ7uLcwQLAfibF9nPB9OOguK7mYFOReOzq6F3pNCSySGiPUz4wn8GvS8StVSRUROX6fPPPItQWp08m7BPNJa9Fjn1Jv_0i07SnNB_EA3WUA-6bwOwnJDr6I4j732iNpYqFKhKtOiae57aYABWMHj9lKkQy5Oi-4IWHLIwgdi1sQfs5SS2pE9QTGD1-AaRqGp43hkE3dUIRSKyrk_43KFMkotj7jYAuvUbFjlF4ESh9_HnpBE4sfzb_1-OIQlHFv_Cd5DrGv3d-7khcgByyqonSwi5DEPw6HbGQwcR7zHNSM2dLd-9e6K-9Y0bH-nlfeWrl2SrAYgxeIicQONjGEOqdChaizqL9jwI1OX3PDOhB_T3Mjtl4QPzMXyY40WgC2DVMAfBBzPtbTipXfYKDljzzm8rhIq2hmKW5wwN3Z5cYbKna8hPIhBaByifcBY5hwoEhGVdfAOtA8JHksmTHZQUbzhryJneu_rQF2M23ztpOMSX36E=w1280-h853-no" },
                new Mach { MachineId = 5, MachineNum = 734, MachineMake = "Deere", MachineModel = "450G", Hours = 4500, Status = false, TypeId = 10, Photo = "https://lh3.googleusercontent.com/DsgnG-eLtMP3R1w5XPsb0tD4LRKTtZMvh-cP6mtI4a60OkB5xMPCSpa4s-w7quOC0LF3jngZF2jMxlUkWvCfl_HNRwZHzJsYrv20WV6yrkwyzkapUusq0NuXfnx78KrfGhzrKiNyMJfk2n4OrOWNgDMjxgF6sCcA2p3IyP7Lv-DPpYw0uav3Xuv4F6GK_KMYSnC9slFR5wxOS-Dw8_OvCs-SJUizUb6NYMpBQXboE6zbUpFWeAXTY8WizcBb4y2-ghq3R5qW0oIkRzH749NFXXNRUMpLtyAe3rNVHVdSeySYveGlCaOUZkIVceA2TuSV9LYFAOMzL5srX0YN8gWreAnG86yzj4KHst6ZIAS9P19EnOYG7x17trB-2a1bRFE_VrBRtYsxXZp0hRrTzlimEA0A1XjiCteLl3t5FJsjG25FlqDJ5MHbQ3VxpUoA-Z5fuhP7gLP1omqk2uDOOzfE7THymSAuP0xMGYlWXKZheS7GlkPDDrQiFxdBCl_WwTTlIPK96E3IiJXSqS5I1HiDBKq3_PTu81vsUgbYOQ9qk0WEFx3OHnPXk64p2usmeFHLs2qSZjQ8ebgEo48ouIT9nUpTHSLygc051eqeVIU=w720-h540-no" },
                new Mach { MachineId = 6, MachineNum = 823, MachineMake = "Deere", MachineModel = "250G", Hours = 6500, Status = false, TypeId = 10, Photo = "https://lh3.googleusercontent.com/aP-BQc03wI0QzK5NPWbFJVsLPDdfMM5uyPQenFTQkOf0Lh-6ZB1bM8o8YjUGuLF_lH4ohXWEaIA60xo2lyCVRaIhczUNu2U_gCkoFNE9lne8uJAPJR0c3cyvQNf6eIZ5hvxKOWkJuB-DbPOGSS_MgGWho_OhRnLVzPFuxXGP-76l4TUJyWflDIqwn-BOXP6MdJm_m2XJ1tsp5ioiBpGjFIVPKRYAbdf3YRAQillAkKtSmb1mbyTkVCiYfxb8hCa2a8_5w3e0sbWGc9pfSlZ-EAOu93g8bQMBGUU2FvB8mVCdp-jBrEzCJ7xX8L3h3FGjez_T2FbR2z0peK3O87tgj6h84IYkmArRjFxvm63JazOYUEZFSEl7RtnLi82UarcAyPJ7lrdvFIa6kwVWMavJIL3Huf3B-c4j3ZsMBQSys1j1VGYJ_TSr6AMywx0VK1d6nKPFrY7KF1anlVGfKFj-FxVcNbFd7DxPgdaKI34MNQeh9oiLPx_2MdPYt31-ygObD8LqJYblZIj_u7N7mHe_0ABEcs0xEqjj1thrcgaM5MfmB7SHOi2xs_ryvOb2CGqQ7yIBu6fh1_MpfnO_aYZyt54OssQLRLsUaUOl0m4=w1266-h949-no" }


                );
            context.SaveChanges();

            
        }
    }
}
