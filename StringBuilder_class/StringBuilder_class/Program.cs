using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_class
{
    class Program
    {
        static void Main()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append('+', 5); // adds a character which it then repeats 3 times (only takes UTF16 characters so no words)
            builder.Append('A', 2); // adds a character on the same line as above
            builder.Append('+', 5);

            builder.AppendLine(); // changes the line
            builder.Append('-', 5);
            builder.Append('A', 2);
            builder.Append('-', 5);

            builder.Replace('+', '=');
            builder.Insert(15, 'p'); // inserts a character at the 15th position of the string
            builder.Remove(18, 3); // removes 3 characters after the character at the 18th index

            Console.WriteLine(builder);
            Console.ReadLine();
        }
    }
}
