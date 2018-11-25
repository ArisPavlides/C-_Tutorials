using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAnswers
{
    class SqlConnection:DbConnection
    {
        private bool conOpened = false;

        public SqlConnection(string conString) : base(conString)
        {
        }

        public override void OpenConnection()
        {
            conOpened = true;
            Console.WriteLine("Connection opened");
        }

        public override void CloseConnection()
        {
            if (conOpened) { Console.WriteLine("Connection closed"); }
        }
    }
}
