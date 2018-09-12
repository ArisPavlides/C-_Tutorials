using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main()
        {
            int hour = 14;

            if (hour > 5 && hour < 12)
            {
                Console.WriteLine("Good morning");
                Console.ReadLine();
            }

            else if (hour >= 12 && hour < 17)
            {
                Console.WriteLine("Good afternoon");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("It's business time");
                Console.ReadLine();
            }

            string wishes = (hour >= 17 || hour <= 5) ? ("Its business time") : ("It's not business time");
            Console.WriteLine(wishes);
            Console.ReadLine();

            Season seasonNow = Season.Winter;

            switch (seasonNow)
            {
                // if two or more cases are under each other and only the bottom case contains a block of what to do, it means that the code will be executed if either 
                // of the cases is satisfied
                case Season.Winter:
                case Season.Spring:
                    Console.WriteLine("Bad weather :(");
                    Console.ReadLine();
                    break;

                case Season.Summer:
                    Console.WriteLine("Its summer");
                    Console.ReadLine();
                    break;

                case Season.Autumn:
                    Console.WriteLine("Its autumn");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("I fucked up");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
