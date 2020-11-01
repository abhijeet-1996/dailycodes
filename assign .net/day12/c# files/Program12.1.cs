using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1
{
    delegate void abhi(int no);
    class Program
    {
        static void Main(string[] args)
        {

            abhi a = delegate(int no)
            {
                int prod = 1;
                for (int i = 1; i <= no; i++)
                {
                    prod *= i;
                }
                Console.WriteLine(prod);
            };
            a += delegate(int no)
            {
                Console.WriteLine(no * no);
            };

            a += delegate(int no)
            {
                Console.WriteLine(no * no * no);
            };

            foreach(abhi ab in a.GetInvocationList())
            {
                Console.Write(ab.Method+"\t\t");
                ab.Invoke(4);
            }
        }
    }
}
