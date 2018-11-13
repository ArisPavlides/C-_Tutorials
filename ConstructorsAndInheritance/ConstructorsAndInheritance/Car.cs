using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsAndInheritance
{
    public class Car
    {
        private readonly string _registrationNum;

        public Car(string registrationNum)
        {
            _registrationNum = registrationNum;
        }
    }
}
