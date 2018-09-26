using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();
            int test1 = calculator.GetSum(2, 3, 4);
            int test2 = calculator.GetSum(2, 3, 4, 5);
            int test3 = calculator.GetSum(2, 3, 4, 5, 6);
            int test4 = calculator.GetSum(new int[] { 1, 3, 5, 7 });

            int numberPow = 5;
            calculator.RaisePower(ref numberPow);

            if (!int.TryParse("aris", out int strToInt))
            {
                Console.WriteLine("Conversion unsuccessful");
                Console.ReadLine();
            }            
        }

        static void PointsGame()
        {
            try
            {
                PointScreen point = new PointScreen(20, 40);
                point.Move(30, 50);
                point.Move(null); // at this line the code will break
            }
            catch (Exception)
            {
                Console.WriteLine("You messed up");
                Console.ReadLine();
            }
        }
    }
}
