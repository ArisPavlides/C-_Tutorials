using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Part2
{
    public class Person
    {
        public string Name;
        public string Surname;

        public void Introduce(string address)
        {
            Console.WriteLine("Hello {0}, I am your {1} {2}", address, Name, Surname);
            Console.ReadLine();
        }

        // create a new instance of a class which and the values of its properties are the ones provided as parameters
        public static Person CreatePerson(string personName, string personSurname)
        {
            Person person = new Person();
            person.Name = personName;
            person.Surname = personSurname;

            return person;
        }
    }

    class Program
    {
        static void Main()
        {
            string name = "Humble";
            string surname = "servant";
            Person person = Person.CreatePerson(name, surname);
            person.Introduce("Aris");
        }
    }
}
