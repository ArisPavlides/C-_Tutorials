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
            // Question_1();
            // Question_2();
            // Question_3();
            // Question_4();
            Question_5();
        }

        /* 1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are 
         * consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; 
         * otherwise, display "Not Consecutive".*/
        static void Question_1()
        {
            Console.WriteLine("Enter a series of numbers separated by a comma: ");
            string userSeries = Console.ReadLine();

            string[] series = userSeries.Split(',');

            bool consecutive = true;
            int prev = Convert.ToInt32(series[0]);
            int back2 = Convert.ToInt32(series[0]); // keep track of this since 5,6,7,6 will not be captured by absolute diff

            for (int i = 1; i < series.Length; i++)
            {
                int now = Convert.ToInt32(series[i]);

                if (Math.Abs(prev - now) != 1 || now == back2)
                {
                    consecutive = false;
                    break;
                }

                back2 = prev;
                prev = now;
            }

            if (consecutive) { Console.WriteLine("Consecutive"); }
            else { Console.WriteLine("Not consecutive"); }

            Console.ReadLine();
        }

        /* 2- Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses 
         * Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, 
         * display "Duplicate" on the console. */
        static void Question_2()
        {
            Console.WriteLine("Enter a few numbers separated by hyphen: ");
            string userNums = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userNums)) { Console.WriteLine("Empty string eentered"); }

            else
            {
                List<string> numArr = userNums.Split('-').ToList();
                bool doublicate = false;

                while (numArr.Count > 0)
                {
                    string nowNum = numArr[0];
                    numArr.RemoveAt(0);

                    if (numArr.Contains(nowNum))
                    {
                        doublicate = true;
                        break;
                    }
                }

                if (doublicate) { Console.WriteLine("Doublicates exist"); }
                else { Console.WriteLine("No dublicates"); }
                Console.ReadLine();
            }
        }

        /* 3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid 
         * time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
         * If the user doesn't provide any values, consider it as invalid time. */
        static void Question_3()
        {
            Console.WriteLine("Enter a time value in the 24-hour time format: ");
            string userTime = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userTime)) { return; }

            string[] timeParts = userTime.Split(':');

            byte num1 = Convert.ToByte(timeParts[0]);
            byte num2 = Convert.ToByte(timeParts[1]);

            if (0 <= num1 && num1 <= 23)
            {
                if (0 <= num2 && num2 <= 59) { Console.WriteLine("OK"); }
                else { Console.WriteLine("Not OK"); }
            }

            else { Console.WriteLine("Not OK"); }

            Console.ReadLine();
        }

        /* Write a program and ask the user to enter a few words separated by a space. Use the words to create a 
         * variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". 
         * Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the 
         * program should still display "NumberOfStudents". */
        static void Question_4()
        {
            Console.WriteLine("Enter a few words separated by a space");
            string userStr = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userStr)) { return; }

            StringBuilder builder = new StringBuilder();

            foreach (string word in userStr.Split(' '))
            {
                string firstLetter = word.ToUpper();
                builder.Append(firstLetter[0]);

                string remaining = word.ToLower();
                builder.Append(remaining.Substring(1));
            }

            Console.WriteLine(builder);
            Console.ReadLine();
        }

        /* Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) 
         * in the word. So, if the user enters "inadequate",  the program should display 6 on the console. */
        static void Question_5()
        {
            Console.WriteLine("Enter a word: ");
            string userWord = Console.ReadLine();

            List<char> vowels = new List<char>() { 'a', 'e', 'o', 'u', 'i' };
            int numVowels = 0;

            foreach (char letter in userWord)
            {
                if (vowels.Contains(letter)) { numVowels++; }
            }

            Console.WriteLine(numVowels);
            Console.ReadLine();
        }
    }
}
