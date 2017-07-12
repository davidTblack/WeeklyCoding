using System;
using System.Collections.Generic;

namespace PizzaOrderApp.Objects
{
    public class Order
    {
        public bool IsDelivery { get; set; }
        public List<T> Contents { get; set; }
        public string Address { get; set; }
        public string OrderName { get; set; }
        public string PhoneNumber { get; set; }

        public Order()
	    {
            IsDelivery = true;
	    }
    }

}