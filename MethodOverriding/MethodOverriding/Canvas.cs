using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                // Even though we are dealing with a list of shapes and the Draw method is found is the Shape class, the 
                // method has been overriden by the classes deriving from Shape so when we call Draw here, the method called
                // will be the one defined in the inherited class
                shape.Draw();
            }
        }
    } 
}
