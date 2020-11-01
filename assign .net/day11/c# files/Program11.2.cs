using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_10._1
{
    delegate void manu(int no);
    class find
    {
        public void fact(int facto)
        {
            int no = 1;
            for (int i = 1; i <= facto; i++)
            {
                no *= i;
            }
            Console.WriteLine("factorial of no is " + no);
        }

        public void sqr(int no)
        {
            Console.WriteLine("sqr of no is " + (no * no));
        }

        public void cube(int no)
        {
            Console.WriteLine("sqr of no is " + (no * no * no));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            find f = new find();
            manu m = f.fact;
            m += f.sqr;
            m += f.cube;

            m(4);
        }
    }
}
