using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadExample threadExample = new ThreadExample();
            Thread thread1 = new Thread(new ThreadStart(threadExample.FirstThread)); // Please note that you have to enter Method Name without '()'
            Thread thread2 = new Thread(new ThreadStart(threadExample.SecondThread)); // Please note that you have to enter Method Name without '()'
            thread1.Start();
            thread2.Start();


            Console.ReadKey();
        }
    }
    public class ThreadExample
    {
        public void FirstThread()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("FirstThread:- " + i);
                //suspending execution of current thread for 1 second
                Thread.Sleep(1000);
            }
        }
        public void SecondThread()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("SecondThread:- " + i);
                //suspending execution of current thread for 1 second
                Thread.Sleep(1000);
            }
        }
    }
}
