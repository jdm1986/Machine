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
                        MachineNum = m.MachineNum,
                        MachineMake = m.MachineMake,
                        MachineModel = m.MachineModel,
                        Hours = m.Hours,
                        Notes = m.Notes,
                        Status = m.Status
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
                        MachineNum = machine.MachineNum,
                        MachineMake = machine.MachineMake,
                        MachineModel = machine.MachineModel,
                        Hours = machine.Hours,
                        Notes = machine.Notes,
                        Status = machine.Status
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
                    MachineNum = machineViewModel.MachineNum.Value,
                    MachineMake = machineViewModel.MachineMake,
                    MachineModel = machineViewModel.MachineModel,
                    Hours = machineViewModel.Hours.Value,
                    Notes = machineViewModel.Notes,
                    Status = machineViewModel.Status
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
                        MachineId = machine.MachineId,
                        MachineNum = machine.MachineNum,
                        MachineMake = machine.MachineMake,
                        MachineModel = machine.MachineModel,
                        Hours = machine.Hours,
                        Notes = machine.Notes,
                        Status = machine.Status

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
                    machine.MachineNum = machineViewModel.MachineNum.Value;
                    machine.MachineMake = machineViewModel.MachineMake;
                    machine.MachineModel = machineViewModel.MachineModel;
                    machine.Hours = machineViewModel.Hours.Value;
                    machine.Notes = machineViewModel.Notes;
                    machine.Status = machineViewModel.Status;
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

                    machineContext.SaveChanges();

                    return RedirectToAction("Index");

                }

                return new HttpNotFoundResult();

            }
                
        }
    }
}