using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06.State_Design_Pattern
{
    public class Machine
    {
        public MachineState state { get; set; }
        public Machine()
        {
            state = new StartState();
        }
        public void displayMachineState()
        {
            state.DisplayState(this);
        }
        public void setNextState()
        {
            state.NextState(this);
        }
        public void setPrevState()
        {
            state.PrevState(this);
        }


    }

}
