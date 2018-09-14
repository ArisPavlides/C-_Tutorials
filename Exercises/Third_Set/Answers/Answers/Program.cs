using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answers
{
    class Program
    {
        static void Main()
        {
            //Question_1();
            Question_2();
        }

        static void Question_1()
        {
            List<string> names = new List<string>();

            while (true)
            {
                Console.Write("Enter a name: ");
                string nameTyped = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nameTyped)) { break; }

                else { names.Add(nameTyped); }
            }

            switch (names.Count)
            {
                case 0:
                    break;

                case 1:
                    Console.WriteLine("{0} has liked your post", names[0]);
                    break;

                case 2:
                    Console.WriteLine("{0} and {1} have liked your post", names[0], names[1]);
                    break;

                default:
                    Console.WriteLine("{0}, {1} and {2} others liked your post", names[0], names[1], names.Count - 2);
                    break;
            }

            Console.ReadLine();
        }

        static void Question_2()
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
        }
    }
}
