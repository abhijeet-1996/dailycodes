using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eightsixth
{
    class mymath
    {
        public static void sum(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            Console.WriteLine("average is "+sum/arr.Length);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           mymath.sum(4, 5);
           mymath.sum(4, 7, 8, 9);
        }
    }
}
