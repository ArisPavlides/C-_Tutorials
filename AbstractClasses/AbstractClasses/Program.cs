using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * In the project "MethodOverriding" we saw that the methods of the base class can be overriden in the derived class by using the 
 * modifiers "virtual" and "override". As seen in the previous example though, the method "Draw" in the Shape class was defined
 * as empty and was left to each individual class to provide the algorithm for drawing a shape. This can introduce problems though
 * because a programmer may forget to override the Draw method in the derived class meaning that when we invoke Draw, nothing will
 * happen. This can be avoided by declaring the method Draw in the base class as abstract rather than Virtual. Doing so means that 
 * we can leave the body of the method empty in the base class and in the derived class, force the programmer to define the function
 * when the class is created.
 */

namespace AbstractClasses
{
    class Program
    {
        static void Main()
        {
            // abstract methods cannot no be instantiated
            // var shape = new Shape();

            var shapeList = new List<Shape>();
            shapeList.Add(new Circle());
            shapeList.Add(new Triangle());
        }
    }
}
