using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Hamed Tara - n01540404

namespace Assignemnt02
{
    internal class Course
    {
        public Course(string courseName,string score) {
        CourseName= courseName;
        Score = Int32.Parse(score);
        }
        public string CourseName { get; set; }  
        public int  Score { get; set; }
    }
}
