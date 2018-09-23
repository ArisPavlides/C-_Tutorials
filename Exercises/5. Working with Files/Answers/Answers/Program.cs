using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Answers
{
    class Program
    {
        static void Main()
        {
            // 1- Write a program that reads a text file and displays the number of words.
            string path = @"C:\Users\arisp\Documents\CSharp_Tutorials\Exercises\5. Working with Files\Questions.txt";
            string file = File.ReadAllText(path);
            file = file.Replace("\r\n", " ");

            Console.WriteLine(file.Replace(" ", "").Length);

            // 2 - Write a program that reads a text file and displays the longest word in the file.
            int maxWord = int.MinValue;
            foreach (string word in file.Split(' '))
            {
                if (word.Length > maxWord) { maxWord = word.Length; }
            }
            Console.WriteLine(maxWord);
            Console.ReadLine();
        }
    }
}
