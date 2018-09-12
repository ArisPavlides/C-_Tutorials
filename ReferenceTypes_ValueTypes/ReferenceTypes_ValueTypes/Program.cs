using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes_ValueTypes
{
    class Program
    {
        static void Main()
        {
            // when you copy a value of a variable into another vaariable, a copy of the first variable is taken and stored in the second 
            // variable (hence their name of VALUE TYPES since their value is copied). therefore, since the 2 values now exist in different 
            // locations in the STACK, their values are independent and changing one does not change the other
            int number_1 = 5;
            int number_2 = number_1;
            number_2++;
            Console.WriteLine("number_1: {0} and number_1: {1}", number_1, number_2);
            Console.ReadLine();

            // when an array is created, the array is created in the heap and the value array_1 is located in the stack but points (or references) 
            // a point in the HEAP (hence their name REFERENCE TYPES). by creating another variable array_2 and copying to it array_1, we do not copy 
            // the array itself but the location in the memory where the array is found. therefore, by changing the array we influence all the variables 
            // which refer to it.
            int[] array_1 = new int[] { 5, 7, 9};
            int[] array_2 = array_1;
            array_2[0] = 12;
            Console.WriteLine("The value at index zero of array_1 is: {0}", array_1[0]);
            Console.ReadLine();
        }
    }
}
