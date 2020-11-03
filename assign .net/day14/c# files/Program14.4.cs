using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._4
{
    class Program
    {
        public static int sqr(int n)
        { 
            return n*n;
        }
        public static int cube(int n)
        {
            return n * n * n;
        }
        public static int fact(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++ )
            {
                fact *= i;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            Func<int, int> fun = new Func<int, int> (sqr);
            Console.WriteLine(fun(4));
            fun += new Func<int, int>(cube);
            Console.WriteLine(fun(4));
            fun += new Func<int, int>(fact);
            Console.WriteLine(fun(4));

           
        }
    }
}
