using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Pets: VirtualPet
    {
        //fields
        private string petType;
        private string petDiet;

        //properties

        public string PetType
        {
            get { return petType; }
            set { petType = value; }    
        }

        public string PetDiet
        {
            get { return petDiet; }
            set { petDiet = value; }
        }

        public Pets()
        {
            //default constructor
        }

        public Pets(string petType, string petDiet)
        {

        }



    }
}
