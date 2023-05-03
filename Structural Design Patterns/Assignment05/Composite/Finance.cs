using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment05.Composite
{
    public class Finance : Departmnet
    {
        public int id { get; set; }
        public string name { get; set; }
        public Finance(int id , string name ) { 
        
            this.id = id;
            this.name = name;
        
        }

        public void getdepartmentDetail()
        {
            Console.WriteLine(id + "" + name);
        }
    }
}
