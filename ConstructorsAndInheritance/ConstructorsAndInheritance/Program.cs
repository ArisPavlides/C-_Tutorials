using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsAndInheritance
{
    class Program
    {
        static void Main()
        {
            /* this will trigger the Car class to be initialised first and then the AlfaRomeo class since AlfaRomeo inherits from
             * Car. The parameter passed to AlfaRomeo will also be used by Car
             */
            var alfaRomeo = new AlfaRomeo("EAX19");
        }
    }
}
