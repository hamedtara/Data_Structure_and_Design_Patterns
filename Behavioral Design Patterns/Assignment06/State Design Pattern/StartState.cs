using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06.State_Design_Pattern
{
    public class StartState : MachineState
    {
        public void DisplayState(Machine machine)
        {
            Console.WriteLine("Current State: Start state");
        }

        public void NextState(Machine machine)
        {

            machine.state = new StopState();

        }

        public void PrevState(Machine machine)

        {

            Console.WriteLine("Machine already at the base state: Start");
        }
    }
}
