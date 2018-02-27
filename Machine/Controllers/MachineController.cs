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
            using (var machineContext = new MachineContext())
            {
                var machineList = new MachineListViewModel
                {
                    Machines = machineContext.Machines.Select(m => new MachineViewModel
                    {
                        MachineId = m.MachineId,
                        MachineMake = m.MachineMake,
                        MachineModel = m.MachineModel,
                        Hours = m.Hours
                    }).ToList()
                };

                return View(machineList);
            }
             
               
        }

        public ActionResult MachineDetail(int id)
        {
            using (var machineContext = new MachineContext())
            {
                var machine = machineContext.Machines.SingleOrDefault(m => m.MachineId == id);
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
            using (var machineContext = new MachineContext())
            {
                var machine = new Mach
                {
                    MachineMake = machineViewModel.MachineMake,
                    MachineModel = machineViewModel.MachineModel,
                    Hours = machineViewModel.Hours.Value
                };

                machineContext.Machines.Add(machine);
                machineContext.SaveChanges();
            }
            return RedirectToAction("Index");
            
        }

        public ActionResult MachineEdit(int id)
        {
            using (var machineContext = new MachineContext())
            {
                var machine = machineContext.Machines.SingleOrDefault(m => m.MachineId == id);
                if (machine != null)
                {
                    var machineViewModel = new MachineViewModel
                    {
                        MachineMake = machine.MachineMake,
                        MachineModel = machine.MachineModel,
                        Hours = machine.Hours

                    };

                    return View("AddEditMachine", machineViewModel);
                }

                return new HttpNotFoundResult();
            }
                
        }

        [HttpPost]
        public ActionResult EditMachine(MachineViewModel machineViewModel)
        {
            using (var machineContext = new MachineContext())
            {
                var machine = machineContext.Machines.SingleOrDefault(m => m.MachineId == machineViewModel.MachineId);

                if (machine != null)
                {
                    machine.MachineMake = machineViewModel.MachineMake;
                    machine.MachineModel = machineViewModel.MachineModel;
                    machine.Hours = machineViewModel.Hours.Value;
                    machineContext.SaveChanges();

                    return RedirectToAction("Index");
                }

                return new HttpNotFoundResult();
            }
                
        }

        [HttpPost]
        public ActionResult DeleteMachine(MachineViewModel machineViewModel)
        {
            using (var machineContext = new MachineContext())
            {
                var machine = machineContext.Machines.SingleOrDefault(m => m.MachineId == machineViewModel.MachineId);

                if (machine != null)
                {
                    machineContext.Machines.Remove(machine);

                    return RedirectToAction("Index");

                }

                return new HttpNotFoundResult();

            }
                
        }
    }
}