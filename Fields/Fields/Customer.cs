using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    public class Customer
    {
        public int ID;
        public string Name;

        // rather than creating a default constructor to initialise the lsit, we can initialise the list here. Also the readonly initialise  will ensure that the given field can only 
        // be initialised ONCE and this is done in order to prevent us from initialising a field by accident and losing all the data we stored in the list. by inclusing the readonly 
        // argument, if we try to initialise the list again we will get an error
        public readonly List<Orders> Orders = new List<Orders>(); 

        /*
         * in a previoux exercise we saw that if we declare a parameterless constructor, then it automatically becomes the default constructor activate when the class is initialised. We
         * can use the parameterless constructor to initialise Lists so as to avoid initialising the in the main code.
        public Customer()
        {
            Orders = new List<Orders>();
        }
        */

        public Customer(int id)
        {
            this.ID = id;
        }

        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }
    }
}
