using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualPet
    {
        //fields
        private string name;
        private string description;
        private string furColor;
        private int hungryLevel = 0;
        private int thirstLevel = 0;
        private int boredLevel = 0;
        private int foodAmount = 0;
        private int weight;
        private bool isFull = false;
        private string foodChoice;



        //Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string FurColor
        {
            get { return furColor; }
            set { furColor = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int HungryLevel
        {
            get { return hungryLevel; }
            set { hungryLevel = value; }

        }

        public int ThirstLevel
        {
            get { return thirstLevel; }
            set { hungryLevel = value; }
        }

        public int BoredLevel
        {
            get { return boredLevel; }
            set { hungryLevel = value; }
        }

        public int FoodAmount
        {
            get { return foodAmount; }

        }

        public string FoodChoice
        {
            get { return foodChoice; }
            set { foodChoice = value; }
        }

        public bool IsFull
        {
            get { return isFull; }
            set { isFull = value; }
        }


        //constructors
        public VirtualPet()
        {

        }

        public VirtualPet(string name, string furColor, int weight)
        {
            this.name = name;
            this.furColor = furColor;
            this.weight = weight;
        }

        public VirtualPet(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public VirtualPet(string name, string description, int hunger, int thirst, string furColor, int weight)
        {
            this.name = name;
            this.description = description;
            this.hungryLevel = hunger;
            this.thirstLevel = thirst;
            this.furColor = furColor;
            this.weight = weight;
        }

        public void Feed(string foodType)
        {
            switch (foodType)
            {
                case "cat nip":
                    hungryLevel = 0;
                    thirstLevel++;
                    foodAmount++;
                    Console.WriteLine("you feed " + name + " cat nip");
                    break;

                case "bacon":
                    hungryLevel = 0;
                    thirstLevel++;
                    foodAmount++;
                    Console.WriteLine("you feed " + name + " bacon");
                    break;

                case "grass":
                    hungryLevel = 0;
                    thirstLevel++;
                    foodAmount++;
                    Console.WriteLine("you feed " + name + " grass");
                    break;

                case "carrots":
                    hungryLevel = 0;
                    thirstLevel++;
                    foodAmount++;
                    Console.WriteLine("you feed " + name + " carrots");
                    break;
            }
        }

        public void GiveWater()
        {
            thirstLevel = 0;
            Console.WriteLine("you gave " + name + " some water");

        }

        public void PlayWith()
        {
            boredLevel = 0;
            Console.WriteLine(name + " had a nice walk");

        }

        public void ToBathroom()
        {
            hungryLevel = 0;
            thirstLevel = 0;
            foodAmount = 0;
            isFull = false;
            Console.WriteLine(name + " has used the bathroom");
        }

        public void tick()
        {
            hungryLevel++;
            thirstLevel++;
            boredLevel++;
        }

        //public void Food()
        //{
        //    List<string> foodType = new List<string> { "Beef", "Pork", "Chicken" };

        //    foreach (string food in foodType)
        //    {
        //        Console.WriteLine(food);

        //    }

        //}
    }
}
