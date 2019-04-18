using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Car : IComparable<Car>
    {
        public Car(int kmPerHour, string psPerKw, int uPerMin, int ccm, int acceleration, int zylinder)
        {
            this.kmPerHour = kmPerHour;
            this.psPerKw = psPerKw;
            this.uPerMin = uPerMin;
            this.ccm = ccm;
            this.acceleration = acceleration;
            this.zylinder = zylinder;
        }
        private int kmPerHour;
        public int KmPerHour
        {
            get { return kmPerHour; }
            set { kmPerHour = value; }
        }

        private string psPerKw;

        public string PsKw
        {
            get { return psPerKw; }
            set { psPerKw = value; }
        }

        private int uPerMin;

        public int UPerMin
        {
            get { return uPerMin; }
            set { uPerMin = value; }
        }

        private int ccm;

        public int Ccm
        {
            get { return ccm; }
            set { ccm = value; }
        }

        private float acceleration;

        public float Acceleration
        {
            get { return acceleration; }
            set { acceleration = value; }
        }

        private int zylinder;

        public int Zylinder
        {
            get { return zylinder; }
            set { zylinder = value; }
        }

        public int CompareTo(Car other)
        {
            if (other == null)
            {
                return 1;
            }
            else return KmPerHour.CompareTo(other.KmPerHour);
        }

        public override string ToString()
        {
            return this.KmPerHour + ", " + this.PsKw + ", " + this.UPerMin + ", " + this.Acceleration + ", " + this.Zylinder;
        }
    }
}
