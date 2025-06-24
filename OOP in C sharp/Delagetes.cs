using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_in_C_sharp
{
    public delegate void WorkIsGoingOn(int hr, string work);
    public delegate void WorkIsGoingCompleted(string work);
    internal class Delagetes
    {
        public void WorkIsGoingOn(int hr, string work)
        {
            Console.WriteLine(hr + " th hours passed " + work + " is still going on.");
        }
        public void WorkIsGoingCompleted(string work)
        {
            Console.WriteLine("Finally " + work + " is completed");
        }

        public static void StartWork(int hrs, string work, WorkIsGoingOn d1, WorkIsGoingCompleted d2)
        {
            for (int i = 0; i < hrs; i++)
            {
                d1(i, work);
                Thread.Sleep(1000);
            }
            d2(work);
        }
    }

    internal class Generic_Delegates
    {
        public double add1(int i, double d, float f)
        {
            return d + i + f;
        }

        public void add2(int i, double d,  float f)
        {
            Console.WriteLine(d + i + f +"From Function");

        }
        public bool check1(string str)
        {
            return str.Length > 5;
        }
        
        public void PerformGenericDelegates()
        {
            Func<int, double, float, double> obj1 = new Func<int, double, float, double>(add1);
            double d = obj1.Invoke(1, 2.23, 3.0f);
            Console.WriteLine(d);

            Action<int, double, float> obj2 = new Action<int, double, float> (add2);
            obj2.Invoke(1, 2.23, 3.0f);

            Predicate<string> obj3 = new Predicate<string>(check1);
            bool ans = obj3.Invoke("sdfwer");
            Console.WriteLine(ans);


        }

    }
}
