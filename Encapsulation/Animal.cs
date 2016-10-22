using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation  //Think hiding implementation of fields, user never sees them, but fields allow access to them
{
    class Animal
    {
        private string type;
        private string color;
        private string weight;
        private string height;
        private int age;
        private int numOfLegs;

        public string Color
        {
            get { return this.color; }
            set { this.color = value; } //Can put logic in the set value to make sure input data is good
        }
        public int Age
        {
            get { return this.age; }  //instance *variable* so lower case
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Age cannot be less than 0.");
                }
                else
                {
                    this.age = value;
                }
                
            } //value = keyword meaning value user is going to pass in
        }



        public void move()
        {
            Console.WriteLine("Moved");
        }

        public void makeNoise()
        {

        }
    }
}
