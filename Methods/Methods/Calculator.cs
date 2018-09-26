using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Calculator
    {
        public int GetSum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers) { sum += number; }

            return sum;
        }

        public void RaisePower(ref int power)
        {
            power = (int)Math.Pow(power, 2);           
        }
    }
}
