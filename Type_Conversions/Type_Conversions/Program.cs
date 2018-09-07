using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversions
{
    class Program
    {
        static void Main()
        {
            // this is implicit conversion since byte takes less space than int so it can be converted without loss of accuracy
            byte num_1 = 1;
            int num_2 = num_1;
            Console.WriteLine(num_2);
            Console.ReadLine();

            // this is explicit conversion since int takes more space than byte so it cannot be converted implicitly. the int value can be CASTED as a byte though since 
            // the value of the int variable is small enough (ie 1) so as to be converted without a loss of accuracy
            int num_3 = 1;
            byte num_4 = (byte)num_3;
            Console.WriteLine(num_4);
            Console.ReadLine();

            // this is an explicit conversion but a loss of accuracy takes place since the value assigned to the int variable is too big to be stored in the byte variable
            int num_5 = 300;
            byte num_6 = (byte)num_5;
            Console.WriteLine(num_6);
            Console.ReadLine();

            // a string variable and an int variable are not compatible so we need to use the Convert class. the int variable has enough memory to store to value of the string converted
            string num_7 = "1234";
            int num_8 = Convert.ToInt32(num_7);
            Console.WriteLine(num_8);
            Console.ReadLine();

            // a string variable and an int variable are not compatible so we need to use the Convert class. the int variable does not have enough memory to store to value of the string converted. Therefore
            // a Try statement is inserted which, whenever an error arises in conversion, returns a message
            try
            {
                string num_9 = "1234";
                byte num_10 = Convert.ToByte(num_9);
                Console.WriteLine(num_10);
                Console.ReadLine();
            }

            catch (Exception)
            {
                Console.WriteLine("Error in conversion");
                Console.ReadLine();
            }

            // a string variable, if it has the approprate value, can be stored as a bool variable not by using casting since a string and bool variables are incompatible, but by using the Convert statement
            string num_11 = "false";
            bool num_12 = Convert.ToBoolean(num_11);
            Console.WriteLine(num_12);
            Console.ReadLine();
        }
    }
}
