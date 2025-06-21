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

        public static void StartWork(int hrs,string work, WorkIsGoingOn d1, WorkIsGoingCompleted d2) 
        {
            for (int i = 0; i < hrs; i++)
            {
                d1(i, work);
                Thread.Sleep(1000);
            }
            d2(work);
        }
    }
}
