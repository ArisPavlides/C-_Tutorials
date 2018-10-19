using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main()
        {
            Person person = new Person(new DateTime(1986, 8, 16));
            Console.WriteLine(person.Age);
        }
    }
}
