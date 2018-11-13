using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsAndInheritance
{
    class AlfaRomeo:Car
    {
        // the base keyword below will cause the AlfaRomeo constructor to pass the registrationNum paramter
        // to the constructor of the class it inherits from (ie parent class)
        public AlfaRomeo(string registrationNum):base(registrationNum)
        {

        }
    }
}
