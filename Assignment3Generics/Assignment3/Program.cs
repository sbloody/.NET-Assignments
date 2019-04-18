using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        public struct Pair<T, U>
        {
            public readonly T first;
            public readonly U second;

            public Pair(T fst, U snd)
            {
                this.first = fst;
                this.second = snd;
            }

            public override string ToString()
            {
                return "(" + first + ", " + second + ")";
            }

            public Pair<U, T> Swap()
            {
                Pair<U, T> temp = new Pair<U, T>(second, first);
                return temp;
            }
        }
        static void Main(string[] args)
        {
            Pair<string, int> pair1 = new Pair<String, int>("Kurt", 13);
            Pair<string, double> pair2 = new Pair<String, double>("Phoenix", 39.7);
            Pair<string, int>[] grades = new Pair<string, int>[5];
            grades[0] = pair1;
            grades[1] = new Pair<string, int>("Peter", 14);
            grades[2] = new Pair<string, int>("Mario", 18);
            foreach (var item in grades)
            {
                Console.WriteLine(item);
            }
            Pair<Pair<int, int>, string> appointment = new Pair<Pair<int, int>, string>(new Pair<int, int>(12, 12), "asd");
            Console.WriteLine(appointment.first.second);
            Console.WriteLine(appointment);
            Console.WriteLine(appointment.Swap());

            Console.ReadKey();
        }
    }

}
