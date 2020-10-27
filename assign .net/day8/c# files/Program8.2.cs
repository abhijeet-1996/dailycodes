using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eightone
{
    class mymath
    {

        public int sqr(int n)
        {
            return n * n;
        }

        public double sqr(int n)
        {
            return n * n;
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            mymath m = new mymath();
            Console.WriteLine(m.sqr(8));//the call is ambiguous bet two methods
        }
    }
}
