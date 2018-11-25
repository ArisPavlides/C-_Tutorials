using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAnswers
{
    public class DbCommand
    {      
        public DbCommand(DbConnection connection)
        {
            if (connection == null)
            {
                throw new Exception("Connection not initialised");
            }
        }

        public void Execute(string command)
        {
            Console.WriteLine("Connection opened");

            Console.WriteLine(command);

            Console.WriteLine("Connection closed");
        }
    }
}
