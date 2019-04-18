using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hand h1 = new Hand();
            List<Car> car1 = new List<Car>();
            car1.Add(new Car(235, "200/150.5", 5600, 2500, 4, 4));
            car1.Add(new Car(25, "250/200.5", 5500, 2090, 5, 5));

            List<Car> car2 = h1.CarSpeedCheck(50);
            foreach (var item in car2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            List<Car> car3 = h1.CarSpeedCheck(250);
            foreach (var item in car3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            foreach (var item in car1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            car1.Sort();
            foreach (var item in car1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            car2.Sort((x, y) => y.UPerMin.CompareTo(x.UPerMin));
            foreach (var item in car2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
