using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 1, 3, 5, 7, 9};

            // add items to the list
            numbers.Add(2); // add a single element to the list
            int[] numArray = new int[4] { 4, 6, 8, 9 };
            numbers.AddRange(numArray); // add a range to the list. the range must be an interface
            foreach (var number in numbers){ Console.WriteLine(number); }

            // get the index of an item in the list
            int idx7 = numbers.IndexOf(7); // find the index of the first occurence of an item in the list
            int idx0 = numbers.IndexOf(0); // when the item does not exist in teh list, it returns -1
            int id9Last = numbers.LastIndexOf(9); // find the index of the last occurence of an item in the list

            //count the items in the list
            int numItems = numbers.Count;

            // remove items from the list
            numbers.Remove(7); // removes the first occurence of an item in the list

            // if we want to remove several items from the list, we need to use a for loop rather than a foreach loop since the foreach loop does not allow 
            // for a collection to be modified during its execution
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 9) { numbers.Remove(numbers[i]); }
            }

            // clears all elements from the list
            numbers.Clear();

            Console.ReadLine();
        }
    }
}
