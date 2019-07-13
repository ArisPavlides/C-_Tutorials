using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Testability
{
    public class ShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f) { return order.TotalPrice * 0.1f; } // only pay shipping for small orders
            else { return 0f; }
        }
    }
}
