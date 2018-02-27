using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Machine.Models
{
    public class MachineViewModel
    {
        public int? MachineId { get; set; }
        [DisplayName("Make")]
        public string MachineMake { get; set; }

        [DisplayName("Model")]
        public string MachineModel { get; set; }

        [DisplayName("Hours")]
        public int? Hours { get; set; }

        [DisplayName("Machine")]
        public string MachineMakeModel => MachineMake + " " + MachineModel;
    }
}