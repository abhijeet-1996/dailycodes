using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Threading;



namespace _16._2
{
    class Program
    {
        static void run()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name+"\t"+i);
                Thread.Sleep(200);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(run);
            t1.Name = "thread1";
            t1.Start();

            Thread t2 = new Thread(run);
            t2.Name = "thread2";
            t2.Start();
        }
    }
}
