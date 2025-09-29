using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_Priority
{

    internal class MyThreadClass
    {
        public static void Thread1()
        {
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Thread 1: " + i);
                System.Threading.Thread.Sleep(500);

                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + i);

            }
        }

        public static void Thread2()
        {
            for(int i = 1;i <= 6; i++)
            {
                Console.WriteLine("Thread 1: " + i);
                System.Threading.Thread.Sleep(500);

                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + i);
            }
        }
    }
}
