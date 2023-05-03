using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06.TemplateDesignPattern
{
    public abstract class Manufactur
    {
        protected abstract void assembleExterior();
        protected abstract void prepareInteriors();
        protected abstract void Paint();

        protected abstract void Polish();
        protected virtual void Dispatch()
        {

            Console.WriteLine(GetType().Name +  " is dispatched using standard shipping : ");
            Console.WriteLine("******************************************");

        }

        public void ManufactureProduct()
        {
            assembleExterior();
            prepareInteriors();
            Paint();
            Polish();
            Dispatch();

        }

    }

 
}
