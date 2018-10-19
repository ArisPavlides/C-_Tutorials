using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Access modifiers are the public/private keywords in from of classes and variables. This concept is particularly
 * useful in object-oriented programming since it can be used to achieve the concept of encapsulation. This ensures that
 * any given class is responsible for one thing only and it does not allow outside classes to access all of its methods
 * and variables
 */

namespace AccessModifiers
{
    class Program
    {
        static void Main()
        {
            Person person = new Person();
            person.SetBirthdate(DateTime.Now);
            DateTime birthDate = person.GetBirthDate();
        }
    }
}
