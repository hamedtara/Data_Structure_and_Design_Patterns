using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05.Composite
{
   
        public class HeadDepartment : Departmnet
        {
            public List<Departmnet> department = new List<Departmnet>();

            public void getdepartmentDetail()
            {
          
                foreach (Departmnet department in this.department)
                {
                   department.getdepartmentDetail();

            }

            }

            public void AddDepartment(Departmnet service)
            {
                department.Add(service);
            }

            public void RemoveService(Departmnet service)
            {
                department.Remove(service);
            }
        }
    }

