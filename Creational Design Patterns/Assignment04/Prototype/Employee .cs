using Assignment04.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04.Employee
{
    internal class Employee : memberPrototype
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public override memberPrototype getClone()
        {
            return this.MemberwiseClone() as memberPrototype;
        }
    }
}

/*Employee*/