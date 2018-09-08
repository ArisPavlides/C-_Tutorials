using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Properties
{
    class Program
    {
        static void Main()
        {
            string firstName = "Aris";
            string lastName = "Pavlides";

            // different methods of concatanating a string
            string fullName = firstName + " " + lastName;
            string fullName_2 = string.Format("Call me {0} {1}", firstName, lastName);

            //concatanate strings in array
            string[] name_arr = new string[3] { "Aris", "Kostis", "Antonia" };
            string joined_names = string.Join(">", name_arr);
            Console.WriteLine(joined_names);
            Console.ReadLine();

            // verbatim strings start with @ and they are useful when the string contains characters which perform
            // other purposes (eg "/", " ", "   ")
            string verb_str = @"My name
is Aris";
            Console.WriteLine(verb_str);
            Console.ReadLine();
        }
    }
}
