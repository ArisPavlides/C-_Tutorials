using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answers
{
    class Program
    {
        enum MaxIterations
        {
            IterationsLimit = 4
        }
        static void Main()
        {
            // Question_1();
            // Question_2();
            // Question_3();
            // Question_4();
            Question_5();
        }

        static void Question_1()
        {
            int count_num = 0;
            for (int i = 3; i <= 100; i = i + 3)
            {
                count_num++;
            }

            Console.Write("The count of numbers divisible by 3 between 1 and 100 is {0}", count_num);
        }

        static void Question_2()
        {
            int currentSum = 0;
            while (true)
            {
                Console.Write("Enter a number to continue or \"OK\" to exit: ");
                string userInput = Console.ReadLine();
                
                if (int.TryParse(userInput, out int inputInt)) { currentSum += inputInt; }

                else if (userInput.ToUpper() == "OK") { break; }
            }

            Console.WriteLine("The count of numbers inputted is {0}", currentSum);
            Console.ReadLine();
        }

        static void Question_3()
        {
            while (true)
            {
                Console.Write("Enter a number: ");
                string userInput = Console.ReadLine();

                long currentProduct = 1;
                if (int.TryParse(userInput, out int inputInt) && inputInt >= 0)
                {
                    for (long i = inputInt; i > 0; i--) { currentProduct *= i; }

                    Console.Write("The factorial produces a value of: {0}", currentProduct);
                    Console.ReadLine();

                    break;
                }
            }
        }

        static void Question_4()
        {
            int guessInt = new Random().Next(1, 11);
            Console.WriteLine(guessInt);
            Console.ReadLine();

            bool numFound = false;
            for (int i = 0; i < (int)MaxIterations.IterationsLimit; i++)
            {
                int inputInt;
                while (true)
                {
                    Console.WriteLine("Guess a number between 1 and 10: ");
                    string numProvidedStr = Console.ReadLine();

                    if (int.TryParse(numProvidedStr, out inputInt)) { break; }
                }

                if (inputInt == guessInt)
                {
                    numFound = true;
                    break;
                }
            }

            if (numFound) { Console.WriteLine("You found it"); }
            else { Console.WriteLine("You lost"); }

            Console.ReadLine();
        }

        static void Question_5()
        {
            Console.Write("Enter a random series of numbers separated by coma: ");
            string numSequenceStr = Console.ReadLine();
            string[] numSequence = numSequenceStr.Split(',');

            int maxNumber = int.MinValue;

            foreach (string numberStr in numSequence)
            {
                int number = Convert.ToInt32(numberStr);

                if (maxNumber < number) { maxNumber = number; }
            }

            Console.WriteLine("The maximum number in the array provided is: {0}", maxNumber);
            Console.ReadLine();
        }
    }
}
