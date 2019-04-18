using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Product
    {
        public string Name;
        public decimal Price;

        public override string ToString()
        {
            return "Name: " + this.Name + ",price: " + this.Price;
        }
    }
}
