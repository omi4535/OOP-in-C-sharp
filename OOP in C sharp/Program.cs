using OOP_in_C_sharp;

namespace propgram
{

    class OOP_programs
    {
        public static void Main(string[] args)
        {
            //MultipleInheritance.PerformInheritance();

            //Overloading.PerformOpOverloading();

            //Overloading.performMethodOverLoading();

            //WorkIsGoingOn d1 = new WorkIsGoingOn(new Delagetes().WorkIsGoingOn);

            //WorkIsGoingCompleted d2 = new WorkIsGoingCompleted(new Delagetes().WorkIsGoingCompleted);

            //Delagetes.StartWork(5, "study", d1, d2);

            //MethodHiding.PerformMethodHiding();

            //Generic_Delegates obj = new Generic_Delegates();

            //obj.PerformGenericDelegates();

            Console.WriteLine("Start of main thread");
            MultiThreading mt = new MultiThreading();
            mt.PlayWithThread();

            Thread ct = Thread.CurrentThread;
            if(ct.IsAlive)
            {
                Console.WriteLine(ct.Name + "Is alive");
            }

            MultiThreadingWithCallbacks mtc = new MultiThreadingWithCallbacks();
            mtc.MultiThreadingCallback(15);

            Console.WriteLine("end of main thread");
        }
    }

}