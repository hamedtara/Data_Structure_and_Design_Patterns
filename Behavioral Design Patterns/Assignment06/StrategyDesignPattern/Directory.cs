using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06.Strategy_Design_Pattern
{
    public  class Directory
    {
        // https://www.youtube.com/watch?v=9uDFHTWCKkQ

        private List<Item> items = new List<Item>();

        public void AddItem (Item item)
        {
            items.Add(item);
        }

        public void RemoveItem (Item item) { 
            items.Remove(item);
        }

        public void Sort(SortInterface sort)
        {

            sort.Sort(27);
        }
    }

   
}


/*
 Imagine you have a toy robot that can do different things like dance, sing, or walk. You have a remote control to make the robot do what you want.

But sometimes, you want the robot to do something different, like play a game or draw a picture. 
Instead of changing the remote control or the robot, you can have different tools that you can attach to the robot. Each tool can make the robot do something different, like a dance tool, a game tool, or an art tool.

In the same way, the Strategy Design Pattern is like having different tools to make your robot do different things. 
The robot is the context, and the tools are the strategies. You can switch between the tools to make the robot do different things without changing the robot or the remote control.

This is useful because you can have a robot that can do many things without having to buy a new robot for each task. 
Just like you can have a toy robot that can do many things with different tools, you can have software that can do many things with different strategies.

 */