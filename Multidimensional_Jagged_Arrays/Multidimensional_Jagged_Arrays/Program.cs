using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_Jagged_Arrays
{
    class Program
    {
        static void Main()
        {
            //CLR is heavily optimized for single-dimension array access, so using a jagged array will likely be faster than a multidimensional array of the same size.

            // single dimensional array
            int[] num_array = new int[] { 9, 7, 5, 3, 9, 2, 4, 6, 8 };

            // find the length of the array. In this case .Length operates on an instance of a class while the rest of the functions below operate directly on the 
            // class itself since these classes are static
            int arr_length = num_array.Length;

            // returns the index of the first occurence of an item in an array
            int index_9 = Array.IndexOf(num_array, 9); 
            int index_10 = Array.IndexOf(num_array, 10); // if the index is not found, it returns -1

            // clear the array starting from index 3 and for the next 2 entries (i.e. 3+4)
            Array.Clear(num_array, 3, 2);

            // copies the first 3 entries from the first array into a second array
            int[] tmpx_array = new int[3];
            Array.Copy(num_array, tmpx_array, 3);

            // sorts the array given
            Array.Sort(num_array);

            // reverses the order of the items in the array
            Array.Reverse(num_array);
        }
    }
}
