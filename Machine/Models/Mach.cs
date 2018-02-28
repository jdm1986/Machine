using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Machine.Models
{
   
    public class Mach
    {
        [Key]
        public int MachineId { get; set; }
        public int MachineNum { get; set; }
        public string MachineMake { get; set; }
        public string MachineModel { get; set; }
        public int Hours { get; set; }

        public virtual MachineType MachineType { get; set; }
    }
}