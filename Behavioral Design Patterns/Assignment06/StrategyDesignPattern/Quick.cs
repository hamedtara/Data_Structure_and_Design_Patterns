using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06.Strategy_Design_Pattern
{
    public class Quick : SortInterface
    {
        public int QuickSort { get; set; }
        public string Name { get; set; }

        public Quick() { }
        public Quick(string name ,int quickSort)
        {
            Name = name;
            QuickSort= quickSort;
        }
        public void Sort(int sorted)
        {
            Console.WriteLine(sorted+  " Sort way : Quick Sort");
        }
    }
}
