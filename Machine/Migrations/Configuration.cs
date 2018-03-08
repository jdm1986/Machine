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
                new Mach { MachineId = 2, MachineNum = 346, MachineMake = "Komatsu", MachineModel = "PC300", Hours = 1500, Status = false, TypeId = 10, Photo = "https://lh3.googleusercontent.com/hyC36SWhUJgRWAyr62u70SOCdVNBFhY7wiKsf1ke0DVUdwTqU3AE5H6l_GrbX8Ey7jN55iVf-fnFS2XImPO3B5HAASVuHkuXJercRx6KzJ4l1UiIEqbhNv_oWz6cRGZHstLng_bw82rp0pMIp8qI3ohKiJHr_i9jol7c__Bpp6Jncam-m3qJ0IVnGe54x3XMsWwV8M82cGTcXqM9GYRlC8ntbz9y6LSUMK7SPny6bdxh4yNKqHztSPdOolnvWqV1Xfpiy-NWvNO9DvZEBbefMJMseASbjHYrNw2ENirdomis1lBjlt5dm3FXOaS4LzJFr45akC1ihgPqZERUqOcEO0PKo3JFODq7eLl7vbMJEIcEJ6b5M8xfb8bzpd5eLHnAKXQb1y3jQfahCzlneghSwwZdA0d5T85pXWsJ4g6Q9oUjzz6RW6Ml7K7Mj63embTtSH13qoZBEVyJuNZOgZHqrQr527JJrZGo4yLJI-Se_uGL630OPRFzoGlsBM-aLYyMhCENUDAqAIeWJGTmAcq73zWNvVn26rFfxkynp-ePumDvjFPw4JQ-VxV8ApdDNN6Jiizu1kHZ1h5xEySE1NIs3ouPlxjjvChXPJE9V9ynBFBcbHOHmYlXZFtagV6EZkmWcBaPMDvV8KwVrZ4l8zPa1LGNguvp7JUW=w1266-h949-no" },
                new Mach { MachineId = 3, MachineNum = 347, MachineMake = "Deere", MachineModel = "9520", Hours = 2500, Status = false, TypeId = 11, Photo = "https://lh3.googleusercontent.com/NDvLnSN5irxb_Yhhtm9BYNH8gqMmx4XhtCM8bdgmzVJLKTXtCcQEdKhwKG29_BhAGNlHWKjFgaGWS2uKS_qXoWIQKE2mpj0XdcTZQcAAvCTz7PuSAa_Vaj5Tvums-JztR5X0LESKC8MM69PgmX6EL_5i9YOTZyeZV_-L457h7PZboKnXFzlfK_iOxPatYKiDWXP92YaWSy6GhHt85zxtod4v1kYv3YLU01d003Bc2BaelacNLy9nWPgsx7q-yrSlPO0AcbtFJoBaiT9reMOlA5EqR487d-zfxstdu1Uik1ZIUkQb-5vwSAYNKQWFCvZC1LwzhrlucMLdDRWobyJ6xTA-442_TjKK4uK_sRbi0moR4Hx5b-aDJ6fkTfyqn1AB_PmYRnBHxRlouuZS6qJ__taURXvrN1InZHqnmyAXydivIp7G3MNx6BOujWp33OlOuOzNYKt5aPvyhObGp9Iu6PnBfFosivNjDyUomcT8xqFk5MVp3djHFI8VlFfN2V7Airt5Oo3Sf3TkFSnc1ut3bxgGGCuxWfaFeJttjdFaVZ5p-DlE7w1jcaghaDFGSfhQGiwClunNk8jyIPYDy6NGZAGr1qE42o9AQT6e53k=w240-h180-no" },
                new Mach { MachineId = 4, MachineNum = 454, MachineMake = "Takeuchi", MachineModel = "TB290", Hours = 3500, Status = false, TypeId = 10, Photo = "https://lh3.googleusercontent.com/k3ak9zPqDxBhy3aHbpPoBNBUOqmniDNka7TRbe9z1RFi_f75Q4eWWgGplgzpE-tO4cYq8o1wIAgy05QM-4eW471esmgiUzsrcnKeV9CYV5PksA9ViuKVvjKgQ7uLcwQLAfibF9nPB9OOguK7mYFOReOzq6F3pNCSySGiPUz4wn8GvS8StVSRUROX6fPPPItQWp08m7BPNJa9Fjn1Jv_0i07SnNB_EA3WUA-6bwOwnJDr6I4j732iNpYqFKhKtOiae57aYABWMHj9lKkQy5Oi-4IWHLIwgdi1sQfs5SS2pE9QTGD1-AaRqGp43hkE3dUIRSKyrk_43KFMkotj7jYAuvUbFjlF4ESh9_HnpBE4sfzb_1-OIQlHFv_Cd5DrGv3d-7khcgByyqonSwi5DEPw6HbGQwcR7zHNSM2dLd-9e6K-9Y0bH-nlfeWrl2SrAYgxeIicQONjGEOqdChaizqL9jwI1OX3PDOhB_T3Mjtl4QPzMXyY40WgC2DVMAfBBzPtbTipXfYKDljzzm8rhIq2hmKW5wwN3Z5cYbKna8hPIhBaByifcBY5hwoEhGVdfAOtA8JHksmTHZQUbzhryJneu_rQF2M23ztpOMSX36E=w1280-h853-no" },
                new Mach { MachineId = 5, MachineNum = 734, MachineMake = "Deere", MachineModel = "450C", Hours = 4500, Status = false, TypeId = 10, Photo = "https://lh3.googleusercontent.com/cf4ehnEOqxripTKQuLPFT4rIMmd-nZFlCOrg1bRoTYLGdztJ-7bTaRf3pf3S683F93z591LvSCdM5ipFIHMYwplXwPfaUosEgdJ72RvGdHBroHN_RN-5e27-4mKgeDmw4SSaZmzkCaylV4PN9xFOP1PSf8N2XjCsuo6wqgKD0j9Bi_Y90Mm4cwUfaMftQMhTDYTOtwm2fKB5VYizzJyMy1U3cEvg6MxrAK5N87-R-JLiM_Xn9m2wkMDABNdzk30C-ElDK4MTXeX6iw2lWrpHLbsp4KPkmktpYx4UzVSp9e-kEnDPxUhexkYLfcUm0iu6uAHO4bVlyZKSVW6d810LllJ53GO-uSyZClFLYE3HhmV7D4odbldVhN44-rJ-41MC4uBwoLUTYHbMWEpCQxhsTGljty5gJ1Pdpk_1wa_2ybi4KTpasm1woCHLsC8Lj4fBh_Bjvg_TgRrRztm3eP4vzOmVl700HPV5VNMpCFSmtBWxlfCjB8jhb8PQEuzX6v3TgLM6cc2kndSF3uToQklfK2zbFdPGyw8mGrQHBtPUCt2GEfjBNvePrDy8cxqXbg98iW8rOYTBDWkaHRG7OdXnx5O2oTj9FtLE8UinELkGFHsUKNXZjSt0Z6aQykF1_77K9wevzgfrrs0TkdJhjXpsrnEI1ae10Gc7=w357-h268-no" },
                new Mach { MachineId = 6, MachineNum = 823, MachineMake = "Deere", MachineModel = "250G", Hours = 6500, Status = false, TypeId = 10, Photo = "https://lh3.googleusercontent.com/HIjJnQyv2tpq6Sg4JiMGDi2VTyJ-D3KmvxeL5iaXfLT06ks0YT1ZQqbEvqptxEPiKKTisq2T3tDR6tojq9yBT6ONVEGKhuc2Bo9JtVk0_6FHCeGZJuS_iZfIwrrf-tMI0n5P63eip-xKNKsCmJTdo5Kt2Hs-F6Zwy7pquG_WUowOKVH-hy71S1r-EhFG_jwhvhnDqNjojcGu8Yc_vLj88B__1FFflWQI5ECtF852nvNsEUBNaIWOJZ6RkSJZOF34fzfyXXfk-pFQjF7ixqHt2A0oLRqbVxcBdbzqZak97xfz95CK0jb3n8Eo_eDW7TXPCGED5F9lnjU_f7xOu9ypqdyjYken1TGbDUS696Ppt4ki7SO3yQZ3wfENAcTcdQO8NxPUweKRzycRWKiztVftjuZKWLtEA1-eX7I5kZA89nkz9Lclzre89aQAfAkKGxsskTbDPSq33V04vSFQ4U3eYSBTt5VGK3X3NMS7Xye2c2n06PplL08diZ21V13exPAy-np6-EFTKPhZ28Ftpr24TwMt9GCrwAHjlJTE2Kw4yq_FXlKUxR-qEG4xBedrig7ujXxjhr1vDFwVzkBzjFC1DAx-lJRZFxxwm4r980wH5YYqe7HivQ8aZ1E-QgFDQEn5Fyu1oF-yJ5mMDNKsvDmwYuMbUg4q29B6=w1266-h949-no" }
              
                );
            context.SaveChanges();

            
        }
    }
}
