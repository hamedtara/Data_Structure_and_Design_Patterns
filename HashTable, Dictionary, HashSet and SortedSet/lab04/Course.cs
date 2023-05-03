using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab04
{
    internal class Course : IComparable<Course>
    {
        //construct
        public Course(string input)
        {
            inputdata = input;
        }


        public string inputdata { get; set; }

        public override string ToString()
        {
            return inputdata;
        }
        public int CompareTo(Course other)
        {
            if (other == null)
            {
                return 1;
            }
            else
            {
                return inputdata.CompareTo(other.inputdata);
            }
        }


    }
    
}
