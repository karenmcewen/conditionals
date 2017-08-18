using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1 conditionals if/else
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            if(age>=17)
            {
                Console.WriteLine("You can see the movie");
            }
            else
            {
                Console.WriteLine("Sorry, you need a parent present.");

            }

        }
    }
}
