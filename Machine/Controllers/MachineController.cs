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
        public static List<Mach> Machines = new List<Mach>
        {
            new Mach { MachineId = 1, MachineMake = "CAT", MachineModel = "D3", Hours = 500 },
            new Mach { MachineId = 2, MachineMake = "CAT", MachineModel = "D4", Hours = 1500 },
            new Mach { MachineId = 3, MachineMake = "CAT", MachineModel = "D5", Hours = 2500 },
            new Mach { MachineId = 4, MachineMake = "CAT", MachineModel = "D6", Hours = 3500 },
            new Mach { MachineId = 5, MachineMake = "CAT", MachineModel = "D8", Hours = 4500 },
            new Mach { MachineId = 6, MachineMake = "CAT", MachineModel = "D9", Hours = 6500 }
        };

        public ActionResult Index()
        {

            var machineList = new MachineListViewModel
            {
                Machines = Machines.Select(m => new MachineViewModel 
                {
                    MachineId = m.MachineId,
                    MachineMake = m.MachineMake,
                    MachineModel = m.MachineModel,
                    Hours = m.Hours
                }).ToList()
            };

            return View(machineList);
        }

        public ActionResult MachineDetail(int id)
        {
            var machine = Machines.SingleOrDefault(m => m.MachineId == id);
            if (machine != null)
            {
                var machineViewModel = new MachineViewModel
                {
                    MachineId = machine.MachineId,
                    MachineMake = machine.MachineMake,
                    MachineModel = machine.MachineModel,
                    Hours = machine.Hours
                };
                return View(machineViewModel);
            }

            return new HttpNotFoundResult();
        }

        public ActionResult MachineAdd()
        {
            var machineViewModel = new MachineViewModel();

            return View("AddEditMachine", machineViewModel);
        }

        [HttpPost]
        public ActionResult AddMachine(MachineViewModel machineViewModel)
        {
            var nextMachineId = Machines.Max(m => m.MachineId) + 1;

            var machine = new Mach
            {
                MachineId = nextMachineId,
                MachineMake = machineViewModel.MachineMake,
                MachineModel = machineViewModel.MachineModel,
                Hours = machineViewModel.Hours.Value
            };

            Machines.Add(machine);

            return RedirectToAction("Index");
        }

        public ActionResult MachineEdit(int id)
        {
            var machine = Machines.SingleOrDefault(m => m.MachineId == id);
            if (machine != null)
            {
                var machineViewModel = new MachineViewModel
                {
                    MachineId = machine.MachineId,
                    MachineMake = machine.MachineMake,
                    MachineModel = machine.MachineModel,
                    Hours = machine.Hours

                };

                return View("AddEditMachine", machineViewModel);
            }

            return new HttpNotFoundResult();
        }

        [HttpPost]
        public ActionResult EditMachine(MachineViewModel machineViewModel)
        {
            var machine = Machines.SingleOrDefault(m => m.MachineId == machineViewModel.MachineId);

            if (machine != null)
            {
                machine.MachineMake = machineViewModel.MachineMake;
                machine.MachineModel = machineViewModel.MachineModel;
                machine.Hours = machineViewModel.Hours.Value;

                return RedirectToAction("Index");
            }

            return new HttpNotFoundResult();
        }

        [HttpPost]
        public ActionResult DeleteMachine(MachineViewModel machineViewModel)
        {
            var machine = Machines.SingleOrDefault(m => m.MachineId == machineViewModel.MachineId);

            if (machine != null)
            {
                Machines.Remove(machine);

                return RedirectToAction("Index");

            }

            return new HttpNotFoundResult();
        }
    }
}