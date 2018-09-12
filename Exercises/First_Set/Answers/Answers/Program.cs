using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answers
{
    enum PenaltyPoint
    {
        VariablePenalty = 1,
        MaximumPenalty = 12
    }

    enum SpeedLimitPenaltyIntervals
    {
        IntervalKM = 5 
    }

    class Program
    {
        static void Main()
        {
            //Question_1();
            //Question_2();
            // Question_3();
            Question_4();
        }

        static void Question_1()
        {
            while (true)
            {
                Console.Write("Enter a number between 1 to 10: ");
                string userNumberStr = Console.ReadLine();

                // if the number is a digit
                if (int.TryParse(userNumberStr, out int userNumber))
                { 
                    if (userNumber > 0 && userNumber < 11)
                    {
                        Console.WriteLine("Valid");
                        Console.ReadLine();
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                }
            }
        }

        static void Question_2()
        {
            string firstNumberStr;
            int firstNumber;

            while (true)
            {
                Console.Write("Enter one number: ");
                firstNumberStr = Console.ReadLine();

                if (int.TryParse(firstNumberStr, out firstNumber)){ break;}
            }

            string secondNumberStr;
            int secondNumber;

            while (true)
            {
                Console.Write("Enter a second number: ");
                secondNumberStr = Console.ReadLine();

                if (int.TryParse(secondNumberStr, out secondNumber)) { break; }
            }

            if (firstNumber > secondNumber)
            {
                Console.Write("The first number is bigger");
                Console.ReadLine();
            }

            else
            {
                Console.Write("The second number is bigger");
                Console.ReadLine();
            }
        }

        static void Question_3()
        {            
            int heightNum;

            while (true)
            {
                Console.Write("Enter the height of the image: ");
                string heightStr = Console.ReadLine();

                if (int.TryParse(heightStr, out heightNum)) { break; }
            }

            int widthNum;

            while (true)
            {
                Console.Write("Enter the width of the image: ");
                string widthStr = Console.ReadLine();

                if (int.TryParse(widthStr, out widthNum)) { break; }
            }

            if (heightNum < widthNum){ Console.WriteLine("Photo is landscape"); }
            else { Console.WriteLine("Photo is portrait"); }

            Console.ReadLine();
        }

        static void Question_4()
        {
            int speed;
            while (true)
            {
                Console.Write("Enter the speed of the car: ");
                string speedStr = Console.ReadLine();

                if (int.TryParse(speedStr, out speed) && speed > 0) { break; }
            }

            int speedLimit;
            while (true)
            {
                Console.Write("Enter the speed limit: ");
                string speedLimitStr = Console.ReadLine();

                if (int.TryParse(speedLimitStr, out speedLimit) && speedLimit > 0) { break; }
            }

            if (speed > speedLimit)
            {
                int penaltyPoints = (speed - speedLimit) / (int)SpeedLimitPenaltyIntervals.IntervalKM;

                int demeritPoints;
                while (true)
                {
                    Console.Write("Enter the current amount of demerit points: ");
                    string demeritPointsStr = Console.ReadLine();

                    if (int.TryParse(demeritPointsStr, out demeritPoints) && demeritPoints >= 0) { break; }
                }

                if ((demeritPoints + penaltyPoints) == (int)PenaltyPoint.MaximumPenalty)
                {
                    Console.Write("License Suspended");
                }
            }

            else { Console.Write("You will live to see another day"); }

            Console.ReadLine();
        }

    }
}
