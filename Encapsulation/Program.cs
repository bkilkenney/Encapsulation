using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog Sami = new Dog();
            Sami.Age = 4;

            Console.WriteLine(Sami.Age);
            Sami.move();
            
            
            
            
            
            //Animal simba = new Animal();


            //Console.WriteLine("How old is your pet Lion?");
            //simba.Age = int.Parse(Console.ReadLine());

            //if (simba.Age > 0)
            //    {
            //        Console.WriteLine("Your pet Lion Simba is " + simba.Age + " years old, that's wonderful!\n");
            //    }
            //    else
            //    {
            //    Console.Clear();
            //    }

            //Console.ReadKey();

            
        }
    }
}
