using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Customer
    {
        public int Id;
        public string Name;
        public List<Purchases> CustomerPurchases;

        // constructors need to have the same name as the name of the class otherwise they will not work

        // this constructor is exactly the same as the default constructor
        public Customer()
        {
            // when an instance of a class has an attribute which is of a generic list type (i.e. List<T>) it is good
            // to initialise the list in the constructor so as to have the list instantiated immediately after the instance
            // is instantiated. The list can be instantiated after the class is instantiated but it is good practise to
            // do so in the constructor
            CustomerPurchases = new List<Purchases>();
        }

        // by using the :this() argument in this case, if the constructor that takes string as a parameter is used 
        // when creating the class, then the constructor right above this will then be executed so that irrespective
        // of which construcor is called, the code will fall back to the previous constructors as well, meaning that 
        // the generic list is always instantiated
        public Customer(string name): this()
        {
            this.Id = 123;
            this.Name = name;
        }

        public Customer(string name, int id):this()
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
