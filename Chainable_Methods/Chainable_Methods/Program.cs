using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chainable_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // since the StringBuilder instance takes the append method, we can chain the commands as follows
            StringBuilder chainBuild = new StringBuilder();

            chainBuild.Append('+', 5)
                      .Append('A', 2)
                      .Append('+', 5)
                      .AppendLine()
                      .Append('-', 5)
                      .Append('A', 2)
                      .Append('-', 5)
                      .Replace('+', '=')
                      .Insert(15, 'p')
                      .Remove(18, 3);

            Console.WriteLine(chainBuild);
            Console.ReadLine();

            List<Nodes> family = new List<Nodes>();

            family.AddRange(new List<Nodes>
            {
                new Nodes("Aris", 32),
                new Nodes("Florentia", 30)
            });
        }
    }
}
