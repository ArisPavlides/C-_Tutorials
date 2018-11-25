using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAnswers
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get { return TimeSpan.FromMilliseconds(100); } }

        // class constructor
        public DbConnection(string conString)
        {
            if (string.IsNullOrEmpty(conString)) { throw new ArgumentNullException("Invalid connection string passed"); }
            else { this.ConnectionString = conString; }
        }

        abstract public void OpenConnection();
        abstract public void CloseConnection();
    }
}
