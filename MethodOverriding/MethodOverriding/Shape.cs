using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        // declare the class as virtual in order to be able to change its implementation details from the inherited class
        public virtual void Draw()
        {
        }
    }
}
