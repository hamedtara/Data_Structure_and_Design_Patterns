using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06.State_Design_Pattern
{
    public class StopState : MachineState
    {
        public void DisplayState(Machine machine)
        {
            Console.WriteLine("Current State: Stopped");
        }

        public void NextState(Machine machine)
        {
            Console.WriteLine("Machine is already at the final state: Stop");
        }

        public void PrevState(Machine machine)
        {
            machine.state = new StopState();
        }
    }

}

