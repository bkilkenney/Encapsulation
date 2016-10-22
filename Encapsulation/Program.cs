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

            Animal simba = new Animal();

            Console.WriteLine("How old is your pet Lion?");
            simba.Age = int.Parse(Console.ReadLine());

            Console.ReadKey();

            Console.WriteLine("Your pet Lion Simba is " + simba.Age + " years old, that's wonderful!\n");

            Console.ReadKey();

            
        }
    }
}
