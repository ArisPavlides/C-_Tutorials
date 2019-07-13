using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Testability
{
    public class OrderProcessor
    {
        private readonly ShippingCalculator _shippingCalculator;

        public OrderProcessor()
        {
            _shippingCalculator = new ShippingCalculator();
        }

        public void Process(Order order)
        {
            // before processing make sure that the order has not already been shipped
            if (order.IsShippied)
            {
                throw new InvalidOperationException("Order has alredy been shipped");
            }

            else
            {
                order.Shipment = new Shipment
                {
                    Cost = _shippingCalculator.CalculateShipping(order).
                    ShippingDate = DateTime.Today.AddDays(1)
                };
            }
        }
    }
}
