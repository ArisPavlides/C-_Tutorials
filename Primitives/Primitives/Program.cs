using System;

namespace Primitives
{
    class Program
    {
        static void Main()
        {
            byte byte_num = 1;
            int int_num = 2;
            long long_num = 3;

            float flot_num = 3.0f;
            double double_num = 3.0;

            char character = 'A'; // character variables in single quotes
            string myName = "Aris"; // character variables in double quotes

            bool lies = true;

            const int const_int = 42;
            // const_int++; we cannot change the value of a constant

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("{0} {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("{0} {1}", double.MinValue, double.MaxValue);
            Console.ReadLine();
        }
    }
}
