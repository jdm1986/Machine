using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Machine.Models;

namespace Machine.Controllers
{
    public class MachineController : Controller
    {

        public ActionResult Index()
        {

            var machineList = new MachineListViewModel
            {
                Machines = new List<MachineViewModel>
                {
                    new MachineViewModel { MachineId = 1, MachineMake = "CAT", MachineModel = "D3", MachineHours = 500 },
                    new MachineViewModel { MachineId = 2, MachineMake = "CAT", MachineModel = "D4", MachineHours = 1500 },
                    new MachineViewModel { MachineId = 3, MachineMake = "CAT", MachineModel = "D5", MachineHours = 2500 },
                    new MachineViewModel { MachineId = 4, MachineMake = "CAT", MachineModel = "D6", MachineHours = 3500 },
                    new MachineViewModel { MachineId = 5, MachineMake = "CAT", MachineModel = "D8", MachineHours = 4500 },
                    new MachineViewModel { MachineId = 6, MachineMake = "CAT", MachineModel = "D9", MachineHours = 6500 }
                }
            };

            return View(machineList);
        }
    }
}