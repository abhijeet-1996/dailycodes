using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_10._1
{
    delegate void manu(int no);
    static class find
    {
        public static void fact(int facto)
        {
            int no = 1;
            for(int i = 1;i<=facto;i++)
            {
                no *= i;
            }
            Console.WriteLine("factorial of no is "+no);
        }

        public static void sqr(int no)
        {
            Console.WriteLine("sqr of no is " + (no * no ));
        }

        public static void cube(int no)
        {
            Console.WriteLine("sqr of no is " + (no * no * no));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            manu m = find.fact;
            m += find.sqr;
            m += find.cube;

            m(4);
        }
    }
}
