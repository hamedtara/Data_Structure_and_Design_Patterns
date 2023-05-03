using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04.Singleton
{
    internal class Course
    {
        // https://www.youtube.com/watch?v=DcbxFugk5pM

        private static Course CoursesObj = null;
        private Course()
        {

        }
        public static Course getInstance()
        {
            if (CoursesObj == null)
            {
                CoursesObj = new Course();
            }
            return CoursesObj;
        }


    }
}
