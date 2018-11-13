using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    // Boxing is the process of converting a value type instance (eg int, boolean, byte, struct) to an object reference
    class Program
    {
        static void Main()
        {
            /*
             * In this case we create an object type and assign a value type to it. What happens is that the value gets BOXED and
             * stored in he heap rather than the stack. This incurs a performance penalty since an object reference must be created
             * in the stack (where value types are stored) and then stored in the heap (where reference types are stored)
             */ 
            object obj1 = 10; // boxing value as reference
            int num1 = (int)obj1; // unboxing reference back into value
        }
    }
}
