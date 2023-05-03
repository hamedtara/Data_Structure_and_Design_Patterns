using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06.State_Design_Pattern
{
    public interface MachineState
    {
        public void DisplayState(Machine machine);
        public void NextState(Machine machine);
        public void PrevState(Machine machine);

    }
}


/*
 * Have you ever played with toys that can change their appearance or behavior? Let's say you have a toy car that can transform into a robot. When the car is in its car form, 
 * it can drive around and go fast or slow. But when it transforms into a robot, it can walk, dance, and do all sorts of cool things.

Now, imagine that the toy car is like an object in a computer program, and the robot form is like a behavior that the object can have. 
The state design pattern is like having different modes for your toy car that can change its behavior.

For example, when the toy car is in "driving" mode, it behaves like a normal car and can go fast or slow.
But when you switch it to "robot" mode, it behaves like a robot and can do all sorts of cool things, like dancing or walking.

In a computer program, we can use the state design pattern to allow an object to switch between different behaviors based on its current state. We can have a separate object that represents each state, 
and the object can delegate its behavior to the appropriate state object. This makes it easy to add new states without changing the object's code, just like how you can switch your toy car between different 
modes without changing its physical form.
 */