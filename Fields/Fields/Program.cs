using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    class Program
    {
        static void Main()
        {
            Customer customer = new Customer(1, "John Smith"); // there are two constructors for this class so we have 2 options to overload this argument

            customer.Orders.Add(new Orders());
            customer.Orders.Add(new Orders());
            int numOrders = customer.Orders.Count;

            // customer.Orders = new List<Orders>(); // since the Orders list is readonly, we cannot initialise it again as it has been initialised in the Customer class
        }
    }
}
