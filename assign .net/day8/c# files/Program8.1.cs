using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eightone
{
    static class mymath
    {

        public static int sqr(int n)
        {
            return n * n;
        }

        public static double sqr(double n)
        {
            return n * n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(mymath.sqr(8));
            Console.WriteLine(mymath.sqr(0.3));
        }
    }
}
