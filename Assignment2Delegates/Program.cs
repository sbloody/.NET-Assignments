using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    //Delegate types to describe predicates on ints and actions on ints.
    public delegate bool IntPredicate(int x);
    public delegate void IntAction(int x);

    // Integer lists with Act and Filter operations.
    // An IntList containing the element 7 9 13 may be constructed as
    // new IntList(7,9,13) due to the params modifier.

    class IntList : List<int>
    {
        public IntList(params int[] elements) : base(elements)
        {

        }

        public void Act(IntAction f)
        {
            foreach (int i in this)
            {
                f(i);
            }
        }

        public IntList Filter(IntPredicate p)
        {
            IntList res = new IntList();
            foreach (int i in this)
                if (p(i))
                    res.Add(i);
            return res;
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IntList xs = new IntList(2,4,7, 9, 13);
            IntList xs1 = new IntList(25, 30, 1, 35, 0);
            xs.Act(Console.WriteLine);
            xs.Filter(delegate (int x) { return x % 2 == 0; }).Act(Console.WriteLine);
            xs1.Filter(delegate (int x) { return x > 25; }).Act(Console.WriteLine);
            int sum = 0;
            xs1.Act(p => sum += p);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
