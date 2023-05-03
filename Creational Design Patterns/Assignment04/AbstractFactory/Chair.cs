using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04.AbstractFactory
{
    public class Chair : Furniture
    {
        public override void compareSitting(Bedding bed)
        {
            Console.WriteLine("Comparison of ease of use Of " + this.GetType().Name + " with " + bed.GetType().Name);

        }
    }
}
