using OOP_in_C_sharp;

namespace propgram
{

    class OOP_programs
    {
        public static void Main(string[] args)
        {
            MultipleInheritance.PerformInheritance();
            Overloading.PerformOpOverloading();
            Overloading.performMethodOverLoading();

            WorkIsGoingOn d1 = new WorkIsGoingOn(new Delagetes().WorkIsGoingOn);
            WorkIsGoingCompleted d2 = new WorkIsGoingCompleted(new Delagetes().WorkIsGoingCompleted);
            Delagetes.StartWork(5, "study", d1, d2);

        }
    }

}