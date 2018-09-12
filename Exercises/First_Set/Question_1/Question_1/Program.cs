using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a number between 1 to 10");
                string userNumberStr = Console.ReadLine();

                // if the number is a digit
                if (userNumberStr.All(char.IsDigit))
                {
                    int userNumber = Convert.ToInt32(userNumberStr);

                    if (userNumber > 0 && userNumber < 11)
                    {
                        Console.WriteLine("Valid");
                        Console.ReadLine();
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                }
            }           
        }
    }
}
