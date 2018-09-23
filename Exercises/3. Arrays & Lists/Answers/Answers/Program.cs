using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answers
{
    enum Q3
    {
        ArrayLength = 5
    }

    class Program
    {
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

            char[] letterArr = new char[userName.Length];

            int arrPointer = userName.Length - 1;

            foreach (char letter in userName)
            {
                letterArr[arrPointer] = letter;
                arrPointer--;
            }

            Console.WriteLine(letterArr);
            Console.ReadLine();

        }

        static void Question_3()
        {
            int countNums = 0;
            int[] numsList = new int[(int)Q3.ArrayLength];

            while (countNums < (int)Q3.ArrayLength)
            {
                Console.Write("Enter a number you have not entered before: ");
                string numberStr = Console.ReadLine();
                int number = Convert.ToInt32(numberStr);

                if (!numsList.Contains(number))
                {
                    numsList[countNums] = number;
                    countNums++;
                }
            }

            Array.Sort(numsList);

            foreach (int number in numsList) { Console.Write(number); }

            Console.ReadLine();
        }

        static void Question_4()
        {
            List<int> userNumbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number: ");
                string numStr = Console.ReadLine();

                if (numStr.ToUpper() == "OK"){ break; }

                else
                {
                    int numInt = Convert.ToInt32(numStr);
                    userNumbers.Add(numInt);
                }
            }

            foreach (int num in userNumbers.Distinct()){ Console.WriteLine(num); }
            Console.ReadLine();            
        }

        static void Question_5()
        {
            List<string> userListStr = new List<string>();
            while (true)
            {
                Console.Write("Supply a list of comma separated numbers: ");
                string userStr = Console.ReadLine();

                userListStr.Clear();
                userListStr = userStr.Split(',').ToList();

                if (userListStr.Count >= 5) { break; }
                else { Console.WriteLine("Enter a sequence of 5 numbers or more!!"); }
            }

            List<int> userList = userListStr.Select(int.Parse).ToList();
            userList.Sort();

            Console.WriteLine("The three smallest numbers are: {0}, {1} and {2} respectively", userList[0], userList[1], userList[2]);
            Console.ReadLine();
        }
    }
}
