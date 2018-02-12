using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Pets myPet = new Pets();
            Pets myPet2 = new Pets();
            Pets myPet3 = new Pets();
            Pets myPet4 = new Pets();

            Volunteer myVolunteer = new Volunteer();
            Volunteer myVolunteer2 = new Volunteer();
            Volunteer myVolunteer3 = new Volunteer();
            Volunteer myVolunteer4 = new Volunteer();

            myVolunteer.Name = "Nicole";
            myVolunteer2.Name = "Mike";
            myVolunteer3.Name = "Matt";
            myVolunteer4.Name = "Sarah";

            myVolunteer.EmployeeID = 0011224;
            myVolunteer2.EmployeeID = 0011225;
            myVolunteer3.EmployeeID = 0011226;
            myVolunteer4.EmployeeID = 0011227;

            Manager myManager = new Manager(35000);
            myManager.Name = "Jovon";
            myManager.EmployeeID = 0011223;
            

            myPet.PetType = "cat";
            myPet2.PetType = "dog";
            myPet3.PetType = "pig";
            myPet4.PetType = "bunny";

            myPet.PetDiet = "cat nip";
            myPet2.PetDiet = "bacon";
            myPet3.PetDiet = "grass";
            myPet4.PetDiet = "carrots";

            myPet.Name = "fuzzy";
            myPet2.Name = "bark";
            myPet3.Name = "oink";
            myPet4.Name = "buzz";

            myPet.Description = "A 1 month old kitty";
            myPet2.Description = "A baby pitbull";
            myPet3.Description = "A baby piggy";
            myPet4.Description = "A baby bunny who loves carrots";


            int userChoice;

            Console.WriteLine("Welcome to Jovon's Virtual Pet Shelter! What employee type are you?\n");
            Console.WriteLine("1. Manager \n2. Volunteer \nEnter a number that corresspond to a option.");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {

                Console.WriteLine(myManager.ClockIn()); 

                do
                {
                    
                    
                    Console.WriteLine("\nWhat would you like to do?\n");

                    List<string> options = new List<string>();
                    options.Add("1. Adot a pet");
                    options.Add("2. Feed the pets");
                    options.Add("3. Play With a pet");
                    options.Add("4. Give pets water");
                    options.Add("5. See pet details");
                    options.Add("6. View all Employees");
                    options.Add("7. Pay the bills");
                    options.Add("8. Quit");

                    foreach (string option in options)
                    {
                        Console.WriteLine(option);
                    }
                    Console.WriteLine("Enter a number that corressponds to an option:");

                    myPet2.tick();
                    myPet3.tick();
                    myPet.tick();
                    myPet4.tick();
                    userChoice = int.Parse(Console.ReadLine());

                    switch (userChoice)
                    {
                        case 1:
                            Console.WriteLine("\nWhich pet would you like to adopt?");
                            Console.WriteLine("1. " + myPet.Name + ": " + myPet.Description);
                            Console.WriteLine("2. " +myPet2.Name + ": " + myPet2.Description);
                            Console.WriteLine("3. " +myPet3.Name + ": " + myPet3.Description);
                            Console.WriteLine("4. " +myPet4.Name + ": " + myPet4.Description);
                            userChoice = int.Parse(Console.ReadLine());
                            if(userChoice >=1 && userChoice <= 4)
                            {
                                myManager.Adopt();
                            }
                            else
                            {
                                Console.WriteLine("Enter a valid number that corresponds to an option");
                            }
                            break;

                        case 2:
                            myPet.Feed(myPet.PetDiet);
                            myPet2.Feed(myPet2.PetDiet);
                            myPet3.Feed(myPet3.PetDiet);
                            myPet4.Feed(myPet4.PetDiet);
                            break;

                        case 3:
                            Console.WriteLine("Which pet would you like to play with?");
                            Console.WriteLine("1. " + myPet.Name);
                            Console.WriteLine("2. " + myPet2.Name);
                            Console.WriteLine("3. " + myPet3.Name);
                            Console.WriteLine("4. " + myPet4.Name);
                            Console.WriteLine("Enter a number that corresponds to an option");
                            userChoice = int.Parse(Console.ReadLine());

                            if(userChoice == 1)
                            {
                                myPet.PlayWith();
                            }
                            else if(userChoice == 2)
                            {
                                myPet2.PlayWith();
                            }
                            else if(userChoice == 3)
                            {
                                myPet3.PlayWith();
                            }
                            else if(userChoice == 4)
                            {
                                myPet4.PlayWith();
                            }
                            else
                            {
                                Console.WriteLine("Enter a valid number that corresponds to an option");
                            }
                            break;

                        case 4:
                            myPet.GiveWater();
                            myPet2.GiveWater();
                            myPet3.GiveWater();
                            myPet4.GiveWater();
                            break;

                        case 5:
                            Console.WriteLine("This is the status of your pets:\n");
                            Console.WriteLine("Name  |Hunger  |Thirst  |Boredom");
                            Console.WriteLine("------|--------|--------|-------");
                            Console.WriteLine(myPet.Name + " | " + myPet.HungryLevel + "      | " + myPet.ThirstLevel + "      | " + myPet.BoredLevel);
                            Console.WriteLine(myPet2.Name + "  | " + myPet2.HungryLevel + "      | " + myPet2.ThirstLevel + "      | " + myPet2.BoredLevel);
                            Console.WriteLine(myPet3.Name + "  | " + myPet3.HungryLevel + "      | " + myPet3.ThirstLevel + "      | " + myPet3.BoredLevel);
                            Console.WriteLine(myPet4.Name + "  | " + myPet4.HungryLevel + "      | " + myPet4.ThirstLevel + "      | " + myPet4.BoredLevel);
                            break;

                        case 6:
                            Console.WriteLine("Here is the current list of all employees: ");
                            Console.WriteLine("\nManager: " + myManager.Name + " ID: " + myManager.ShowID());
                            Console.WriteLine("\nVolunteers: ");
                            Console.WriteLine("Name: " +myVolunteer.Name +  " " + "ID: " +myVolunteer.ShowID());
                            Console.WriteLine("Name: " +myVolunteer2.Name + " " + "ID: " +myVolunteer2.ShowID());
                            Console.WriteLine("Name: " +myVolunteer3.Name + " " + "ID: " +myVolunteer3.ShowID());
                            Console.WriteLine("Name: " +myVolunteer4.Name + " " + "ID: " +myVolunteer4.ShowID());
                            break;

                        case 7:
                            Console.WriteLine("The bills have been payed");
                            break;

                    }

                    

                }
                while (userChoice != 8);


            }

            if (userChoice == 2)
            {

                Console.WriteLine(myVolunteer.ClockIn());
                Console.WriteLine("This is the status of your pets:\n");
                Console.WriteLine("Name  |Hunger  |Thirst  |Boredom");
                Console.WriteLine("------|--------|--------|-------");
                Console.WriteLine(myPet.Name + " | " + myPet.HungryLevel + "      | " + myPet.ThirstLevel + "      | " + myPet.BoredLevel);
                Console.WriteLine(myPet2.Name + "  | " + myPet2.HungryLevel + "      | " + myPet2.ThirstLevel + "      | " + myPet2.BoredLevel);
                Console.WriteLine(myPet3.Name + "  | " + myPet3.HungryLevel + "      | " + myPet3.ThirstLevel + "      | " + myPet3.BoredLevel);
                Console.WriteLine(myPet4.Name + "  | " + myPet4.HungryLevel + "      | " + myPet4.ThirstLevel + "      | " + myPet4.BoredLevel);
                

                do
                {
                    Console.WriteLine("\nWhat would you like to do next?");
                    Console.WriteLine("1. Feed the pets \n2. Water the pets \n3. Play with a pet \n4. See pet status \n5. Quit");
                    Console.WriteLine("Enter a number that corresponds to an option");
                    userChoice = int.Parse(Console.ReadLine());
                    myPet.tick();
                    myPet4.tick();
                    myPet2.tick();
                    myPet3.tick();


                    switch (userChoice)
                    {
                        case 1:
                            myPet.Feed(myPet.PetDiet);
                            myPet2.Feed(myPet2.PetDiet);
                            myPet3.Feed(myPet3.PetDiet);
                            myPet4.Feed(myPet4.PetDiet);
                            Console.WriteLine(myVolunteer.Feed());
                            break;

                        case 2:
                            myPet.GiveWater();
                            myPet2.GiveWater();
                            myPet3.GiveWater();
                            myPet4.GiveWater();
                            Console.WriteLine(myVolunteer.GiveWater());
                            break;

                        case 3:
                            Console.WriteLine("Which pet would you like to play with?");
                            Console.WriteLine("1. " + myPet.Name);
                            Console.WriteLine("2. " + myPet2.Name);
                            Console.WriteLine("3. " + myPet3.Name);
                            Console.WriteLine("4. " + myPet4.Name);
                            Console.WriteLine("Enter a number that corresponds to an option");
                            userChoice = int.Parse(Console.ReadLine());

                            if (userChoice == 1)
                            {
                                myPet.PlayWith();
                            }
                            else if (userChoice == 2)
                            {
                                myPet2.PlayWith();
                            }
                            else if (userChoice == 3)
                            {
                                myPet3.PlayWith();
                            }
                            else if (userChoice == 4)
                            {
                                myPet4.PlayWith();
                            }
                            else
                            {
                                Console.WriteLine("Enter a valid number that corresponds to an option");
                            }
                            break;

                        case 4:
                            Console.WriteLine("This is the status of your pets:\n");
                            Console.WriteLine("Name  |Hunger  |Thirst  |Boredom");
                            Console.WriteLine("------|--------|--------|-------");
                            Console.WriteLine(myPet.Name + " | " + myPet.HungryLevel + "      | " + myPet.ThirstLevel + "      | " + myPet.BoredLevel);
                            Console.WriteLine(myPet2.Name + "  | " + myPet2.HungryLevel + "      | " + myPet2.ThirstLevel + "      | " + myPet2.BoredLevel);
                            Console.WriteLine(myPet3.Name + "  | " + myPet3.HungryLevel + "      | " + myPet3.ThirstLevel + "      | " + myPet3.BoredLevel);
                            Console.WriteLine(myPet4.Name + "  | " + myPet4.HungryLevel + "      | " + myPet4.ThirstLevel + "      | " + myPet4.BoredLevel);
                            break;

                    }

                   
                }
                while (userChoice != 5);
            }

            

        }
    }
}
