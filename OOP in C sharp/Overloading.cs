using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOP_in_C_sharp
{
    class ComplexNumber
    {
        public int i { get; set; }
        public int r { get; set; }
        public ComplexNumber(int r,int i ) {
            this.r = r;
            this.i = i;
        }
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.r + c2.r, c1.i + c2.i);
        }
    }
    internal class Overloading
    {
        public static void PerformOpOverloading()
        {
            ComplexNumber c1 = new ComplexNumber(2, 4);
            ComplexNumber c2 = new ComplexNumber(2, 4);
            ComplexNumber c3 = c1 + c2;
            Console.WriteLine(c1.r + "+" + c1.i + "i + " + c1.r + "+" + c2.i + "i = " + c3.r + "+" + c3.i + "i");
        }

        public static void performMethodOverLoading()
        {
            Area a = new Area();
            Console.WriteLine("Area of square with side 5 is " + a.area(5));
            Console.WriteLine("Area of rectangle with length 5 and width 10 is " + a.area(5,10));
        }
    }

    class Area
    {
        public float area(float a)   // square
        {
            return a * a;
        }
        public float area(float a, float b)   // reactangle
        {
            return a * b;
        }

    }
}
