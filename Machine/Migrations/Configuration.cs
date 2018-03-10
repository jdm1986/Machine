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
                new Mach { MachineId = 1, MachineNum = 345, MachineMake = "CAT", MachineModel = "D8", Hours = 500, Status = false, TypeId = 1, Photo = "https://lh3.googleusercontent.com/gowM7RMBzhJab0Bd2kboKC-GraMEjhFZGwZ0BPCDer0fuUR-LpMDGM2OJpd9qqF10Nt6oR244SjWj66Xq0aDaM35p6ObMP6SwSicrRQFi5eq-QmLrAKGRltaYwRGr4em5zCc_Qqnvggbq_GuIb30idHtJ_C9R1lS7HP4jsdOMlsUWCOtc_pBvtdq7OI-uoUSkLmVbbbrQzYvC6r3eBL1kDD9JYYuYhYb775EAYUg6lP2rLG9Uu4fOinnuDcjAvVpiWivcHWUmn_XFr2M1a38HR-ls1HJXdrxt8lEE9D3UUupVudEPTv4x4-k0uG4XjzBfbkMYXMn7aRKJygbzL1m2N09hmPUXFnM_5WBci583S5kPt8VRiPtoPBzbk8H6MHyiu1AquwgjBt8hUccAa2iIXe51KRGhfqpNZlPOCxqmjZzrNU5vNh7pXtitJQIx-8XLsHK-HHN_AK4vMwIqTajjnvjtnuXUHyi3Kp6cF1iKNTOxFuJW68L4A0lAbfTlejQ7jIEWrkTCxaH1L0wZtifHSdCj3ZShql-Ow11NwUhV-GLY1fxx8eqCrQkuYbyHSADrHU4YrQ6vrcH_22V0MAEpUwm1XRrZXfcxPqdIw_pglInM37k7r5h6c4VjQ9Hqpbo6ngvJZjh9bfYB0BZP34sp8AmOR3dwHeM=w803-h602-no" },
                new Mach { MachineId = 2, MachineNum = 346, MachineMake = "Komatsu", MachineModel = "PC300", Hours = 1500, Status = false, TypeId = 10, Photo = "https://lh3.googleusercontent.com/hyC36SWhUJgRWAyr62u70SOCdVNBFhY7wiKsf1ke0DVUdwTqU3AE5H6l_GrbX8Ey7jN55iVf-fnFS2XImPO3B5HAASVuHkuXJercRx6KzJ4l1UiIEqbhNv_oWz6cRGZHstLng_bw82rp0pMIp8qI3ohKiJHr_i9jol7c__Bpp6Jncam-m3qJ0IVnGe54x3XMsWwV8M82cGTcXqM9GYRlC8ntbz9y6LSUMK7SPny6bdxh4yNKqHztSPdOolnvWqV1Xfpiy-NWvNO9DvZEBbefMJMseASbjHYrNw2ENirdomis1lBjlt5dm3FXOaS4LzJFr45akC1ihgPqZERUqOcEO0PKo3JFODq7eLl7vbMJEIcEJ6b5M8xfb8bzpd5eLHnAKXQb1y3jQfahCzlneghSwwZdA0d5T85pXWsJ4g6Q9oUjzz6RW6Ml7K7Mj63embTtSH13qoZBEVyJuNZOgZHqrQr527JJrZGo4yLJI-Se_uGL630OPRFzoGlsBM-aLYyMhCENUDAqAIeWJGTmAcq73zWNvVn26rFfxkynp-ePumDvjFPw4JQ-VxV8ApdDNN6Jiizu1kHZ1h5xEySE1NIs3ouPlxjjvChXPJE9V9ynBFBcbHOHmYlXZFtagV6EZkmWcBaPMDvV8KwVrZ4l8zPa1LGNguvp7JUW=w1266-h949-no" },
                new Mach { MachineId = 3, MachineNum = 347, MachineMake = "Deere", MachineModel = "9520", Hours = 2500, Status = false, TypeId = 11, Photo = "https://lh3.googleusercontent.com/jJLv8V9cvrMy88DhAK89f_cdiVx9B3AwKTzUcS_G2_21DwIvVR6_TEC0S3nUYUv7Q8DR68pOHrj16Lkl3fWaGkdJQILi-1IC5BWav8Q45cpWhTg9N2xFaVcdp-i5HsWLtlbg9dAAFHJZ6gj8862MHnWX0ZYTbV72Cq4lPeDLnQOtYPJYoZmChJ_zytrFiN7lETHT-WoDjpix5fza2dzfkDIVTl_N3aGnHJ7GmdRzqIevDQCqU0cuaXdqOOAR9U4QrQ99bBX5FwDuRrkY6HwoF78znf9BddI5duQiFFZWRijkFvMacUShDwWD_-99mZasn3KPsYdEA6bo2iVj53WaBfhl2DVfFybsxC0xmBHrZw0gyFo7xOfpAPfFuC_G1af3AfZo2gWyW6zB5ELf-ufYkjOwiIAhhy6IjRKhKrhHpVa8juO3MuEEdddFaEkrZulrBISAkad44i1kLzXeUC-lu6EwD_PYh0l46ZE0imx48G_yQKhxTGDQ4WS3NP6PW50yKzxUuNNS2D5U98ARaTsgD4YU4Xrcv5Bjv-K8sWOu4cK7GP4XzyHO_4_78yNfirNrkN72_hJty1sLiOEud5X14RfZcziQDrSP4AUtp48=w850-h637-no" },
                new Mach { MachineId = 4, MachineNum = 454, MachineMake = "Takeuchi", MachineModel = "TB235", Hours = 3500, Status = false, TypeId = 10, Photo = "https://lh3.googleusercontent.com/K143K6SkK8N-k4ejCy4TiZpkhGbkuhUtG5LhZgvBuA_nyuynTe3uy-pu8XpxU1egMlQ8lCVe-ut7YpnNtYxOlpXZFO-9w2H8DLfVW_w66Gas5xagxgrB5__1vOVlQhFqOt6hDxLHXGJ7KxYfuByjXAbixI2CYHQTMs8hKU7xH61JMS40P6DWLqO6LZG5zSdcUqwWbse985vCSqP8SqOk_uhNRe_gzXHzV5vJBxpH1AAZ-EUeoBgKJ8GfdFNfSOS8ZMaiAOQWwuxOmHqXkQzjWLbp9BN-D3syYD4tP1EV5iEvAh39yzLq57i4gjSYA27u1CGK4oU_kd0ZDjBTLQ8VOxk6TYtrr7TQbS38gH8WoWxQFh7vsHV4Mq4Io6o9EMdl1x3l7RyVxSQRUUUiqluohLDwMZfOgc8iqbyFUKHnHp6FZcyFHua3j8j_KBn-i8q6nfHCvAib3woDN3dnQL-WQsoaG7k-0jmCiQHXsRWE0BToEjjMRjPcWjPVc10zCtDbQah10o6_rU_ergyv361JgYFJqW3A7Jvq5rHoarYfIpcySCIcEuylkYznd64pHjltKfMCC5asMEnjOYGKw_VBz_iUpVUaqcDNE6h5IkUcRpU3oy1y487yGLcOM_o8j8IuJ6c1EIaIiNfUT_ZxduTp-S05KZwnjdNJ=w956-h637-no" },
                new Mach { MachineId = 5, MachineNum = 734, MachineMake = "Deere", MachineModel = "450C", Hours = 4500, Status = false, TypeId = 10, Photo = "https://lh3.googleusercontent.com/cf4ehnEOqxripTKQuLPFT4rIMmd-nZFlCOrg1bRoTYLGdztJ-7bTaRf3pf3S683F93z591LvSCdM5ipFIHMYwplXwPfaUosEgdJ72RvGdHBroHN_RN-5e27-4mKgeDmw4SSaZmzkCaylV4PN9xFOP1PSf8N2XjCsuo6wqgKD0j9Bi_Y90Mm4cwUfaMftQMhTDYTOtwm2fKB5VYizzJyMy1U3cEvg6MxrAK5N87-R-JLiM_Xn9m2wkMDABNdzk30C-ElDK4MTXeX6iw2lWrpHLbsp4KPkmktpYx4UzVSp9e-kEnDPxUhexkYLfcUm0iu6uAHO4bVlyZKSVW6d810LllJ53GO-uSyZClFLYE3HhmV7D4odbldVhN44-rJ-41MC4uBwoLUTYHbMWEpCQxhsTGljty5gJ1Pdpk_1wa_2ybi4KTpasm1woCHLsC8Lj4fBh_Bjvg_TgRrRztm3eP4vzOmVl700HPV5VNMpCFSmtBWxlfCjB8jhb8PQEuzX6v3TgLM6cc2kndSF3uToQklfK2zbFdPGyw8mGrQHBtPUCt2GEfjBNvePrDy8cxqXbg98iW8rOYTBDWkaHRG7OdXnx5O2oTj9FtLE8UinELkGFHsUKNXZjSt0Z6aQykF1_77K9wevzgfrrs0TkdJhjXpsrnEI1ae10Gc7=w357-h268-no" },
                new Mach { MachineId = 6, MachineNum = 823, MachineMake = "Deere", MachineModel = "250G", Hours = 6500, Status = false, TypeId = 10, Photo = "https://lh3.googleusercontent.com/HIjJnQyv2tpq6Sg4JiMGDi2VTyJ-D3KmvxeL5iaXfLT06ks0YT1ZQqbEvqptxEPiKKTisq2T3tDR6tojq9yBT6ONVEGKhuc2Bo9JtVk0_6FHCeGZJuS_iZfIwrrf-tMI0n5P63eip-xKNKsCmJTdo5Kt2Hs-F6Zwy7pquG_WUowOKVH-hy71S1r-EhFG_jwhvhnDqNjojcGu8Yc_vLj88B__1FFflWQI5ECtF852nvNsEUBNaIWOJZ6RkSJZOF34fzfyXXfk-pFQjF7ixqHt2A0oLRqbVxcBdbzqZak97xfz95CK0jb3n8Eo_eDW7TXPCGED5F9lnjU_f7xOu9ypqdyjYken1TGbDUS696Ppt4ki7SO3yQZ3wfENAcTcdQO8NxPUweKRzycRWKiztVftjuZKWLtEA1-eX7I5kZA89nkz9Lclzre89aQAfAkKGxsskTbDPSq33V04vSFQ4U3eYSBTt5VGK3X3NMS7Xye2c2n06PplL08diZ21V13exPAy-np6-EFTKPhZ28Ftpr24TwMt9GCrwAHjlJTE2Kw4yq_FXlKUxR-qEG4xBedrig7ujXxjhr1vDFwVzkBzjFC1DAx-lJRZFxxwm4r980wH5YYqe7HivQ8aZ1E-QgFDQEn5Fyu1oF-yJ5mMDNKsvDmwYuMbUg4q29B6=w1266-h949-no" }
              
                );
            context.SaveChanges();

            
        }
    }
}
