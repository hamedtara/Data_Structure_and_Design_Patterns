using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06.Strategy_Design_Pattern
{
    public class Item
    {
        public Item(string name , int page) {
        
            Name = name;
            Page = page;
        }
        public string Name { get; set; }
        public int Page { get; set; }
    }
}
