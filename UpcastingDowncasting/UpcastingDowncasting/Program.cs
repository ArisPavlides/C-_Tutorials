using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Upcasting -> Conversion from a derived class (child class) to base class (parent class)
// Downcasting -> Conversion from a base class (parent class) to derived class (child class)

namespace UpcastingDowncasting
{
    class Program
    {
        static void Main()
        {
            // in this case circle is the child class of the shape class so we convert the circle object to a shape object (upcasting)
            Circle circle = new Circle();
            Shape shape = circle;

            // this is an example of downcasting since we cast an instance of a parent class to an instance of  child class
            Circle anotherCirle = (Circle)shape;

            // below we see an example of an invalid cast since the shape object is not related to car (either child or parent)
            // Car car = (Car)shape; // this will throw invalid exception

            // the code below will first check if the shape is of a car type and then proceeds to do somehing with it
            if (shape is Car)
            {

                Console.WriteLine("Conversion successful!");
            }
        }
    }
}
