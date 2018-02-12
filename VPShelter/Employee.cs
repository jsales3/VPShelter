using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class Employee: VirtualPet
    {
        //fileds
        private string name;
        private int employeeID;

        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int EmployeeID
        {
            get { return employeeID;}
            set { employeeID = value; }

        }



        //Methods
        public abstract string ClockIn();

        public abstract int ShowID();


    }
}
