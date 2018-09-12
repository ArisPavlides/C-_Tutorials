using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes_ValueTypes_v2
{
    public class Person
    {
        public int Age = 3;
    }

    class Program
    {
        static void Main()
        {
            // in this case we assign a number to the variable. we then call a void method which takes variable of the same name and increments it. even though
            // the increment method has a variable of the same name, the second variable is of VALUE type so its value is written in another part in the stack
            // making the 2 variables called "number" independent of each other
            int number = 1;
            Increment(number);
            Console.WriteLine(number);
            Console.ReadLine();

            // here we assign the value of 42 to a property of the Person class which is a REFERENCE type. therefore, even though the method called is void, 
            // setting a new number to the person.Age property, changes the value stored in the heap so all variable refering this roperty now show the updated value
            Person person = new Person();
            person.Age = 42;
            MakeOld(person);
            Console.WriteLine(person.Age);
            Console.ReadLine();
        }

        public static void Increment(int number)
        {
            number += 5;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
