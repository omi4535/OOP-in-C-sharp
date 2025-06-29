using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_in_C_sharp
{
    internal class MultiThreading
    {
        public void PlayWithThread()
        {

            
            // does not work as mentioned on tutorials point
            Thread maint = Thread.CurrentThread;
            Console.WriteLine("Thread Name : "+maint.Name);

            Thread t1 = new Thread(Run);
            t1.Name = "T1";
            t1.Start();

            // Thread using Thread start
            ThreadStart st = new ThreadStart(Run);
            Thread t2 = new Thread(st);
            t2.Name = "t2";
           t2.Start();  

            // Using anonymous Method
            Thread t3 = new Thread(delegate() {
                Thread.CurrentThread.Name = "t3";
                Run();
            });
            t3.Start();

            // using lamda expression

            Thread t4 = new Thread( () => {
                Thread.CurrentThread.Name = "t4";
                Run();
            });
            t4.Start();



            // parameterized method calls

            // using parameterizedThreadStart;
            
            ParameterizedThreadStart pts = new ParameterizedThreadStart(run1);
            Thread t5 = new Thread(pts);
            // t5.Join();   here it will give exception as it is not started
            t5.Name = "T5";
            t5.Start(10);



            // join in MultiThreading

            //t5.Join();  // now main thread will wait till t5 get executed.
            //t1.Join(100);  // for t1 it will wait for 100 mili sec or execution to get over
            //t2.Join(TimeSpan.FromSeconds(3)); // for t1 it will wait for 3  sec or execution to get over



        }
        public static readonly object lockObj = new object();
        public static void Run()
        {
            lock (lockObj)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("from " + Thread.CurrentThread.Name + " : " + i);
                    Thread.Sleep(new Random().Next(2000));
                }
            }
        }
        public static void run1(Object j)
        {
            // j need to passed as object it not type saf so need to boxing concept
            for (int i = 0; i < (int)j; i++)
            {
                Console.WriteLine("from " + Thread.CurrentThread.Name + " : " + i);
               
            }
        }
    }
    delegate void CallBackDelegate(int i);
    internal class MultiThreadingWithCallbacks
    {
        public static void Call(int i) {
            Console.WriteLine("Call back has been called after printing "+i );
        }

        public void MultiThreadingCallback(int i)
        {
            CallBackDelegate d = new CallBackDelegate(Call);
            helper_class h1 = new helper_class(i, d);
            Thread newThread = new Thread(h1.Run);
            newThread.Name = "NewThread";
            newThread.Start();
            newThread.Join(1000);
        }
    }
    internal class helper_class
    {
        public readonly object  lockobj = new object(); 

        CallBackDelegate d2;
        int i = 0;
        public helper_class(int i,CallBackDelegate d)
        {
             d2 = d;
             this.i = i;
        }

        public void Run()
        {
            lock (lockobj)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine("from " + Thread.CurrentThread.Name + " : " + j);
                    Thread.Sleep(new Random().Next(2000));
                }

                d2.Invoke(i);
            }
        }


    }
}
