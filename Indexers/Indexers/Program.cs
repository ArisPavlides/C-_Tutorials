using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main()
        {
            HTTPcookie cookie = new HTTPcookie();
            cookie["whatever"] = "anyhow";

            cookie["expiry"] = cookie.expiry.ToString();     
        }
    }
}
