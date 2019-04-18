using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Hand
    {
        private List<Car> cars;
        public Hand()
        {
            this.cars = new List<Car>();
            cars.Add(new Car(265, "300/200.5", 5900, 2994, 6, 6));
            cars.Add(new Car(255, "250/200.5", 5700, 2990, 5, 6));
            cars.Add(new Car(230, "230/200.5", 5600, 2890, 6, 4));
            cars.Sort();
        }


        public List<Car> CarSpeedCheck(int x)
        {
            return cars.Where(n => n.KmPerHour > x).ToList();

        }

        public override string ToString()
        {
            return cars.ToString();
        }
    }
}
