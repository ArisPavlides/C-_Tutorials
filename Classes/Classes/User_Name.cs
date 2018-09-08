using System;

namespace Classes
{
    public class User_Name
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
            Console.ReadLine();
        }
    }
}
