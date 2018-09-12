using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Statements
{
    class Program
    {
        static void Main()
        {
            // using "for" loop on a List<T> is 2 times as fast as using "foreach" loop on a List<T> 
            // looping on an array is around 2 times cheaper than looping  on List<T>
            // looping on array using "for" is 5 times cheaper than looping on List <T> using "foreach"
               
            string myName = "Kirk Lazarus";

            for (int i = 0; i < myName.Length; i++)
            {
                bool isL = (myName[i] == 'L') ? (true) : (false);
                Console.WriteLine("The letter L lies in the {0} position -> {1}", i, isL);
                Console.ReadLine();
            }

            foreach (char letter in myName)
            {
                Console.WriteLine(letter);
                Console.ReadLine();
            }

            while (true)
            {
                Console.Write("Type your name: ");
                string nameGiven = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(nameGiven))
                {
                    Console.WriteLine("The name you have provided is {0}", nameGiven);
                    Console.ReadLine();
                    break;
                }
            }

            while (true)
            {
                Console.Write("Type your name: ");
                string nameGiven = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(nameGiven))
                {
                    Console.WriteLine("The name you have provided is {0}", nameGiven);
                    Console.ReadLine();
                    continue; // continue will force the program to proceed to the next iteration without proceeding any further
                }

                break;
            }
        }
    }
}