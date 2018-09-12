using System;

namespace Classes
{
    public class User_Name
    {
        // properties of the class
        public string FirstName;
        public string LastName;

        // methods of the class
        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
            Console.ReadLine();
        }
    }
}
