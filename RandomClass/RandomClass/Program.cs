using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                int randomNum = rnd.Next(0, 100); // generate random number between  zero (inclusive) and 100 (exclusive)
                Console.WriteLine(randomNum);
            }

            for (int i = 0; i < 10; i++)
            {
                char intToLetter = (char)rnd.Next(97, 122); // transform the number to its ASCII letter equivalent
                Console.Write(intToLetter);
                
                char intToLetter2 = (char)('a' + rnd.Next(0, 26)); // 'a' is a character which corresponds to a number so we can add any number to it
                Console.Write(intToLetter2);
            }

            char[] lettersCache = new char[10];
            for (int i = 0; i < 10; i++)
            {
                lettersCache[i] = (char)('a' + rnd.Next(0, 26));
            }

            string password = new string(lettersCache);
            Console.WriteLine(password);

            Console.ReadLine();
        }
    }
}
