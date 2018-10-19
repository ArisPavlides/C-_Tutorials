using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class HTTPcookie
    {
        // make readonly so it is only initialised once
        private readonly Dictionary<string, string> _dictionary;
        public DateTime expiry
        {
            get { return DateTime.Now.AddDays(5); }
        }

        // default constructor to initialise the dictionary
        public HTTPcookie()
        {
            this._dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}
