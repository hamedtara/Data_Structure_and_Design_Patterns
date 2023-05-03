using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06.TemplateDesignPattern
{
    public  class Car : Manufactur
    {
        protected override void assembleExterior()
        {
            Console.WriteLine("Assembling exterior for: " + GetType().Name);
        }

        protected override void Paint()
        {
            Console.WriteLine("Paint for: " + GetType().Name);
        }

        protected override void Polish()
        {
            Console.WriteLine("Polish for: " + GetType().Name);
        }

        protected override void prepareInteriors()
        {
            Console.WriteLine("Preparing Interiors for: " + GetType().Name);
          
        }

    }
}
