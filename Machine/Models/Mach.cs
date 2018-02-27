using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Machine.Models
{
    public class Mach
    {
        public int MachineId { get; set; }
        public string MachineMake { get; set; }
        public string MachineModel { get; set; }
        public int Hours { get; set; }
    }
}