using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class Rectangle:Shape
    {
        public override void Draw()
        {
            // base.Draw(); // this command inherits the code in the method found in the base class. Now Draw is empty so commend out

            Console.WriteLine("Enter algorithm for drawing a rectangle");
        }
    }
}
