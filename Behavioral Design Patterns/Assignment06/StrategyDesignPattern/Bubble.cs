using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06.Strategy_Design_Pattern
{
    public class Bubble : SortInterface
    {
        public int BubbleSort { get; set; }
        public string  Name { get; set;}
        public Bubble(string name,int bublesort) {

            Name = name;          
            BubbleSort = bublesort;
        
        }

        public void Sort(int sorted)
        {
            Console.WriteLine(sorted +  " Sort way : bubble sort ");

        }
    }
}
