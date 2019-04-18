using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customer = new List<Customer>();
            customer.Add(new Customer
            {
                Name = "Kim Foged",
                City = "Beder",
                Orders = new Order[]
            {
                new Order { Quantity = 1000, Product = new Product { Name = "Milk", Price = 6 } },
                new Order { Quantity = 5, Product = new Product { Name = "Butter", Price = 5 } },
                new Order { Quantity = 2, Product = new Product { Name = "Bread", Price = 2 } }
            }
            });

            customer.Add(new Customer
            {
                Name = "Ib Havn",
                City = "Horsens",
                Orders = new Order[]
            {
                new Order { Quantity = 1000, Product = new Product{ Name = "Milk", Price = 6 } },
                new Order { Quantity = 5, Product = new Product { Name = "Butter", Price = 5 } },
                new Order { Quantity = 2, Product = new Product{ Name = "Bread", Price = 2 } },
                new Order { Quantity = 2, Product = new Product { Name = "Cacao", Price = 5 } }
            }
            });

            customer.Add(new Customer
            {
                Name = "Rasmus Bjerner",
                City = "Horsens",
                Orders = new Order[]
            {
                new Order { Quantity = 100, Product = new Product{ Name = "Juice", Price = 3 } },

            }
            });

            #region
            (from c in customer
             select new { c.Name, c.City }).ToList().ForEach(Console.WriteLine);
            Console.WriteLine();
            #endregion

            #region
            (from c in customer
             where c.City == "Horsens"
             select c.Name).ToList().ForEach(Console.WriteLine);
            Console.WriteLine();
            #endregion

            #region
            (from c in customer
             where c.Name == "Ib Havn"
             select c.Orders.Length).ToList().ForEach(Console.WriteLine);
            Console.WriteLine();
            #endregion

            #region
            (from c in customer
             where c.Orders.Any(p => p.Product.Name == "Milk")
             select c.Name).ToList().ForEach(Console.WriteLine);
            Console.WriteLine();
            #endregion

            #region
            var a = customer.Select(c => c.Orders.Sum(p => p.Product.Price)).ToList();
            var b = customer.Select(c => c.Name).ToList();
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(b[i] + ": " + a[i]);
            }
            Console.WriteLine();
            #endregion

            #region
            decimal sum = 0;
            (from c in customer
             select c.Orders.Sum(p => p.Product.Price)).ToList().ForEach(p => sum += p);
            Console.WriteLine(sum);
            #endregion
            Console.ReadKey();
        }
    }
}
