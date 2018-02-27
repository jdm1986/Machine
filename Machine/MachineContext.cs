namespace Machine
{
    using Machine.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MachineContext : DbContext
    {

        public MachineContext()
            : base("name=Machine") { }

        public virtual DbSet<Mach> Machines { get; set; }
       
       
    }
}