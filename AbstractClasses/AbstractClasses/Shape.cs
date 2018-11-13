using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    // if we want to define methods as abstract, the class must be defined as abstract as well
    public abstract class Shape
    {
        public abstract void Draw();

        public void Copy()
        {

        }
    }
}
