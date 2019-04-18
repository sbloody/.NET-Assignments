using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Customer
    {
        public string Name;
        public string City;
        public Order[] Orders;


        public override string ToString()
        {
            return "Name" + this.Name + ",city: " + this.City + ",orders: " + Orders;
        }
    }




}
