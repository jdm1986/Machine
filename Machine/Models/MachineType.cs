using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Machine.Models
{
    public class MachineType
    {
        [Key]
        public int TypeId { get; set; }
        public string TypeName { get; set; }
    }
}