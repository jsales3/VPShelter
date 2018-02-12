using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Manager: Employee
    {
        private int salary;

        public int Salary
        {
            get { return Salary; }
            set { Salary = value; }
        }

        public Manager()
        {
            //defauly constructor
        }

        public Manager(int salary)
        {
            this.salary = salary;
        }

        public override string ClockIn()
        {
            return "Thanks for clocking in at Jovon's Virtual Pet Shelter";
        }

        public override int ShowID()
        {
            return EmployeeID;
        }

        public void Adopt()
        {
            Console.WriteLine("you have successfully apdoted your pet");
            
           
            
        }

        //public int ManagerOptions()
        //{
        //    Console.WriteLine("Thank you for working at Jovon's Virtual Pet Shelter\n\n");
        //    Console.WriteLine("What would you like to do?\n");

        //    List<string> options = new List<string>();
        //    options.Add("1. Adot a pet");
        //    options.Add("2. Feed the pets");
        //    options.Add("3. Play With a pet");
        //    options.Add("4 Pay the bills");
        //    options.Add("5. Quit");

        //    foreach(string option in options)
        //    {
        //        Console.WriteLine(option);
        //    }
        //    Console.WriteLine("Enter a number that corressponds to an option:");
        //    int userOption = int.Parse(Console.ReadLine());
        //    return userOption;
        //}
    }
}
