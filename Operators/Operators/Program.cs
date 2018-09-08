using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // dividing 2 integers returns an integer result (floored)
            int a = 2;
            int b = 3;
            Console.WriteLine(a / b);
            Console.ReadLine();

            // cast both values as float to return a float result from division
            Console.WriteLine((float)a / (float)b);
            Console.ReadLine();

            // operators are prioritised as used in mathematics
            int c = 4;
            Console.WriteLine(a + b * c);
            Console.ReadLine();

            // the result of a comparison is always boolean
            Console.WriteLine(a == b);
            Console.ReadLine();
        }
    }
}