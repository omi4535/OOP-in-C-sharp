using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_in_C_sharp
{

    class Parent
    {
        public virtual void Display()
        {
            Console.WriteLine("Parent Display");
        }

        public void show()
        {
            Console.WriteLine("Parent show");
        }
    }

    class child : Parent
    {
        //public new void Display()  // For hiding
        public override void Display()  // for Overriding 
        {
            Console.WriteLine("Child Display");
        }
        public void show()   // use new keyword to avoid this warning 
            // using new key we explicitly say that we are entended to do hiding 
        {
            Console.WriteLine("Child show");
        }
    }
    internal class MethodHiding
    {
        public static void PerformMethodHiding()
        {
            Parent p = new child();
            p.show();   
            p.Display();    
        }
    }
}
