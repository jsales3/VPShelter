using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Volunteer: Employee
    {
        private int hoursAvailable;

        public int HoursAvailable
        {
            get { return HoursAvailable; }
            set { HoursAvailable = value; }
        }

        public Volunteer()
        {
            //default constructor
        }

        public override string ClockIn()
        {
            return "Thanks for clocking in at Jovon's Virtual Pet Shelter";    
        }

        public override int ShowID()
        {
            return EmployeeID;
        }

        public string Feed()
        {
            return "All pets have been feed";
        }

        public string GiveWater()
        {
            return "you gave all your pet some water";
        }

        //public int GetOption()
        //{
        //    Console.WriteLine();
        //}
    }
}
